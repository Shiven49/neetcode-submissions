public class TimeMap {

    Dictionary<string, List<(int time, string value)>> map;

    public TimeMap() {
        map = new Dictionary<string, List<(int, string)>>();
    }

    public void Set(string key, string value, int timestamp) {

        if (!map.ContainsKey(key))
            map[key] = new List<(int, string)>();

        map[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp) {

        if (!map.ContainsKey(key))
            return "";

        List<(int time, string value)> list = map[key];

        int l = 0;
        int r = list.Count - 1;
        string ans = "";

        while (l <= r) {

            int mid = l + (r - l) / 2;

            if (list[mid].time <= timestamp) {
                ans = list[mid].value;
                l = mid + 1;
            }
            else {
                r = mid - 1;
            }
        }

        return ans;
    }
}
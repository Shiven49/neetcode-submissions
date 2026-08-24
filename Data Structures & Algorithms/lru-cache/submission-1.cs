public class LRUCache {

    class Node {

        public int key, value;

        public Node prev, next;

        public Node(int key, int value) {

            this.key = key;

            this.value = value;

        }

    }

    Dictionary<int, Node> map = new();

    Node left, right;

    int capacity;

    public LRUCache(int capacity) {

        this.capacity = capacity;

        left = new Node(0, 0);

        right = new Node(0, 0);

        left.next = right;

        right.prev = left;

    }

    public int Get(int key) {

        if (!map.ContainsKey(key))

            return -1;

        Node node = map[key];

        node.prev.next = node.next;

        node.next.prev = node.prev;

        node.prev = right.prev;

        node.next = right;

        right.prev.next = node;

        right.prev = node;

        return node.value;

    }

    public void Put(int key, int value) {

        if (map.ContainsKey(key)) {

            Node node = map[key];

            node.value = value;

            node.prev.next = node.next;

            node.next.prev = node.prev;

            node.prev = right.prev;

            node.next = right;

            right.prev.next = node;

            right.prev = node;

        }

        else {

            Node node = new Node(key, value);

            map[key] = node;

            node.prev = right.prev;

            node.next = right;

            right.prev.next = node;

            right.prev = node;

            if (map.Count > capacity) {

                Node lru = left.next;

                lru.prev.next = lru.next;

                lru.next.prev = lru.prev;

                map.Remove(lru.key);

            }

        }

    }
}
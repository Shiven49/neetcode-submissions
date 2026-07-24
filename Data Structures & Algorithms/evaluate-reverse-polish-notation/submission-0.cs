public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new();

        foreach (string token in tokens) {
            if (token == "+" || token == "-" || token == "*" || token == "/") {
                int a = stack.Pop();

                int b = stack.Pop();

                if (token == "+")

                    stack.Push(b + a);

                else if (token == "-")

                    stack.Push(b - a);

                else if (token == "*")

                    stack.Push(b * a);

                else

                    stack.Push(b / a);

            }

            else {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Peek();
    }
}

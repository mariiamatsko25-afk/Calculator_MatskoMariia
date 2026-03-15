namespace CalculatorMatsko;

public class ShuntingYard
{
    private Dictionary<string, int> priorities = new Dictionary<string, int>();

    public ShuntingYard()
    {
        priorities = new Dictionary<string, int> { { "+", 1 }, { "-", 1 }, { "*", 2 }, { "/", 2 }, {"(", -1}, {"^", 3}, {"sin", 4}, {"cos", 4}, {"max", 4}, {",", 0}};
    }
    public Queue Algorithm(Queue queue)
    {
        Queue numbers = new Queue();
        Stack signs = new Stack();
        string token = queue.Dequeue();
        while (token != null)
        {
            if (token == "+" || token == "-" || token == "*" || token == "/" || token == "^" || token == ",")
            {
                while (signs.Count() != 0 && priorities[token] <= priorities[signs.Peek()])
                {
                    string previousSign = signs.Pull();
                    numbers.Enqueue(previousSign);
                }
                signs.Push(token);

            }
            
            else if ( token == "(")
            {
                signs.Push(token);
            }
            
            else if (token == ")")
            {
                while (signs.Count() != 0 && signs.Peek() != "(")
                {
                    string tokenNew = signs.Pull();
                    if (tokenNew == ",")
                    {
                        continue;
                    }
                    numbers.Enqueue(tokenNew);

                }
                if (signs.Count() == 0)
                {
                    throw new Exception("( is missing");
                }

                signs.Pull();
            }
            else if (token == "cos" || token == "sin" || token == "max")
            {
                signs.Push(token);
                if (signs.Count() == 0)
                {
                    throw new Exception("( is missing");
                }
            }
            else
            {
                numbers.Enqueue(token); 
            }
            token = queue.Dequeue();
        }

        while (signs.Count() != 0)
        {
            string lastSign = signs.Pull();
            if (lastSign == "(")
            {
                throw new Exception(") is missing");
            }
            numbers.Enqueue(lastSign);
        }

        return numbers;
    }
}
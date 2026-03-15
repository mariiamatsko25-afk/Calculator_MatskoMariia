namespace CalculatorMatsko;

public class Tokens
{
    public Queue Tokenize(string inputTask)
    {
        
        Queue result = new Queue();
        string Buffer = "";
        
        foreach (char symbol in inputTask)
        {
            if (symbol == ' ')
            {
                if (Buffer != "")
                {
                    result.Enqueue(Buffer);
                    Buffer = "";
                }
                else
                {
                    continue;
                }
            }
            else if (char.IsDigit(symbol) || char.IsLetter(symbol))
            {
                Buffer += symbol;
                    
            }
            else if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/' || symbol == '(' ||
                     symbol == ')' || symbol == '^' || symbol == ',')
            {
                if (Buffer != "")
                {
                    result.Enqueue(Buffer);
                    Buffer = "";
                }
                result.Enqueue(symbol.ToString());
            }
        }

        if (Buffer != "")
        {
            result.Enqueue(Buffer);
        }

        return result;
    }

}

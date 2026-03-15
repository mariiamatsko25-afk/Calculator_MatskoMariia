namespace CalculatorMatsko;

public class Calculation
{
    public string ResultNum( Queue algQueue)
    {
        Stack result = new Stack();
        string token = algQueue.Dequeue();

        while (token != null)
        {
            if (token == "+" )
            {
                string num1 = result.Pull();
                string num2 = result.Pull();
                double newNum = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                result.Push(newNum.ToString());

            }
            else if (token == "-")
            {
                string num1 = result.Pull();
                string num2 = result.Pull();
                double newNum = Convert.ToDouble(num2) - Convert.ToDouble(num1);
                result.Push(newNum.ToString());
            }
            else if (token == "*")
            {
                string num1 = result.Pull();
                string num2 = result.Pull();
                double newNum = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                result.Push(newNum.ToString());
            }
            else if (token == "/")
            {
                string num1 = result.Pull();
                string num2 = result.Pull();
                double newNum = Convert.ToDouble(num2) / Convert.ToDouble(num1);
                result.Push(newNum.ToString());
            }
            else if (token == "^")
            {
                string num1 = result.Pull();
                string num2 = result.Pull();
                double newNum = 1;
                for (int i = 1; i <= Convert.ToInt32(num1); i++)
                {
                    newNum = Convert.ToDouble(newNum) * Convert.ToDouble(num2);
                }
                result.Push(newNum.ToString());
            }
            else if (token == "cos")
            {
                string num = result.Pull();
                double newNum = Math.Cos(Convert.ToDouble(num));
                result.Push(newNum.ToString());
            }
            else if (token == "sin")
            {
                string num = result.Pull();
                double newNum = Math.Sin(Convert.ToDouble(num));
                result.Push(newNum.ToString());
            }
            else if (token == "max")
            {
                string num1 = result.Pull();
                string num2 = result.Pull();
                if (Convert.ToDouble(num1) >= Convert.ToDouble(num2))
                {
                    double newNum = Convert.ToDouble(num1);
                    result.Push(newNum.ToString());
                }
                else if (Convert.ToDouble(num1) <= Convert.ToDouble(num2))
                {
                    double newNum = Convert.ToDouble(num2);
                    result.Push(newNum.ToString());
                }
            }
            else
            {
                result.Push(token);
            }
            
            token = algQueue.Dequeue();
        }

        double resultNum = Convert.ToDouble(result.Pull());
        return resultNum.ToString("F2");
    }
}
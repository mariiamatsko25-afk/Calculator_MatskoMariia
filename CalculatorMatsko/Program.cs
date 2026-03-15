using CalculatorMatsko;

Console.WriteLine("input your expression: ");
string inputTask = Console.ReadLine();

Tokens tokens = new Tokens();
Queue queue = tokens.Tokenize(inputTask);

ShuntingYard algorithm = new ShuntingYard();
Queue numbers = algorithm.Algorithm(queue);
numbers.Write();

Calculation calculation = new Calculation();
string resultNum = calculation.ResultNum(numbers);
Console.WriteLine($"result is {resultNum}");
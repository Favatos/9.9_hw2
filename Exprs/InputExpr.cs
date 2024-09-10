namespace Interpreter;

public class InputExpr : IExpr
{

    public int Calculate() => Convert.ToInt32(Console.ReadLine());
}

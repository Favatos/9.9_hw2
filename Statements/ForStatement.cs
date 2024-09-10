namespace Interpreter;

public class ForStatement : IStatement
{
    IExpr i, value;
    IStatement body;
    public ForStatement(IExpr i, IExpr value, IStatement body)
    {
        this.i = i;
        this.value = value;
        this.body = body;
    }

    public void Execute()
    {
        for (int j = i.Calculate(); j < value.Calculate(); j++)
        {
            body.Execute();
        }
    }
}

namespace Interpreter;

public class WhileStatement
{
    private IStatement body;
    private IExpr condition;

    public WhileStatement(IStatement body, IExpr condition)
    {
        this.body = body;
        this.condition = condition;
    }

    public void Execute()
    {
        while(condition.Calculate() != 0)
        {
            body.Execute();
        }
    }
}

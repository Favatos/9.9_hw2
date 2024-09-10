namespace Interpreter;

public class DoWhileStatement : IStatement {
    private IStatement body;
    private IExpr condition;

    public DoWhileStatement (IStatement body, IExpr condition) {
        this.body = body;
        this.condition = condition;
    }

    public void Execute () {
        do {
            body.Execute ();
        } while (condition.Calculate () != 0);
    }
}

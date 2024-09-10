namespace Interpreter.Statements
{
    public class IfStatement
    {
        private IExpr condition;  
        private IStatement then;

        public IfStatement(IExpr condition, IStatement then)
        {
            this.condition = condition;
            this.then = then;
        }

        public void Execute()
        {
            if (condition.Calculate() != 0)  
                then.Execute();
        }
    }
}

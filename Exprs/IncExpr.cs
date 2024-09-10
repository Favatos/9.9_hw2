namespace Interpreter;

internal class IncExpr : IExpr
{
    IExpr n;
    public IncExpr(IExpr n) => this.n = n;
    public int Calculate()
    {
       return n.Calculate()+ 1;
    }
}

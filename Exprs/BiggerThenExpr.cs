namespace Interpreter;

public class BiggerThenExpr : BinaryExpr
{
    public BiggerThenExpr(IExpr left, IExpr right) : base(left, right)
    {
    }

    public override int Calculate() =>
        left.Calculate() > right.Calculate() ? 1 : 0;
}

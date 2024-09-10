namespace Interpreter;

public class EqualExpr : BinaryExpr
{
    public EqualExpr(IExpr left, IExpr right) : base(left, right)
    {
    }

    public override int Calculate() =>
        left.Calculate() == right.Calculate() ? 1 : 0;
}


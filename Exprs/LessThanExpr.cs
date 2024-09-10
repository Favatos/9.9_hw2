namespace Interpreter;

public class LessThanExpr : BinaryExpr {
    public LessThanExpr (IExpr left, IExpr right) : base (left, right) {
    }

    public override int Calculate () =>
        left.Calculate () < right.Calculate () ? 1 : 0;
}

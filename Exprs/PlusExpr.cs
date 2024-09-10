namespace Interpreter;

public class PlusExpr : BinaryExpr {
    public PlusExpr (IExpr left, IExpr right) : base (left, right) {
    }

    public override int Calculate () => left.Calculate () + right.Calculate ();
}

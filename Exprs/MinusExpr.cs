namespace Interpreter;

public class MinusExpr : BinaryExpr {
    public MinusExpr (IExpr left, IExpr right) : base (left, right) {
    }

    public override int Calculate () => left.Calculate () - right.Calculate ();
}

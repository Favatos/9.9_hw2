namespace Interpreter;

public class AssignExpr : IExpr {
    private VarExpr left;
    private IExpr right;

    public AssignExpr (VarExpr left, IExpr right) {
        this.left = left;
        this.right = right;
    }

    public int Calculate () =>
        // записывает переменную
        // возвращает значение
        VarExpr.Vars[left.Name] = right.Calculate ();
}

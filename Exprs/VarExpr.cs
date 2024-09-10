namespace Interpreter;

public class VarExpr : IExpr {
    public static IDictionary<string, int> Vars { get; } = new Dictionary<string, int> ();

    public string Name { get; }
    public VarExpr (string name) => this.Name = name;

    public int Calculate () => Vars[Name];
}

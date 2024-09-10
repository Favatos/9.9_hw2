namespace Interpreter;

internal class Program
{
    static void Main(string[] args)
    {
        new BlockStatement(
            new ExprStatement(
                new AssignExpr(
                    new VarExpr("n"),
                    new ConstExpr(
                        new InputExpr().Calculate()
                        )
                    )
                ),
            new ExprStatement(
                new AssignExpr(
                    new VarExpr("sum"),
                    new ConstExpr(0)
                    )
                ),
            new ForStatement(
                new AssignExpr(
                    new VarExpr("i"),
                    new ConstExpr(0)
                    ),
                new VarExpr("n"),
                new BlockStatement(
                    new ExprStatement(
                        new PrintExpr(
                            new VarExpr("i")
                        )
                    ),
                    new ExprStatement(
                        new AssignExpr(
                            new VarExpr("sum"),
                            new PlusExpr(
                                new VarExpr("sum"),
                                new VarExpr("i")
                            )
                            )
                        ),
                    new ExprStatement(
                        new AssignExpr(
                            new VarExpr("i"),
                            new PlusExpr(
                                new VarExpr("i"),
                                new ConstExpr(1)
                            )
                            )
                        )
                    )
                ),

            new ExprStatement(
                new PrintExpr(
                    new VarExpr("sum")
                    )
                )
            ).Execute();
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            sum += i;
        }
        Console.WriteLine(sum);
    }
}

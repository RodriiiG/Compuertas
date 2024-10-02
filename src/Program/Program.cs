namespace Program;

class Program
{
    static void Main(string[] args)
    {
        AND and1 = new AND("and1", "A", "B");
        and1.AgregarEstado1(1);
        and1.AgregarEstado2(1);
        //Console.WriteLine($"{and1.Calcular()}");
        OR or1 = new OR("or1", "C", "D");
        or1.AgregarEstado1(1);
        or1.AgregarEstado2(0);
        //Console.WriteLine($"{or1.Calcular()}");
        NOT not1 = new NOT("not1", "E");
        not1.AgregarEstado(1);
        //Console.WriteLine($"{not1.Calcular()}");
        AND and2 = new AND("and2", "A", "B");
        OR or2 = new OR("or2", "C", "D");
        NOT not2 = new NOT("not2", "E");
        and2.AgregarEstado1(1);
        and2.AgregarEstado2(1);
        int Resultado1 = and2.Calcular();
        or2.AgregarEstado1(Resultado1);
        or2.AgregarEstado2(0);
        int Resultado2 = or2.Calcular();
        not2.AgregarEstado(Resultado2);
        int ResultadoFinal = not2.Calcular();
        //Console.WriteLine($"El resultado final es {ResultadoFinal}");
        
        //Garage
        int A = 1;
        int B = 1;
        int C = 1;
            
        AND and3 = new AND("and3", "A", "B");
        OR or3 = new OR("or3", "C", "D");
        NOT not3 = new NOT("not3", "E");
        NOT not4 = new NOT("not4", "E");
        AND and4 = new AND("and4", "A", "B");
        AND and5 = new AND("and5", "A", "B");
        and3.AgregarEstado1(A);
        and3.AgregarEstado2(B);
        not3.AgregarEstado(A);
        not4.AgregarEstado(B);
        and4.AgregarEstado1(not3.Calcular());
        and4.AgregarEstado2(not4.Calcular());
        or3.AgregarEstado1(and3.Calcular());
        or3.AgregarEstado2(and4.Calcular());
        and5.AgregarEstado1(or3.Calcular());
        and5.AgregarEstado2(C);
        Console.WriteLine($"{and5.Calcular()}");
    }
}

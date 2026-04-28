using ConsoleTemporalICDIA_Unidad3.Model;

namespace ConsoleTemporalICDIA_Unidad3.Runners;

public class RunnerAreasPoligonos
{
    public RunnerAreasPoligonos()
    {

        Poligono poligono;
        //= new Poligono();
        
        
        poligono = new Triangulo();
        //poligono.
        
        //poligono.
        
        Triangulo triangulo = new Triangulo();
        //triangulo.CalcArea()

        double a = triangulo.CalcPerimetro(5, 7);

        a = triangulo.CalcArea(new int[] { 3, 6 });

        Console.WriteLine(a);

    }
}
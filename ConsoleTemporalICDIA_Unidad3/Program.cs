using ConsoleTemporalICDIA_Unidad3.Model;
using ConsoleTemporalICDIA_Unidad3.Runners;

namespace ConsoleTemporalICDIA_Unidad3;

public class Program{
    public static void Main(string[] args)
    {
        //new JsonTest();
        //new JsonArchivoAlumnos();
        //new JsonLecturaAlumnos();

        //new RunnerExcepcionesPersonalizadas();

        //double x = 2;

        //double cuadradoX = x * x;

        //Math m;
        //m = new Math();

        //double cuadradoX = Math.Pow(x, 2);


        //new RunnerEjecutarOperacionesBasicas();

        //new RunnerLeerArchivos();

        // new RunnerAreasPoligonos();

        new RunnerAlumnoPuntuacion();

        Score.Puntuacion += 5;
        Console.WriteLine(Score.Puntuacion);
        




    }

}

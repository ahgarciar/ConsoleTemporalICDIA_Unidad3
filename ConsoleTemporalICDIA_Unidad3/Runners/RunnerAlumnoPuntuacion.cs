using ConsoleTemporalICDIA_Unidad3.Model;

namespace ConsoleTemporalICDIA_Unidad3.Runners;

public class RunnerAlumnoPuntuacion
{
    public RunnerAlumnoPuntuacion()
    {

        Score.Puntuacion = 10;
        Console.WriteLine(Score.Puntuacion.ToString());
        Score.Puntuacion += 15;
        Console.WriteLine(Score.Puntuacion.ToString());

    }
}
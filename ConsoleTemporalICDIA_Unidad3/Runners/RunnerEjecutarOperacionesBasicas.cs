using ConsoleTemporalICDIA_Unidad3.Utilidades;

namespace ConsoleTemporalICDIA_Unidad3.Runners;

public class RunnerEjecutarOperacionesBasicas
{
    public RunnerEjecutarOperacionesBasicas()
    {
        //Math.PI
        
        //int resultado = OperacionesBasicas.Suma(2, 4);
        int resultado = OperacionesBasicas.Multiplicacion(2, 4);
        
        double indiceR = OperacionesBasicas.INDICE_REPROBACION;
        
        Console.WriteLine($"Resultado: {resultado}");

    }
}
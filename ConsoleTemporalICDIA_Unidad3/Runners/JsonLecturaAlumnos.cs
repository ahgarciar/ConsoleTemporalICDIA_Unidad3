using System.Text.Json;
using ConsoleTemporalICDIA_Unidad3.Model;

namespace ConsoleTemporalICDIA_Unidad3.Runners;

public class JsonLecturaAlumnos
{
    public JsonLecturaAlumnos()
    {
        List<Alumno> alumnos;
        alumnos = new List<Alumno>();
        Alumno temporal;
        foreach (string linea in File.ReadLines("Alumnos.json"))
        {
            temporal = JsonSerializer.Deserialize<Alumno>(linea);
            alumnos.Add(temporal);
        }

        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine(alumno);
        }
        
    
        
    }
}
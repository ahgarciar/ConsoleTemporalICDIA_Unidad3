namespace ConsoleTemporalICDIA_Unidad3.Model;

public class MatriculaException : Exception
{
    public MatriculaException(string mensaje) 
        : base(mensaje)
    {
        //Guardar el base de datos que ocurrio este error
    }
}
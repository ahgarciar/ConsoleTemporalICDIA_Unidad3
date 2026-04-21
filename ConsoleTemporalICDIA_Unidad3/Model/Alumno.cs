namespace ConsoleTemporalICDIA_Unidad3.Model;
public class Alumno : IComparable<Alumno>
{
    //Atributos
    private long matricula;
    private string nombre;
    private double calificacion;
    
    //Propiedades
    public long Matricula
    {
        get => matricula; 
        set => matricula = value;
    }
    public string Nombre
    {
        get => nombre; 
        set => nombre = value;
    }

    public double Calificacion
    {
        get => calificacion;
        set => calificacion = value;
    }
    //Constructor
    public Alumno(long matricula, string nombre)
    {
        Matricula = matricula;
        Nombre = nombre;
    }

    public Alumno(long matricula)
    {
        Matricula = matricula;
    }

    public Alumno(long matricula, string nombre, double calificacion)
    {
        Matricula = matricula;
        Nombre = nombre;
        Calificacion = calificacion;
    }

    public Alumno()
    {
    }

    //ToString
    public int CompareTo(Alumno? other)
    {
        return //this.Matricula-other.Matricula;
            this.Matricula.CompareTo(other.Matricula);
    }

    public override string ToString()
    {
        return "(" + Matricula.ToString() + ") - " + Nombre;
    }
    
}
namespace ConsoleTemporalICDIA_Unidad3.Model;

public class Triangulo : Poligono
{
    /// <summary>
    /// PPP. Param 1 = Base, Param 2 =  Altura
    /// </summary>
    /// <param name="parametros"> Se espera dos parametros, el primero asociado a la base y
    /// el segundo a la altura del triangulo
    /// </param>
    /// <returns> Devuelve el area del poligono</returns>
    /// <exception cref="ArgumentException"></exception>
    public override int CalcArea(int[] parametros)
    {
        if (parametros.Length < 2)
        {
            throw new ArgumentException("Se ocupan dos parametros");
        }
        return (parametros[0] * parametros[1])/2;
        
    }
}
namespace ConsoleTemporalICDIA_Unidad3.Model;

public class Cuadrado : Poligono
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="parametros">Se espera un único parámetro
    /// asociado al lado del cuadrado</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public override int CalcArea(int[] parametros)
    {
        if (parametros.Length < 1)
        {
            throw new ArgumentException("Se requiere un parametro");
        }
        return parametros[0] * parametros[0];
    }
}
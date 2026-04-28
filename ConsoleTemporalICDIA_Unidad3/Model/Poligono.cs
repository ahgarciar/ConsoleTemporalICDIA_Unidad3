namespace ConsoleTemporalICDIA_Unidad3.Model;

/// <summary>
/// Esta clase sirve para realizar operaciones con poligonos 
/// </summary>
public abstract class Poligono
{
    //Comentario de una linea
    
    /*
     * Comentario multiple
     */
    
    /// <summary>
    /// 
    /// </summary>
    private string nombre;

    /// <summary>
    /// Calcula el perimetro de un poligono
    /// </summary>
    /// <param name="lados"> cantidad de lados</param>
    /// <param name="longitud"> largo de cada lado </param>
    /// <returns></returns>
    public int CalcPerimetro(int lados, int longitud)
    {
       ////////
        return lados * longitud;
    }

    /// <summary>
    /// Calcula el ara de un poligono
    /// </summary>
    /// <param name="parametros">TEXTOOOOOO</param>
    /// <returns></returns>
    public abstract int CalcArea(int[] parametros);
    

}
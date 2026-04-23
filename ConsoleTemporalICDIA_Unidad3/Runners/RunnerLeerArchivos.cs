using ConsoleTemporalICDIA_Unidad3.Utilidades;

namespace ConsoleTemporalICDIA_Unidad3.Runners;

public class RunnerLeerArchivos
{
    public RunnerLeerArchivos()
    {
        
        LeerArchivos.Leer();

        LeerArchivos archivo;
        archivo = new LeerArchivos();
        //archivo.Leer();
        archivo.LeerV2();


    }
    
}
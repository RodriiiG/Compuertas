namespace Program;

public class NOT
{
    private string nombreCompuerta;

    public string NombreCompuerta
    {
        get { return nombreCompuerta; }
        set { nombreCompuerta = value; }
    }
    private string? nombreEntrada;

    public string? NombreEntrada
    {
        get { return nombreEntrada; }
        set { nombreEntrada = value; }
    }
    
    private int? entrada;

    public int? Entrada
    {
        get { return entrada; }
        set { entrada = value; }
    }
    public NOT(string nombreCompuerta, string nombreEntrada)
    {
        NombreCompuerta = nombreCompuerta;
        NombreEntrada = nombreEntrada;
    }
    public void AgregarEstado(int estado)
    {
        if (estado > 1 || estado < 0)
        {
            throw new ArgumentException("La entrada debe ser 0 o 1");
        }
        entrada = estado;
    }

    public int Calcular()
    {
        if (entrada == null)
        {
            throw new InvalidOperationException("La entrada no pueden ser nula");
        }
        if (entrada == 0)
        {
            return 1;
        }

        return 0;
    }
   
}
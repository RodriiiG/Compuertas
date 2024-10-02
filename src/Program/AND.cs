
namespace Program;
public class AND
{
    private string nombreCompuerta;

    public string NombreCompuerta
    {
        get { return nombreCompuerta; }
        set { nombreCompuerta = value; }
    }
    private string? nombreEntrada1;

    public string? NombreEntrada1
    {
        get { return nombreEntrada1; }
        set { nombreEntrada1 = value; }
    }
    private string? nombreEntrada2;

    public string? NombreEntrada2
    {
        get { return nombreEntrada2; }
        set { nombreEntrada2 = value; }
    }
    private int? entrada1;

    public int? Entrada1
    {
        get { return entrada1; }
        set { entrada1 = value; }
    }

    private int? entrada2;

    public int? Entrada2
    {
        get {return entrada2; }
        set { entrada2 = value; }
    }

    public AND(string nombreCompuerta, string nombreEntrada1, string nombreEntrada2)
    {
        NombreCompuerta = nombreCompuerta;
        NombreEntrada1 = nombreEntrada1;
        NombreEntrada2 = nombreEntrada2;
    }

    public void AgregarEstado1(int estado)
    {
        if (estado > 1 || estado < 0)
        {
            throw new ArgumentException("La entrada debe ser 0 o 1");
        }
        entrada1 = estado;
    }
    public void AgregarEstado2(int estado)
    {
        if (estado > 1 || estado < 0)
        {
            throw new ArgumentException("La entrada debe ser 0 o 1");
        }
        entrada2 = estado;
    }
    public int Calcular()
    {
        if (entrada1 == null || entrada2 == null)
        {
            throw new InvalidOperationException("Las entradas no pueden ser nulas");
        }
        if (entrada1 == 1 && entrada2 == 1)
        {
            return 1;
        }

        return 0;
    }
}
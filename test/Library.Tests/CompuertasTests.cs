using NUnit.Framework; // Asegúrate de tener esta línea
using Program;        // Asegúrate de importar el namespace Program

namespace Library.Tests;

public class ANDTests
{
    private AND andTest;
    [SetUp]
    public void Setup()
    {
        andTest = new AND("And", "A", "B");
    }
    
    [Test]
    public void ValoresInicialTest()
    {
        string nombre = "And";
        string compuerta1 = "A";
        string compuerta2 = "B";
        Assert.AreEqual(nombre,andTest.NombreCompuerta);
        Assert.AreEqual(compuerta1,andTest.NombreEntrada1);
        Assert.AreEqual(compuerta2,andTest.NombreEntrada2);
    }
    [Test]
    public void Agregar1ANDTest()
    {
        andTest.AgregarEstado1(1);
        Assert.AreEqual(1,andTest.Entrada1);
    }
    [Test]
    public void Agregar2ANDTest()
    {
        andTest.AgregarEstado2(1);
        Assert.AreEqual(1,andTest.Entrada2);
    }

    [Test]
    public void CalcularTest()
    {
        andTest.AgregarEstado1(1);
        andTest.AgregarEstado2(0);
        Assert.AreEqual(0, andTest.Calcular());
    }
}
public class ORTests
{
    private OR orTest;
    [SetUp]
    public void Setup()
    {
        orTest = new OR("Or", "A", "B");
    }
    
    [Test]
    public void ValoresInicialTest()
    {
        string nombre = "Or";
        string compuerta1 = "A";
        string compuerta2 = "B";
        Assert.AreEqual(nombre,orTest.NombreCompuerta);
        Assert.AreEqual(compuerta1,orTest.NombreEntrada1);
        Assert.AreEqual(compuerta2,orTest.NombreEntrada2);
    }
    [Test]
    public void Agregar1ORTest()
    {
        orTest.AgregarEstado1(1);
        Assert.AreEqual(1,orTest.Entrada1);
    }
    [Test]
    public void Agregar2ORTest()
    {
        orTest.AgregarEstado2(1);
        Assert.AreEqual(1,orTest.Entrada2);
    }

    [Test]
    public void CalcularTest()
    {
        orTest.AgregarEstado1(1);
        orTest.AgregarEstado2(0);
        Assert.AreEqual(1, orTest.Calcular());
    }
}
public class NOTTests
{
    private NOT notTest;
    [SetUp]
    public void Setup()
    {
        notTest = new NOT("Not", "A");
    }
    
    [Test]
    public void ValoresInicialTest()
    {
        string nombre = "Not";
        string compuerta = "A";
        Assert.AreEqual(nombre,notTest.NombreCompuerta);
        Assert.AreEqual(compuerta,notTest.NombreEntrada);
    }
    [Test]
    public void AgregarNOTTest()
    {
        notTest.AgregarEstado(1);
        Assert.AreEqual(1,notTest.Entrada);
    }

    [Test]
    public void CalcularTest()
    {
        notTest.AgregarEstado(1);
        Assert.AreEqual(0, notTest.Calcular());
    }
}

using BookData;
using MotivationalDays;

namespace EstructuraDatosTests;

public class Tests
{
    [Test]
    public void Paridad_Matricula_EsPar()
    {
        Assert.That(ParityChecker.ParityChecker.IsEven(2468), Is.True);
    }

    [Test]
    public void Paridad_Matricula_EsImpar()
    {
        Assert.That(ParityChecker.ParityChecker.IsEven(1357), Is.False);
    }

    [Test]
    public void Numero_Almacenado_En_Indice()
    {
        var storage = new NumberStorage.NumberStorage(new int[] { 10, 20, 30 });
        Assert.That(storage.GetNumberAt(1), Is.EqualTo(20));
    }

    [Test]
    public void Numero_Almacenado_IndiceFueraRango()
    {
        var storage = new NumberStorage.NumberStorage(new int[] { 1, 2 });
        Assert.Throws<IndexOutOfRangeException>(() => storage.GetNumberAt(5));
    }

    [Test]
    public void Calificaciones_Promedio_Correcto()
    {
        var grades = new double[,] { { 90, 80, 70 } };
        var sg = new StudentGrades.StudentGrades(grades);
        var result = sg.GetAllGradesWithAverages();
        Assert.That(result, Is.EqualTo($"Estudiante 1: Final=90, Parcial1=80, Parcial2=70, Promedio=80.00\r\n"));
    }

    [Test]
    public void Libro_LineaAleatoria_PrimeraPagina()
    {
        var pages = new char[][][]
        {
            new char[][] { "Hola".ToCharArray(), "Mundo".ToCharArray() },
            new char[][] { "Central".ToCharArray() },
            new char[][] { "Ultima".ToCharArray() }
        };
        var libro = new Book(pages);
        var linea = libro.GetRandomLineFromFirstPage(new Random(0));
        Assert.That(new[] { "Hola", "Mundo" }, Does.Contain(linea));
    }

    [Test]
    public void Libro_LineaAleatoria_CentralPagina()
    {
        var pages = new char[][][]
        {
            new char[][] { "Primera".ToCharArray() },
            new char[][] { "Central".ToCharArray(), "Otra".ToCharArray() },
            new char[][] { "Ultima".ToCharArray() }
        };
        var libro = new Book(pages);
        var linea = libro.GetRandomLineFromCentralPage(new Random(0));
        Assert.That(new[] { "Central", "Otra" }, Does.Contain(linea));
    }

    [Test]
    public void Libro_LineaAleatoria_UltimaPagina()
    {
        var pages = new char[][][]
        {
            new char[][] { "Primera".ToCharArray() },
            new char[][] { "Central".ToCharArray() },
            new char[][] { "Ultima".ToCharArray(), "Fin".ToCharArray() }
        };
        var libro = new Book(pages);
        var linea = libro.GetRandomLineFromLastPage(new Random(0));
        Assert.That(new[] { "Ultima", "Fin" }, Does.Contain(linea));
    }

    [Test]
    public void Saludo_CharArray()
    {
        var nombre = "Juan Perez".ToCharArray();
        var saludo = CharArrayGreeting.CharArrayGreeting.Greet(nombre);
        Assert.That(saludo, Is.EqualTo("Hola, Juan Perez!"));
    }

    [Test]
    public void Saludo_String()
    {
        var saludo = StringGreeting.StringGreeting.Greet("Ana López");
        Assert.That(saludo, Is.EqualTo("Hola, Ana López!"));
    }

    [Test]
    public void MensajeMotivador_Lunes()
    {
        var mensaje = MotivationalMessage.GetMessage(Day.Lunes);
        Assert.That(mensaje, Is.EqualTo("¡Nuevo inicio, nuevas oportunidades!"));
    }

    [Test]
    public void MensajeMotivador_Domingo()
    {
        var mensaje = MotivationalMessage.GetMessage(Day.Domingo);
        Assert.That(mensaje, Is.EqualTo("¡Recarga energías para la próxima semana!"));
    }
}

public class Observador : IObservador
{
    private string nombre;

    public Observador(string Nombre)
    {
        nombre = Nombre;
    }

    public void Actualizar(string mensaje)
    {
        Console.WriteLine($"Estimado cliente {nombre}: {mensaje}");
    }
}

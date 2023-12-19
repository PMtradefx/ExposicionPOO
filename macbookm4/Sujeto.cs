public class Sujeto : ISujeto
{
    private List<IObservador> observadores = new List<IObservador>();

    public void RegistrarObservador(IObservador observador)
    {
        observadores.Add(observador);
    }

    public void EliminarObservador(IObservador observador)
    {
        observadores.Remove(observador);
    }

    public void NotificarObservadores(string mensaje)
    {
        foreach (var observador in observadores)
        {
            observador.Actualizar(mensaje);
        }
    }
}
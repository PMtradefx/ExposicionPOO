public interface ISujeto
{
    void RegistrarObservador(IObservador observador);
    void EliminarObservador(IObservador observador);
    void NotificarObservadores(string mensaje);
}

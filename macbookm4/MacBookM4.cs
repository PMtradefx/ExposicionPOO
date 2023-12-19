public class MacBookM4 : Sujeto
{
    private bool disponible;

    public bool Disponible
    {
        get { return disponible; }
        set
        {
            disponible = value;
            if (disponible)
            {
                NotificarObservadores("PC MAster tiene el agrado de anuncuarle que\n  El Macbook con chip M4 ya se encuentra desponible para la compra\n encuentranos en el local 103 de edificio de ciencias informaticas en la Uleam.");
            }
        }
    }
}
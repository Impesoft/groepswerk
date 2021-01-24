namespace Dieren
{
    public interface IDier
    {
        string Name { get; set; }

        string Praten(string vraag);

        string Strelen();

        string Eten();
    }
}
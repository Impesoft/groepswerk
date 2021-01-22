namespace Dieren
{
    internal interface IDier
    {
        string Name { get; set; }

        string Praten(string vraag);

        string Strelen();

        string Eten();
    }
}
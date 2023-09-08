namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product latteBerna = new Product("Latte Berna", 1.20f, 15f);

            Console.WriteLine();
            Console.WriteLine($" Benvenuto alla pagina del prodotto {latteBerna.Name}");
            Console.WriteLine($" Numero seriale: {latteBerna.SerialNumber}");
            Console.WriteLine($" Nome univoco: {latteBerna.GetIdentificationName()}");
            Console.WriteLine($" Descrizione del prodotto: {latteBerna.Description}");
            Console.WriteLine($" Prezzo compresa IVA {latteBerna.Vat}%: {latteBerna.GetIvaTotalPrice()} || Prezzo originale: {latteBerna.Price} ");

        }
    }
}
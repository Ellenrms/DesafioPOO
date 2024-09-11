using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone iphone = new Iphone("123456789", "iPhone 14", "Apple", 128);
        Smartphone nokia = new Nokia("987654321", "Nokia 3310", "Nokia", 64);

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Facebook");
    }
}

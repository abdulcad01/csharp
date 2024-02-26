using System.Data.Common;

class Thagappa
{
    public string dad = "Abdullah";
    public void Dada()
    {
        Console.WriteLine("Bawa");
    }
}

//Second class

class Magan : Thagappa
{
    public string son = "Abbu";
    public void Beta()
    {
        Console.WriteLine("Abbu");
    }
  
}
class Family
{
    static void Main(string[] args)
    {
    Magan paiyan = new Magan();
    paiyan.Dada();
    paiyan.Beta();
  
    }
}

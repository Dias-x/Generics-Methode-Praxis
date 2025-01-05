class Program
{
    static void Main(string[] args)
    {
        //Liste erstellen
        List<string> namensListe = new List<string>();
        AddMultiple<string>(namensListe, 5, "Dias");
        
        
        foreach(string name in namensListe)
            Console.WriteLine(name);
    }

    
    //Generics Methode erstellen mit den Werten
    static void AddMultiple<T>(List<T> list, int amount, T value)
    {
        //Wert solange zur Liste hinzufügen, bis der amount "5" durchgeführt wurde
        for (int i = 0; i < amount; i++)
        {
            list.Add(value);
        }
    }
}
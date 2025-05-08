using evaluacion;

Pais paiiss = new();
paiiss = Cargarpais();



Console.WriteLine("presione tecla para mostrar datos");
Console.ReadKey();

Console.Clear();

mostrardatos();

void mostrardatos()
{
    
    Console.WriteLine("Pais:");
    Console.WriteLine($"  Nombre: {paiiss.Nombre}");
    foreach (Provincia provin in paiiss.provincias)
    {
        
        Console.WriteLine("    Provincia:");
        Console.WriteLine($"    Nombre: {provin.Nombre}");
        Console.WriteLine($"    Gobernador: {provin.Gobernador}");
        Console.WriteLine($"    Region: {provin.Region}");
        foreach (Ciudad ciudad in provin.ciudades)
        {
            Console.WriteLine("       Ciudades:");
            Console.WriteLine($"       Nombre: {ciudad.nombre}");
            Console.WriteLine($"       Habitantes: {ciudad.CantHabitantes}");
            Console.WriteLine($"       Superficie: {ciudad.Superficies}");
        }
    }
}



Pais Cargarpais()
{
    Pais paiis = new Pais();
    Console.WriteLine("ingrese el nombre del pais");
    paiis.Nombre = Console.ReadLine();
    Provincia provi;
    do
    {
        provi = CargarProvi();
        if (provi != null)
        {
            paiis.provincias.Add(provi);
            Ciudad ciuc;
            do
            {
                ciuc = CargarCiudad();
                if (ciuc != null)
                    provi.ciudades.Add(ciuc);
            } while (ciuc != null);
        }
    } while (provi != null);
    return paiis;
}
  Provincia? CargarProvi()
    {
        Provincia provinci = new();
        Console.WriteLine("ingrese el nombre de la provincia");
        provinci.Nombre = Console.ReadLine();
        if (!string.IsNullOrEmpty(provinci.Nombre))
        {
            Console.WriteLine("ingrese el nombre del gobernador");
            provinci.Gobernador = Console.ReadLine();
            Console.WriteLine("ingrese el nombre de la region");
            provinci.Region = Console.ReadLine();
            
            
           return provinci;
        }
       else
            return null;

    }
Ciudad? CargarCiudad()
{
    Ciudad ciud = new();
    Console.WriteLine("ingrese el nombre de la ciudad");
    ciud.nombre = Console.ReadLine();
    if (!string.IsNullOrEmpty(ciud.nombre))
    {
        Console.WriteLine("ingrese la cantidad de habitantes");
        ciud.CantHabitantes=int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese la superficie de la ciudad en kilometros cubicos");
        ciud.Superficies=double.Parse(Console.ReadLine());

        return ciud;
    }
    return null;
}

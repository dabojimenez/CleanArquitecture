// Funcion de primera clase
// sin los parentesis, por q ocn los parentesis, ya ejecutamos la funcion
var t = TomorrowPure;
Console.WriteLine(t(new DateTime(2024, 5, 5, 00, 00, 00)));

// Tipo Action
// Action: siempre es void, no regresa nada
// Es un tipo de delegado, para tener tipado de funciones
Action<string> show = Console.WriteLine;
show("hola");

// Funciones flecha o lambda
Action<string> hi = name => Console.WriteLine($"Hola {name}");
hi("David");
Action<int, int> add = (int a, int b) => show((a + b).ToString());
add(5, 6);
// Funcion NO PURA
DateTime Tomorrow()
{
    return DateTime.Now.AddDays(1);
}

Beer ToUpper(Beer beer)
{
    beer.Name = beer.Name.ToUpper();
    return beer;
}



// Funcion PURA
// Una funcion PURA, deve devolver siempre el mismo valor, cuando los parametros son los mismos
// Una FUNCION PURA, no modifica elementos externos
DateTime TomorrowPure(DateTime dateTime)
{
    return dateTime.AddDays(1);
}

Beer ToUpperPure(Beer beer)
{
    var beerDos = new Beer { Name = beer.Name.ToUpper() };
    return beerDos;
}




Console.WriteLine(Tomorrow());
Console.WriteLine(TomorrowPure(new DateTime(2025, 05, 01, 00, 00, 00)));
Beer berr = new Beer { Name = "Corona" };
Console.WriteLine(ToUpper(berr));
Console.WriteLine(berr.Name);
Beer berrDos = new Beer { Name = "Pilsener" };
Console.WriteLine(ToUpperPure(berr));
Console.WriteLine(berr.Name);

// Clases
public class Beer
{
    public string Name { get; set; }
}
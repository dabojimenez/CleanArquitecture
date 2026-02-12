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


// Func: siempre va a retornar algo, SIEMPREEE
// El tipo de dato, final definido es el q retornara
Func<int, int, int> mul = (a, b) => a * b;
show(mul(3, 4).ToString());

// Función de orden superior: pueden recibir funciones como parametros e incluso puede devolver otra funcion

List<int> numbers = [1,2,3,4,5];

List<int> Filter(List<int> list, Func<int, bool> condition)
{
    var resultList = new List<int>();
    foreach (int item in list)
    {
        if(condition(item))
            resultList.Add(item);
    }

    return resultList;
}

var numbers2 = Filter(numbers, n => n % 2 == 0);
foreach (int item in numbers2)
{
    Console.WriteLine(item);
}

Func<int, int, string> mulString = (a, b) =>
{
    var res = a * b;
    return res.ToString();
};
show(mulString(5,8));

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
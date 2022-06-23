// See https://aka.ms/new-console-template for more information
using Cohesion;

Console.WriteLine("Buscando Cohesion en Compras . . .\n");

List<Compra> compras = new List<Compra>();
compras.Add(new Compra(1, CiudadEnum.Santiago, 875));
compras.Add(new Compra(2, CiudadEnum.Lima, 1500));
compras.Add(new Compra(3, CiudadEnum.SaoPaulo, 5300));
compras.Add(new Compra(4, CiudadEnum.Montevideo, 3250));
compras.Add(new Compra(5, CiudadEnum.LaPaz, 2300));

var calculoTotal = new CalcularPrecio();


foreach (var compra in compras)
{
    string msj;

    if(compra.valor >= 5000)
    {
        calculoTotal.descuento(new CincoPorciento());
        msj = "5%";

    }else if(compra.valor >= 1000)
    {
        calculoTotal.descuento(new TresPorciento());
        msj = "3%";
    }
    else
    {
        calculoTotal.descuento(new SinDescuento());
        msj = "0%"; 
    }

    decimal valorTotal = calculoTotal.CalcularCompra(compra);
    Console.WriteLine($"Id: {compra.id}, Ciudad: {compra.ciudadEnum}, Valor: {compra.valor} ,valor Total: {valorTotal}, Descuento: {msj}");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
    Console.ForegroundColor = ConsoleColor.White;
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nend . . .");
Console.ForegroundColor = ConsoleColor.White;

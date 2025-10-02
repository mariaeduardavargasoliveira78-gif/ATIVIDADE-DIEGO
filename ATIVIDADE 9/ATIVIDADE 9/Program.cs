
Console.Write("digite a quatidade de maçãs compradas: ");

int quantidades = int.Parse(Console.ReadLine());

// se forem menos de 12 maçãs,preço é 1,30, caso contrário,1,00.
decimal precoUnitario * quantidade;
decimal total = precoUnitario * quantidade;

Console.WriteLine();
Console.WriteLine($"quantidade: {quantidades}");
Console.WriteLine($"preço unitario: {precoUnitario.ToString("(c")}");
Console.WriteLine($"custo total de compras: {total.ToString("c")}");


Console.WriteLine("/nPressione Enter para sair...");
Console.ReadLine();

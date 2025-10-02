
Console.WriteLine("exercicio 10 - média de avaliação");

//ler nota 1
Console.Write("digite a nota de 1 avaliação: ");
double nota2 = double.Parse(Console.ReadLine());

//ler nota 2
Console.Write("digite a nota 2 avaliação: ");
double nota2 = double.Parse(Console.ReadLine());

//calcular média
double media = (nota1 + nota2) / 2,0;


Console.WriteLine()
Console.WriteLine($"nota 1: {nota1}");
Console.WriteLine($"nota 2: {nota2}");
Console.WriteLine($"Média: {media:F2}");

//verificação aprovação
if (media >= 6.0

    Console.WriteLine("Aluno aprovado!");
else
    Console.WriteLine("Aluno não aprovado!");

Console.WriteLine("/nPressione Enter para sair...");
Console.ReadLine();





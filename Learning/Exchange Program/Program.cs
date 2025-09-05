using System.ComponentModel.Design;


    Console.WriteLine("A Luiza vai comigo no intercambio? ");
    string resposta = Console.ReadLine();

if (resposta == "sim")
{
    Console.WriteLine("Entao Ryan vai ficar feliz");
}
else if (resposta == "nao")
{
    Console.WriteLine("Entao Ryan vai ficar triste");
}
else
{
    Console.WriteLine("As unicas respostas aceitas são: 'sim' e 'nao'");
}

Console.ReadKey();
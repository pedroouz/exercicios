//Implemente um código que mostre como objetos de referência funcionam
public class Pessoa
{
    public string? Nome;
}

public class Ex002
{
    public static void Run()
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Roberto";

        Pessoa pessoa2 = pessoa1;
        pessoa2.Nome = "Julinha";
        Console.WriteLine(pessoa1.Nome);
        Console.WriteLine(pessoa2.Nome);
    }
}


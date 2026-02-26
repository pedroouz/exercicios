public class Ex004
{
    public static void Run()
    {
        //Crie um programa que tente converter uma string para int e evite exceções.
        string valor = Console.ReadLine();
        if (int.TryParse(valor, out int resultado))
        {
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Erro!");
        }
    }
}
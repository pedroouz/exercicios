
public class Ex001
{
    public static void Run()
{
    //Crie um programa que demonstre a diferença entre cópia e referência usando tipos de valor.
    int var1 = 1;
    int var2 = var1;
    Console.WriteLine($"Variavel 1 = {var1} Variavel 2 = {var2}");
    var2 = 2;
    Console.WriteLine($"Variavel 1 = {var1} Variavel 2 = {var2}");
}
}

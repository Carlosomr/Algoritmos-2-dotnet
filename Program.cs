namespace aula1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("### Programa da media ###");
        //chamando a função//
        BoasVindas("Carlos");

        Console.WriteLine("Digite a nota 1 >>"); // mostrar na tela //
        Double nota1 = Convert.ToDouble(Console.ReadLine()); // inserir dados do usuario//

        Console.WriteLine("Digite a nota 2 >>");
        Double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota 3 >>");
        Double nota3 = Convert.ToDouble(Console.ReadLine());

        Double media = (nota1 + nota2 + nota3) / 3;
        string resultado = "";

        if (media >= 6)
        {
            resultado = "Aprovado";
        } else {
             resultado = "reprovado";
        }

    Console.WriteLine($"Media: {media}");
    Console.WriteLine($"Resultado: {resultado}");

            //função//
    static void BoasVindas (string pessoa){
        Console.WriteLine(pessoa);
    }
    }
}

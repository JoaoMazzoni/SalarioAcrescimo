while (true)
{
    float salario = 0;
    float salarioAcrescimo = 0;
    float valorAcrescimo = 0;
    float porcentagem = 0;


    do
    {
        Console.Write("Digite o valor do salário base: ");
        salario = float.Parse(Console.ReadLine());
        if (salario == 0 || salario < 0)
        {
            Console.WriteLine("\n|O valor do salário não pode ser menor ou igual a zero.");
            Console.WriteLine("------------------------------------------------------------\n\n");
        }

    } while (salario == 0 || salario < 0);

    do
    {
        Console.Write("\nDigite o valor do salário com o acréscimo: ");
        salarioAcrescimo = float.Parse(Console.ReadLine());
        if (salarioAcrescimo < salario)
        {
            Console.WriteLine("\n|O valor do salário com acréscimo não pode ser inferior ao salário base.");
            Console.WriteLine("------------------------------------------------------------------------------\n\n");
        }
    } while (salarioAcrescimo < salario);

    valorAcrescimo = salarioAcrescimo - salario;
    porcentagem = (valorAcrescimo / salario) * 100;


    Console.WriteLine("\nO valor do acréscimo em porcentagem é: {0}%", porcentagem);

    Console.Write("\n\n|Pressione qualquer tecla: ");
    Console.ReadKey();
    Console.Clear();
}


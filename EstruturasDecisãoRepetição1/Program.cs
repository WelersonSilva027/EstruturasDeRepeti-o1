const string APROVADO = "Aluno Aprovado!";
const string REPROVADO = "Aluno Reprovado!";
const string RECUPERACAO = "Aluno ficou de Recuperação!";

Console.WriteLine("Digite uma nota para o Aluno:");

decimal nota = Convert.ToDecimal(Console.ReadLine());

if (nota >= 10)
{
    Console.WriteLine(APROVADO);
}
else if (nota >= 4 && nota < 5) //PRATICAR ESSA ESTRUTURA DE CÓDIGO PARA MELHOR FIXAÇÃO
{
    Console.WriteLine(RECUPERACAO);
}
else
{
    Console.WriteLine(REPROVADO);
}


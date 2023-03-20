using System.Data;
using System.Runtime.ConstrainedExecution;

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

/*switch (variavel)
{
    case valor1:
        //comando a ser executado;
        break;

    case valor2:
        //comando a ser executado;
        break;

        default;
        //comando a ser executado;
        break;
}
*/

const string DIAS_28 = "Este mês contem 28 Dias!";
const string DIAS_30 = "Este mês contem 30 Dias!";
const string DIAS_31 = "Este mês contem 31 Dias!";
const string MES_INVALIDO = "Este mês não existe!";

Console.WriteLine("Escreva um mês: ");
string mes = Console.ReadLine();

switch (mes.ToUpper())  //Comando ToUpper possibilita escrever em minusculo mesmo definindo os valores em UpperCase.
    //Isto é, Se eu definir "JANEIRO" no console posso digitar "Janeiro" normal ou todo em minusculo, sem problemas. 
{
    case "JANEIRO":
    case "MARCO":
    case "MAIO":
    case "JULHO":
    case "AGOSTO":
    case "OUTUBRO":
    case "DEZEMBRO":
        Console.WriteLine(DIAS_31);
        break;

    case "FEVEREIRO":
        Console.WriteLine(DIAS_28);
        break;

    case "ABRIL":
    case "JUNHO":
    case "SETEMBRO":
    case "NOVEMBRO":
        Console.WriteLine(DIAS_30);
        break;

    default:
        Console.WriteLine(MES_INVALIDO);
        break;
}


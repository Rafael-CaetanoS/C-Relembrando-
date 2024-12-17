// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

//int numero1 = 0;
//int numero2 = 0;
//char operador = ' ';
//int resultado = 0;

//Console.WriteLine("Digite o primeiro numero");
//numero1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o operador:");
//operador = char.Parse(Console.ReadLine());

//while (operador != '=')
//{
//    if (operador == '+' || operador == '-' || operador == '*' || operador =='/') {
//        Console.WriteLine("Digite um numero");
//        numero2 = int.Parse(Console.ReadLine());

//        switch (operador)
//        {
//            case '+':
//                resultado = numero1 + numero2;
//                break;

//            case '-':
//                resultado = numero1 - numero2;
//                break;
//        }
//        numero1 = resultado;
//        Console.WriteLine("Digite o operador:");
//        operador = char.Parse(Console.ReadLine());
//    }
//    else
//    {
//        Console.WriteLine("Operador invalido");
//        Console.WriteLine("Digite um operador valido:");
//        operador = char.Parse(Console.ReadLine());
//    }
   
//}

//Console.WriteLine($" Resultado final: {resultado}");


// Jogo da velha

string palavra = "rafael";
int quantidadeDeErros = 5;
List<string> letrasErradas = [];
List<string> letrasCertas = [];
string letraChute = "";



Console.WriteLine($"A palavra tem {palavra.Length} letras");

while(quantidadeDeErros != 0)
{
    Console.WriteLine("Chute uma letra");
    letraChute = Console.ReadLine();

    if (letrasErradas.Contains(letraChute) || letrasCertas.Contains(letraChute)){
        Console.WriteLine("Letra ja foi chutada");
        continue;
    }

    if(letraChute.Length > 1)
    {
        Console.WriteLine("Digite apenas uma letra");
        continue;
    }

    if (palavra.Contains(letraChute))
    {
        int index = 1;
        string[] letras = palavra.ToCharArray().Select(c => c.ToString()).ToArray();
        foreach (string t in letras)
        {
            if(t == letraChute)
            {
                Console.WriteLine($"A letra {letraChute} esta na posição {index} ");
            }
        index++;
        }

        letrasCertas.Add(letraChute);
    }
    else
    {
        letrasErradas.Add(letraChute);
        quantidadeDeErros--;
        Console.WriteLine($"Errou Te resta mais {quantidadeDeErros} tentativas");
        foreach (string letras in letrasErradas)
        {
            Console.WriteLine(letras);     
        }
    }
}








using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Interfaces;

IIMC objeto  = new IMC();

var imc = objeto.CalcularIMC(98.00, 1.78);
var resultado = objeto.RetornarClassificacaoIMC(imc);

// VER RESULTADO
    Console.WriteLine("O seu indice de massa corporal é: " + resultado);
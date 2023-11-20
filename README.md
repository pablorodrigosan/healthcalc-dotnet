# ::::::: Health Calc :::::::::
## Curso de Pós Graduação da Egenharia de Software Puc Minas
## Descrição Do Projeto
O projeto tem por objetivo calculac o Índice de Massa Corporal (IMC),
ele classifica o resultado e também faz um cálculo de macronutrientes.
Sem dúvida uma ferramenta importante para todas as pessoas que desejarem saber mais de sua saúde.

## Do Funcionamento:
Este programa efetua alguns calculos e processos seguir:

##  Cálculando IMC:

O IMC é calculado utilizando a fórmula IMC = peso (kg) / (altura (m) * altura (m)).
O resultado é categorizado de acordo com a classificação padrão do IMC.

## Cálculo de Macronutrientes:

A proporção de macronutrientes (carboidratos, proteínas e gorduras) é determinada com base no objetivo (perda de peso, manutenção de peso, ganho de peso) e nas diretrizes nutricionais recomendadas.
Os valores de carboidratos, proteínas e gorduras são calculados em gramas e exibidos na tela.

## Benefícios:

Os usuários podem monitorar seu IMC, o que é uma métrica importante para avaliar o peso corporal.
A aplicação ajuda os usuários a entender sua classificação de IMC e os riscos associados à sua categoria.

## Notas Adicionais:

É importante lembrar que essa aplicação fornece informações gerais e não substitui a orientação de um profissional de saúde ou nutricionista. A consulta a um profissional de saúde é recomendada antes de fazer mudanças significativas na dieta ou no estilo de vida.

## Pré-requisitos

- Visual Studio 2022 ou posterior.
- NET 7.0 SDK.
- xUnit.net para a execução dos testes.

## Configuração do Projeto

1. Clone este repositório em sua máquina local:
```
https://github.com/pablorodrigosan/healthcalc-dotnet.git
```

2. Verficar se voce possui o .NET 7.0 SDK instalado.

3. Restaurar as dependências do NuGet usando o seguinte comando

  - Selecione o comando de menu ferramentas > NuGet Gerenciador de Pacotes > Gerenciador de Pacotes Configurações.
  - Marque as duas opções em Restauração de Pacote.
  - Selecione OK.
  - Compile o projeto novamente.


## Estrutura do Projeto
![Untitled](https://github.com/pablorodrigosan/healthcalc-dotnet/blob/0714398d0ac8f65756c293e1cc24f8f0034aa551/estrutura-heathcalc.jpg)

## Execução de Testes

Para verificar a cobertura de testes instalar a extensão fine code coverage

## Sobre o uso do pacote

Você pode usar opacote fornecido para calcular o IMC e os macronutrientes. O pacote está disponível no NuGet. Para instalá-lo, execute o seguinte comando:

```
dotnet add package healthcalc-path-dotnetbhz --version 1.0.0

````

## Contribuição
Sinta-se a vontade para contribuir com este projeto, basta executar as etapas a seguir:

1. Primeiro faça um clone do repositório.
2. Procure criar uma nova branch para sua contribuição: `git checkout -b feature/sua-contribuicao`.
3. Efetue as suas alterações e adicione testes, se caso necessário.
4. Envie com um pull request.

## Autor <<<<
Pablo Rodrigo Dos Santos
 



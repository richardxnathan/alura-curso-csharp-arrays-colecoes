// Contrataram você como o novo desenvolvedor da equipe da Esther, e você ficou responsável de iniciar a codificação do módulo de estatística da aplicação,
// iniciando o desenvolvimento da função que irá calcular a média de uma amostra. Essa amostra será um vetor de doubles que será o parâmetro de entrada do seu método.

// Este é um exercício opcional e te desafiamos a criar um método que receba como parâmetro um array de double e retorne a média simples calculada.

double[] array = { 3.2, 5.4, 7.8, 9.9 };

void CalcularMediaVetor(double[] array)
{
    Console.WriteLine($"A média é {array.Average()}.");
}

CalcularMediaVetor(array);

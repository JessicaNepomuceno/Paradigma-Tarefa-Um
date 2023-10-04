//*****************************************************************************************************
//
//  Company: Paradigma
//  
//  Program Name: Avaliação Técnica - Tarefa 01
//  
//  Description: Utilizando o array [7, 5, 3, 9, 6, 4, 1], faça o código para percorrer a lista,
//  localizar e substituir o valor 9 por 5, remover o valor 4 da lista. Ao final você deve apresentar
//  na tela a lista original, a nova lista e a soma dos valores da nova lista.
//  
//  Author: Jéssica Alves Nepomuceno
//  
//  Created date: 03/10/2023
//
//*****************************************************************************************************

var listNumbers = new List<int>() { 7, 5, 3, 9, 6, 4, 1};
var headDescription = "--> Avaliação Técnica - Tarefa 01";
var headSubDescription = "--> Realizado por: Jéssica Nepomuceno";

void ShowHead()
{
    Console.WriteLine("=======================================================================================================");
    Console.WriteLine(headDescription);
    Console.WriteLine(headSubDescription);
    Console.WriteLine("=======================================================================================================");
    Console.WriteLine("\n");
}

ShowHead();

Console.WriteLine("=======================================================================================================");
Console.Write($"--> Lista original: [{string.Join(", ", listNumbers.Select(x => x))}] \n");
Console.WriteLine("\n");

listNumbers.Insert(listNumbers.IndexOf(9), 5);
listNumbers.Remove(9);

listNumbers.Remove(4);

Console.Write($"--> Nova lista: [{string.Join(", ", listNumbers.Select(x => x))}] \n");
Console.WriteLine("\n");

Console.Write($"--> Somatório com os valores da nova lista =  {listNumbers.Sum(x => x)} \n");
Console.WriteLine("=======================================================================================================");

Console.WriteLine("\n--> Para sair, pressione Enter! <--");

while (Console.ReadKey().Key != ConsoleKey.Enter) { }


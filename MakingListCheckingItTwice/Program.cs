
using System.Collections;
using System.Xml.Linq;

ArrayList inputList = new ArrayList();

string input = "Insert you input:";

for  (int i = 0; i < 10; i++)
{
    Console.WriteLine(input);
    var input2 = Console.ReadLine();
    inputList.Add(input2);
}



Console.WriteLine("Contenuto dell ArrayList in ordine Crescente");

foreach (var elemento in inputList)
{
    Console.WriteLine(elemento);
    
}

Console.WriteLine("Contenuto dell ArrayList in ordine Decrescente");

for (int i = inputList.Count -1; i >= 0; i--)
{
    Console.WriteLine(inputList[i]);
}

Console.ReadLine();




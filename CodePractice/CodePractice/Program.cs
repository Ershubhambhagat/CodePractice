using CodePractice;
using System.Net.Http.Headers;
using System.Security.AccessControl;

Console.WriteLine("Hello, World!");
 Car audi=new("audi");
 Car BMW=new("BMW");

audi.Drive();
Console.WriteLine("Type 1 for Stop");
string userInput=Console.ReadLine();

if (userInput == "1")
{
    audi.Stop();

}
else
{
    Console.WriteLine("Driveing");
}


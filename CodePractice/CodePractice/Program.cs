using CodePractice;
using System.Net.Http.Headers;
using System.Security.AccessControl;


Car audi=new("audi");
Console.WriteLine(audi.GetHP()+"is Hp of this Car");
Car BMW=new("BMW");
audi.Deatais();
BMW.Deatais();
BMW.Name = audi.Name;

Car MyCar = new Car();
Console.WriteLine(MyCar+"is my car 1");
MyCar.Deatais();

MyCar.Name = "Something";
Console.WriteLine(MyCar + "is my car 2");
MyCar.Deatais();


audi.Drive();
Console.WriteLine("Type 1 for Stop");
string userInput=Console.ReadLine();



#region if 
if (userInput == "1")
{
    audi.Stop();

}
else
{
    Console.WriteLine("Driveing");
}
#endregion


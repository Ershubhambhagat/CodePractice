using CodePractice;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Security.AccessControl;
#region Day_1 25/02/2024
//Car audi =new("audi");
//Console.WriteLine(audi.GetHP()+"is Hp of this Car");
//Car BMW=new("BMW");
//audi.Deatais();
//BMW.Deatais();
//BMW.Name = audi.Name;
//audi.Drive();
//Console.WriteLine("Type 1 for Stop");
////string userInput=Console.ReadLine();
//var userInput="1";
//#region if 
//if (userInput == "1")
//{
//    audi.Stop();
//}
//else
//{
//    Console.WriteLine("Driveing");
//}
//#endregion
#endregion
#region Day_2 25/02/2024
//Car MyCar = new Car();
//Console.WriteLine(MyCar + "is my car 1");
//MyCar.Deatais();
//MyCar.Name = "Something";
//Console.WriteLine(MyCar + "is my car 2");
//MyCar.Deatais();
//MyCar.MaxSpeed = 6884; //Now we can  set 
//Console.WriteLine("my car max speed is " + MyCar.MaxSpeed);
////MyCar.Waight = 6884; //read only prop
//Console.WriteLine("my car Waight  is " + MyCar.Waight);
#endregion
#region Day_2 {2} 25/02/2024 Mambers
//Mambers members =new Mambers();
//members.Introduction(true);
//Console.ReadKey();
#endregion
#region Day_2 {3} 25/02/2024 ForEach Loop With Array

int[] Number = { 0, 1, 2, 3, 4, 5, 6, 7, 9, 10 };
foreach (var item in Number)
{
    Console.WriteLine(item);

}
for(int i=0; i<Number.Length; i+=2)
{
    Console.WriteLine("i =" +i );

}
string input;
do
{
    Console.WriteLine("Input Valid Number");
    input = Console.ReadLine();

} while (!int.TryParse(input,out _));


#endregion



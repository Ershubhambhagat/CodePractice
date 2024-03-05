string[] myfamily = new string[] { "me ", "you" };

string[][] FreandsAndFamily = new string[][]
{
    new string[]{"Friend ","Friend2"} ,
    new string[]{"Father ","Mother"} ,
    new string[]{"Broathe","Cusion"} ,
    myfamily

};
Console.WriteLine(  "Hi {0},I am going to intreduce  {1}", FreandsAndFamily[0][0], FreandsAndFamily[0][1]);
Console.WriteLine(  "Hi {0},I am going to intreduce  {1}", FreandsAndFamily[1][0], FreandsAndFamily[1][1]);
Console.WriteLine(  "Hi {0},I am going to intreduce  {1}", FreandsAndFamily[2][0], FreandsAndFamily[2][1]);
Console.WriteLine(  "Hi {0},I am going to intreduce  {1}", myfamily[1][0], myfamily[1][1]);
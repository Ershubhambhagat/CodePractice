using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

class Programe
{
    static void Main(String[] args)
    {

        //Undifind amount of Obj
        ArrayList arrayList = new ArrayList();
        //difind amount of Obj

        ArrayList arrayList2 = new ArrayList(10);
        arrayList.Add("s");

        arrayList.Add(22);
        arrayList.Add(22);
        arrayList.Add(22);
        arrayList.Add(2.3);

        double sum = 2;
        foreach (object obj in arrayList)
        {
            if (obj is int)
            {
                sum += Convert.ToDouble(obj);
            }
            else if (obj is double)
            {
                sum += (double)obj;


            }
            else if (obj is string)
            {
                Console.WriteLine("all string is " + obj);
            }

        }
        Console.WriteLine("Sum of obj is :{0}", sum);
        Console.ReadKey();


    }


}
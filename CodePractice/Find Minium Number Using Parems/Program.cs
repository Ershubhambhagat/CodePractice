
using System.Security.Cryptography;

class Programe
{

    static void Main(string[] args)
    {

        int min= math2(2, 3, 34, 1, 434, 3, 123);
        Console.WriteLine(  "This is min numnber :{0}",min);

    }

    public static int math2(params int[] numbers)
    {
        int min = int.MaxValue;
        foreach (var number in numbers)
        {
            if(number< min)
            {
                min = number;
            }

        }
        return min;
    }

}
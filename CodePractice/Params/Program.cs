

using System.Security.Cryptography;
class Programe
{
    static void Main()
    {
        ParemsMethod("this  is the text "+"from "+"me");

    }


    public static void ParemsMethod(params string[] sentance)
    {
        for (int i = 0; i < sentance.Length; i++)
        {
            Console.WriteLine(sentance[i] + " ");


        }


    }
}
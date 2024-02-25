Console.WriteLine("");

 int[,] matrix = {
    { 1,2,3},
    { 4,5,6 },
    { 7,8,9}
};

 
foreach (var item in matrix)
{
    Console.WriteLine(item.ToString(),"");
            
}
Console.WriteLine("2D Array Printed Using Nested For Loop");
//Outer For Loop 
for (int i = 0; i <matrix.GetLength(0); i++)
{
    //Inner For Loop 
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine(matrix[i,j]);

    }
}
    

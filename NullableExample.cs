using System;
using System.Collections.Generic;
class NullableExample
{
    static void Main()
    {
        //Nullable and non-nullable float
        float pi = 3.14f;
        float? pi2 = 3.14f;
        float? piUnknown = null;

        //Non-Nullable and Nullable assigned a non-null value
        int num1 = 10;
        int? num2 = num1;

        //Nullable Boolean
        bool? flag = null;

        //Nullable Array of ints example
        int?[] myArray = new int?[10];

        Console.WriteLine("Am I null?: " + flag.HasValue); //Boolean returning if I have a value
        Console.WriteLine("The value in num2 is:" + num2.Value); //Getting the value of the nullable
    }
}

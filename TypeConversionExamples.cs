using System;

public class TypeConversionExamples
{
    static void Main(string[] args)
    {
        // Ints have 4 bytes of size
        // Longs have 8 bytes of size
        int num1 = 25;
        //byte num2 = (byte)num1;
        long num2 = num1; // implicit conversion from int to a long, smaller size -> larger size

        int num3 = (int)num2;

        // sometimes we want ot convert a string to an Int
        string myNum = "50";

        int myRealNum = Int32.Parse(myNum);
        int myRealNum2 = Convert.ToInt32(myNum);
        // int myRealAttemptAtARealNum = (int)myNum; // commonly tried, will NOT work
    }
}

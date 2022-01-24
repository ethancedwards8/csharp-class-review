using System;

public enum LetterGrade
{
    A,
    B,
    C,
    D,
    F
}

public class FindLetterGrade
{
    public static void Main()
    {
        Console.WriteLine("Please enter your grade: ");
        float numGrade = Convert.ToInt32(Console.ReadLine());

        IFFindGrade(numGrade);
        SWITCHFindGrade(numGrade);
    }

    public static LetterGrade SWITCHFindGrade(float grade)
    {
        LetterGrade res;

        switch (grade)
        {
            case < 0:
                Console.WriteLine("You've entered an invalid grade.");
                res = LetterGrade.F;
                break;

            case >= 90:
                Console.WriteLine("You've passed the class with an: \"A\"");
                res = LetterGrade.A;
                break;

            case >= 80:
                Console.WriteLine("You've passed the class with an: \"B\"");
                res = LetterGrade.B;
                break;

            case >= 70:
                Console.WriteLine("You've passed the class with an: \"C\"");
                res = LetterGrade.C;
                break;

            case >= 60:
                Console.WriteLine("You've passed the class with an: \"D\"");
                res = LetterGrade.D;
                break;

            default:
                Console.WriteLine("You've failed the class with an: \"F\"");
                res = LetterGrade.F;
                break;
        }

        return res;
    }

    public static LetterGrade IFFindGrade(float grade)
    {
        LetterGrade res;

        // if statement version
        if (grade < 0)
        {
            Console.WriteLine("You've entered an invalid grade.");
            res = LetterGrade.F;
        }
        else if (grade >= 90)
        {
            Console.WriteLine("You've passed the class with an: \"A\"");
            res = LetterGrade.A;
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You've passed the class with an: \"B\"");
            res = LetterGrade.B;
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You've passed the class with an: \"C\"");
            res = LetterGrade.C;
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You've passed the class with an: \"D\"");
            res = LetterGrade.D;
        }
        else 
        {
            Console.WriteLine("You've failed the class with an: \"F\"");
            res = LetterGrade.F;
        }

        return res;
    }

}

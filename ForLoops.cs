using System;
using System.Collections.Generic;
public class ForLoops
{
    public static void Main()
    {
        // Three statements needed in a for loop declaration
        // 1st; Exit Variable Declaration ; 2nd: Condition to check before each iteration ; 3rd: Exit variable change, usually -- or ++;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Current iteration is: {i}");
        }
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine($"Current iteration is: {i}");
        }

        List<string> cards = new List<string>();
        for (int i = 2; i <= 14; i++)
        {
            for (int suit = 1; suit <= 4; suit++)
            {
                string currentSuit = "";
                string currentCard = "";
                switch (suit)
                {
                    case 1:
                        currentSuit = "Hearts";
                        break;
                    case 2:
                        currentSuit = "Diamonds";
                        break;
                    case 3:
                        currentSuit = "Clubs";
                        break;
                    case 4:
                        currentSuit = "Spades";
                        break;
                    default:
                        break;
                } //End switch

                if (i == 11)
                {
                    currentCard = "Jack of " + currentSuit;
                }
                else if (i == 12)
                {
                    currentCard = "Queen of " + currentSuit;
                }
                else if (i == 13)
                {
                    currentCard = "King of " + currentSuit;
                }
                else if (i == 14)
                {
                    currentCard = "Ace of " + currentSuit;
                }
                else
                {
                    currentCard = i + " of " + currentSuit;
                }

                cards.Add(currentCard);
            } //end nested for loop
        } //end outer for loop

        foreach (string c in cards)
        {
            Console.WriteLine(c);
        }


    }
}

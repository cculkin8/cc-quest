using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void DefinitelyNotMain()        {
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                $"What is the current second? (it's {DateTime.Now.Second})", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge($"What number am I thinking of? (it's {randomNumber})", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20
            );
            Challenge dumbQuestion1 = new Challenge(
                @"Why did Carter Culkin join NSS
    1) Out of moral obligation
    2) Because he wanted to start a new career path
    3) Because he got tired of the automotive industry
    4) To make money
    5) All of the above
                  ", 
                  5, 10);
            Challenge dumbQuestion2 = new Challenge(
                @"Who is the best Dark Souls summon here?
    1) Black Iron Tarkus
    2) Manscorpian Tark
    3) Knight Slayer Tsorig
                ",
                1,100
            );
                Challenge dumbQuestion3 = new Challenge(
                "What is the airspeed velocity of an unladen swallow? (In miles per hour)",
                25,25
            );

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 200;

            Console.WriteLine("What is your name peasant?");
            string AdName = Console.ReadLine();
            Console.WriteLine($"{AdName} is the best your parents could come up with? I guess I'll let it slide but grow a better imagination");
            Console.WriteLine("===========================================================================================================");

            Robe AdRobe = new Robe();
            Hat AdHat = new Hat();
            { 
                AdHat.ShininessLevel = new Random().Next(12);
            }
            Prize ABadPrize = new Prize ("this mug I have sitting next to my mouse");
            while (true)
            {
                Console.WriteLine("What color would you like on your robe?");
                string singeColor = Console.ReadLine();
                AdRobe.Colors.Add(singeColor);
                Console.WriteLine("Do you REALLY want to add another color? (Y/N)");
                string moreColors = Console.ReadLine().ToLower();
                while (moreColors != "y" && moreColors != "n")
                {
                    Console.WriteLine("Do you REALLY want to add another color? (Y/N)");
                    moreColors = Console.ReadLine().ToLower();
                }
                if (moreColors == "n")
                {
                    break;
                }


            }
            // Make a new "Adventurer" object using the "Adventurer" class
            Adventurer theAdventurer = new Adventurer(AdName, AdRobe, AdHat);
            Console.Clear();
            Console.WriteLine("Let me put my glasses on so I can take a good look at you, one sec.");
            Thread.Sleep(2000);
            Console.WriteLine(theAdventurer.GetDescription());
            Thread.Sleep(4000);
            Console.WriteLine("Now answer these questions");
            Console.WriteLine("===============================================================================================================");

            // A list of challenges for the Adventurer to complete
            // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
            int randomInt()
            {
                int i = new Random().Next() % 10;
                return i;
            }
            Dictionary<Challenge, int> challenges = new Dictionary<Challenge, int>();
                challenges.Add(twoPlusTwo, randomInt());
                challenges.Add(theAnswer, randomInt());
                challenges.Add(whatSecond, randomInt());
                challenges.Add(guessRandom, randomInt());
                challenges.Add(favoriteBeatle, randomInt());
                challenges.Add(dumbQuestion1, randomInt());
                challenges.Add(dumbQuestion2, randomInt());
                challenges.Add(dumbQuestion3, randomInt());

                var sorted = from pair in challenges
                orderby pair.Value descending
                select pair;
                int i =0;

            // Loop through all the challenges and subject the Adventurer to them
            foreach (var challenge in sorted)
            {
                if (i<6)
                {
                    challenge.Key.RunChallenge(theAdventurer);
                }
                i++;
            }
            
            // This code examines how Awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }
            Console.WriteLine(ABadPrize.ShowPrize(theAdventurer));
            Thread.Sleep(3000);
        }
        static void Main(string[] args){
            DefinitelyNotMain();
            Console.WriteLine("Would you like to continue? (Y/N):" );
            string reply = Console.ReadLine().ToLower();
           while (reply != "y" && reply != "n")
         {
           Console.Write("Would you like to continue? (Y/N):" );
           reply = Console.ReadLine().ToLower();
        }
         if (reply == "y")
        {
          DefinitelyNotMain();
         }
         else
         {
         Console.WriteLine("You're just a sore loser then aren't you?");
         }
    }
    }
}
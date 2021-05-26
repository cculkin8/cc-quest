//_text class needed, text paramenter should be fed in a _text sub(constructor)-class
//Create a method called showprize to accept the adventurer parameter, and if the awesomeness is greater than zero show a text field to the console with the same value of the awesomeness property. If the awesomeness is zero or less than zero write a message of pity
//Create an instance of prize in program.cs
//ShowPrize at the end of the quest

namespace Quest
{
    public class Prize
    {
        private string _text {get; set; }

        public Prize(string prizeName)
        {
            _text = prizeName;
        }
        public string ShowPrize(Adventurer player)
        {
            if (player.Awesomeness <= 0)
            {
                return "You should just give up and leave if you're going to be this pitiful";
            }
            else if (player.Awesomeness > 0)
            {
                return $"Wow, you actually won. I won't let you win another round but go ahead and take {_text} as your prize.";
            }
            else
            {
                return "";
            }
        }
    }}
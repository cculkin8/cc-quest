namespace Quest
{
    public class Hat
    {

        public int ShininessLevel { get; set; }

        public string ShininessDescription
        {
            get
            {
                if (ShininessLevel <= 2)
                {
                    return "whoops, I dropped your hat in the mud. It's kinda dull now.";
                }
                else if (ShininessLevel <= 5)
                {
                    return "your hat is noticeable at best. I hope you aren't as bad at answering my riddles as you are at picking hats";
                }
                else if (ShininessLevel <= 9)
                {
                    return "nice Hat you got there, though it's a bit too bright for my tastes. I'll pluck it off your body when you fail to decipher these riddles regardless.";
                }
                else if (ShininessLevel > 9)
                {
                    return "what a beautiful shiny hat you have there, it's damn near blinding me.";
                }
                else
                {
                    return "where is your hat dummy?";
                }
            }
        }

    }
}
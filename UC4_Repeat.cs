namespace UC4_Repeat
{
     public class UC4_Repeat
        {

        static void Main(string[] args)
        {

            void Position()
            {
                int No_Play = 1;
                int Play_Ladder = 2;
                int Play_Snake = 3;
                int WinningPosition = 100;
                int playerPosition = 0;
                int DiceNum;
                while (playerPosition <= WinningPosition)
                {
                    Random rNumber = new Random();
                    DiceNum = rNumber.Next(1, 7);
                    Random rd = new Random();
                    int Option = rd.Next(0, 3);
                    if (Option == No_Play)
                    {
                        Console.WriteLine("No play");
                    }
                    else if (Option == Play_Ladder)
                    {
                        playerPosition = playerPosition + DiceNum;
                        Console.WriteLine("Ladder--->Your position is now:" + playerPosition);
                    }
                    else if (Option == Play_Snake)
                    {
                        playerPosition = playerPosition - DiceNum;
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        Console.WriteLine("Snake--->Your position is:" + playerPosition);
                    }
                }
            }

        }

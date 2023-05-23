using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class UC3_CheckOption
{
    public void checkoption()
    {
        int No_Play = 1;
        int Play_Ladder = 2;
        int Play_Snake = 3;

        int Position = 0;
        Random randomnumber = new Random();
        int Option = randomnumber.Next(1, 3);
        int DiceNum = randomnumber.Next(0, 7);

        if(Option == No_Play)
        {
            Console.WriteLine("No play");
        }
        else if (Option == Play_Ladder)
        {
            Console.WriteLine("Ladder--->Your position is now:"+ DiceNum);
        }
        else if (Option == Play_Snake)
        {
           Console.WriteLine("Snake--->You are still in First position");
        }

        
    }

}


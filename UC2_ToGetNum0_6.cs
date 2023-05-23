using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 public class UC2_ToGetNum0_6
    {
    public void GetNumber()
    {
        int Player;
        Random randamnumber = new Random();
        Player = randamnumber.Next(1, 6);
        Console.Write("Player Gets the Number is:" + Player+"\n");
    }
   

}


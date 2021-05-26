using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //PlayerCharacter player = new PlayerCharacter();
            //player.DaysSinceLastLogin = 42;
            ////var player = new PlayerCharacter
            ////{
            ////    Name = ""
            ////    //,DaysSinceLastLogin = 42
            ////};


            ////PlayerDisplayer.Write(player);

            ////int days = player.DaysSinceLastLogin.Value;
            //int days = player?.DaysSinceLastLogin?? -1;

            //Console.WriteLine(days);

            #region Using the Null Conditional Operator
            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter{ Name = "Tammy"}
                ,new PlayerCharacter()
                ,null
            };

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;
            #endregion


        }
    }
}

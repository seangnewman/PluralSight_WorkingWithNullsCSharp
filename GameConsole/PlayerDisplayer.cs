﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);

            }
            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);

            // Using conditional operator
            //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;

            // Null Coalescing operator
            int days = player.DaysSinceLastLogin ?? -1;

            /// Using null conditional 

            Console.WriteLine($"{days} days since last login");

            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin.Value);
            //}
            //else
            //{
               
            //    Console.WriteLine("No value for DaysSinceLastLogin");
            //}

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }


            if (player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if(player.IsNoob == true)
            {
                Console.WriteLine("Player is newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}

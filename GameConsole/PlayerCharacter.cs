using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name  { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }

        //public PlayerCharacter()
        //{
        //    #region Using Magic Numbers for Value Types
        //    //DateOfBirth = DateTime.MinValue; // Magic Number
        //    //DaysSinceLastLogin = -1;
        //    #endregion
        //    #region Nullable Values
        //    DateOfBirth = null;
        //    DaysSinceLastLogin = null;
        //    #endregion
        //}
    }
}

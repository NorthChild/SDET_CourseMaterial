using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    public class Stones
    {


        public static void Main(string[] args) 
        {

            GetStones(-1);
        }


        public static int GetStones(int totalPounds)
        {

            if (totalPounds < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Input");
            }

            var stonesConv = totalPounds * 0.071429f;
            return (int)stonesConv;


            
        }

        public static int GetPounds(int totalPounds)
        {

            if (totalPounds < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Input");
            }

            return totalPounds % 14;


        }



        


        
    }
}

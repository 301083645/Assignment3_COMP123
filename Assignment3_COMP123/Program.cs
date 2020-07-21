/*
 * Author's name       : Eunbee Lee
 * student number      : 301083645
 * Date last modified  : 2020/Jul/21
 * Program description : Planet creating program for the Assignment3
 * Revision History    : 2020/Jul/21
 */

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_COMP123
{
    class Program
    {
        static void waitForAnyKey()
        {
            Console.ReadKey();
        }

   

        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Mars",8000,9000,"gas");
            Console.WriteLine(giantPlanet.ToString());

            //TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet();
        }
    }
}

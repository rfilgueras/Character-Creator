/*
 * 
 * FoodBotMini GUI Character Creator
 * Windows Form project
 * 
 * Rhona Filgueras
 * December 12, 2020
 * 
 * Transparancey Control code derived from 
 * https://stackoverflow.com/questions/10455484/winforms-semi-transparent-png-over-semi-transparent-png
 * To change Font Style derived from
 * https://stackoverflow.com/questions/10173147/easiest-way-to-change-font-and-font-size
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

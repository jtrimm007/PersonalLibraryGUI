///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	File Name:         Program.cs
//	Description:       This Program file contains the Main which is the starting point for the program to run.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PersonalLibraryGUI
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// <see cref="Program" /> is where the application starts.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Add the splash screen
            Application.Run(new SplashScreenForm());
            Application.Run(new PersonalLibraryForm());
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	File Name:         SplashScreenForm.cs
//	Description:       YOUR DESCRIPTION HERE
//	Course:            CSCI 2210 - Data Structures	
//	Author:           Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PersonalLibraryGUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="SplashScreenForm" />.
    /// </summary>
    public partial class SplashScreenForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashScreenForm"/> class.
        /// </summary>
        public SplashScreenForm()
        {
            InitializeComponent();
            this.Text = String.Format("Splash {0}", Application.ProductName);
        }

        /// <summary>
        /// The SplashScreenForm_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            this.Version.Text = $"Version {Application.ProductVersion}";
        }

        /// <summary>
        /// The SplashTimer_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

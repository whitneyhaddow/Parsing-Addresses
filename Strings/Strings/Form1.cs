using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //splits the address into components and displays them
        private void btnParse_Click(object sender, EventArgs e)
        {
            //Get the culture property of the thread to use ToTitleCase
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            string address; //full address
            

            //need an array of strings because the string will split into an array
            string[] components; //address components 
            address = txtAddress.Text; //get the address
            components = address.Split(','); //split at commas
            components[0] = components[0].Replace("Str.", "Street"); //will change str. to street if str. is present
            //the above line is case senstive

           //changes city ([1]) to title case
            components[1] = textInfo.ToTitleCase(components[1]);

            components[2] = components[2].ToUpper(); //changes province code to upper case

            //display address components
            lblAddress.Text = components[0];
            lblCity.Text = components[1];
            lblProvince.Text = components[2];
            lblPostalCode.Text = components[3];
      
        }
    }
}

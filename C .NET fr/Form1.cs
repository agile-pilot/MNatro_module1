using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C.NET_fr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            //string username;
            //username = textboxUsername.Text;
            //username = username + "something";
            //textboxUsername.Text = username;1

            //1. get username value from somewhere. 
            string username = textboxUsername.Text;
            string somev;


            //2. calculate greeting string by HelloLibrary. Save to the variable String greeting
            string greeting = HelloLibrary.HelloHelper.GetHello(username);


            //3 set greeting string to text (component that has "user see" text)
            // text - object ( it's like concept, it's component name, it's label.
            // Set = action
            // greeting string  - object
            // {target where we are going to save value} = { source where we are going to get value from}
            // {target where we are going to save value} 
            // {target where we are going to save value} 
            //{ source where we are going to get value from}
            text.Text = greeting;

        }

        private void text_Click(object sender, EventArgs e)
        {

        }
    }
}

using Mini_Project___Web_Services___Winform.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project___Web_Services___Winform
{
    public partial class Form1 : Form
    {
        APIcontroller APIcontroller = new APIcontroller();
        



        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string fruit1 = Fruit1.Text;
            string fruit2 = Fruit2.Text;
            bool ice = IceBox.Checked;
         
            
            string getSmoothie = APIcontroller.GetMethod($"https://miniproject-webservices-rest20190924043310.azurewebsites.net/api/smoothie?fruit1={fruit1}&fruit2={fruit2}&iceOrNot={ice}");
            if (getSmoothie != "null")
            {
                smoothieList.Items.Add(getSmoothie);
            }
            else
            {
                MessageBox.Show("Smoothie not found, please try agian..");
            }
            
        }

       

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            string recipeName = RecipeBox.Text;

            string getRecipeName = APIcontroller.GetMethod($"https://miniproject-webservices-rest20190924043310.azurewebsites.net/api/smoothie?name={recipeName}");
            if(getRecipeName != "null")
            {
                RecipeItems.Items.Add(getRecipeName);
            }
            else
            {
                MessageBox.Show("Name not found.. please try agian");
            }
            
        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void TextBox3_TextChanged_1(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font.Name, 24F);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var returnedFruits = APIcontroller.GetMethod("https://miniproject-webservices-rest20190924043310.azurewebsites.net/api/smoothie");
            var trimedList = Regex.Replace(returnedFruits, @"[^\w\@-]", " ", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            string[] fruitList = trimedList.Split(' ');

            foreach (var fruit in fruitList)
            {
                if (fruit.Length > 0)
                {
                    fruitsList.Items.Add(fruit);
                }
            }
        }

        private void FruitsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Przychodnia;
using System.ComponentModel;
using System.IO;
using System.Text;



namespace WebPrzychodnia
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = "Oho!";
            //Label1.Text = Przychodnia.
            

            
            //ListBox1.Items.Add(czynnosc.ToString());
            foreach(Przychodnia.CzynnoscZaplanowana czynnosc in Przychodnia.CzynnoscZaplanowana.listaCzynnosciZaplanowanych)
            {
                DropDownList1.Items.Add(czynnosc.ToString());
            }
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "Dane";
            if (!string.IsNullOrEmpty(path))
            {
                string[] readText = File.ReadAllLines(@"G:\sem2\programowanie\Dane.txt");
                StringBuilder strbuild = new StringBuilder();
                foreach (string s in readText)
                {
                    strbuild.Append(s);
                    strbuild.AppendLine();
                }
                 strbuild.ToString();
                DropDownList1.Items.Add(strbuild.ToString());
            }
        }
    }
}
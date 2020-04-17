using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxAutoComplete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Turn on "AutoComplete" propertie in textbox
        private void SetAutoComplete()
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.Add("arbuz");
            source.Add("anana");
            source.Add("aawoakdo");
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteCustomSource = source;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetAutoComplete();
        }
        //IF APPLICATION THROW A INTERFACE EXCEPTION THEN YOU NEED TO ADD BEFORE main() ATTRIBUTE [STAThread]. FOR EXAMPLE

        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form());
        //}
    }
}

using System;
using System.IO;

namespace CSVExporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String year = DateTime.Now.Year.ToString();
            String month = DateTime.Now.Month.ToString();
            String day = DateTime.Now.Day.ToString();
            String hour = DateTime.Now.Hour.ToString();
            String minute = DateTime.Now.Minute.ToString();
            String contents = this.richTextBox1.Text;
            String name = year + "-" + month + "-" + day + "-" + hour + "-" + minute + ".csv";
            contents = contents.Replace(' ', ';');
            FileStream fs = new FileStream(name, FileMode.Append, FileAccess.Write);  
            StreamWriter sw = new StreamWriter(fs); 
            if (File.Exists(name)) {
                MessageBox.Show("Successfully Created File!", "CSVExporter", MessageBoxButtons.OK);
            } else
            {
                MessageBox.Show("File Did Not Created Successfully.", "CSVExporter", MessageBoxButtons.OKCancel);
            }
            sw.WriteLine(contents);  
            sw.Flush();  
            sw.Close();  
            fs.Close();  
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
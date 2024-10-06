namespace markedtext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
        
                n++;
                listBox1.Items.Add(n + ") Ad və soyad: " +textBox1.Text+
                    " Təvəllüd: "+dateTimePicker1+" Telefon: "+maskedTextBox2.Text+
                    " Seriya: "+maskedTextBox3.Text+" Saat: "+maskedTextBox4.Text);
                
            
        }
    }
}
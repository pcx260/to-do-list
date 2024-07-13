namespace to_do_list
{
    public partial class Form1 : Form
    {
        string _todolist;
        
        string _result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            _todolist += textBox1.Text;
            _todolist += "\n";

            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(_todolist);
            
        }
    }
}

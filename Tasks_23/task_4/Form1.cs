namespace task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = Convert.ToString(textBox1.Text);
            string name = Convert.ToString(textBox2.Text);
            string lastName = Convert.ToString(textBox3.Text);

            textBox6.Text += Environment.NewLine + " �������:" + firstName;
            textBox6.Text += Environment.NewLine + " ���:" + name;
            textBox6.Text += Environment.NewLine + " ��������:" + lastName;

            if (radioButton1.Checked)
            {
                textBox6.Text += Environment.NewLine + "���: " + radioButton1.Text;
            }else if (radioButton2.Checked)
            {
                textBox6.Text += Environment.NewLine + "���: " + radioButton2.Text;
            }

            textBox6.Text += Environment.NewLine + "���� ��������: " + comboBox1.Text +" "+ comboBox2.Text + " " + comboBox3.Text;

            textBox6.Text += Environment.NewLine + "����� ����������: " + comboBox4.Text;

            textBox6.Text += Environment.NewLine + "����� ����������� �����: " + textBox4.Text;

            textBox6.Text += Environment.NewLine + "��������� �������: " + comboBox5.Text + " " + textBox5.Text;

            if (radioButton3.Checked)
            {
                textBox6.Text += Environment.NewLine + "���� ������: " + radioButton3.Text;
            }else if (radioButton4.Checked)
            {
                textBox6.Text += Environment.NewLine + "���� ������: " + radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                textBox6.Text += Environment.NewLine + "���� ������: " + radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                textBox6.Text += Environment.NewLine + "���� ������: " + radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                textBox6.Text += Environment.NewLine + "���� ������: " + radioButton7.Text;
            }

            if (checkBox1.Checked)
            {
                textBox6.Text += Environment.NewLine + "���� ������ ����";
            }
            else
            {
                textBox6.Text += Environment.NewLine + "��� ������ ����";
            }

            if (checkBox2.Checked)
            {
                textBox6.Text += Environment.NewLine + "���� ������������ �������������";
            }
            else
            {
                textBox6.Text += Environment.NewLine + "��� ������������� �������������";
            }

            if (checkBox3.Checked)
            {
                textBox6.Text += Environment.NewLine + "������������ ���������" + checkBox3.Text;
            }
            
            if (checkBox4.Checked)
            {
                textBox6.Text += Environment.NewLine + "������������ ���������" + checkBox4.Text;
            }

            if (checkBox5.Checked)
            {
                textBox6.Text += Environment.NewLine + "������������ ���������" + checkBox5.Text;
            }

            if (checkBox6.Checked)
            {
                textBox6.Text += Environment.NewLine + "������������ ���������" + checkBox6.Text;
            }

            textBox6.Text += Environment.NewLine + "���������� ����� ��:" + numericUpDown1.Value + "��: " + numericUpDown2.Value;

            if (radioButton8.Checked)
            {
                textBox6.Text += Environment.NewLine + "������ ������: " + radioButton8.Text;
            }else if (radioButton9.Checked)
            {
                textBox6.Text += Environment.NewLine + "������ ������: " + radioButton9.Text;
            }
            else if (radioButton10.Checked)
            {
                textBox6.Text += Environment.NewLine + "������ ������: " + radioButton10.Text;
            }
            else if (radioButton11.Checked)
            {
                textBox6.Text += Environment.NewLine + "������ ������: " + radioButton11.Text;
            }
        }
    }
}
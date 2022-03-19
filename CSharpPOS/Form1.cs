namespace CSharpPOS
{
    public partial class Form1 : Form
    {
        private string name;
        private double price;
        private double number;
        private double subTatal;

        public Form1()
        {
            InitializeComponent();
            name = "";

            //�N���~���رa����
            DataGridViewRowCollection rows = dataGridViewMenu.Rows;
            rows.Add(new object[] { "����", 25 });
            rows.Add(new object[] { "���", 25 });
            rows.Add(new object[] { "����", 30 });
            rows.Add(new object[] { "�ï]����", 35 });


        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //����Y���� �N�Ӷ��ت�����J�N�ʶ��ؤ�
            if (dataGridViewMenu.Rows[e.RowIndex].Cells[0].Value == null)
            {
                return;
            }

            textBoxName.Text = dataGridViewMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxPrice.Text = dataGridViewMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDownNumber.Value = 1;
            textBoxSubTotal.Text = textBoxPrice.Text;
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            calculateSubTotal();//�ƶq�ק�� ���s�p��
        }

        //���s�p��p�p
        private void calculateSubTotal()
        {
            if (textBoxName.Text == "" && textBoxPrice.Text == "")
            {
                return;
            }

            name = textBoxName.Text;
            price = double.Parse(textBoxPrice.Text);
            number = (double)numericUpDownNumber.Value;
            subTatal = price * number;
            textBoxSubTotal.Text = subTatal.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //�[�J���s�Q���U
            calculateSubTotal();//�p��p�p�å[�J�q��
            dataGridViewOrder.Rows.Add(new object[] { name, price, number, subTatal });

        }

        //�p���`��
        private void calculateTotal()
        {
            double total = 0.0;
            for (int i = 0; i < dataGridViewOrder.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridViewOrder.Rows[i];
                if (row.Cells[0].Value != null)
                {
                    total += Convert.ToInt32( row.Cells[3].Value);
                    
                }
            }

            textBoxTotal.Text = total.ToString();
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            calculateTotal();//���s�p��ػ�
        }
    }
}
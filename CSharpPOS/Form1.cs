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

            //將產品項目帶到菜單
            DataGridViewRowCollection rows = dataGridViewMenu.Rows;
            rows.Add(new object[] { "紅茶", 25 });
            rows.Add(new object[] { "綠茶", 25 });
            rows.Add(new object[] { "奶茶", 30 });
            rows.Add(new object[] { "珍珠奶茶", 35 });


        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //選取某項目 將該項目的欄位放入代購項目中
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
            calculateSubTotal();//數量修改時 重新計算
        }

        //重新計算小計
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
            //加入按鈕被按下
            calculateSubTotal();//計算小計並加入訂單
            dataGridViewOrder.Rows.Add(new object[] { name, price, number, subTatal });

        }

        //計算總價
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
            calculateTotal();//重新計算種價
        }
    }
}
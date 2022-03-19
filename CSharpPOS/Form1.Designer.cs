namespace CSharpPOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.BuyColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyColumnSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPrice});
            this.dataGridViewMenu.Location = new System.Drawing.Point(969, 54);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowTemplate.Height = 25;
            this.dataGridViewMenu.Size = new System.Drawing.Size(244, 574);
            this.dataGridViewMenu.TabIndex = 0;
            this.dataGridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "品名";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "單價";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyColumnName,
            this.BuyColumnPrice,
            this.BuyColumnNumber,
            this.BuyColumnSubTotal});
            this.dataGridViewOrder.Location = new System.Drawing.Point(61, 260);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 25;
            this.dataGridViewOrder.Size = new System.Drawing.Size(844, 319);
            this.dataGridViewOrder.TabIndex = 1;
            // 
            // BuyColumnName
            // 
            this.BuyColumnName.HeaderText = "品名";
            this.BuyColumnName.Name = "BuyColumnName";
            this.BuyColumnName.Width = 200;
            // 
            // BuyColumnPrice
            // 
            this.BuyColumnPrice.HeaderText = "單價";
            this.BuyColumnPrice.Name = "BuyColumnPrice";
            this.BuyColumnPrice.Width = 200;
            // 
            // BuyColumnNumber
            // 
            this.BuyColumnNumber.HeaderText = "數量";
            this.BuyColumnNumber.Name = "BuyColumnNumber";
            this.BuyColumnNumber.Width = 200;
            // 
            // BuyColumnSubTotal
            // 
            this.BuyColumnSubTotal.HeaderText = "小計";
            this.BuyColumnSubTotal.Name = "BuyColumnSubTotal";
            this.BuyColumnSubTotal.Width = 200;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(61, 206);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(124, 34);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(232, 206);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(128, 34);
            this.textBoxPrice.TabIndex = 3;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubTotal.Location = new System.Drawing.Point(574, 206);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(128, 34);
            this.textBoxSubTotal.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(749, 206);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(154, 34);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonTotal
            // 
            this.buttonTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTotal.Location = new System.Drawing.Point(751, 605);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(154, 34);
            this.buttonTotal.TabIndex = 7;
            this.buttonTotal.Text = "Total";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTotal.Location = new System.Drawing.Point(610, 605);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 34);
            this.textBoxTotal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(232, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "單價";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(407, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(574, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "小計";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(749, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "加入";
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownNumber.Location = new System.Drawing.Point(407, 206);
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(120, 34);
            this.numericUpDownNumber.TabIndex = 14;
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownNumber_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 663);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.dataGridViewMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewMenu;
        private DataGridView dataGridViewOrder;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxSubTotal;
        private Button buttonAdd;
        private Button buttonTotal;
        private TextBox textBoxTotal;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn BuyColumnName;
        private DataGridViewTextBoxColumn BuyColumnPrice;
        private DataGridViewTextBoxColumn BuyColumnNumber;
        private DataGridViewTextBoxColumn BuyColumnSubTotal;
        private NumericUpDown numericUpDownNumber;
    }
}
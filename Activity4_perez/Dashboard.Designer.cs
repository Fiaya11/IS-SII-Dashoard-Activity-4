namespace Activity3
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            inventoryBindingSource = new BindingSource(components);
            label1 = new Label();
            panel2 = new Panel();
            button11 = new Button();
            button10 = new Button();
            textBox6 = new TextBox();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button16 = new Button();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label16 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            label17 = new Label();
            label23 = new Label();
            panel5 = new Panel();
            label24 = new Label();
            label30 = new Label();
            panel6 = new Panel();
            label31 = new Label();
            label37 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(236, 17);
            label1.Name = "label1";
            label1.Size = new Size(290, 35);
            label1.TabIndex = 15;
            label1.Text = "INVENTORY MANAGEMENT";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button16);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(236, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 516);
            panel2.TabIndex = 16;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.None;
            button11.BackColor = SystemColors.ControlLightLight;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 0;
            button11.ForeColor = Color.Black;
            button11.Location = new Point(136, 221);
            button11.Name = "button11";
            button11.Size = new Size(94, 28);
            button11.TabIndex = 60;
            button11.Text = "Refresh";
            button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.None;
            button10.BackColor = SystemColors.ControlText;
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderSize = 0;
            button10.ForeColor = Color.White;
            button10.Location = new Point(503, 223);
            button10.Name = "button10";
            button10.Size = new Size(94, 28);
            button10.TabIndex = 59;
            button10.Text = "Search";
            button10.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(290, 223);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(205, 28);
            textBox6.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.Location = new Point(17, 222);
            label10.Name = "label10";
            label10.Size = new Size(113, 25);
            label10.TabIndex = 57;
            label10.Text = "Product List";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = inventoryBindingSource;
            dataGridView1.Location = new Point(17, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(866, 238);
            dataGridView1.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(551, 88);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 55;
            label9.Text = "Reorder Level";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(290, 88);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 54;
            label8.Text = "Quantity";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(551, 115);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(194, 28);
            textBox5.TabIndex = 53;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(290, 115);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(235, 28);
            textBox4.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(17, 88);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 51;
            label6.Text = "Description";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 115);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 78);
            textBox3.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(551, 17);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 49;
            label5.Text = "Unit Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(551, 45);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 28);
            textBox2.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(290, 17);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 47;
            label4.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(290, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 28);
            comboBox1.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 45;
            label2.Text = "Product Name";
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.BackColor = Color.DimGray;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(401, 159);
            button9.Name = "button9";
            button9.Size = new Size(94, 34);
            button9.TabIndex = 44;
            button9.Text = "Clear";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.FromArgb(192, 0, 0);
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(290, 159);
            button8.Name = "button8";
            button8.Size = new Size(94, 34);
            button8.TabIndex = 43;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = SystemColors.Control;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.IndianRed;
            button7.Location = new Point(789, 79);
            button7.Name = "button7";
            button7.Size = new Size(94, 34);
            button7.TabIndex = 42;
            button7.Text = "Update";
            button7.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.Anchor = AnchorStyles.None;
            button16.BackColor = Color.Black;
            button16.Cursor = Cursors.Hand;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = Color.White;
            button16.Location = new Point(789, 39);
            button16.Name = "button16";
            button16.Size = new Size(94, 34);
            button16.TabIndex = 41;
            button16.Text = "✚ Add";
            button16.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 28);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label11);
            panel3.ForeColor = SystemColors.Control;
            panel3.Location = new Point(236, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 94);
            panel3.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(73, 38);
            label16.Name = "label16";
            label16.Size = new Size(40, 46);
            label16.TabIndex = 1;
            label16.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(41, 13);
            label11.Name = "label11";
            label11.Size = new Size(98, 25);
            label11.TabIndex = 0;
            label11.Text = "Total Items";
            // 
            // panel4
            // 
            panel4.BackColor = Color.RosyBrown;
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label23);
            panel4.ForeColor = SystemColors.Control;
            panel4.Location = new Point(483, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 94);
            panel4.TabIndex = 18;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(72, 38);
            label17.Name = "label17";
            label17.Size = new Size(40, 46);
            label17.TabIndex = 20;
            label17.Text = "0";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(52, 13);
            label23.Name = "label23";
            label23.Size = new Size(75, 25);
            label23.TabIndex = 19;
            label23.Text = "In Stock";
            // 
            // panel5
            // 
            panel5.BackColor = Color.RosyBrown;
            panel5.Controls.Add(label24);
            panel5.Controls.Add(label30);
            panel5.ForeColor = SystemColors.Control;
            panel5.Location = new Point(721, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 94);
            panel5.TabIndex = 18;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(72, 38);
            label24.Name = "label24";
            label24.Size = new Size(40, 46);
            label24.TabIndex = 20;
            label24.Text = "0";
            label24.TextAlign = ContentAlignment.TopCenter;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(47, 13);
            label30.Name = "label30";
            label30.Size = new Size(92, 25);
            label30.TabIndex = 19;
            label30.Text = "Low Stock";
            // 
            // panel6
            // 
            panel6.BackColor = Color.RosyBrown;
            panel6.Controls.Add(label31);
            panel6.Controls.Add(label37);
            panel6.ForeColor = SystemColors.Control;
            panel6.Location = new Point(954, 64);
            panel6.Name = "panel6";
            panel6.Size = new Size(180, 94);
            panel6.TabIndex = 18;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(71, 38);
            label31.Name = "label31";
            label31.Size = new Size(40, 46);
            label31.TabIndex = 20;
            label31.Text = "0";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label37.Location = new Point(36, 13);
            label37.Name = "label37";
            label37.Size = new Size(112, 25);
            label37.TabIndex = 19;
            label37.Text = "Out of Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 30);
            label7.Name = "label7";
            label7.Size = new Size(118, 50);
            label7.TabIndex = 1;
            label7.Text = "INVENTORY\r\nMANAGEMENT";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            button1.FlatAppearance.MouseOverBackColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(18, 104);
            button1.Name = "button1";
            button1.Size = new Size(183, 40);
            button1.TabIndex = 2;
            button1.Text = "📊 Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Blue;
            button2.FlatAppearance.MouseOverBackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(18, 150);
            button2.Name = "button2";
            button2.Size = new Size(183, 40);
            button2.TabIndex = 3;
            button2.Text = "📋 Inventory";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 689);
            panel1.TabIndex = 13;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(41, 378);
            button3.Name = "button3";
            button3.Size = new Size(138, 44);
            button3.TabIndex = 4;
            button3.Text = "➜] Logout";
            button3.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1156, 675);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
        private Button button16;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label16;
        private Label label11;
        private Label label17;
        private Label label23;
        private Label label24;
        private Label label30;
        private Label label31;
        private Label label37;
        private Label label7;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label label2;
        private ComboBox comboBox1;
        private Label label9;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox6;
        private Label label10;
        private DataGridView dataGridView1;
        private BindingSource inventoryBindingSource;
        private Button button11;
        private Button button10;
        private Button button3;
    }
}
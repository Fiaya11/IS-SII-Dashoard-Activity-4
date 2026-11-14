namespace Activity3
{
    partial class Login
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            linkRegister = new LinkLabel();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(linkRegister);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 533);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 20F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 239);
            label7.Name = "label7";
            label7.Size = new Size(199, 126);
            label7.TabIndex = 3;
            label7.Text = "INVENTORY\r\nMANAGEMENT\r\nSYSTEM";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 55F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(57, 97);
            label6.Name = "label6";
            label6.Size = new Size(178, 123);
            label6.TabIndex = 2;
            label6.Text = "📦";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(187, 279);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(424, 47);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(187, 168);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(424, 47);
            textBox2.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Vineta BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(187, 368);
            button1.Name = "button1";
            button1.Size = new Size(424, 49);
            button1.TabIndex = 14;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.BackColor = Color.Black;
            linkRegister.Cursor = Cursors.Hand;
            linkRegister.Font = new Font("Segoe UI", 10F);
            linkRegister.LinkColor = SystemColors.HotTrack;
            linkRegister.Location = new Point(329, 436);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(150, 23);
            linkRegister.TabIndex = 16;
            linkRegister.TabStop = true;
            linkRegister.Text = "Create an account";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(814, 533);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(313, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 53);
            textBox1.TabIndex = 18;
            textBox1.Text = "Login";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Vineta BT", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 241);
            label1.Name = "label1";
            label1.Size = new Size(113, 17);
            label1.TabIndex = 19;
            label1.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Vineta BT", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(187, 124);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 18;
            label3.Text = "Name:";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel linkRegister;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private PictureBox pictureBox3;
    }
}
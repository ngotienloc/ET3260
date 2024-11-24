namespace ET2060
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
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            matkhau = new TextBox();
            tendangnhap = new TextBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(matkhau);
            panel1.Controls.Add(tendangnhap);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(147, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 389);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(62, 234);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(120, 327);
            button1.Name = "button1";
            button1.Size = new Size(207, 41);
            button1.TabIndex = 10;
            button1.Text = "Tạo tài khoản";
            button1.UseVisualStyleBackColor = false;
            // 
            // matkhau
            // 
            matkhau.Location = new Point(62, 182);
            matkhau.Multiline = true;
            matkhau.Name = "matkhau";
            matkhau.PasswordChar = '*';
            matkhau.Size = new Size(305, 32);
            matkhau.TabIndex = 9;
            matkhau.TextChanged += textBox2_TextChanged;
            matkhau.KeyDown += matkhau_KeyDown;
            // 
            // tendangnhap
            // 
            tendangnhap.Location = new Point(62, 98);
            tendangnhap.Multiline = true;
            tendangnhap.Name = "tendangnhap";
            tendangnhap.Size = new Size(305, 32);
            tendangnhap.TabIndex = 8;
            tendangnhap.TextChanged += textBox1_TextChanged_2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(271, 230);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(159, 270);
            button2.Name = "button2";
            button2.Size = new Size(135, 41);
            button2.TabIndex = 6;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 4;
            label3.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(105, 26);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(146, 26);
            label1.TabIndex = 1;
            label1.Text = "Tên tài khoản:";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 568);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = " ";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private CheckBox checkBox1;
        private TextBox matkhau;
        private TextBox tendangnhap;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}

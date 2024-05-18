namespace FormDers2
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
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(130, 49);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(165, 31);
            maskedTextBox1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(130, 108);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(165, 31);
            maskedTextBox2.TabIndex = 1;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(130, 168);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(165, 31);
            maskedTextBox3.TabIndex = 2;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(130, 226);
            maskedTextBox4.Mask = "90:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(165, 31);
            maskedTextBox4.TabIndex = 3;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 52);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 4;
            label1.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 111);
            label2.Name = "label2";
            label2.Size = new Size(33, 23);
            label2.TabIndex = 5;
            label2.Text = "Tc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 171);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 6;
            label3.Text = "Tarih:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 229);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 7;
            label4.Text = "Saat:";
            // 
            // button1
            // 
            button1.Location = new Point(130, 277);
            button1.Name = "button1";
            button1.Size = new Size(165, 33);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(57, 337);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(736, 142);
            listBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(547, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(600, 142);
            button2.Name = "button2";
            button2.Size = new Size(165, 33);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(957, 514);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}


namespace WindowsFormsApp_01._03._2021
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_q3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.true2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checking_responses = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.Exet_button = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_q3
            // 
            this.comboBox_q3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_q3.FormattingEnabled = true;
            this.comboBox_q3.Items.AddRange(new object[] {
            "В.В. Путин",
            "Петр I",
            "Б.Н. Ельцын",
            "Алексей Михайлович"});
            this.comboBox_q3.Location = new System.Drawing.Point(12, 295);
            this.comboBox_q3.Name = "comboBox_q3";
            this.comboBox_q3.Size = new System.Drawing.Size(253, 39);
            this.comboBox_q3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(689, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "№3 При каком павители впервые в России появился триколор?";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(10, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 50);
            this.textBox1.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.true2);
            this.groupBox2.Location = new System.Drawing.Point(3, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 106);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(6, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 36);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Да";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // true2
            // 
            this.true2.AutoSize = true;
            this.true2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.true2.Location = new System.Drawing.Point(6, 58);
            this.true2.Name = "true2";
            this.true2.Size = new System.Drawing.Size(72, 35);
            this.true2.TabIndex = 6;
            this.true2.TabStop = true;
            this.true2.Text = "Нет";
            this.true2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(762, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "№2 Существует ли официальная трактовка цветов российского флага?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "№1 В каком году был утвержден российский триколор?";
            // 
            // checking_responses
            // 
            this.checking_responses.BackColor = System.Drawing.Color.Purple;
            this.checking_responses.ForeColor = System.Drawing.Color.White;
            this.checking_responses.Location = new System.Drawing.Point(743, 427);
            this.checking_responses.Name = "checking_responses";
            this.checking_responses.Size = new System.Drawing.Size(159, 121);
            this.checking_responses.TabIndex = 18;
            this.checking_responses.Text = "Проверить";
            this.checking_responses.UseVisualStyleBackColor = false;
            this.checking_responses.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_label.Location = new System.Drawing.Point(780, 30);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(295, 46);
            this.name_label.TabIndex = 27;
            this.name_label.Text = "Пользователь:";
            // 
            // Exet_button
            // 
            this.Exet_button.BackColor = System.Drawing.Color.Purple;
            this.Exet_button.ForeColor = System.Drawing.Color.White;
            this.Exet_button.Location = new System.Drawing.Point(958, 450);
            this.Exet_button.Name = "Exet_button";
            this.Exet_button.Size = new System.Drawing.Size(117, 75);
            this.Exet_button.TabIndex = 28;
            this.Exet_button.Text = "Выйти";
            this.Exet_button.UseVisualStyleBackColor = false;
            this.Exet_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 594);
            this.Controls.Add(this.Exet_button);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.comboBox_q3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checking_responses);
            this.Name = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_q3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton true2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checking_responses;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button Exet_button;
    }
}
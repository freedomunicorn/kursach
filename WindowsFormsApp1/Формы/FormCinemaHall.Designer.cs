﻿namespace WindowsFormsApp1.Формы
{
    partial class FormCinemaHall
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
            this.lblKol = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.cB2 = new System.Windows.Forms.ComboBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKol
            // 
            this.lblKol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKol.Location = new System.Drawing.Point(12, 335);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(145, 24);
            this.lblKol.TabIndex = 0;
            this.lblKol.Text = "Занято мест: 0";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(601, 335);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(25, 24);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = " 0";
            // 
            // lblFilmName
            // 
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilmName.Location = new System.Drawing.Point(437, 27);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(172, 23);
            this.lblFilmName.TabIndex = 2;
            this.lblFilmName.Text = "Название фильма";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(437, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата сеанса";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(437, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер места";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(437, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выбор времени";
            // 
            // cB1
            // 
            this.cB1.FormattingEnabled = true;
            this.cB1.Location = new System.Drawing.Point(441, 54);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(158, 21);
            this.cB1.TabIndex = 6;
            // 
            // cB2
            // 
            this.cB2.FormattingEnabled = true;
            this.cB2.Items.AddRange(new object[] {
            "12:00",
            "21:00"});
            this.cB2.Location = new System.Drawing.Point(441, 230);
            this.cB2.Name = "cB2";
            this.cB2.Size = new System.Drawing.Size(154, 21);
            this.cB2.TabIndex = 7;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(438, 174);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(0, 13);
            this.lblPlace.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.Location = new System.Drawing.Point(-1, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label5.Location = new System.Drawing.Point(1, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label6.Location = new System.Drawing.Point(-1, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label7.Location = new System.Drawing.Point(-1, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 40);
            this.label7.TabIndex = 14;
            this.label7.Text = "4";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label8.Location = new System.Drawing.Point(-1, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 44);
            this.label8.TabIndex = 15;
            this.label8.Text = "5";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(437, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Введите ФИО";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 18;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.Location = new System.Drawing.Point(207, 333);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(154, 37);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "печатать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(425, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Итоговая стоимость:";
            // 
            // FormCinemaHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 368);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.cB2);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFilmName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblKol);
            this.Name = "FormCinemaHall";
            this.Text = "Выбор места";
            this.Load += new System.EventHandler(this.FormCinemaHall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKol;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.ComboBox cB2;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label10;
    }
}
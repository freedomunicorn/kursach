namespace WindowsFormsApp1.Формы
{
    partial class FormFilm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilm));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblNameOfFilm = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(558, 310);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 37);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Вперед";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Location = new System.Drawing.Point(409, 310);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(76, 37);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "Назад";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "f1.jpg");
            this.imageList1.Images.SetKeyName(1, "f2.jpg");
            this.imageList1.Images.SetKeyName(2, "f3.jpg");
            // 
            // lblNameOfFilm
            // 
            this.lblNameOfFilm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameOfFilm.AutoSize = true;
            this.lblNameOfFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNameOfFilm.Location = new System.Drawing.Point(12, 9);
            this.lblNameOfFilm.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblNameOfFilm.Name = "lblNameOfFilm";
            this.lblNameOfFilm.Size = new System.Drawing.Size(41, 24);
            this.lblNameOfFilm.TabIndex = 5;
            this.lblNameOfFilm.Text = "1+1";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescription.Location = new System.Drawing.Point(13, 57);
            this.lblDescription.MaximumSize = new System.Drawing.Size(391, 250);
            this.lblDescription.MinimumSize = new System.Drawing.Size(391, 153);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(391, 153);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFilm.Location = new System.Drawing.Point(16, 310);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(115, 37);
            this.btnAddFilm.TabIndex = 9;
            this.btnAddFilm.Text = "Добавить фильм";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.f1;
            this.pictureBox1.Location = new System.Drawing.Point(409, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 280);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 368);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNameOfFilm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Name = "FormFilm";
            this.Text = "Фильмы";
            this.Load += new System.EventHandler(this.FormFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblNameOfFilm;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddFilm;
    }
}
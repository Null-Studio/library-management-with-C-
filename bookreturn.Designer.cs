namespace LiberaryManegment.Properties
{
    partial class bookreturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookreturn));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Serch_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Serch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIssue = new System.Windows.Forms.TextBox();
            this.textBoxBookname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = global::LiberaryManegment.Properties.Properties.Resources.OIG_o;
            this.panel1.Controls.Add(this.Serch_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Serch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 304);
            this.panel1.TabIndex = 1;
            // 
            // Serch_textbox
            // 
            this.Serch_textbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serch_textbox.Location = new System.Drawing.Point(34, 158);
            this.Serch_textbox.MaxLength = 10;
            this.Serch_textbox.Name = "Serch_textbox";
            this.Serch_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Serch_textbox.Size = new System.Drawing.Size(184, 22);
            this.Serch_textbox.TabIndex = 5;
            this.Serch_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Serch_textbox.TextChanged += new System.EventHandler(this.Serch_textbox_TextChanged);
            this.Serch_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Serch_textbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::LiberaryManegment.Properties.Properties.Resources.OIG_o;
            this.label1.Location = new System.Drawing.Point(85, 134);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "کد ملی را وارد کنید";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Snow;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Reset.Location = new System.Drawing.Point(143, 256);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "پاک کردن";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Snow;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit.Location = new System.Drawing.Point(43, 256);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "خروج";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Serch
            // 
            this.Serch.BackColor = System.Drawing.Color.Snow;
            this.Serch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Serch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Serch.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Serch.Location = new System.Drawing.Point(84, 186);
            this.Serch.Name = "Serch";
            this.Serch.Size = new System.Drawing.Size(100, 23);
            this.Serch.TabIndex = 1;
            this.Serch.Text = "جستو جو";
            this.Serch.UseVisualStyleBackColor = false;
            this.Serch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LiberaryManegment.Properties.Properties.Resources.OIG_o;
            this.pictureBox1.Image = global::LiberaryManegment.Properties.Properties.Resources.icons8_student_male_100;
            this.pictureBox1.Location = new System.Drawing.Point(75, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImage = global::LiberaryManegment.Properties.Properties.Resources.OIG_o;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.buttonReturn);
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxIssue);
            this.panel2.Controls.Add(this.textBoxBookname);
            this.panel2.Location = new System.Drawing.Point(277, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 141);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::LiberaryManegment.Properties.Properties.Resources.OIG_o;
            this.label6.Location = new System.Drawing.Point(181, 59);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "بازگشت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(135, 59);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "لغو";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturn.Image = global::LiberaryManegment.Properties.Properties.Resources.icons8_save_64;
            this.buttonReturn.Location = new System.Drawing.Point(185, 15);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(39, 41);
            this.buttonReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonReturn.TabIndex = 13;
            this.buttonReturn.TabStop = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // Cancel
            // 
            this.Cancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.Image = global::LiberaryManegment.Properties.Properties.Resources.icons8_cancel_40;
            this.Cancel.Location = new System.Drawing.Point(126, 15);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(42, 41);
            this.Cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cancel.TabIndex = 12;
            this.Cancel.TabStop = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(509, 26);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = " نام کتاب :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(495, 67);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "تاریخ امانت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(495, 112);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "تاریخ بازگشت :";
            // 
            // textBoxIssue
            // 
            this.textBoxIssue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIssue.Location = new System.Drawing.Point(280, 67);
            this.textBoxIssue.Name = "textBoxIssue";
            this.textBoxIssue.ReadOnly = true;
            this.textBoxIssue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxIssue.Size = new System.Drawing.Size(200, 22);
            this.textBoxIssue.TabIndex = 7;
            this.textBoxIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBookname
            // 
            this.textBoxBookname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookname.Location = new System.Drawing.Point(280, 24);
            this.textBoxBookname.Name = "textBoxBookname";
            this.textBoxBookname.ReadOnly = true;
            this.textBoxBookname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxBookname.Size = new System.Drawing.Size(200, 22);
            this.textBoxBookname.TabIndex = 6;
            this.textBoxBookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookreturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::LiberaryManegment.Properties.Properties.Resources.OIG__14_;
            this.ClientSize = new System.Drawing.Size(1032, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "bookreturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookreturn";
            this.Load += new System.EventHandler(this.bookreturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Serch_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Serch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox buttonReturn;
        private System.Windows.Forms.PictureBox Cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIssue;
        private System.Windows.Forms.TextBox textBoxBookname;
    }
}
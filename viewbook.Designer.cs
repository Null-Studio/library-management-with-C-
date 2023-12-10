namespace LiberaryManegment.Properties
{
    partial class viewbook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBookname = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.publishdate = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.cansel = new System.Windows.Forms.Button();
            this.Bookname = new System.Windows.Forms.TextBox();
            this.Whriter = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::LiberaryManegment.Properties.Properties.Resources.OIG__12_;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 143);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(510, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "مشاهده کتاب ها";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LiberaryManegment.Properties.Properties.Resources.OIG__12_;
            this.pictureBox1.Image = global::LiberaryManegment.Properties.Properties.Resources.view_book_gif1;
            this.pictureBox1.Location = new System.Drawing.Point(327, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(541, 155);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = " جستو جوی کتاب :";
            // 
            // textBookname
            // 
            this.textBookname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBookname.Location = new System.Drawing.Point(380, 152);
            this.textBookname.Name = "textBookname";
            this.textBookname.Size = new System.Drawing.Size(155, 22);
            this.textBookname.TabIndex = 3;
            this.textBookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBookname.TextChanged += new System.EventHandler(this.textBookname_TextChanged);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Snow;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.refresh.Location = new System.Drawing.Point(309, 150);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(65, 24);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "پاک کردن";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(967, 287);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImage = global::LiberaryManegment.Properties.Properties.Resources.OIG__6_;
            this.panel2.Controls.Add(this.publishdate);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.cansel);
            this.panel2.Controls.Add(this.Bookname);
            this.panel2.Controls.Add(this.Whriter);
            this.panel2.Controls.Add(this.publisher);
            this.panel2.Controls.Add(this.Price);
            this.panel2.Controls.Add(this.Type);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(2, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 191);
            this.panel2.TabIndex = 6;
            // 
            // publishdate
            // 
            this.publishdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishdate.Location = new System.Drawing.Point(191, 19);
            this.publishdate.Name = "publishdate";
            this.publishdate.Size = new System.Drawing.Size(216, 22);
            this.publishdate.TabIndex = 18;
            this.publishdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Snow;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.delete.Location = new System.Drawing.Point(433, 153);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 17;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Snow;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.Highlight;
            this.update.Location = new System.Drawing.Point(514, 153);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 16;
            this.update.Text = "بروز رسانی";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // cansel
            // 
            this.cansel.BackColor = System.Drawing.Color.Snow;
            this.cansel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cansel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cansel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cansel.Location = new System.Drawing.Point(352, 153);
            this.cansel.Name = "cansel";
            this.cansel.Size = new System.Drawing.Size(75, 23);
            this.cansel.TabIndex = 15;
            this.cansel.Text = "لغو";
            this.cansel.UseVisualStyleBackColor = false;
            this.cansel.Click += new System.EventHandler(this.cansel_Click);
            // 
            // Bookname
            // 
            this.Bookname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookname.Location = new System.Drawing.Point(543, 16);
            this.Bookname.Name = "Bookname";
            this.Bookname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bookname.Size = new System.Drawing.Size(208, 22);
            this.Bookname.TabIndex = 13;
            this.Bookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Whriter
            // 
            this.Whriter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Whriter.Location = new System.Drawing.Point(543, 67);
            this.Whriter.Name = "Whriter";
            this.Whriter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Whriter.Size = new System.Drawing.Size(208, 22);
            this.Whriter.TabIndex = 12;
            this.Whriter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // publisher
            // 
            this.publisher.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher.Location = new System.Drawing.Point(543, 112);
            this.publisher.Name = "publisher";
            this.publisher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.publisher.Size = new System.Drawing.Size(208, 22);
            this.publisher.TabIndex = 11;
            this.publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(191, 68);
            this.Price.Name = "Price";
            this.Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Price.Size = new System.Drawing.Size(216, 22);
            this.Price.TabIndex = 10;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(191, 113);
            this.Type.Name = "Type";
            this.Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Type.Size = new System.Drawing.Size(216, 22);
            this.Type.TabIndex = 9;
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(766, 19);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "نام کتاب :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(767, 72);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "نویسنده :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(757, 116);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "منتشر کننده :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(413, 19);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "تاریخ انتشار :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(421, 71);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "قیمت کتاب :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(420, 116);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "دسته بندی :";
            // 
            // viewbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1006, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.textBookname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "viewbook";
            this.Text = "viewbook";
            this.Load += new System.EventHandler(this.viewbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBookname;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Bookname;
        private System.Windows.Forms.TextBox Whriter;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button cansel;
        private System.Windows.Forms.TextBox publishdate;
    }
}
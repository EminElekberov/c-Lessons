
namespace taskRepeat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.cmb_genre = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_book = new System.Windows.Forms.ListBox();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBM Number";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(10, 46);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(86, 20);
            this.txt_name.TabIndex = 2;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(279, 46);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(86, 20);
            this.txt_price.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(137, 46);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(86, 20);
            this.txt_number.TabIndex = 7;
            // 
            // cmb_genre
            // 
            this.cmb_genre.FormattingEnabled = true;
            this.cmb_genre.Location = new System.Drawing.Point(429, 46);
            this.cmb_genre.Name = "cmb_genre";
            this.cmb_genre.Size = new System.Drawing.Size(104, 21);
            this.cmb_genre.TabIndex = 8;
            this.cmb_genre.SelectedIndexChanged += new System.EventHandler(this.cmb_genre_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_book
            // 
            this.lbl_book.FormattingEnabled = true;
            this.lbl_book.Location = new System.Drawing.Point(1, 218);
            this.lbl_book.Name = "lbl_book";
            this.lbl_book.Size = new System.Drawing.Size(685, 173);
            this.lbl_book.TabIndex = 10;
            // 
            // cmb_filter
            // 
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.Location = new System.Drawing.Point(1, 192);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(104, 21);
            this.cmb_filter.TabIndex = 12;
            this.cmb_filter.SelectedIndexChanged += new System.EventHandler(this.cmb_filter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter By Genre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.cmb_filter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_book);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_genre);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.ComboBox cmb_genre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbl_book;
        private System.Windows.Forms.ComboBox cmb_filter;
        private System.Windows.Forms.Label label5;
    }
}


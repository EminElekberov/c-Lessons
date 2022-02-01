
namespace taskRepeat
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_GroupDelete = new System.Windows.Forms.ComboBox();
            this.cmb_StudentDelete = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Group";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_GroupDelete
            // 
            this.cmb_GroupDelete.FormattingEnabled = true;
            this.cmb_GroupDelete.Location = new System.Drawing.Point(62, 55);
            this.cmb_GroupDelete.Name = "cmb_GroupDelete";
            this.cmb_GroupDelete.Size = new System.Drawing.Size(274, 21);
            this.cmb_GroupDelete.TabIndex = 1;
            this.cmb_GroupDelete.SelectedIndexChanged += new System.EventHandler(this.cmb_GroupDelete_SelectedIndexChanged);
            // 
            // cmb_StudentDelete
            // 
            this.cmb_StudentDelete.FormattingEnabled = true;
            this.cmb_StudentDelete.Location = new System.Drawing.Point(62, 154);
            this.cmb_StudentDelete.Name = "cmb_StudentDelete";
            this.cmb_StudentDelete.Size = new System.Drawing.Size(274, 21);
            this.cmb_StudentDelete.TabIndex = 3;
            this.cmb_StudentDelete.SelectedIndexChanged += new System.EventHandler(this.cmb_StudentDelete_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Student";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(23, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_StudentDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_GroupDelete);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_GroupDelete;
        private System.Windows.Forms.ComboBox cmb_StudentDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
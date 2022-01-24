
namespace video26
{
    partial class TypeDelete
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
            this.cmbDeleteType = new System.Windows.Forms.ComboBox();
            this.BtnTypeDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // cmbDeleteType
            // 
            this.cmbDeleteType.FormattingEnabled = true;
            this.cmbDeleteType.Location = new System.Drawing.Point(13, 39);
            this.cmbDeleteType.Name = "cmbDeleteType";
            this.cmbDeleteType.Size = new System.Drawing.Size(231, 21);
            this.cmbDeleteType.TabIndex = 1;
            // 
            // BtnTypeDelete
            // 
            this.BtnTypeDelete.Location = new System.Drawing.Point(50, 89);
            this.BtnTypeDelete.Name = "BtnTypeDelete";
            this.BtnTypeDelete.Size = new System.Drawing.Size(155, 41);
            this.BtnTypeDelete.TabIndex = 2;
            this.BtnTypeDelete.Text = "Delete";
            this.BtnTypeDelete.UseVisualStyleBackColor = true;
            this.BtnTypeDelete.Click += new System.EventHandler(this.BtnTypeDelete_Click);
            // 
            // TypeDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 166);
            this.Controls.Add(this.BtnTypeDelete);
            this.Controls.Add(this.cmbDeleteType);
            this.Controls.Add(this.label1);
            this.Name = "TypeDelete";
            this.Text = "TypeDelete";
            this.Load += new System.EventHandler(this.TypeDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDeleteType;
        private System.Windows.Forms.Button BtnTypeDelete;
    }
}
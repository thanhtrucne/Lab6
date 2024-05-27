namespace OpenLibrary.Presentation
{
    partial class frmQLyChuyenNganhcs
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
            this.btnxoadausach = new DevExpress.XtraEditors.SimpleButton();
            this.btnthemoidausach = new DevExpress.XtraEditors.SimpleButton();
            this.btnsuadausach = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnxoadausach
            // 
            this.btnxoadausach.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.cancel_32x321;
            this.btnxoadausach.Location = new System.Drawing.Point(714, 266);
            this.btnxoadausach.Name = "btnxoadausach";
            this.btnxoadausach.Size = new System.Drawing.Size(243, 66);
            this.btnxoadausach.TabIndex = 23;
            this.btnxoadausach.Text = "Xóa Chuyên Ngành";
            // 
            // btnthemoidausach
            // 
            this.btnthemoidausach.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.add_32x321;
            this.btnthemoidausach.Location = new System.Drawing.Point(74, 265);
            this.btnthemoidausach.Name = "btnthemoidausach";
            this.btnthemoidausach.Size = new System.Drawing.Size(302, 67);
            this.btnthemoidausach.TabIndex = 22;
            this.btnthemoidausach.Text = "Thêm Mới Chuyên Ngành";
            // 
            // btnsuadausach
            // 
            this.btnsuadausach.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.editname_32x321;
            this.btnsuadausach.Location = new System.Drawing.Point(419, 265);
            this.btnsuadausach.Name = "btnsuadausach";
            this.btnsuadausach.Size = new System.Drawing.Size(226, 67);
            this.btnsuadausach.TabIndex = 21;
            this.btnsuadausach.Text = "Sửa Chuyên Ngành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(116, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã Chuyên Ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(116, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên Chuyên Ngành:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 31);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(395, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 31);
            this.textBox2.TabIndex = 25;
            // 
            // frmQLyChuyenNganhcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 667);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxoadausach);
            this.Controls.Add(this.btnthemoidausach);
            this.Controls.Add(this.btnsuadausach);
            this.Name = "frmQLyChuyenNganhcs";
            this.Text = "frmQLyChuyenNganhcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnxoadausach;
        private DevExpress.XtraEditors.SimpleButton btnthemoidausach;
        private DevExpress.XtraEditors.SimpleButton btnsuadausach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
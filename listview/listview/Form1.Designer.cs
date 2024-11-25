namespace listview
{
    partial class Form1
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
            this.lsSanPham = new System.Windows.Forms.ListView();
            this.ls_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ls_Ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ls_Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_stt = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsSanPham
            // 
            this.lsSanPham.CheckBoxes = true;
            this.lsSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ls_STT,
            this.ls_Ma,
            this.ls_Ten});
            this.lsSanPham.FullRowSelect = true;
            this.lsSanPham.GridLines = true;
            this.lsSanPham.HideSelection = false;
            this.lsSanPham.Location = new System.Drawing.Point(47, 32);
            this.lsSanPham.Name = "lsSanPham";
            this.lsSanPham.Size = new System.Drawing.Size(477, 299);
            this.lsSanPham.TabIndex = 0;
            this.lsSanPham.UseCompatibleStateImageBehavior = false;
            this.lsSanPham.View = System.Windows.Forms.View.Details;
            this.lsSanPham.SelectedIndexChanged += new System.EventHandler(this.lsnhanvien_SelectedIndexChanged);
            // 
            // ls_STT
            // 
            this.ls_STT.Text = "STT";
            this.ls_STT.Width = 136;
            // 
            // ls_Ma
            // 
            this.ls_Ma.Text = "Mã";
            this.ls_Ma.Width = 105;
            // 
            // ls_Ten
            // 
            this.ls_Ten.Text = "tên";
            this.ls_Ten.Width = 160;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(567, 322);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(678, 322);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(777, 322);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(619, 151);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(218, 22);
            this.txt_ten.TabIndex = 4;
            // 
            // txt_stt
            // 
            this.txt_stt.Location = new System.Drawing.Point(619, 76);
            this.txt_stt.Name = "txt_stt";
            this.txt_stt.Size = new System.Drawing.Size(218, 22);
            this.txt_stt.TabIndex = 5;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(619, 114);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(218, 22);
            this.txt_ma.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(545, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "stt:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(546, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "tên:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(545, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "mã:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.txt_stt);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lsSanPham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsSanPham;
        private System.Windows.Forms.ColumnHeader ls_STT;
        private System.Windows.Forms.ColumnHeader ls_Ma;
        private System.Windows.Forms.ColumnHeader ls_Ten;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_stt;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


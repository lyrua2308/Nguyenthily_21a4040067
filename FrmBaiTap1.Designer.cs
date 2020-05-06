namespace vidu_chuong4
{
    partial class FrmBaiTap1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.BtnTinh = new System.Windows.Forms.Button();
            this.BtnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labal2 = new System.Windows.Forms.Label();
            this.Lbsobe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbsolon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbtong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // textA
            // 
            this.textA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textA.Location = new System.Drawing.Point(295, 59);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 26);
            this.textA.TabIndex = 2;
            this.textA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textA_KeyPress);
            // 
            // textB
            // 
            this.textB.AcceptsReturn = true;
            this.textB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB.Location = new System.Drawing.Point(295, 139);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 26);
            this.textB.TabIndex = 3;
            this.textB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textB_KeyPress);
            // 
            // BtnTinh
            // 
            this.BtnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTinh.Location = new System.Drawing.Point(57, 270);
            this.BtnTinh.Name = "BtnTinh";
            this.BtnTinh.Size = new System.Drawing.Size(143, 42);
            this.BtnTinh.TabIndex = 4;
            this.BtnTinh.Text = "Tính Tổng";
            this.BtnTinh.UseVisualStyleBackColor = true;
            this.BtnTinh.Click += new System.EventHandler(this.BtnTinh_Click);
            // 
            // BtnLamlai
            // 
            this.BtnLamlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLamlai.Location = new System.Drawing.Point(321, 270);
            this.BtnLamlai.Name = "BtnLamlai";
            this.BtnLamlai.Size = new System.Drawing.Size(138, 42);
            this.BtnLamlai.TabIndex = 5;
            this.BtnLamlai.Text = "Làm Lại";
            this.BtnLamlai.UseVisualStyleBackColor = true;
            this.BtnLamlai.Click += new System.EventHandler(this.BtnLamlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(607, 270);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labal2
            // 
            this.labal2.AutoSize = true;
            this.labal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labal2.Location = new System.Drawing.Point(133, 220);
            this.labal2.Name = "labal2";
            this.labal2.Size = new System.Drawing.Size(135, 24);
            this.labal2.TabIndex = 7;
            this.labal2.Text = "Tổng các số từ";
            // 
            // Lbsobe
            // 
            this.Lbsobe.AutoSize = true;
            this.Lbsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbsobe.Location = new System.Drawing.Point(291, 215);
            this.Lbsobe.Name = "Lbsobe";
            this.Lbsobe.Size = new System.Drawing.Size(0, 24);
            this.Lbsobe.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "đến";
            // 
            // Lbsolon
            // 
            this.Lbsolon.AutoSize = true;
            this.Lbsolon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbsolon.Location = new System.Drawing.Point(434, 222);
            this.Lbsolon.Name = "Lbsolon";
            this.Lbsolon.Size = new System.Drawing.Size(0, 24);
            this.Lbsolon.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "là";
            // 
            // Lbtong
            // 
            this.Lbtong.AutoSize = true;
            this.Lbtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbtong.Location = new System.Drawing.Point(586, 220);
            this.Lbtong.Name = "Lbtong";
            this.Lbtong.Size = new System.Drawing.Size(0, 24);
            this.Lbtong.TabIndex = 12;
            // 
            // FrmBaiTap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbtong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbsolon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbsobe);
            this.Controls.Add(this.labal2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.BtnLamlai);
            this.Controls.Add(this.BtnTinh);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBaiTap1";
            this.Text = "Tính Tổng Dãy Số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Button BtnTinh;
        private System.Windows.Forms.Button BtnLamlai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labal2;
        private System.Windows.Forms.Label Lbsobe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbsolon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbtong;
    }
}
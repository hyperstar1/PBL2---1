﻿
namespace PBL2___1
{
    partial class FormUpdateWallet
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
            this.TabCtrl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Tbx2 = new System.Windows.Forms.TextBox();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Tbx3 = new System.Windows.Forms.TextBox();
            this.Lb3 = new System.Windows.Forms.Label();
            this.Tbx1 = new System.Windows.Forms.TextBox();
            this.Lb1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Dtgv1 = new System.Windows.Forms.DataGridView();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.TabCtrl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCtrl1
            // 
            this.TabCtrl1.Controls.Add(this.tabPage1);
            this.TabCtrl1.Controls.Add(this.tabPage2);
            this.TabCtrl1.Location = new System.Drawing.Point(12, 12);
            this.TabCtrl1.Name = "TabCtrl1";
            this.TabCtrl1.SelectedIndex = 0;
            this.TabCtrl1.Size = new System.Drawing.Size(776, 426);
            this.TabCtrl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn1);
            this.tabPage1.Controls.Add(this.Tbx2);
            this.tabPage1.Controls.Add(this.Lb2);
            this.tabPage1.Controls.Add(this.Tbx3);
            this.tabPage1.Controls.Add(this.Lb3);
            this.tabPage1.Controls.Add(this.Tbx1);
            this.tabPage1.Controls.Add(this.Lb1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cập nhật thông tin ví";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(344, 225);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(129, 40);
            this.Btn1.TabIndex = 3;
            this.Btn1.Text = "Xác nhận";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Tbx2
            // 
            this.Tbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx2.Location = new System.Drawing.Point(249, 109);
            this.Tbx2.Name = "Tbx2";
            this.Tbx2.ReadOnly = true;
            this.Tbx2.Size = new System.Drawing.Size(224, 34);
            this.Tbx2.TabIndex = 0;
            this.Tbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2.Location = new System.Drawing.Point(51, 114);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(162, 29);
            this.Lb2.TabIndex = 0;
            this.Lb2.Text = "Tên ví hiện tại";
            // 
            // Tbx3
            // 
            this.Tbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx3.Location = new System.Drawing.Point(249, 159);
            this.Tbx3.Name = "Tbx3";
            this.Tbx3.Size = new System.Drawing.Size(224, 34);
            this.Tbx3.TabIndex = 1;
            this.Tbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lb3
            // 
            this.Lb3.AutoSize = true;
            this.Lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb3.Location = new System.Drawing.Point(51, 162);
            this.Lb3.Name = "Lb3";
            this.Lb3.Size = new System.Drawing.Size(179, 29);
            this.Lb3.TabIndex = 0;
            this.Lb3.Text = "Nhập tên ví mới";
            // 
            // Tbx1
            // 
            this.Tbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx1.Location = new System.Drawing.Point(249, 58);
            this.Tbx1.Name = "Tbx1";
            this.Tbx1.ReadOnly = true;
            this.Tbx1.Size = new System.Drawing.Size(224, 34);
            this.Tbx1.TabIndex = 0;
            this.Tbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(51, 63);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(59, 29);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "ID ví";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn7);
            this.tabPage2.Controls.Add(this.Dtgv1);
            this.tabPage2.Controls.Add(this.Btn6);
            this.tabPage2.Controls.Add(this.Btn5);
            this.tabPage2.Controls.Add(this.Btn4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cập nhật thu chi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(512, 16);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(136, 34);
            this.Btn7.TabIndex = 4;
            this.Btn7.Text = "Làm mới";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Dtgv1
            // 
            this.Dtgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtgv1.Location = new System.Drawing.Point(6, 56);
            this.Dtgv1.Name = "Dtgv1";
            this.Dtgv1.RowHeadersWidth = 51;
            this.Dtgv1.RowTemplate.Height = 24;
            this.Dtgv1.Size = new System.Drawing.Size(759, 335);
            this.Dtgv1.TabIndex = 0;
            this.Dtgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgv1_CellContentClick);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(348, 16);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(136, 34);
            this.Btn6.TabIndex = 3;
            this.Btn6.Text = "Xóa giao dịch ";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(184, 16);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(136, 34);
            this.Btn5.TabIndex = 2;
            this.Btn5.Text = "Sửa giao dịch ";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(3, 16);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(154, 34);
            this.Btn4.TabIndex = 1;
            this.Btn4.Text = "Thêm giao dịch ";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // FormUpdateWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabCtrl1);
            this.Name = "FormUpdateWallet";
            this.Text = "Hello User!";
            this.TabCtrl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCtrl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Tbx3;
        private System.Windows.Forms.Label Lb3;
        private System.Windows.Forms.TextBox Tbx1;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Tbx2;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.DataGridView Dtgv1;
        private System.Windows.Forms.Button Btn7;
    }
}
﻿
namespace ModuleSoanDe
{
    partial class Page_TaoDeThi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TaoDeThi = new System.Windows.Forms.Button();
            this.lbl_SoLuongCauHoi = new System.Windows.Forms.Label();
            this.txt_SoLuongCauHoi = new System.Windows.Forms.NumericUpDown();
            this.cbx_LuaChon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_SoLuongToiDa = new System.Windows.Forms.Label();
            this.clbx_CauHoi = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(134, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo đề thi";
            // 
            // btn_TaoDeThi
            // 
            this.btn_TaoDeThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaoDeThi.Location = new System.Drawing.Point(14, 466);
            this.btn_TaoDeThi.Name = "btn_TaoDeThi";
            this.btn_TaoDeThi.Size = new System.Drawing.Size(613, 53);
            this.btn_TaoDeThi.TabIndex = 1;
            this.btn_TaoDeThi.Text = "Tạo đề thi";
            this.btn_TaoDeThi.UseVisualStyleBackColor = true;
            this.btn_TaoDeThi.Click += new System.EventHandler(this.btn_TaoDeThi_Click);
            // 
            // lbl_SoLuongCauHoi
            // 
            this.lbl_SoLuongCauHoi.AutoSize = true;
            this.lbl_SoLuongCauHoi.Location = new System.Drawing.Point(14, 127);
            this.lbl_SoLuongCauHoi.Name = "lbl_SoLuongCauHoi";
            this.lbl_SoLuongCauHoi.Size = new System.Drawing.Size(121, 20);
            this.lbl_SoLuongCauHoi.TabIndex = 2;
            this.lbl_SoLuongCauHoi.Text = "Số lượng câu hỏi";
            // 
            // txt_SoLuongCauHoi
            // 
            this.txt_SoLuongCauHoi.Location = new System.Drawing.Point(141, 125);
            this.txt_SoLuongCauHoi.Name = "txt_SoLuongCauHoi";
            this.txt_SoLuongCauHoi.Size = new System.Drawing.Size(68, 27);
            this.txt_SoLuongCauHoi.TabIndex = 3;
            // 
            // cbx_LuaChon
            // 
            this.cbx_LuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LuaChon.FormattingEnabled = true;
            this.cbx_LuaChon.Location = new System.Drawing.Point(89, 82);
            this.cbx_LuaChon.Name = "cbx_LuaChon";
            this.cbx_LuaChon.Size = new System.Drawing.Size(120, 28);
            this.cbx_LuaChon.TabIndex = 4;
            this.cbx_LuaChon.SelectedIndexChanged += new System.EventHandler(this.cbx_LuaChon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lựa chọn";
            // 
            // lbl_SoLuongToiDa
            // 
            this.lbl_SoLuongToiDa.AutoSize = true;
            this.lbl_SoLuongToiDa.Location = new System.Drawing.Point(215, 127);
            this.lbl_SoLuongToiDa.Name = "lbl_SoLuongToiDa";
            this.lbl_SoLuongToiDa.Size = new System.Drawing.Size(112, 20);
            this.lbl_SoLuongToiDa.TabIndex = 5;
            this.lbl_SoLuongToiDa.Text = "Số lượng tối đa";
            // 
            // clbx_CauHoi
            // 
            this.clbx_CauHoi.CheckOnClick = true;
            this.clbx_CauHoi.FormattingEnabled = true;
            this.clbx_CauHoi.Location = new System.Drawing.Point(14, 180);
            this.clbx_CauHoi.Name = "clbx_CauHoi";
            this.clbx_CauHoi.Size = new System.Drawing.Size(613, 268);
            this.clbx_CauHoi.TabIndex = 6;
            this.clbx_CauHoi.Visible = false;
            this.clbx_CauHoi.SelectedIndexChanged += new System.EventHandler(this.clbx_CauHoi_SelectedIndexChanged);
            // 
            // Page_TaoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clbx_CauHoi);
            this.Controls.Add(this.lbl_SoLuongCauHoi);
            this.Controls.Add(this.lbl_SoLuongToiDa);
            this.Controls.Add(this.txt_SoLuongCauHoi);
            this.Controls.Add(this.cbx_LuaChon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_TaoDeThi);
            this.Controls.Add(this.label1);
            this.Name = "Page_TaoDeThi";
            this.Size = new System.Drawing.Size(638, 535);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TaoDeThi;
        private System.Windows.Forms.Label lbl_SoLuongCauHoi;
        private System.Windows.Forms.NumericUpDown txt_SoLuongCauHoi;
        private System.Windows.Forms.ComboBox cbx_LuaChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_SoLuongToiDa;
        private System.Windows.Forms.CheckedListBox clbx_CauHoi;
    }
}
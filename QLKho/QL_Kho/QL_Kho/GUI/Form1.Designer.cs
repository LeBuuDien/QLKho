
namespace QL_Kho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnADD = new System.Windows.Forms.ToolStripButton();
            this.btnDELETE = new System.Windows.Forms.ToolStripButton();
            this.txtEDIT = new System.Windows.Forms.ToolStripButton();
            this.txtUpdate = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDCG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaVD = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnADD,
            this.btnDELETE,
            this.txtEDIT,
            this.txtUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnADD
            // 
            this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
            this.btnADD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(57, 22);
            this.btnADD.Text = "Thêm";
            this.btnADD.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Image = ((System.Drawing.Image)(resources.GetObject("btnDELETE.Image")));
            this.btnDELETE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(47, 22);
            this.btnDELETE.Text = "Xóa";
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // txtEDIT
            // 
            this.txtEDIT.Image = ((System.Drawing.Image)(resources.GetObject("txtEDIT.Image")));
            this.txtEDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtEDIT.Name = "txtEDIT";
            this.txtEDIT.Size = new System.Drawing.Size(46, 22);
            this.txtEDIT.Text = "Sửa";
            this.txtEDIT.Click += new System.EventHandler(this.txtEDIT_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Image = ((System.Drawing.Image)(resources.GetObject("txtUpdate.Image")));
            this.txtUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(75, 22);
            this.txtUpdate.Text = "Cập nhật";
            this.txtUpdate.Click += new System.EventHandler(this.txtUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 330);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnSaveEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtCC);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCR);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDCN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDCG);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTenNN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMaVD);
            this.panel2.Location = new System.Drawing.Point(617, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 330);
            this.panel2.TabIndex = 2;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(34, 303);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 20;
            this.btnClean.Text = "Tạo mới";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(277, 304);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(196, 304);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdit.TabIndex = 18;
            this.btnSaveEdit.Text = "Chỉnh sửa";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu Lại";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Chiều cao";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(97, 203);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(93, 20);
            this.txtCC.TabIndex = 14;
            this.txtCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCC_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chiều rộng";
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(97, 177);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(93, 20);
            this.txtCR.TabIndex = 12;
            this.txtCR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCR_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chiều dài";
            // 
            // txtCD
            // 
            this.txtCD.Location = new System.Drawing.Point(97, 151);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(93, 20);
            this.txtCD.TabIndex = 10;
            this.txtCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCD_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trọng lượng";
            // 
            // txtTL
            // 
            this.txtTL.Location = new System.Drawing.Point(97, 125);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(93, 20);
            this.txtTL.TabIndex = 8;
            this.txtTL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTL_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ nhận";
            // 
            // txtDCN
            // 
            this.txtDCN.Location = new System.Drawing.Point(97, 94);
            this.txtDCN.Name = "txtDCN";
            this.txtDCN.Size = new System.Drawing.Size(255, 20);
            this.txtDCN.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ gửi";
            // 
            // txtDCG
            // 
            this.txtDCG.Location = new System.Drawing.Point(97, 62);
            this.txtDCG.Name = "txtDCG";
            this.txtDCG.Size = new System.Drawing.Size(255, 20);
            this.txtDCG.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Người Nhận";
            // 
            // txtTenNN
            // 
            this.txtTenNN.Location = new System.Drawing.Point(97, 36);
            this.txtTenNN.Name = "txtTenNN";
            this.txtTenNN.Size = new System.Drawing.Size(174, 20);
            this.txtTenNN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Vận Đơn";
            // 
            // txtMaVD
            // 
            this.txtMaVD.Location = new System.Drawing.Point(97, 10);
            this.txtMaVD.Name = "txtMaVD";
            this.txtMaVD.Size = new System.Drawing.Size(174, 20);
            this.txtMaVD.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnADD;
        private System.Windows.Forms.ToolStripButton btnDELETE;
        private System.Windows.Forms.ToolStripButton txtEDIT;
        private System.Windows.Forms.ToolStripButton txtUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDCG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaVD;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnClean;
    }
}


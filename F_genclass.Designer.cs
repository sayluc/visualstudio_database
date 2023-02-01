namespace WindowsFormsApp2
{
    partial class F_genclass
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
            this.btn_genclose = new System.Windows.Forms.Button();
            this.btn_generase = new System.Windows.Forms.Button();
            this.btn_gennew = new System.Windows.Forms.Button();
            this.btn_genupdate = new System.Windows.Forms.Button();
            this.btn_genclean = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_genidclass = new System.Windows.Forms.TextBox();
            this.nud_genlevelclass = new System.Windows.Forms.NumericUpDown();
            this.cmb_genstateclass = new System.Windows.Forms.ComboBox();
            this.dgv_class = new System.Windows.Forms.DataGridView();
            this.txt_genpassclass = new System.Windows.Forms.TextBox();
            this.txt_gennickclass = new System.Windows.Forms.TextBox();
            this.txt_gennameclass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_genlevelclass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_genclose);
            this.panel1.Controls.Add(this.btn_generase);
            this.panel1.Controls.Add(this.btn_gennew);
            this.panel1.Controls.Add(this.btn_genupdate);
            this.panel1.Controls.Add(this.btn_genclean);
            this.panel1.Location = new System.Drawing.Point(-1, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 55);
            this.panel1.TabIndex = 35;
            // 
            // btn_genclose
            // 
            this.btn_genclose.Location = new System.Drawing.Point(717, 9);
            this.btn_genclose.Name = "btn_genclose";
            this.btn_genclose.Size = new System.Drawing.Size(91, 33);
            this.btn_genclose.TabIndex = 9;
            this.btn_genclose.Text = "Sair";
            this.btn_genclose.UseVisualStyleBackColor = true;
            this.btn_genclose.Click += new System.EventHandler(this.btn_genclose_Click);
            // 
            // btn_generase
            // 
            this.btn_generase.Location = new System.Drawing.Point(549, 9);
            this.btn_generase.Name = "btn_generase";
            this.btn_generase.Size = new System.Drawing.Size(91, 33);
            this.btn_generase.TabIndex = 8;
            this.btn_generase.Text = "Excluir";
            this.btn_generase.UseVisualStyleBackColor = true;
            this.btn_generase.Click += new System.EventHandler(this.btn_generase_Click);
            // 
            // btn_gennew
            // 
            this.btn_gennew.Location = new System.Drawing.Point(366, 9);
            this.btn_gennew.Name = "btn_gennew";
            this.btn_gennew.Size = new System.Drawing.Size(91, 33);
            this.btn_gennew.TabIndex = 7;
            this.btn_gennew.Text = "Novo";
            this.btn_gennew.UseVisualStyleBackColor = true;
            this.btn_gennew.Click += new System.EventHandler(this.btn_gennew_Click);
            // 
            // btn_genupdate
            // 
            this.btn_genupdate.Location = new System.Drawing.Point(184, 9);
            this.btn_genupdate.Name = "btn_genupdate";
            this.btn_genupdate.Size = new System.Drawing.Size(91, 33);
            this.btn_genupdate.TabIndex = 6;
            this.btn_genupdate.Text = "Atualizar";
            this.btn_genupdate.UseVisualStyleBackColor = true;
            this.btn_genupdate.Click += new System.EventHandler(this.btn_genupdate_Click);
            // 
            // btn_genclean
            // 
            this.btn_genclean.Location = new System.Drawing.Point(10, 9);
            this.btn_genclean.Name = "btn_genclean";
            this.btn_genclean.Size = new System.Drawing.Size(91, 33);
            this.btn_genclean.TabIndex = 5;
            this.btn_genclean.Text = "Limpar";
            this.btn_genclean.UseVisualStyleBackColor = true;
            this.btn_genclean.Click += new System.EventHandler(this.btn_genclean_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "A: Ativo B: Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome";
            // 
            // txt_genidclass
            // 
            this.txt_genidclass.Location = new System.Drawing.Point(32, 394);
            this.txt_genidclass.Name = "txt_genidclass";
            this.txt_genidclass.ReadOnly = true;
            this.txt_genidclass.Size = new System.Drawing.Size(96, 20);
            this.txt_genidclass.TabIndex = 27;
            // 
            // nud_genlevelclass
            // 
            this.nud_genlevelclass.Location = new System.Drawing.Point(228, 264);
            this.nud_genlevelclass.Name = "nud_genlevelclass";
            this.nud_genlevelclass.Size = new System.Drawing.Size(155, 20);
            this.nud_genlevelclass.TabIndex = 25;
            // 
            // cmb_genstateclass
            // 
            this.cmb_genstateclass.FormattingEnabled = true;
            this.cmb_genstateclass.Location = new System.Drawing.Point(32, 264);
            this.cmb_genstateclass.Name = "cmb_genstateclass";
            this.cmb_genstateclass.Size = new System.Drawing.Size(169, 21);
            this.cmb_genstateclass.TabIndex = 24;
            // 
            // dgv_class
            // 
            this.dgv_class.AllowUserToAddRows = false;
            this.dgv_class.AllowUserToDeleteRows = false;
            this.dgv_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_class.EnableHeadersVisualStyles = false;
            this.dgv_class.Location = new System.Drawing.Point(418, 57);
            this.dgv_class.MultiSelect = false;
            this.dgv_class.Name = "dgv_class";
            this.dgv_class.ReadOnly = true;
            this.dgv_class.RowHeadersVisible = false;
            this.dgv_class.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_class.Size = new System.Drawing.Size(367, 357);
            this.dgv_class.TabIndex = 26;
            this.dgv_class.SelectionChanged += new System.EventHandler(this.dgv_user_SelectionChanged);
            // 
            // txt_genpassclass
            // 
            this.txt_genpassclass.Location = new System.Drawing.Point(32, 197);
            this.txt_genpassclass.Name = "txt_genpassclass";
            this.txt_genpassclass.Size = new System.Drawing.Size(351, 20);
            this.txt_genpassclass.TabIndex = 23;
            // 
            // txt_gennickclass
            // 
            this.txt_gennickclass.Location = new System.Drawing.Point(32, 127);
            this.txt_gennickclass.Name = "txt_gennickclass";
            this.txt_gennickclass.Size = new System.Drawing.Size(351, 20);
            this.txt_gennickclass.TabIndex = 22;
            // 
            // txt_gennameclass
            // 
            this.txt_gennameclass.Location = new System.Drawing.Point(32, 57);
            this.txt_gennameclass.Name = "txt_gennameclass";
            this.txt_gennameclass.Size = new System.Drawing.Size(351, 20);
            this.txt_gennameclass.TabIndex = 21;
            // 
            // F_genclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_genidclass);
            this.Controls.Add(this.nud_genlevelclass);
            this.Controls.Add(this.cmb_genstateclass);
            this.Controls.Add(this.dgv_class);
            this.Controls.Add(this.txt_genpassclass);
            this.Controls.Add(this.txt_gennickclass);
            this.Controls.Add(this.txt_gennameclass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_genclass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Cursos";
            this.Load += new System.EventHandler(this.F_genclass_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_genlevelclass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_genclose;
        private System.Windows.Forms.Button btn_generase;
        private System.Windows.Forms.Button btn_gennew;
        private System.Windows.Forms.Button btn_genupdate;
        private System.Windows.Forms.Button btn_genclean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_genidclass;
        private System.Windows.Forms.NumericUpDown nud_genlevelclass;
        private System.Windows.Forms.ComboBox cmb_genstateclass;
        private System.Windows.Forms.DataGridView dgv_class;
        private System.Windows.Forms.TextBox txt_genpassclass;
        private System.Windows.Forms.TextBox txt_gennickclass;
        private System.Windows.Forms.TextBox txt_gennameclass;
    }
}
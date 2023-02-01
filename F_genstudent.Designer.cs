namespace WindowsFormsApp2
{
    partial class F_genstudent
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
            this.txt_genidstudent = new System.Windows.Forms.TextBox();
            this.nud_genlevelstudent = new System.Windows.Forms.NumericUpDown();
            this.cmb_genstatestudent = new System.Windows.Forms.ComboBox();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.txt_genpassstudent = new System.Windows.Forms.TextBox();
            this.txt_gennickstudent = new System.Windows.Forms.TextBox();
            this.txt_gennamestudent = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_genlevelstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-3, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 55);
            this.panel1.TabIndex = 50;
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
            this.label7.Location = new System.Drawing.Point(31, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "A: Ativo B: Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome";
            // 
            // txt_genidstudent
            // 
            this.txt_genidstudent.Location = new System.Drawing.Point(30, 394);
            this.txt_genidstudent.Name = "txt_genidstudent";
            this.txt_genidstudent.ReadOnly = true;
            this.txt_genidstudent.Size = new System.Drawing.Size(99, 20);
            this.txt_genidstudent.TabIndex = 42;
            // 
            // nud_genlevelstudent
            // 
            this.nud_genlevelstudent.Location = new System.Drawing.Point(226, 264);
            this.nud_genlevelstudent.Name = "nud_genlevelstudent";
            this.nud_genlevelstudent.Size = new System.Drawing.Size(158, 20);
            this.nud_genlevelstudent.TabIndex = 40;
            // 
            // cmb_genstatestudent
            // 
            this.cmb_genstatestudent.FormattingEnabled = true;
            this.cmb_genstatestudent.Location = new System.Drawing.Point(30, 264);
            this.cmb_genstatestudent.Name = "cmb_genstatestudent";
            this.cmb_genstatestudent.Size = new System.Drawing.Size(172, 21);
            this.cmb_genstatestudent.TabIndex = 39;
            // 
            // dgv_student
            // 
            this.dgv_student.AllowUserToAddRows = false;
            this.dgv_student.AllowUserToDeleteRows = false;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.EnableHeadersVisualStyles = false;
            this.dgv_student.Location = new System.Drawing.Point(416, 57);
            this.dgv_student.MultiSelect = false;
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.ReadOnly = true;
            this.dgv_student.RowHeadersVisible = false;
            this.dgv_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_student.Size = new System.Drawing.Size(370, 357);
            this.dgv_student.TabIndex = 41;
            this.dgv_student.SelectionChanged += new System.EventHandler(this.dgv_student_SelectionChanged);
            // 
            // txt_genpassstudent
            // 
            this.txt_genpassstudent.Location = new System.Drawing.Point(30, 197);
            this.txt_genpassstudent.Name = "txt_genpassstudent";
            this.txt_genpassstudent.Size = new System.Drawing.Size(354, 20);
            this.txt_genpassstudent.TabIndex = 38;
            // 
            // txt_gennickstudent
            // 
            this.txt_gennickstudent.Location = new System.Drawing.Point(30, 127);
            this.txt_gennickstudent.Name = "txt_gennickstudent";
            this.txt_gennickstudent.Size = new System.Drawing.Size(354, 20);
            this.txt_gennickstudent.TabIndex = 37;
            // 
            // txt_gennamestudent
            // 
            this.txt_gennamestudent.Location = new System.Drawing.Point(30, 57);
            this.txt_gennamestudent.Name = "txt_gennamestudent";
            this.txt_gennamestudent.Size = new System.Drawing.Size(354, 20);
            this.txt_gennamestudent.TabIndex = 36;
            // 
            // F_genstudent
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
            this.Controls.Add(this.txt_genidstudent);
            this.Controls.Add(this.nud_genlevelstudent);
            this.Controls.Add(this.cmb_genstatestudent);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.txt_genpassstudent);
            this.Controls.Add(this.txt_gennickstudent);
            this.Controls.Add(this.txt_gennamestudent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_genstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Estudante";
            this.Load += new System.EventHandler(this.F_genstudent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_genlevelstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
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
        private System.Windows.Forms.TextBox txt_genidstudent;
        private System.Windows.Forms.NumericUpDown nud_genlevelstudent;
        private System.Windows.Forms.ComboBox cmb_genstatestudent;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.TextBox txt_genpassstudent;
        private System.Windows.Forms.TextBox txt_gennickstudent;
        private System.Windows.Forms.TextBox txt_gennamestudent;
    }
}
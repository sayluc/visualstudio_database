namespace WindowsFormsApp2
{
    partial class F_genteacher
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_genidteacher = new System.Windows.Forms.TextBox();
            this.dgv_teacher = new System.Windows.Forms.DataGridView();
            this.txt_genareateacher = new System.Windows.Forms.TextBox();
            this.txt_gennickteacher = new System.Windows.Forms.TextBox();
            this.txt_gennameteacher = new System.Windows.Forms.TextBox();
            this.txt_genturnteacher = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_gentelteacher = new System.Windows.Forms.TextBox();
            this.txt_gensetorteacher = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-4, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 55);
            this.panel1.TabIndex = 50;
            // 
            // btn_genclose
            // 
            this.btn_genclose.Location = new System.Drawing.Point(717, 9);
            this.btn_genclose.Name = "btn_genclose";
            this.btn_genclose.Size = new System.Drawing.Size(91, 33);
            this.btn_genclose.TabIndex = 11;
            this.btn_genclose.Text = "Sair";
            this.btn_genclose.UseVisualStyleBackColor = true;
            this.btn_genclose.Click += new System.EventHandler(this.btn_genclose_Click);
            // 
            // btn_generase
            // 
            this.btn_generase.Location = new System.Drawing.Point(549, 9);
            this.btn_generase.Name = "btn_generase";
            this.btn_generase.Size = new System.Drawing.Size(91, 33);
            this.btn_generase.TabIndex = 10;
            this.btn_generase.Text = "Excluir";
            this.btn_generase.UseVisualStyleBackColor = true;
            this.btn_generase.Click += new System.EventHandler(this.btn_generase_Click);
            // 
            // btn_gennew
            // 
            this.btn_gennew.Location = new System.Drawing.Point(366, 9);
            this.btn_gennew.Name = "btn_gennew";
            this.btn_gennew.Size = new System.Drawing.Size(91, 33);
            this.btn_gennew.TabIndex = 9;
            this.btn_gennew.Text = "Novo";
            this.btn_gennew.UseVisualStyleBackColor = true;
            this.btn_gennew.Click += new System.EventHandler(this.btn_gennew_Click);
            // 
            // btn_genupdate
            // 
            this.btn_genupdate.Location = new System.Drawing.Point(184, 9);
            this.btn_genupdate.Name = "btn_genupdate";
            this.btn_genupdate.Size = new System.Drawing.Size(91, 33);
            this.btn_genupdate.TabIndex = 8;
            this.btn_genupdate.Text = "Atualizar";
            this.btn_genupdate.UseVisualStyleBackColor = true;
            this.btn_genupdate.Click += new System.EventHandler(this.btn_genupdate_Click);
            // 
            // btn_genclean
            // 
            this.btn_genclean.Location = new System.Drawing.Point(10, 9);
            this.btn_genclean.Name = "btn_genclean";
            this.btn_genclean.Size = new System.Drawing.Size(91, 33);
            this.btn_genclean.TabIndex = 7;
            this.btn_genclean.Text = "Limpar";
            this.btn_genclean.UseVisualStyleBackColor = true;
            this.btn_genclean.Click += new System.EventHandler(this.btn_genclean_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Setor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Sobrenome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome";
            // 
            // txt_genidteacher
            // 
            this.txt_genidteacher.Location = new System.Drawing.Point(29, 395);
            this.txt_genidteacher.Name = "txt_genidteacher";
            this.txt_genidteacher.ReadOnly = true;
            this.txt_genidteacher.Size = new System.Drawing.Size(100, 20);
            this.txt_genidteacher.TabIndex = 6;
            // 
            // dgv_teacher
            // 
            this.dgv_teacher.AllowUserToAddRows = false;
            this.dgv_teacher.AllowUserToDeleteRows = false;
            this.dgv_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teacher.EnableHeadersVisualStyles = false;
            this.dgv_teacher.Location = new System.Drawing.Point(415, 58);
            this.dgv_teacher.MultiSelect = false;
            this.dgv_teacher.Name = "dgv_teacher";
            this.dgv_teacher.ReadOnly = true;
            this.dgv_teacher.RowHeadersVisible = false;
            this.dgv_teacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_teacher.Size = new System.Drawing.Size(371, 357);
            this.dgv_teacher.TabIndex = 12;
            this.dgv_teacher.SelectionChanged += new System.EventHandler(this.dgv_teacher_SelectionChanged);
            // 
            // txt_genareateacher
            // 
            this.txt_genareateacher.Location = new System.Drawing.Point(29, 212);
            this.txt_genareateacher.Name = "txt_genareateacher";
            this.txt_genareateacher.Size = new System.Drawing.Size(173, 20);
            this.txt_genareateacher.TabIndex = 2;
            // 
            // txt_gennickteacher
            // 
            this.txt_gennickteacher.Location = new System.Drawing.Point(29, 133);
            this.txt_gennickteacher.Name = "txt_gennickteacher";
            this.txt_gennickteacher.Size = new System.Drawing.Size(355, 20);
            this.txt_gennickteacher.TabIndex = 1;
            // 
            // txt_gennameteacher
            // 
            this.txt_gennameteacher.Location = new System.Drawing.Point(29, 58);
            this.txt_gennameteacher.Name = "txt_gennameteacher";
            this.txt_gennameteacher.Size = new System.Drawing.Size(355, 20);
            this.txt_gennameteacher.TabIndex = 0;
            // 
            // txt_genturnteacher
            // 
            this.txt_genturnteacher.Location = new System.Drawing.Point(230, 293);
            this.txt_genturnteacher.Name = "txt_genturnteacher";
            this.txt_genturnteacher.Size = new System.Drawing.Size(154, 20);
            this.txt_genturnteacher.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Turno";
            // 
            // txt_gentelteacher
            // 
            this.txt_gentelteacher.Location = new System.Drawing.Point(29, 293);
            this.txt_gentelteacher.Name = "txt_gentelteacher";
            this.txt_gentelteacher.Size = new System.Drawing.Size(173, 20);
            this.txt_gentelteacher.TabIndex = 4;
            // 
            // txt_gensetorteacher
            // 
            this.txt_gensetorteacher.Location = new System.Drawing.Point(230, 212);
            this.txt_gensetorteacher.Name = "txt_gensetorteacher";
            this.txt_gensetorteacher.Size = new System.Drawing.Size(154, 20);
            this.txt_gensetorteacher.TabIndex = 3;
            // 
            // F_genteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 490);
            this.Controls.Add(this.txt_gensetorteacher);
            this.Controls.Add(this.txt_gentelteacher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_genturnteacher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_genidteacher);
            this.Controls.Add(this.dgv_teacher);
            this.Controls.Add(this.txt_genareateacher);
            this.Controls.Add(this.txt_gennickteacher);
            this.Controls.Add(this.txt_gennameteacher);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_genteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Professores";
            this.Load += new System.EventHandler(this.F_genteacher_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_genidteacher;
        private System.Windows.Forms.DataGridView dgv_teacher;
        private System.Windows.Forms.TextBox txt_genareateacher;
        private System.Windows.Forms.TextBox txt_gennickteacher;
        private System.Windows.Forms.TextBox txt_gennameteacher;
        private System.Windows.Forms.TextBox txt_genturnteacher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_gentelteacher;
        private System.Windows.Forms.TextBox txt_gensetorteacher;
    }
}
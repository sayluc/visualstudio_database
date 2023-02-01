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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_genid = new System.Windows.Forms.TextBox();
            this.nud_genlevel = new System.Windows.Forms.NumericUpDown();
            this.cmb_genstate = new System.Windows.Forms.ComboBox();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.txt_genpass = new System.Windows.Forms.TextBox();
            this.txt_gennick = new System.Windows.Forms.TextBox();
            this.txt_genname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_genlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
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
            this.btn_genclose.TabIndex = 9;
            this.btn_genclose.Text = "Sair";
            this.btn_genclose.UseVisualStyleBackColor = true;
            // 
            // btn_generase
            // 
            this.btn_generase.Location = new System.Drawing.Point(549, 9);
            this.btn_generase.Name = "btn_generase";
            this.btn_generase.Size = new System.Drawing.Size(91, 33);
            this.btn_generase.TabIndex = 8;
            this.btn_generase.Text = "Excluir";
            this.btn_generase.UseVisualStyleBackColor = true;
            // 
            // btn_gennew
            // 
            this.btn_gennew.Location = new System.Drawing.Point(366, 9);
            this.btn_gennew.Name = "btn_gennew";
            this.btn_gennew.Size = new System.Drawing.Size(91, 33);
            this.btn_gennew.TabIndex = 7;
            this.btn_gennew.Text = "Novo";
            this.btn_gennew.UseVisualStyleBackColor = true;
            // 
            // btn_genupdate
            // 
            this.btn_genupdate.Location = new System.Drawing.Point(184, 9);
            this.btn_genupdate.Name = "btn_genupdate";
            this.btn_genupdate.Size = new System.Drawing.Size(91, 33);
            this.btn_genupdate.TabIndex = 6;
            this.btn_genupdate.Text = "Atualizar";
            this.btn_genupdate.UseVisualStyleBackColor = true;
            // 
            // btn_genclean
            // 
            this.btn_genclean.Location = new System.Drawing.Point(10, 9);
            this.btn_genclean.Name = "btn_genclean";
            this.btn_genclean.Size = new System.Drawing.Size(91, 33);
            this.btn_genclean.TabIndex = 5;
            this.btn_genclean.Text = "Limpar";
            this.btn_genclean.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "A: Ativo B: Bloqueado";
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
            this.label5.Location = new System.Drawing.Point(227, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome";
            // 
            // txt_genid
            // 
            this.txt_genid.Location = new System.Drawing.Point(29, 395);
            this.txt_genid.Name = "txt_genid";
            this.txt_genid.ReadOnly = true;
            this.txt_genid.Size = new System.Drawing.Size(100, 20);
            this.txt_genid.TabIndex = 42;
            // 
            // nud_genlevel
            // 
            this.nud_genlevel.Location = new System.Drawing.Point(225, 265);
            this.nud_genlevel.Name = "nud_genlevel";
            this.nud_genlevel.Size = new System.Drawing.Size(159, 20);
            this.nud_genlevel.TabIndex = 40;
            // 
            // cmb_genstate
            // 
            this.cmb_genstate.FormattingEnabled = true;
            this.cmb_genstate.Location = new System.Drawing.Point(29, 265);
            this.cmb_genstate.Name = "cmb_genstate";
            this.cmb_genstate.Size = new System.Drawing.Size(173, 21);
            this.cmb_genstate.TabIndex = 39;
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.EnableHeadersVisualStyles = false;
            this.dgv_user.Location = new System.Drawing.Point(415, 58);
            this.dgv_user.MultiSelect = false;
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersVisible = false;
            this.dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_user.Size = new System.Drawing.Size(371, 357);
            this.dgv_user.TabIndex = 41;
            // 
            // txt_genpass
            // 
            this.txt_genpass.Location = new System.Drawing.Point(29, 198);
            this.txt_genpass.Name = "txt_genpass";
            this.txt_genpass.Size = new System.Drawing.Size(355, 20);
            this.txt_genpass.TabIndex = 38;
            // 
            // txt_gennick
            // 
            this.txt_gennick.Location = new System.Drawing.Point(29, 128);
            this.txt_gennick.Name = "txt_gennick";
            this.txt_gennick.Size = new System.Drawing.Size(355, 20);
            this.txt_gennick.TabIndex = 37;
            // 
            // txt_genname
            // 
            this.txt_genname.Location = new System.Drawing.Point(29, 58);
            this.txt_genname.Name = "txt_genname";
            this.txt_genname.Size = new System.Drawing.Size(355, 20);
            this.txt_genname.TabIndex = 36;
            // 
            // F_genteacher
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
            this.Controls.Add(this.txt_genid);
            this.Controls.Add(this.nud_genlevel);
            this.Controls.Add(this.cmb_genstate);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.txt_genpass);
            this.Controls.Add(this.txt_gennick);
            this.Controls.Add(this.txt_genname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_genteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_genteacher";
            this.Load += new System.EventHandler(this.F_genteacher_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_genlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
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
        private System.Windows.Forms.TextBox txt_genid;
        private System.Windows.Forms.NumericUpDown nud_genlevel;
        private System.Windows.Forms.ComboBox cmb_genstate;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.TextBox txt_genpass;
        private System.Windows.Forms.TextBox txt_gennick;
        private System.Windows.Forms.TextBox txt_genname;
    }
}
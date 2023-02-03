namespace WindowsFormsApp2
{
    partial class F_newteacher
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
            this.txt_namet = new System.Windows.Forms.TextBox();
            this.txt_areat = new System.Windows.Forms.TextBox();
            this.txt_setort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cleant = new System.Windows.Forms.Button();
            this.btn_savet = new System.Windows.Forms.Button();
            this.btn_closet = new System.Windows.Forms.Button();
            this.txt_nickt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phonet = new System.Windows.Forms.TextBox();
            this.txt_turnt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_namet
            // 
            this.txt_namet.Location = new System.Drawing.Point(40, 61);
            this.txt_namet.Name = "txt_namet";
            this.txt_namet.Size = new System.Drawing.Size(127, 20);
            this.txt_namet.TabIndex = 0;
            // 
            // txt_areat
            // 
            this.txt_areat.Location = new System.Drawing.Point(40, 123);
            this.txt_areat.Name = "txt_areat";
            this.txt_areat.Size = new System.Drawing.Size(127, 20);
            this.txt_areat.TabIndex = 2;
            // 
            // txt_setort
            // 
            this.txt_setort.Location = new System.Drawing.Point(197, 123);
            this.txt_setort.Name = "txt_setort";
            this.txt_setort.Size = new System.Drawing.Size(119, 20);
            this.txt_setort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Setor ";
            // 
            // btn_cleant
            // 
            this.btn_cleant.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_cleant.Location = new System.Drawing.Point(12, 233);
            this.btn_cleant.Name = "btn_cleant";
            this.btn_cleant.Size = new System.Drawing.Size(93, 41);
            this.btn_cleant.TabIndex = 6;
            this.btn_cleant.Text = "Limpar";
            this.btn_cleant.UseVisualStyleBackColor = false;
            this.btn_cleant.Click += new System.EventHandler(this.btn_cleant_Click);
            // 
            // btn_savet
            // 
            this.btn_savet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_savet.Location = new System.Drawing.Point(223, 233);
            this.btn_savet.Name = "btn_savet";
            this.btn_savet.Size = new System.Drawing.Size(93, 41);
            this.btn_savet.TabIndex = 7;
            this.btn_savet.Text = "Salvar";
            this.btn_savet.UseVisualStyleBackColor = false;
            this.btn_savet.Click += new System.EventHandler(this.btn_savet_Click);
            // 
            // btn_closet
            // 
            this.btn_closet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_closet.Location = new System.Drawing.Point(415, 233);
            this.btn_closet.Name = "btn_closet";
            this.btn_closet.Size = new System.Drawing.Size(93, 41);
            this.btn_closet.TabIndex = 8;
            this.btn_closet.Text = "Sair";
            this.btn_closet.UseVisualStyleBackColor = false;
            this.btn_closet.Click += new System.EventHandler(this.btn_closet_Click);
            // 
            // txt_nickt
            // 
            this.txt_nickt.Location = new System.Drawing.Point(197, 61);
            this.txt_nickt.Name = "txt_nickt";
            this.txt_nickt.Size = new System.Drawing.Size(281, 20);
            this.txt_nickt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sobrenome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Turno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefone";
            // 
            // txt_phonet
            // 
            this.txt_phonet.Location = new System.Drawing.Point(346, 123);
            this.txt_phonet.Name = "txt_phonet";
            this.txt_phonet.Size = new System.Drawing.Size(132, 20);
            this.txt_phonet.TabIndex = 4;
            // 
            // txt_turnt
            // 
            this.txt_turnt.Location = new System.Drawing.Point(40, 187);
            this.txt_turnt.Name = "txt_turnt";
            this.txt_turnt.Size = new System.Drawing.Size(84, 20);
            this.txt_turnt.TabIndex = 5;
            // 
            // F_newteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(520, 286);
            this.Controls.Add(this.txt_turnt);
            this.Controls.Add(this.txt_phonet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nickt);
            this.Controls.Add(this.btn_closet);
            this.Controls.Add(this.btn_savet);
            this.Controls.Add(this.btn_cleant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_setort);
            this.Controls.Add(this.txt_areat);
            this.Controls.Add(this.txt_namet);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_newteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_namet;
        private System.Windows.Forms.TextBox txt_areat;
        private System.Windows.Forms.TextBox txt_setort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cleant;
        private System.Windows.Forms.Button btn_savet;
        private System.Windows.Forms.Button btn_closet;
        private System.Windows.Forms.TextBox txt_nickt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phonet;
        private System.Windows.Forms.TextBox txt_turnt;
    }
}
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
            this.txt_floort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cleant = new System.Windows.Forms.Button();
            this.btn_savet = new System.Windows.Forms.Button();
            this.btn_closet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_namet
            // 
            this.txt_namet.Location = new System.Drawing.Point(40, 61);
            this.txt_namet.Name = "txt_namet";
            this.txt_namet.Size = new System.Drawing.Size(221, 20);
            this.txt_namet.TabIndex = 0;
            // 
            // txt_areat
            // 
            this.txt_areat.Location = new System.Drawing.Point(40, 107);
            this.txt_areat.Name = "txt_areat";
            this.txt_areat.Size = new System.Drawing.Size(221, 20);
            this.txt_areat.TabIndex = 1;
            // 
            // txt_floort
            // 
            this.txt_floort.Location = new System.Drawing.Point(40, 151);
            this.txt_floort.Name = "txt_floort";
            this.txt_floort.Size = new System.Drawing.Size(56, 20);
            this.txt_floort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Área de Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Setor ";
            // 
            // btn_cleant
            // 
            this.btn_cleant.Location = new System.Drawing.Point(12, 194);
            this.btn_cleant.Name = "btn_cleant";
            this.btn_cleant.Size = new System.Drawing.Size(73, 30);
            this.btn_cleant.TabIndex = 6;
            this.btn_cleant.Text = "Limpar";
            this.btn_cleant.UseVisualStyleBackColor = true;
            this.btn_cleant.Click += new System.EventHandler(this.btn_cleant_Click);
            // 
            // btn_savet
            // 
            this.btn_savet.Location = new System.Drawing.Point(117, 194);
            this.btn_savet.Name = "btn_savet";
            this.btn_savet.Size = new System.Drawing.Size(73, 30);
            this.btn_savet.TabIndex = 7;
            this.btn_savet.Text = "Salvar";
            this.btn_savet.UseVisualStyleBackColor = true;
            this.btn_savet.Click += new System.EventHandler(this.btn_savet_Click);
            // 
            // btn_closet
            // 
            this.btn_closet.Location = new System.Drawing.Point(222, 194);
            this.btn_closet.Name = "btn_closet";
            this.btn_closet.Size = new System.Drawing.Size(73, 30);
            this.btn_closet.TabIndex = 8;
            this.btn_closet.Text = "Sair";
            this.btn_closet.UseVisualStyleBackColor = true;
            this.btn_closet.Click += new System.EventHandler(this.btn_closet_Click);
            // 
            // F_newteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 236);
            this.Controls.Add(this.btn_closet);
            this.Controls.Add(this.btn_savet);
            this.Controls.Add(this.btn_cleant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_floort);
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
        private System.Windows.Forms.TextBox txt_floort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cleant;
        private System.Windows.Forms.Button btn_savet;
        private System.Windows.Forms.Button btn_closet;
    }
}
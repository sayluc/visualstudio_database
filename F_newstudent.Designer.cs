namespace WindowsFormsApp2
{
    partial class F_aluno
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
            this.btn_cleanstud = new System.Windows.Forms.Button();
            this.btn_savestud = new System.Windows.Forms.Button();
            this.btn_closestud = new System.Windows.Forms.Button();
            this.txt_namestud = new System.Windows.Forms.TextBox();
            this.txt_classtud = new System.Windows.Forms.TextBox();
            this.txt_periodstud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cleanstud
            // 
            this.btn_cleanstud.Location = new System.Drawing.Point(9, 207);
            this.btn_cleanstud.Name = "btn_cleanstud";
            this.btn_cleanstud.Size = new System.Drawing.Size(77, 33);
            this.btn_cleanstud.TabIndex = 0;
            this.btn_cleanstud.Text = "Limpar";
            this.btn_cleanstud.UseVisualStyleBackColor = true;
            this.btn_cleanstud.Click += new System.EventHandler(this.btn_cleanstud_Click);
            // 
            // btn_savestud
            // 
            this.btn_savestud.Location = new System.Drawing.Point(110, 207);
            this.btn_savestud.Name = "btn_savestud";
            this.btn_savestud.Size = new System.Drawing.Size(77, 33);
            this.btn_savestud.TabIndex = 1;
            this.btn_savestud.Text = "Salvar";
            this.btn_savestud.UseVisualStyleBackColor = true;
            this.btn_savestud.Click += new System.EventHandler(this.btn_savestud_Click);
            // 
            // btn_closestud
            // 
            this.btn_closestud.Location = new System.Drawing.Point(211, 207);
            this.btn_closestud.Name = "btn_closestud";
            this.btn_closestud.Size = new System.Drawing.Size(77, 33);
            this.btn_closestud.TabIndex = 2;
            this.btn_closestud.Text = "Sair";
            this.btn_closestud.UseVisualStyleBackColor = true;
            this.btn_closestud.Click += new System.EventHandler(this.btn_closestud_Click);
            // 
            // txt_namestud
            // 
            this.txt_namestud.Location = new System.Drawing.Point(45, 51);
            this.txt_namestud.Name = "txt_namestud";
            this.txt_namestud.Size = new System.Drawing.Size(203, 20);
            this.txt_namestud.TabIndex = 3;
            // 
            // txt_classtud
            // 
            this.txt_classtud.Location = new System.Drawing.Point(45, 103);
            this.txt_classtud.Name = "txt_classtud";
            this.txt_classtud.Size = new System.Drawing.Size(203, 20);
            this.txt_classtud.TabIndex = 4;
            // 
            // txt_periodstud
            // 
            this.txt_periodstud.Location = new System.Drawing.Point(45, 153);
            this.txt_periodstud.Name = "txt_periodstud";
            this.txt_periodstud.Size = new System.Drawing.Size(72, 20);
            this.txt_periodstud.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Curso do Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Periodo";
            // 
            // F_newstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_periodstud);
            this.Controls.Add(this.txt_classtud);
            this.Controls.Add(this.txt_namestud);
            this.Controls.Add(this.btn_closestud);
            this.Controls.Add(this.btn_savestud);
            this.Controls.Add(this.btn_cleanstud);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_newstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cleanstud;
        private System.Windows.Forms.Button btn_savestud;
        private System.Windows.Forms.Button btn_closestud;
        private System.Windows.Forms.TextBox txt_namestud;
        private System.Windows.Forms.TextBox txt_classtud;
        private System.Windows.Forms.TextBox txt_periodstud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
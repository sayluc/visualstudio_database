namespace WindowsFormsApp2
{
    partial class F_newclass
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
            this.txt_nameclass = new System.Windows.Forms.TextBox();
            this.txt_areaclass = new System.Windows.Forms.TextBox();
            this.txt_stateclass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_classclean = new System.Windows.Forms.Button();
            this.btn_classave = new System.Windows.Forms.Button();
            this.btn_classclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nameclass
            // 
            this.txt_nameclass.Location = new System.Drawing.Point(39, 38);
            this.txt_nameclass.Name = "txt_nameclass";
            this.txt_nameclass.Size = new System.Drawing.Size(244, 20);
            this.txt_nameclass.TabIndex = 1;
            // 
            // txt_areaclass
            // 
            this.txt_areaclass.Location = new System.Drawing.Point(39, 85);
            this.txt_areaclass.Name = "txt_areaclass";
            this.txt_areaclass.Size = new System.Drawing.Size(178, 20);
            this.txt_areaclass.TabIndex = 2;
            // 
            // txt_stateclass
            // 
            this.txt_stateclass.Location = new System.Drawing.Point(249, 85);
            this.txt_stateclass.Name = "txt_stateclass";
            this.txt_stateclass.Size = new System.Drawing.Size(127, 20);
            this.txt_stateclass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Área do curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // btn_classclean
            // 
            this.btn_classclean.Location = new System.Drawing.Point(12, 129);
            this.btn_classclean.Name = "btn_classclean";
            this.btn_classclean.Size = new System.Drawing.Size(95, 35);
            this.btn_classclean.TabIndex = 8;
            this.btn_classclean.Text = "Limpar";
            this.btn_classclean.UseVisualStyleBackColor = true;
            this.btn_classclean.Click += new System.EventHandler(this.btn_classclean_Click);
            // 
            // btn_classave
            // 
            this.btn_classave.Location = new System.Drawing.Point(163, 129);
            this.btn_classave.Name = "btn_classave";
            this.btn_classave.Size = new System.Drawing.Size(95, 35);
            this.btn_classave.TabIndex = 9;
            this.btn_classave.Text = "Salvar";
            this.btn_classave.UseVisualStyleBackColor = true;
            this.btn_classave.Click += new System.EventHandler(this.btn_classave_Click);
            // 
            // btn_classclose
            // 
            this.btn_classclose.Location = new System.Drawing.Point(310, 129);
            this.btn_classclose.Name = "btn_classclose";
            this.btn_classclose.Size = new System.Drawing.Size(95, 35);
            this.btn_classclose.TabIndex = 10;
            this.btn_classclose.Text = "Sair";
            this.btn_classclose.UseVisualStyleBackColor = true;
            this.btn_classclose.Click += new System.EventHandler(this.btn_classclose_Click);
            // 
            // F_newclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 176);
            this.Controls.Add(this.btn_classclose);
            this.Controls.Add(this.btn_classave);
            this.Controls.Add(this.btn_classclean);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_stateclass);
            this.Controls.Add(this.txt_areaclass);
            this.Controls.Add(this.txt_nameclass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_newclass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Curso";
            this.Load += new System.EventHandler(this.F_newclass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nameclass;
        private System.Windows.Forms.TextBox txt_areaclass;
        private System.Windows.Forms.TextBox txt_stateclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_classclean;
        private System.Windows.Forms.Button btn_classave;
        private System.Windows.Forms.Button btn_classclose;
    }
}
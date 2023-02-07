namespace WindowsFormsApp2
{
    partial class F_classroom
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
            this.dgv_classroom = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idtimeclassroom = new System.Windows.Forms.TextBox();
            this.txt_teacherclassroom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idclassroom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_closeroom = new System.Windows.Forms.Button();
            this.btn_modifyroom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_stateclassroom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maxclassroom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idcourseclassroom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idteacherclassroom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_eraseclassroom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classroom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_classroom
            // 
            this.dgv_classroom.AllowUserToAddRows = false;
            this.dgv_classroom.AllowUserToDeleteRows = false;
            this.dgv_classroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classroom.Location = new System.Drawing.Point(482, 52);
            this.dgv_classroom.Name = "dgv_classroom";
            this.dgv_classroom.ReadOnly = true;
            this.dgv_classroom.Size = new System.Drawing.Size(370, 357);
            this.dgv_classroom.TabIndex = 0;
            this.dgv_classroom.SelectionChanged += new System.EventHandler(this.dgv_classroom_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horário das Aulas";
            // 
            // txt_idtimeclassroom
            // 
            this.txt_idtimeclassroom.BackColor = System.Drawing.SystemColors.Control;
            this.txt_idtimeclassroom.Location = new System.Drawing.Point(15, 52);
            this.txt_idtimeclassroom.Name = "txt_idtimeclassroom";
            this.txt_idtimeclassroom.ReadOnly = true;
            this.txt_idtimeclassroom.Size = new System.Drawing.Size(247, 20);
            this.txt_idtimeclassroom.TabIndex = 3;
            // 
            // txt_teacherclassroom
            // 
            this.txt_teacherclassroom.Location = new System.Drawing.Point(152, 132);
            this.txt_teacherclassroom.Name = "txt_teacherclassroom";
            this.txt_teacherclassroom.ReadOnly = true;
            this.txt_teacherclassroom.Size = new System.Drawing.Size(110, 20);
            this.txt_teacherclassroom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Professor Responsável";
            // 
            // txt_idclassroom
            // 
            this.txt_idclassroom.Location = new System.Drawing.Point(15, 364);
            this.txt_idclassroom.Name = "txt_idclassroom";
            this.txt_idclassroom.ReadOnly = true;
            this.txt_idclassroom.Size = new System.Drawing.Size(83, 20);
            this.txt_idclassroom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Turma";
            // 
            // btn_closeroom
            // 
            this.btn_closeroom.BackColor = System.Drawing.SystemColors.Window;
            this.btn_closeroom.Location = new System.Drawing.Point(741, 23);
            this.btn_closeroom.Name = "btn_closeroom";
            this.btn_closeroom.Size = new System.Drawing.Size(113, 37);
            this.btn_closeroom.TabIndex = 9;
            this.btn_closeroom.Text = "Sair";
            this.btn_closeroom.UseVisualStyleBackColor = false;
            this.btn_closeroom.Click += new System.EventHandler(this.btn_closeroom_Click);
            // 
            // btn_modifyroom
            // 
            this.btn_modifyroom.BackColor = System.Drawing.SystemColors.Window;
            this.btn_modifyroom.Location = new System.Drawing.Point(14, 23);
            this.btn_modifyroom.Name = "btn_modifyroom";
            this.btn_modifyroom.Size = new System.Drawing.Size(113, 37);
            this.btn_modifyroom.TabIndex = 10;
            this.btn_modifyroom.Text = "Modificar";
            this.btn_modifyroom.UseVisualStyleBackColor = false;
            this.btn_modifyroom.Click += new System.EventHandler(this.btn_modifyroom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_eraseclassroom);
            this.panel1.Controls.Add(this.btn_modifyroom);
            this.panel1.Controls.Add(this.btn_closeroom);
            this.panel1.Location = new System.Drawing.Point(-3, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 76);
            this.panel1.TabIndex = 11;
            // 
            // txt_stateclassroom
            // 
            this.txt_stateclassroom.Location = new System.Drawing.Point(15, 212);
            this.txt_stateclassroom.Name = "txt_stateclassroom";
            this.txt_stateclassroom.ReadOnly = true;
            this.txt_stateclassroom.Size = new System.Drawing.Size(134, 20);
            this.txt_stateclassroom.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status da Turma";
            // 
            // txt_maxclassroom
            // 
            this.txt_maxclassroom.Location = new System.Drawing.Point(15, 292);
            this.txt_maxclassroom.Name = "txt_maxclassroom";
            this.txt_maxclassroom.ReadOnly = true;
            this.txt_maxclassroom.Size = new System.Drawing.Size(111, 20);
            this.txt_maxclassroom.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Máximo de Alunos";
            // 
            // txt_idcourseclassroom
            // 
            this.txt_idcourseclassroom.Location = new System.Drawing.Point(180, 364);
            this.txt_idcourseclassroom.Name = "txt_idcourseclassroom";
            this.txt_idcourseclassroom.ReadOnly = true;
            this.txt_idcourseclassroom.Size = new System.Drawing.Size(82, 20);
            this.txt_idcourseclassroom.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID Curso";
            // 
            // txt_idteacherclassroom
            // 
            this.txt_idteacherclassroom.Location = new System.Drawing.Point(15, 132);
            this.txt_idteacherclassroom.Name = "txt_idteacherclassroom";
            this.txt_idteacherclassroom.ReadOnly = true;
            this.txt_idteacherclassroom.Size = new System.Drawing.Size(83, 20);
            this.txt_idteacherclassroom.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID Professor";
            // 
            // btn_eraseclassroom
            // 
            this.btn_eraseclassroom.BackColor = System.Drawing.SystemColors.Window;
            this.btn_eraseclassroom.Location = new System.Drawing.Point(365, 23);
            this.btn_eraseclassroom.Name = "btn_eraseclassroom";
            this.btn_eraseclassroom.Size = new System.Drawing.Size(113, 37);
            this.btn_eraseclassroom.TabIndex = 20;
            this.btn_eraseclassroom.Text = "Excluir";
            this.btn_eraseclassroom.UseVisualStyleBackColor = false;
            this.btn_eraseclassroom.Click += new System.EventHandler(this.btn_eraseclassroom_Click);
            // 
            // F_classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(864, 504);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_idteacherclassroom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_idcourseclassroom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_maxclassroom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_stateclassroom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idclassroom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_teacherclassroom);
            this.Controls.Add(this.txt_idtimeclassroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_classroom);
            this.Name = "F_classroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.F_classroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classroom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_classroom;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_teacherclassroom;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_idclassroom;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_idtimeclassroom;
        private System.Windows.Forms.Button btn_closeroom;
        private System.Windows.Forms.Button btn_modifyroom;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_stateclassroom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maxclassroom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_idcourseclassroom;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_idteacherclassroom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_eraseclassroom;
    }
}
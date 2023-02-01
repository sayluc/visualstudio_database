namespace WindowsFormsApp2
{
    partial class F_newuser
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_nick = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_nick = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_stats = new System.Windows.Forms.Label();
            this.lb_level = new System.Windows.Forms.Label();
            this.lb_state = new System.Windows.Forms.Label();
            this.bt_newuser = new System.Windows.Forms.Button();
            this.bt_saveuser = new System.Windows.Forms.Button();
            this.bt_closeuser = new System.Windows.Forms.Button();
            this.nud_level = new System.Windows.Forms.NumericUpDown();
            this.cmb_state = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_level)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(43, 46);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(400, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(43, 161);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(400, 20);
            this.txt_pass.TabIndex = 3;
            // 
            // txt_nick
            // 
            this.txt_nick.Location = new System.Drawing.Point(43, 104);
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Size = new System.Drawing.Size(400, 20);
            this.txt_nick.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(40, 30);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 5;
            this.lb_name.Text = "Nome";
            // 
            // lb_nick
            // 
            this.lb_nick.AutoSize = true;
            this.lb_nick.Location = new System.Drawing.Point(40, 88);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(55, 13);
            this.lb_nick.TabIndex = 6;
            this.lb_nick.Text = "Username";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(40, 145);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(38, 13);
            this.lb_pass.TabIndex = 7;
            this.lb_pass.Text = "Senha";
            // 
            // lb_stats
            // 
            this.lb_stats.AutoSize = true;
            this.lb_stats.Location = new System.Drawing.Point(40, 199);
            this.lb_stats.Name = "lb_stats";
            this.lb_stats.Size = new System.Drawing.Size(37, 13);
            this.lb_stats.TabIndex = 8;
            this.lb_stats.Text = "Status";
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Location = new System.Drawing.Point(272, 199);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(33, 13);
            this.lb_level.TabIndex = 9;
            this.lb_level.Text = "Nível";
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Location = new System.Drawing.Point(40, 238);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(117, 13);
            this.lb_state.TabIndex = 10;
            this.lb_state.Text = "A: Ativo   B: Bloqueado";
            // 
            // bt_newuser
            // 
            this.bt_newuser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_newuser.Location = new System.Drawing.Point(12, 272);
            this.bt_newuser.Name = "bt_newuser";
            this.bt_newuser.Size = new System.Drawing.Size(110, 32);
            this.bt_newuser.TabIndex = 6;
            this.bt_newuser.Text = "Limpar";
            this.bt_newuser.UseVisualStyleBackColor = false;
            this.bt_newuser.Click += new System.EventHandler(this.bt_cleanuser_Click);
            // 
            // bt_saveuser
            // 
            this.bt_saveuser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_saveuser.Location = new System.Drawing.Point(195, 272);
            this.bt_saveuser.Name = "bt_saveuser";
            this.bt_saveuser.Size = new System.Drawing.Size(110, 32);
            this.bt_saveuser.TabIndex = 7;
            this.bt_saveuser.Text = "Salvar";
            this.bt_saveuser.UseVisualStyleBackColor = false;
            this.bt_saveuser.Click += new System.EventHandler(this.bt_saveuser_Click);
            // 
            // bt_closeuser
            // 
            this.bt_closeuser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_closeuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_closeuser.Location = new System.Drawing.Point(364, 272);
            this.bt_closeuser.Name = "bt_closeuser";
            this.bt_closeuser.Size = new System.Drawing.Size(110, 32);
            this.bt_closeuser.TabIndex = 8;
            this.bt_closeuser.Text = "Fechar";
            this.bt_closeuser.UseVisualStyleBackColor = false;
            this.bt_closeuser.Click += new System.EventHandler(this.bt_closeuser_Click);
            // 
            // nud_level
            // 
            this.nud_level.Location = new System.Drawing.Point(274, 215);
            this.nud_level.Name = "nud_level";
            this.nud_level.Size = new System.Drawing.Size(169, 20);
            this.nud_level.TabIndex = 5;
            // 
            // cmb_state
            // 
            this.cmb_state.FormattingEnabled = true;
            this.cmb_state.Location = new System.Drawing.Point(43, 215);
            this.cmb_state.Name = "cmb_state";
            this.cmb_state.Size = new System.Drawing.Size(169, 21);
            this.cmb_state.TabIndex = 4;
            // 
            // F_newuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 316);
            this.Controls.Add(this.cmb_state);
            this.Controls.Add(this.nud_level);
            this.Controls.Add(this.bt_closeuser);
            this.Controls.Add(this.bt_saveuser);
            this.Controls.Add(this.bt_newuser);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.lb_level);
            this.Controls.Add(this.lb_stats);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_nick);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.txt_nick);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_newuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.nud_level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_nick;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_stats;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.Button bt_newuser;
        private System.Windows.Forms.Button bt_saveuser;
        private System.Windows.Forms.Button bt_closeuser;
        private System.Windows.Forms.NumericUpDown nud_level;
        private System.Windows.Forms.ComboBox cmb_state;
    }
}
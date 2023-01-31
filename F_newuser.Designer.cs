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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_newuser));
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
            resources.ApplyResources(this.txt_name, "txt_name");
            this.txt_name.Name = "txt_name";
            // 
            // txt_pass
            // 
            resources.ApplyResources(this.txt_pass, "txt_pass");
            this.txt_pass.Name = "txt_pass";
            // 
            // txt_nick
            // 
            resources.ApplyResources(this.txt_nick, "txt_nick");
            this.txt_nick.Name = "txt_nick";
            // 
            // lb_name
            // 
            resources.ApplyResources(this.lb_name, "lb_name");
            this.lb_name.Name = "lb_name";
            // 
            // lb_nick
            // 
            resources.ApplyResources(this.lb_nick, "lb_nick");
            this.lb_nick.Name = "lb_nick";
            // 
            // lb_pass
            // 
            resources.ApplyResources(this.lb_pass, "lb_pass");
            this.lb_pass.Name = "lb_pass";
            // 
            // lb_stats
            // 
            resources.ApplyResources(this.lb_stats, "lb_stats");
            this.lb_stats.Name = "lb_stats";
            // 
            // lb_level
            // 
            resources.ApplyResources(this.lb_level, "lb_level");
            this.lb_level.Name = "lb_level";
            // 
            // lb_state
            // 
            resources.ApplyResources(this.lb_state, "lb_state");
            this.lb_state.Name = "lb_state";
            // 
            // bt_newuser
            // 
            this.bt_newuser.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.bt_newuser, "bt_newuser");
            this.bt_newuser.Name = "bt_newuser";
            this.bt_newuser.UseVisualStyleBackColor = false;
            this.bt_newuser.Click += new System.EventHandler(this.bt_cleanuser_Click);
            // 
            // bt_saveuser
            // 
            this.bt_saveuser.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.bt_saveuser, "bt_saveuser");
            this.bt_saveuser.Name = "bt_saveuser";
            this.bt_saveuser.UseVisualStyleBackColor = false;
            this.bt_saveuser.Click += new System.EventHandler(this.bt_saveuser_Click);
            // 
            // bt_closeuser
            // 
            this.bt_closeuser.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.bt_closeuser, "bt_closeuser");
            this.bt_closeuser.Name = "bt_closeuser";
            this.bt_closeuser.UseVisualStyleBackColor = false;
            this.bt_closeuser.Click += new System.EventHandler(this.bt_closeuser_Click);
            // 
            // nud_level
            // 
            resources.ApplyResources(this.nud_level, "nud_level");
            this.nud_level.Name = "nud_level";
            // 
            // cmb_state
            // 
            this.cmb_state.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_state, "cmb_state");
            this.cmb_state.Name = "cmb_state";
            // 
            // F_newuser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Load += new System.EventHandler(this.F_newuser_Load);
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
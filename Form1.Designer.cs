namespace WindowsFormsApp2
{
    partial class F_escola
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_nivel = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.entrarEmContatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.gerenciamentoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.gerenciamentoAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.visualizarProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.gerenciamentoProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.gerenciamentoCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nivel
            // 
            this.lb_nivel.AutoSize = true;
            this.lb_nivel.Location = new System.Drawing.Point(111, 58);
            this.lb_nivel.Name = "lb_nivel";
            this.lb_nivel.Size = new System.Drawing.Size(13, 13);
            this.lb_nivel.TabIndex = 5;
            this.lb_nivel.Text = "--";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(69, 41);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(46, 13);
            this.user.TabIndex = 2;
            this.user.Text = "Usuário:";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(121, 41);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(13, 13);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "--";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Location = new System.Drawing.Point(69, 58);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(36, 13);
            this.nivel.TabIndex = 4;
            this.nivel.Text = "Nível:";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logoffToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logonToolStripMenuItem.Text = "Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.toolStripMenuItem4,
            this.entrarEmContatoToolStripMenuItem});
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.suporteToolStripMenuItem.Text = "Suporte";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(168, 6);
            // 
            // entrarEmContatoToolStripMenuItem
            // 
            this.entrarEmContatoToolStripMenuItem.Name = "entrarEmContatoToolStripMenuItem";
            this.entrarEmContatoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.entrarEmContatoToolStripMenuItem.Text = "Entrar em Contato";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuario,
            this.toolStripMenuItem2,
            this.gerenciamentoUsuariosToolStripMenuItem,
            this.toolStripMenuItem6});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoUsuario
            // 
            this.novoUsuario.Name = "novoUsuario";
            this.novoUsuario.Size = new System.Drawing.Size(172, 22);
            this.novoUsuario.Text = "Novo";
            this.novoUsuario.Click += new System.EventHandler(this.novoUsuario_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 6);
            // 
            // gerenciamentoUsuariosToolStripMenuItem
            // 
            this.gerenciamentoUsuariosToolStripMenuItem.Name = "gerenciamentoUsuariosToolStripMenuItem";
            this.gerenciamentoUsuariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gerenciamentoUsuariosToolStripMenuItem.Text = "Gerenciar Usuários";
            this.gerenciamentoUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoUsuariosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(169, 6);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAluno,
            this.toolStripMenuItem3,
            this.gerenciamentoAlunosToolStripMenuItem,
            this.toolStripMenuItem5});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAluno
            // 
            this.novoAluno.Name = "novoAluno";
            this.novoAluno.Size = new System.Drawing.Size(164, 22);
            this.novoAluno.Text = "Novo";
            this.novoAluno.Click += new System.EventHandler(this.novoAluno_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 6);
            // 
            // gerenciamentoAlunosToolStripMenuItem
            // 
            this.gerenciamentoAlunosToolStripMenuItem.Name = "gerenciamentoAlunosToolStripMenuItem";
            this.gerenciamentoAlunosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.gerenciamentoAlunosToolStripMenuItem.Text = "Gerenciar Alunos";
            this.gerenciamentoAlunosToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoAlunosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(161, 6);
            // 
            // visualizarProfessor
            // 
            this.visualizarProfessor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProfessor,
            this.toolStripMenuItem8,
            this.gerenciamentoProfessoresToolStripMenuItem,
            this.toolStripMenuItem9});
            this.visualizarProfessor.Name = "visualizarProfessor";
            this.visualizarProfessor.Size = new System.Drawing.Size(79, 20);
            this.visualizarProfessor.Text = "Professores";
            // 
            // novoProfessor
            // 
            this.novoProfessor.Name = "novoProfessor";
            this.novoProfessor.Size = new System.Drawing.Size(187, 22);
            this.novoProfessor.Text = "Novo";
            this.novoProfessor.Click += new System.EventHandler(this.novoProfessor_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(184, 6);
            // 
            // gerenciamentoProfessoresToolStripMenuItem
            // 
            this.gerenciamentoProfessoresToolStripMenuItem.Name = "gerenciamentoProfessoresToolStripMenuItem";
            this.gerenciamentoProfessoresToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gerenciamentoProfessoresToolStripMenuItem.Text = "Gerenciar Professores";
            this.gerenciamentoProfessoresToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoProfessoresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(184, 6);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCurso,
            this.toolStripMenuItem7,
            this.gerenciamentoCursosToolStripMenuItem,
            this.toolStripMenuItem10});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // novoCurso
            // 
            this.novoCurso.Name = "novoCurso";
            this.novoCurso.Size = new System.Drawing.Size(163, 22);
            this.novoCurso.Text = "Novo";
            this.novoCurso.Click += new System.EventHandler(this.novoCurso_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(160, 6);
            // 
            // gerenciamentoCursosToolStripMenuItem
            // 
            this.gerenciamentoCursosToolStripMenuItem.Name = "gerenciamentoCursosToolStripMenuItem";
            this.gerenciamentoCursosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gerenciamentoCursosToolStripMenuItem.Text = "Gerenciar Cursos";
            this.gerenciamentoCursosToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoCursosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(160, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.suporteToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.turmasToolStripMenuItem,
            this.visualizarProfessor,
            this.alunosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nivel);
            this.panel1.Controls.Add(this.pb_login);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Controls.Add(this.lb_nivel);
            this.panel1.Controls.Add(this.user);
            this.panel1.Location = new System.Drawing.Point(-6, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 84);
            this.panel1.TabIndex = 6;
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.toolStripMenuItem11});
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.turmasToolStripMenuItem.Text = "Turmas";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aToolStripMenuItem.Text = "Visualizar";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(177, 6);
            // 
            // pb_login
            // 
            this.pb_login.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pb_login.Image = global::WindowsFormsApp2.Properties.Resources.bvermelha;
            this.pb_login.Location = new System.Drawing.Point(18, 41);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(30, 30);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login.TabIndex = 1;
            this.pb_login.TabStop = false;
            // 
            // F_escola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_escola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.Load += new System.EventHandler(this.F_escola_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label nivel;
        public System.Windows.Forms.PictureBox pb_login;
        public System.Windows.Forms.Label lb_user;
        public System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem entrarEmContatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAluno;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem visualizarProfessor;
        private System.Windows.Forms.ToolStripMenuItem novoProfessor;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCurso;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
    }
}

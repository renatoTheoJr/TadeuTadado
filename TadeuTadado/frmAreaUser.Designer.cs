namespace TadeuTadado
{
    partial class frmAreaUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDadosUsuarios = new System.Windows.Forms.TabPage();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.radMasc = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tpTeste = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.btnGerarTeste = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpDadosUsuarios.SuspendLayout();
            this.grpSexo.SuspendLayout();
            this.tpTeste.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDadosUsuarios);
            this.tabControl1.Controls.Add(this.tpTeste);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tpDadosUsuarios
            // 
            this.tpDadosUsuarios.Controls.Add(this.btnExcluir);
            this.tpDadosUsuarios.Controls.Add(this.txtSenha);
            this.tpDadosUsuarios.Controls.Add(this.grpSexo);
            this.tpDadosUsuarios.Controls.Add(this.btnLimpar);
            this.tpDadosUsuarios.Controls.Add(this.btnAltera);
            this.tpDadosUsuarios.Controls.Add(this.btnSalvar);
            this.tpDadosUsuarios.Controls.Add(this.lblSenha);
            this.tpDadosUsuarios.Controls.Add(this.lblLogin);
            this.tpDadosUsuarios.Controls.Add(this.lblSobrenome);
            this.tpDadosUsuarios.Controls.Add(this.lblRA);
            this.tpDadosUsuarios.Controls.Add(this.lblTelefone);
            this.tpDadosUsuarios.Controls.Add(this.lblNome);
            this.tpDadosUsuarios.Controls.Add(this.txtTelefone);
            this.tpDadosUsuarios.Controls.Add(this.txtLogin);
            this.tpDadosUsuarios.Controls.Add(this.txtRA);
            this.tpDadosUsuarios.Controls.Add(this.txtSobrenome);
            this.tpDadosUsuarios.Controls.Add(this.txtNome);
            this.tpDadosUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpDadosUsuarios.Name = "tpDadosUsuarios";
            this.tpDadosUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosUsuarios.Size = new System.Drawing.Size(780, 412);
            this.tpDadosUsuarios.TabIndex = 0;
            this.tpDadosUsuarios.Text = "Dados";
            this.tpDadosUsuarios.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(465, 309);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(165, 20);
            this.txtSenha.TabIndex = 30;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.radFem);
            this.grpSexo.Controls.Add(this.radMasc);
            this.grpSexo.Location = new System.Drawing.Point(136, 192);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(495, 70);
            this.grpSexo.TabIndex = 25;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // radFem
            // 
            this.radFem.AutoSize = true;
            this.radFem.Location = new System.Drawing.Point(213, 35);
            this.radFem.Name = "radFem";
            this.radFem.Size = new System.Drawing.Size(67, 17);
            this.radFem.TabIndex = 7;
            this.radFem.Text = "Feminino";
            this.radFem.UseVisualStyleBackColor = true;
            // 
            // radMasc
            // 
            this.radMasc.AutoSize = true;
            this.radMasc.Checked = true;
            this.radMasc.Location = new System.Drawing.Point(27, 35);
            this.radMasc.Name = "radMasc";
            this.radMasc.Size = new System.Drawing.Size(73, 17);
            this.radMasc.TabIndex = 6;
            this.radMasc.TabStop = true;
            this.radMasc.Text = "Masculino";
            this.radMasc.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(231, 360);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(156, 30);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAltera
            // 
            this.btnAltera.Location = new System.Drawing.Point(587, 360);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(156, 30);
            this.btnAltera.TabIndex = 29;
            this.btnAltera.Text = "Alterar";
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(51, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(156, 30);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(463, 284);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 17;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(133, 284);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Login";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(464, 25);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 19;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(134, 76);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(22, 13);
            this.lblRA.TabIndex = 20;
            this.lblRA.Text = "RA";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(134, 134);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 21;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(134, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(137, 150);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(165, 20);
            this.txtTelefone.TabIndex = 24;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(136, 300);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(165, 20);
            this.txtLogin.TabIndex = 26;
            // 
            // txtRA
            // 
            this.txtRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRA.Location = new System.Drawing.Point(137, 92);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(165, 20);
            this.txtRA.TabIndex = 23;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSobrenome.Location = new System.Drawing.Point(467, 41);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(165, 20);
            this.txtSobrenome.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(137, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 20);
            this.txtNome.TabIndex = 15;
            // 
            // tpTeste
            // 
            this.tpTeste.Controls.Add(this.label1);
            this.tpTeste.Controls.Add(this.cmbMateria);
            this.tpTeste.Controls.Add(this.btnGerarTeste);
            this.tpTeste.Location = new System.Drawing.Point(4, 22);
            this.tpTeste.Name = "tpTeste";
            this.tpTeste.Padding = new System.Windows.Forms.Padding(3);
            this.tpTeste.Size = new System.Drawing.Size(780, 412);
            this.tpTeste.TabIndex = 1;
            this.tpTeste.Text = "Teste";
            this.tpTeste.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Selecione a materia:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Items.AddRange(new object[] {
            "Português",
            "Matemática"});
            this.cmbMateria.Location = new System.Drawing.Point(222, 193);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(109, 21);
            this.cmbMateria.TabIndex = 31;
            // 
            // btnGerarTeste
            // 
            this.btnGerarTeste.Location = new System.Drawing.Point(190, 229);
            this.btnGerarTeste.Name = "btnGerarTeste";
            this.btnGerarTeste.Size = new System.Drawing.Size(223, 127);
            this.btnGerarTeste.TabIndex = 0;
            this.btnGerarTeste.Text = "Gerar Teste";
            this.btnGerarTeste.UseVisualStyleBackColor = true;
            this.btnGerarTeste.Click += new System.EventHandler(this.btnGerarTeste_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(411, 360);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(156, 30);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmAreaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAreaUser";
            this.Text = "frmAreaUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAreaUser_FormClosing);
            this.Load += new System.EventHandler(this.frmAreaUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpDadosUsuarios.ResumeLayout(false);
            this.tpDadosUsuarios.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.tpTeste.ResumeLayout(false);
            this.tpTeste.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDadosUsuarios;
        private System.Windows.Forms.TabPage tpTeste;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.RadioButton radMasc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnGerarTeste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Button btnExcluir;
    }
}
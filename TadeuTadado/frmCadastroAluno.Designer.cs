namespace TadeuTadado
{
    partial class frmCadastroAluno
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblCadastroAlunos = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.radMasc = new System.Windows.Forms.RadioButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(76, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSobrenome.Location = new System.Drawing.Point(406, 94);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(165, 20);
            this.txtSobrenome.TabIndex = 2;
            // 
            // txtRA
            // 
            this.txtRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRA.Location = new System.Drawing.Point(76, 145);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(165, 20);
            this.txtRA.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(75, 353);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(165, 20);
            this.txtLogin.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(76, 203);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(165, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // lblCadastroAlunos
            // 
            this.lblCadastroAlunos.AutoSize = true;
            this.lblCadastroAlunos.Location = new System.Drawing.Point(297, 30);
            this.lblCadastroAlunos.Name = "lblCadastroAlunos";
            this.lblCadastroAlunos.Size = new System.Drawing.Size(98, 13);
            this.lblCadastroAlunos.TabIndex = 3;
            this.lblCadastroAlunos.Text = "Cadastro de alunos";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(73, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(403, 78);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 3;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(73, 129);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(22, 13);
            this.lblRA.TabIndex = 3;
            this.lblRA.Text = "RA";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(73, 187);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(72, 337);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(402, 337);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(59, 413);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(156, 30);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(239, 413);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(156, 30);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(422, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.radFem);
            this.grpSexo.Controls.Add(this.radMasc);
            this.grpSexo.Location = new System.Drawing.Point(75, 245);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(495, 70);
            this.grpSexo.TabIndex = 6;
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
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(404, 362);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(165, 20);
            this.txtSenha.TabIndex = 14;
            // 
            // frmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 480);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastroAlunos);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TadeuTadado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastroAluno_FormClosing);
            this.Load += new System.EventHandler(this.frmTadeuTadado_Load);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblCadastroAlunos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.RadioButton radMasc;
        private System.Windows.Forms.TextBox txtSenha;
    }
}


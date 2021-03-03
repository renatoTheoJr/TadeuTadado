namespace TadeuTadado
{
    partial class frmAreaProfessor
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
            this.tpDados = new System.Windows.Forms.TabPage();
            this.tpHistorico = new System.Windows.Forms.TabPage();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.radMasc = new System.Windows.Forms.RadioButton();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDados);
            this.tabControl1.Controls.Add(this.tpHistorico);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.txtSenha);
            this.tpDados.Controls.Add(this.cmbMateria);
            this.tpDados.Controls.Add(this.grpSexo);
            this.tpDados.Controls.Add(this.lblSenha);
            this.tpDados.Controls.Add(this.lblLogin);
            this.tpDados.Controls.Add(this.lblSobrenome);
            this.tpDados.Controls.Add(this.lbCPF);
            this.tpDados.Controls.Add(this.lblDataNascimento);
            this.tpDados.Controls.Add(this.lblTelefone);
            this.tpDados.Controls.Add(this.lblNome);
            this.tpDados.Controls.Add(this.txtTelefone);
            this.tpDados.Controls.Add(this.txtLogin);
            this.tpDados.Controls.Add(this.txtCpf);
            this.tpDados.Controls.Add(this.txtSobrenome);
            this.tpDados.Controls.Add(this.txtNome);
            this.tpDados.Controls.Add(this.label1);
            this.tpDados.Location = new System.Drawing.Point(4, 22);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpDados.Size = new System.Drawing.Size(769, 412);
            this.tpDados.TabIndex = 0;
            this.tpDados.Text = "Dados";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // tpHistorico
            // 
            this.tpHistorico.Location = new System.Drawing.Point(4, 22);
            this.tpHistorico.Name = "tpHistorico";
            this.tpHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tpHistorico.Size = new System.Drawing.Size(769, 412);
            this.tpHistorico.TabIndex = 1;
            this.tpHistorico.Text = "Analizar";
            this.tpHistorico.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(467, 378);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(165, 20);
            this.txtSenha.TabIndex = 50;
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Items.AddRange(new object[] {
            "Português",
            "Matemática"});
            this.cmbMateria.Location = new System.Drawing.Point(138, 212);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 21);
            this.cmbMateria.TabIndex = 49;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.radFem);
            this.grpSexo.Controls.Add(this.radMasc);
            this.grpSexo.Location = new System.Drawing.Point(137, 266);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(495, 70);
            this.grpSexo.TabIndex = 47;
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
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(465, 362);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 38;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(135, 362);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 39;
            this.lblLogin.Text = "Login";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(465, 25);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 40;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(135, 76);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 41;
            this.lbCPF.Text = "CPF";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(135, 196);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(42, 13);
            this.lblDataNascimento.TabIndex = 42;
            this.lblDataNascimento.Text = "Materia";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(135, 134);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 43;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(135, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 44;
            this.lblNome.Text = "Nome";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(138, 150);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(165, 20);
            this.txtTelefone.TabIndex = 46;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(138, 378);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(165, 20);
            this.txtLogin.TabIndex = 48;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Location = new System.Drawing.Point(138, 92);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(165, 20);
            this.txtCpf.TabIndex = 45;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSobrenome.Location = new System.Drawing.Point(468, 41);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(165, 20);
            this.txtSobrenome.TabIndex = 37;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(138, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 20);
            this.txtNome.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cadastrar Professor";
            // 
            // frmAreaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAreaProfessor";
            this.Text = "frmAreaProfessor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAreaProfessor_FormClosing);
            this.Load += new System.EventHandler(this.frmAreaProfessor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.TabPage tpHistorico;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.RadioButton radMasc;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
    }
}
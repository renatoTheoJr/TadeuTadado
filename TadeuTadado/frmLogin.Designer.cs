namespace TadeuTadado
{
    partial class frmLogin
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.radProfessor = new System.Windows.Forms.RadioButton();
            this.radAluno = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(211, 146);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(200, 38);
            this.txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(211, 225);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(200, 38);
            this.txtSenha.TabIndex = 2;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(208, 130);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(43, 13);
            this.lblLog.TabIndex = 1;
            this.lblLog.Text = "LOGIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(211, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(336, 400);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(89, 39);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // radProfessor
            // 
            this.radProfessor.AutoSize = true;
            this.radProfessor.Location = new System.Drawing.Point(211, 313);
            this.radProfessor.Name = "radProfessor";
            this.radProfessor.Size = new System.Drawing.Size(69, 17);
            this.radProfessor.TabIndex = 4;
            this.radProfessor.Text = "Professor";
            this.radProfessor.UseVisualStyleBackColor = true;
            // 
            // radAluno
            // 
            this.radAluno.AutoSize = true;
            this.radAluno.Checked = true;
            this.radAluno.Location = new System.Drawing.Point(211, 290);
            this.radAluno.Name = "radAluno";
            this.radAluno.Size = new System.Drawing.Size(52, 17);
            this.radAluno.TabIndex = 3;
            this.radAluno.TabStop = true;
            this.radAluno.Text = "Aluno";
            this.radAluno.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 534);
            this.Controls.Add(this.radAluno);
            this.Controls.Add(this.radProfessor);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.RadioButton radProfessor;
        private System.Windows.Forms.RadioButton radAluno;
    }
}
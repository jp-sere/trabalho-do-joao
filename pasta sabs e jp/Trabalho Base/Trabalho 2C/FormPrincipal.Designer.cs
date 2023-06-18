namespace Trabalho_2C
{
    partial class FormPrincipal
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
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.grpAlternativas = new System.Windows.Forms.GroupBox();
            this.lblE = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.RadioButton();
            this.lblD = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.RadioButton();
            this.lblC = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.RadioButton();
            this.lblB = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.RadioButton();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnProximaPergunta = new System.Windows.Forms.Button();
            this.txtResolucao = new System.Windows.Forms.TextBox();
            this.lblResolucao = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.prbAcertos = new System.Windows.Forms.ProgressBar();
            this.grpAlternativas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(8, 13);
            this.lblDisciplina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 0;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(63, 11);
            this.cmbDisciplinas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(185, 21);
            this.cmbDisciplinas.TabIndex = 1;
            this.cmbDisciplinas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(8, 36);
            this.lblEnunciado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(58, 13);
            this.lblEnunciado.TabIndex = 2;
            this.lblEnunciado.Text = "Enunciado";
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Enabled = false;
            this.txtEnunciado.Location = new System.Drawing.Point(11, 58);
            this.txtEnunciado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(525, 100);
            this.txtEnunciado.TabIndex = 3;
            // 
            // grpAlternativas
            // 
            this.grpAlternativas.Controls.Add(this.lblE);
            this.grpAlternativas.Controls.Add(this.E);
            this.grpAlternativas.Controls.Add(this.lblD);
            this.grpAlternativas.Controls.Add(this.D);
            this.grpAlternativas.Controls.Add(this.lblC);
            this.grpAlternativas.Controls.Add(this.C);
            this.grpAlternativas.Controls.Add(this.lblB);
            this.grpAlternativas.Controls.Add(this.B);
            this.grpAlternativas.Controls.Add(this.lblA);
            this.grpAlternativas.Controls.Add(this.A);
            this.grpAlternativas.Location = new System.Drawing.Point(11, 160);
            this.grpAlternativas.Margin = new System.Windows.Forms.Padding(2);
            this.grpAlternativas.Name = "grpAlternativas";
            this.grpAlternativas.Padding = new System.Windows.Forms.Padding(2);
            this.grpAlternativas.Size = new System.Drawing.Size(524, 159);
            this.grpAlternativas.TabIndex = 4;
            this.grpAlternativas.TabStop = false;
            this.grpAlternativas.Text = "Alternativas";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(6, 135);
            this.lblE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(17, 13);
            this.lblE.TabIndex = 9;
            this.lblE.Text = "E.";
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(26, 134);
            this.E.Margin = new System.Windows.Forms.Padding(2);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(14, 13);
            this.E.TabIndex = 8;
            this.E.TabStop = true;
            this.E.UseVisualStyleBackColor = true;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(6, 105);
            this.lblD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(18, 13);
            this.lblD.TabIndex = 7;
            this.lblD.Text = "D.";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(26, 103);
            this.D.Margin = new System.Windows.Forms.Padding(2);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(14, 13);
            this.D.TabIndex = 6;
            this.D.TabStop = true;
            this.D.UseVisualStyleBackColor = true;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(6, 76);
            this.lblC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(17, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "C.";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(26, 75);
            this.C.Margin = new System.Windows.Forms.Padding(2);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(14, 13);
            this.C.TabIndex = 4;
            this.C.TabStop = true;
            this.C.UseVisualStyleBackColor = true;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(6, 46);
            this.lblB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B.";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(26, 45);
            this.B.Margin = new System.Windows.Forms.Padding(2);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(14, 13);
            this.B.TabIndex = 2;
            this.B.TabStop = true;
            this.B.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(6, 18);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A.";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(26, 16);
            this.A.Margin = new System.Windows.Forms.Padding(2);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(14, 13);
            this.A.TabIndex = 0;
            this.A.TabStop = true;
            this.A.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(11, 322);
            this.btnResponder.Margin = new System.Windows.Forms.Padding(2);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(149, 34);
            this.btnResponder.TabIndex = 5;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnProximaPergunta
            // 
            this.btnProximaPergunta.Location = new System.Drawing.Point(164, 322);
            this.btnProximaPergunta.Margin = new System.Windows.Forms.Padding(2);
            this.btnProximaPergunta.Name = "btnProximaPergunta";
            this.btnProximaPergunta.Size = new System.Drawing.Size(371, 34);
            this.btnProximaPergunta.TabIndex = 6;
            this.btnProximaPergunta.Text = "Próxima Pergunta";
            this.btnProximaPergunta.UseVisualStyleBackColor = true;
            this.btnProximaPergunta.Click += new System.EventHandler(this.btnProximaPergunta_Click);
            // 
            // txtResolucao
            // 
            this.txtResolucao.Enabled = false;
            this.txtResolucao.Location = new System.Drawing.Point(11, 390);
            this.txtResolucao.Margin = new System.Windows.Forms.Padding(2);
            this.txtResolucao.Multiline = true;
            this.txtResolucao.Name = "txtResolucao";
            this.txtResolucao.Size = new System.Drawing.Size(525, 100);
            this.txtResolucao.TabIndex = 7;
            this.txtResolucao.TextChanged += new System.EventHandler(this.txtResolucao_TextChanged);
            // 
            // lblResolucao
            // 
            this.lblResolucao.AutoSize = true;
            this.lblResolucao.Location = new System.Drawing.Point(11, 373);
            this.lblResolucao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResolucao.Name = "lblResolucao";
            this.lblResolucao.Size = new System.Drawing.Size(141, 13);
            this.lblResolucao.TabIndex = 8;
            this.lblResolucao.Text = "Resolução com comentários";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Location = new System.Drawing.Point(11, 494);
            this.lblAcertos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(80, 13);
            this.lblAcertos.TabIndex = 12;
            this.lblAcertos.Text = "80% de acertos";
            this.lblAcertos.TextChanged += new System.EventHandler(this.lblAcertos_TextChanged);
            this.lblAcertos.Click += new System.EventHandler(this.lblAcertos_Click);
            // 
            // prbAcertos
            // 
            this.prbAcertos.Location = new System.Drawing.Point(83, 494);
            this.prbAcertos.Margin = new System.Windows.Forms.Padding(2);
            this.prbAcertos.Name = "prbAcertos";
            this.prbAcertos.Size = new System.Drawing.Size(452, 13);
            this.prbAcertos.TabIndex = 11;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 527);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.prbAcertos);
            this.Controls.Add(this.lblResolucao);
            this.Controls.Add(this.txtResolucao);
            this.Controls.Add(this.btnProximaPergunta);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.grpAlternativas);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.lblDisciplina);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "Aplicativo de Resolução de Questões CPII";
            this.grpAlternativas.ResumeLayout(false);
            this.grpAlternativas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.GroupBox grpAlternativas;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.RadioButton E;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnProximaPergunta;
        private System.Windows.Forms.TextBox txtResolucao;
        private System.Windows.Forms.Label lblResolucao;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.ProgressBar prbAcertos;
    }
}


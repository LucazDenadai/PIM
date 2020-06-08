namespace Demo
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.documento = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.complemento = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tel = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dados do cliente";
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(30, 109);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(205, 20);
            this.documento.TabIndex = 2;
            this.documento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(241, 109);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(220, 20);
            this.nome.TabIndex = 3;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(30, 146);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(165, 20);
            this.email.TabIndex = 4;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endereço";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(30, 213);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(100, 20);
            this.cep.TabIndex = 7;
            this.cep.TextChanged += new System.EventHandler(this.cep_TextChanged);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(137, 213);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(263, 20);
            this.log.TabIndex = 8;
            this.log.TextChanged += new System.EventHandler(this.log_TextChanged);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(406, 213);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(55, 20);
            this.num.TabIndex = 9;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // complemento
            // 
            this.complemento.Location = new System.Drawing.Point(30, 252);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(192, 20);
            this.complemento.TabIndex = 10;
            this.complemento.TextChanged += new System.EventHandler(this.complemento_TextChanged);
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(229, 251);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(171, 20);
            this.cidade.TabIndex = 11;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(406, 251);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(55, 20);
            this.estado.TabIndex = 12;
            this.estado.TextChanged += new System.EventHandler(this.estado_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "CNPJ/CPF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome completo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefone";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "E-mail";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cep";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Logradouro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Número";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Complemento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Cidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(406, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Estado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Buscar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(201, 146);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(118, 20);
            this.tel.TabIndex = 25;
            this.tel.TextChanged += new System.EventHandler(this.tel_TextChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(323, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Telefone adicional";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 330);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.complemento);
            this.Controls.Add(this.num);
            this.Controls.Add(this.log);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Octus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox complemento;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
    }
}
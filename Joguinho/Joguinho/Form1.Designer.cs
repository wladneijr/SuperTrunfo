namespace Joguinho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSortear = new Button();
            btnComparar = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            pictureBoxJogador = new PictureBox();
            pictureBoxMaquina = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            QuantidadeCartasMinhas = new Label();
            QuantidadeCartasOponente = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJogador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaquina).BeginInit();
            SuspendLayout();
            // 
            // btnSortear
            // 
            btnSortear.BackColor = Color.Orange;
            btnSortear.ForeColor = SystemColors.ButtonHighlight;
            btnSortear.Location = new Point(331, 35);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(109, 51);
            btnSortear.TabIndex = 0;
            btnSortear.Text = "SORTEAR";
            btnSortear.UseVisualStyleBackColor = false;
            btnSortear.Click += BtnSortear_Click;
            // 
            // btnComparar
            // 
            btnComparar.BackColor = Color.Teal;
            btnComparar.ForeColor = SystemColors.Control;
            btnComparar.Location = new Point(331, 274);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(109, 60);
            btnComparar.TabIndex = 1;
            btnComparar.Text = "COMPARAR";
            btnComparar.UseVisualStyleBackColor = false;
            btnComparar.Click += BtnComparar_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(331, 112);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Atributo1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(331, 137);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Atributo2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(331, 162);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(75, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Atributo3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxJogador
            // 
            pictureBoxJogador.Location = new Point(99, 106);
            pictureBoxJogador.Name = "pictureBoxJogador";
            pictureBoxJogador.Size = new Size(145, 159);
            pictureBoxJogador.TabIndex = 5;
            pictureBoxJogador.TabStop = false;
            // 
            // pictureBoxMaquina
            // 
            pictureBoxMaquina.Location = new Point(528, 106);
            pictureBoxMaquina.Name = "pictureBoxMaquina";
            pictureBoxMaquina.Size = new Size(145, 159);
            pictureBoxMaquina.TabIndex = 6;
            pictureBoxMaquina.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 283);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 307);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 333);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // QuantidadeCartasMinhas
            // 
            QuantidadeCartasMinhas.AutoSize = true;
            QuantidadeCartasMinhas.Location = new Point(99, 35);
            QuantidadeCartasMinhas.Name = "QuantidadeCartasMinhas";
            QuantidadeCartasMinhas.Size = new Size(83, 15);
            QuantidadeCartasMinhas.TabIndex = 10;
            QuantidadeCartasMinhas.Text = "Minhas cartas:";
            // 
            // QuantidadeCartasOponente
            // 
            QuantidadeCartasOponente.AutoSize = true;
            QuantidadeCartasOponente.Location = new Point(528, 35);
            QuantidadeCartasOponente.Name = "QuantidadeCartasOponente";
            QuantidadeCartasOponente.Size = new Size(114, 15);
            QuantidadeCartasOponente.TabIndex = 11;
            QuantidadeCartasOponente.Text = "Cartas do oponente:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 407);
            Controls.Add(QuantidadeCartasOponente);
            Controls.Add(QuantidadeCartasMinhas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxMaquina);
            Controls.Add(pictureBoxJogador);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnComparar);
            Controls.Add(btnSortear);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxJogador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaquina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSortear;
        private Button btnComparar;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private PictureBox pictureBoxJogador;
        private PictureBox pictureBoxMaquina;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label QuantidadeCartasMinhas;
        private Label QuantidadeCartasOponente;
    }
}
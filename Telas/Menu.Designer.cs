namespace Aula64_Exercicio_LocacaoLivros
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnManter = new System.Windows.Forms.Button();
            this.btnDevovler = new System.Windows.Forms.Button();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManter
            // 
            this.btnManter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnManter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManter.FlatAppearance.BorderSize = 0;
            this.btnManter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManter.Location = new System.Drawing.Point(284, 256);
            this.btnManter.Name = "btnManter";
            this.btnManter.Size = new System.Drawing.Size(233, 40);
            this.btnManter.TabIndex = 1;
            this.btnManter.Text = "Manter Livro";
            this.btnManter.UseVisualStyleBackColor = false;
            this.btnManter.Click += new System.EventHandler(this.btnManter_Click);
            // 
            // btnDevovler
            // 
            this.btnDevovler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDevovler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDevovler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevovler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDevovler.Location = new System.Drawing.Point(284, 206);
            this.btnDevovler.Name = "btnDevovler";
            this.btnDevovler.Size = new System.Drawing.Size(233, 40);
            this.btnDevovler.TabIndex = 2;
            this.btnDevovler.Text = "Devolver Livro";
            this.btnDevovler.UseVisualStyleBackColor = false;
            this.btnDevovler.Click += new System.EventHandler(this.btnDevovler_Click);
            // 
            // btnAlugar
            // 
            this.btnAlugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAlugar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlugar.Location = new System.Drawing.Point(284, 155);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(233, 40);
            this.btnAlugar.TabIndex = 3;
            this.btnAlugar.Text = "Alugar Livro";
            this.btnAlugar.UseVisualStyleBackColor = false;
            this.btnAlugar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(650, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Encerrar Sistema";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManter);
            this.Controls.Add(this.btnDevovler);
            this.Controls.Add(this.btnAlugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Sistema de Locação de Livros";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManter;
        private System.Windows.Forms.Button btnDevovler;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.Button button1;
    }
}


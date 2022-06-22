
namespace Caledario
{
    partial class Form1
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
            this.RecipienteDoDia = new System.Windows.Forms.FlowLayoutPanel();
            this.BotaoAn = new System.Windows.Forms.Button();
            this.BotaoPro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seg = new System.Windows.Forms.Label();
            this.Ter = new System.Windows.Forms.Label();
            this.qua = new System.Windows.Forms.Label();
            this.qui = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Sab = new System.Windows.Forms.Label();
            this.LDdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecipienteDoDia
            // 
            this.RecipienteDoDia.Location = new System.Drawing.Point(12, 77);
            this.RecipienteDoDia.Name = "RecipienteDoDia";
            this.RecipienteDoDia.Size = new System.Drawing.Size(811, 430);
            this.RecipienteDoDia.TabIndex = 0;
            // 
            // BotaoAn
            // 
            this.BotaoAn.Location = new System.Drawing.Point(667, 523);
            this.BotaoAn.Name = "BotaoAn";
            this.BotaoAn.Size = new System.Drawing.Size(69, 27);
            this.BotaoAn.TabIndex = 1;
            this.BotaoAn.Text = "Voltar";
            this.BotaoAn.UseVisualStyleBackColor = true;
            // 
            // BotaoPro
            // 
            this.BotaoPro.Location = new System.Drawing.Point(742, 523);
            this.BotaoPro.Name = "BotaoPro";
            this.BotaoPro.Size = new System.Drawing.Size(70, 26);
            this.BotaoPro.TabIndex = 2;
            this.BotaoPro.Text = "Proximo";
            this.BotaoPro.UseVisualStyleBackColor = true;
            this.BotaoPro.Click += new System.EventHandler(this.BotaoPro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Domingo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // seg
            // 
            this.seg.AutoSize = true;
            this.seg.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seg.Location = new System.Drawing.Point(164, 45);
            this.seg.Name = "seg";
            this.seg.Size = new System.Drawing.Size(71, 21);
            this.seg.TabIndex = 5;
            this.seg.Text = "Segunda";
            // 
            // Ter
            // 
            this.Ter.AutoSize = true;
            this.Ter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ter.Location = new System.Drawing.Point(287, 45);
            this.Ter.Name = "Ter";
            this.Ter.Size = new System.Drawing.Size(47, 21);
            this.Ter.TabIndex = 6;
            this.Ter.Text = "Terça";
            // 
            // qua
            // 
            this.qua.AutoSize = true;
            this.qua.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qua.Location = new System.Drawing.Point(394, 45);
            this.qua.Name = "qua";
            this.qua.Size = new System.Drawing.Size(58, 21);
            this.qua.TabIndex = 7;
            this.qua.Text = "Quarta";
            // 
            // qui
            // 
            this.qui.AutoSize = true;
            this.qui.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qui.Location = new System.Drawing.Point(509, 45);
            this.qui.Name = "qui";
            this.qui.Size = new System.Drawing.Size(57, 21);
            this.qui.TabIndex = 8;
            this.qui.Text = "Quinta";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(629, 45);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(47, 21);
            this.Sex.TabIndex = 5;
            this.Sex.Text = "Sexta";
            this.Sex.Click += new System.EventHandler(this.Sex_Click);
            // 
            // Sab
            // 
            this.Sab.AutoSize = true;
            this.Sab.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sab.Location = new System.Drawing.Point(739, 45);
            this.Sab.Name = "Sab";
            this.Sab.Size = new System.Drawing.Size(62, 21);
            this.Sab.TabIndex = 9;
            this.Sab.Text = "Sábado";
            this.Sab.Click += new System.EventHandler(this.Sab_Click);
            // 
            // LDdate
            // 
            this.LDdate.AutoSize = true;
            this.LDdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDdate.Location = new System.Drawing.Point(381, 9);
            this.LDdate.Name = "LDdate";
            this.LDdate.Size = new System.Drawing.Size(71, 21);
            this.LDdate.TabIndex = 10;
            this.LDdate.Text = "Mês Ano";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 561);
            this.Controls.Add(this.LDdate);
            this.Controls.Add(this.Sab);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.qui);
            this.Controls.Add(this.qua);
            this.Controls.Add(this.Ter);
            this.Controls.Add(this.seg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotaoPro);
            this.Controls.Add(this.BotaoAn);
            this.Controls.Add(this.RecipienteDoDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RecipienteDoDia;
        private System.Windows.Forms.Button BotaoAn;
        private System.Windows.Forms.Button BotaoPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label seg;
        private System.Windows.Forms.Label Ter;
        private System.Windows.Forms.Label qua;
        private System.Windows.Forms.Label qui;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Sab;
        private System.Windows.Forms.Label LDdate;
    }
}


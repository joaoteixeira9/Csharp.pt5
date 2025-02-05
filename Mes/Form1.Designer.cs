namespace Mes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInicial = new System.Windows.Forms.TextBox();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.textBoxAtual = new System.Windows.Forms.TextBox();
            this.btnSelecionarData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInicialAuto = new System.Windows.Forms.TextBox();
            this.txtAtualAuto = new System.Windows.Forms.TextBox();
            this.txtFinalAuto = new System.Windows.Forms.TextBox();
            this.IconeCalendario = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar1.Location = new System.Drawing.Point(158, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data atual:";
            // 
            // textBoxInicial
            // 
            this.textBoxInicial.Location = new System.Drawing.Point(498, 99);
            this.textBoxInicial.Name = "textBoxInicial";
            this.textBoxInicial.Size = new System.Drawing.Size(100, 20);
            this.textBoxInicial.TabIndex = 2;
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(498, 128);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinal.TabIndex = 4;
            // 
            // textBoxAtual
            // 
            this.textBoxAtual.Location = new System.Drawing.Point(498, 158);
            this.textBoxAtual.Name = "textBoxAtual";
            this.textBoxAtual.Size = new System.Drawing.Size(100, 20);
            this.textBoxAtual.TabIndex = 6;
            // 
            // btnSelecionarData
            // 
            this.btnSelecionarData.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelecionarData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecionarData.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarData.Location = new System.Drawing.Point(419, 201);
            this.btnSelecionarData.Name = "btnSelecionarData";
            this.btnSelecionarData.Size = new System.Drawing.Size(179, 26);
            this.btnSelecionarData.TabIndex = 7;
            this.btnSelecionarData.Text = "Selecionar data";
            this.btnSelecionarData.UseVisualStyleBackColor = false;
            this.btnSelecionarData.Click += new System.EventHandler(this.btnSelecionarData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data atual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data inicial:";
            // 
            // txtInicialAuto
            // 
            this.txtInicialAuto.Location = new System.Drawing.Point(237, 246);
            this.txtInicialAuto.Name = "txtInicialAuto";
            this.txtInicialAuto.Size = new System.Drawing.Size(100, 20);
            this.txtInicialAuto.TabIndex = 11;
            // 
            // txtAtualAuto
            // 
            this.txtAtualAuto.Location = new System.Drawing.Point(237, 306);
            this.txtAtualAuto.Name = "txtAtualAuto";
            this.txtAtualAuto.Size = new System.Drawing.Size(100, 20);
            this.txtAtualAuto.TabIndex = 13;
            // 
            // txtFinalAuto
            // 
            this.txtFinalAuto.Location = new System.Drawing.Point(237, 276);
            this.txtFinalAuto.Name = "txtFinalAuto";
            this.txtFinalAuto.Size = new System.Drawing.Size(100, 20);
            this.txtFinalAuto.TabIndex = 12;
            // 
            // IconeCalendario
            // 
            this.IconeCalendario.ContextMenuStrip = this.Menu;
            this.IconeCalendario.Icon = ((System.Drawing.Icon)(resources.GetObject("IconeCalendario.Icon")));
            this.IconeCalendario.Text = "IconeCalendario";
            this.IconeCalendario.Visible = true;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Restaurar,
            this.Mensagem,
            this.Fechar});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(181, 92);
            this.Menu.Text = "Menu";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // Restaurar
            // 
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(180, 22);
            this.Restaurar.Text = "Restaurar";
            // 
            // Mensagem
            // 
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(180, 22);
            this.Mensagem.Text = "Mensagem";
            // 
            // Fechar
            // 
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(180, 22);
            this.Fechar.Text = "Fechar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFinalAuto);
            this.Controls.Add(this.txtAtualAuto);
            this.Controls.Add(this.txtInicialAuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelecionarData);
            this.Controls.Add(this.textBoxAtual);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.textBoxInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInicial;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.TextBox textBoxAtual;
        private System.Windows.Forms.Button btnSelecionarData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInicialAuto;
        private System.Windows.Forms.TextBox txtAtualAuto;
        private System.Windows.Forms.TextBox txtFinalAuto;
        private System.Windows.Forms.NotifyIcon IconeCalendario;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Restaurar;
        private System.Windows.Forms.ToolStripMenuItem Mensagem;
        private System.Windows.Forms.ToolStripMenuItem Fechar;
    }
}


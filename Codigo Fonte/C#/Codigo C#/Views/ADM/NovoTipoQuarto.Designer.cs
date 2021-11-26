
namespace Hotelaria.Views.ADM
{
    partial class NovoTipoQuarto
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
            XanderUI.XUIButton xuiButton2;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label ds_StatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoTipoQuarto));
            this.btnInativo = new MetroFramework.Controls.MetroRadioButton();
            this.btnAtivo = new MetroFramework.Controls.MetroRadioButton();
            this.BtnClose = new System.Windows.Forms.Label();
            this.txtMaxCriancas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSave = new XanderUI.XUIButton();
            this.txtPrTipoQuarto = new System.Windows.Forms.TextBox();
            this.txtVlCrianca = new System.Windows.Forms.TextBox();
            this.txtVlAdultos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxAdultos = new System.Windows.Forms.TextBox();
            this.txtNomeTipo = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new XanderUI.XUIButton();
            xuiButton2 = new XanderUI.XUIButton();
            panel1 = new System.Windows.Forms.Panel();
            ds_StatusLabel = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiButton2
            // 
            xuiButton2.BackgroundColor = System.Drawing.Color.White;
            xuiButton2.ButtonImage = null;
            xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            xuiButton2.ButtonText = "";
            xuiButton2.CausesValidation = false;
            xuiButton2.ClickBackColor = System.Drawing.Color.White;
            xuiButton2.ClickTextColor = System.Drawing.Color.White;
            xuiButton2.CornerRadius = 9;
            xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            xuiButton2.HoverBackgroundColor = System.Drawing.Color.White;
            xuiButton2.HoverTextColor = System.Drawing.Color.White;
            xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            xuiButton2.Location = new System.Drawing.Point(7, 6);
            xuiButton2.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            xuiButton2.MaximumSize = new System.Drawing.Size(4388, 2182);
            xuiButton2.Name = "xuiButton2";
            xuiButton2.Size = new System.Drawing.Size(389, 385);
            xuiButton2.TabIndex = 241;
            xuiButton2.TabStop = false;
            xuiButton2.TextColor = System.Drawing.Color.White;
            xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.CausesValidation = false;
            panel1.Controls.Add(this.btnInativo);
            panel1.Controls.Add(this.btnAtivo);
            panel1.Controls.Add(ds_StatusLabel);
            panel1.Controls.Add(this.BtnClose);
            panel1.Controls.Add(this.txtMaxCriancas);
            panel1.Controls.Add(this.label7);
            panel1.Controls.Add(this.BtnSave);
            panel1.Controls.Add(this.txtPrTipoQuarto);
            panel1.Controls.Add(this.txtVlCrianca);
            panel1.Controls.Add(this.txtVlAdultos);
            panel1.Controls.Add(this.label6);
            panel1.Controls.Add(this.label5);
            panel1.Controls.Add(this.label4);
            panel1.Controls.Add(this.label3);
            panel1.Controls.Add(this.label2);
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.txtMaxAdultos);
            panel1.Controls.Add(this.txtNomeTipo);
            panel1.Controls.Add(this.BtnCancelar);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(374, 369);
            panel1.TabIndex = 245;
            // 
            // btnInativo
            // 
            this.btnInativo.AutoSize = true;
            this.btnInativo.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.btnInativo.Location = new System.Drawing.Point(102, 282);
            this.btnInativo.Name = "btnInativo";
            this.btnInativo.Size = new System.Drawing.Size(82, 25);
            this.btnInativo.TabIndex = 260;
            this.btnInativo.Text = "Inativo";
            this.btnInativo.UseSelectable = true;
            this.btnInativo.CheckedChanged += new System.EventHandler(this.btnInativo_CheckedChanged);
            // 
            // btnAtivo
            // 
            this.btnAtivo.AutoSize = true;
            this.btnAtivo.Checked = true;
            this.btnAtivo.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.btnAtivo.Location = new System.Drawing.Point(26, 282);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(70, 25);
            this.btnAtivo.TabIndex = 259;
            this.btnAtivo.TabStop = true;
            this.btnAtivo.Text = "Ativo";
            this.btnAtivo.UseSelectable = true;
            this.btnAtivo.CheckedChanged += new System.EventHandler(this.btnAtivo_CheckedChanged);
            // 
            // ds_StatusLabel
            // 
            ds_StatusLabel.AutoSize = true;
            ds_StatusLabel.BackColor = System.Drawing.Color.White;
            ds_StatusLabel.Location = new System.Drawing.Point(22, 259);
            ds_StatusLabel.Name = "ds_StatusLabel";
            ds_StatusLabel.Size = new System.Drawing.Size(56, 20);
            ds_StatusLabel.TabIndex = 258;
            ds_StatusLabel.Text = "Status";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.CausesValidation = false;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(336, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 244;
            this.BtnClose.UseMnemonic = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtMaxCriancas
            // 
            this.txtMaxCriancas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxCriancas.Location = new System.Drawing.Point(141, 220);
            this.txtMaxCriancas.Name = "txtMaxCriancas";
            this.txtMaxCriancas.Size = new System.Drawing.Size(96, 26);
            this.txtMaxCriancas.TabIndex = 257;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label7.Location = new System.Drawing.Point(14, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Novo Tipo de Quarto";
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnSave.ButtonImage = null;
            this.BtnSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnSave.ButtonText = "Salvar";
            this.BtnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSave.CornerRadius = 5;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnSave.Location = new System.Drawing.Point(283, 325);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(78, 39);
            this.BtnSave.TabIndex = 256;
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtPrTipoQuarto
            // 
            this.txtPrTipoQuarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrTipoQuarto.Location = new System.Drawing.Point(201, 93);
            this.txtPrTipoQuarto.Name = "txtPrTipoQuarto";
            this.txtPrTipoQuarto.Size = new System.Drawing.Size(160, 26);
            this.txtPrTipoQuarto.TabIndex = 255;
            // 
            // txtVlCrianca
            // 
            this.txtVlCrianca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlCrianca.Location = new System.Drawing.Point(201, 158);
            this.txtVlCrianca.Name = "txtVlCrianca";
            this.txtVlCrianca.Size = new System.Drawing.Size(160, 26);
            this.txtVlCrianca.TabIndex = 253;
            // 
            // txtVlAdultos
            // 
            this.txtVlAdultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlAdultos.Location = new System.Drawing.Point(22, 158);
            this.txtVlAdultos.Name = "txtVlAdultos";
            this.txtVlAdultos.Size = new System.Drawing.Size(160, 26);
            this.txtVlAdultos.TabIndex = 252;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(197, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 251;
            this.label6.Text = "Valor do Quarto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(197, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 250;
            this.label5.Text = "Valor por Criança";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 249;
            this.label4.Text = "Valor por Adulto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(137, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 248;
            this.label3.Text = "Max Crianças";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 247;
            this.label2.Text = "Max  Adultos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 246;
            this.label1.Text = "Nome do Tipo";
            // 
            // txtMaxAdultos
            // 
            this.txtMaxAdultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxAdultos.Location = new System.Drawing.Point(26, 220);
            this.txtMaxAdultos.Name = "txtMaxAdultos";
            this.txtMaxAdultos.Size = new System.Drawing.Size(96, 26);
            this.txtMaxAdultos.TabIndex = 245;
            // 
            // txtNomeTipo
            // 
            this.txtNomeTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeTipo.Location = new System.Drawing.Point(19, 93);
            this.txtNomeTipo.MaxLength = 200;
            this.txtNomeTipo.Name = "txtNomeTipo";
            this.txtNomeTipo.Size = new System.Drawing.Size(163, 26);
            this.txtNomeTipo.TabIndex = 244;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.BtnCancelar.ButtonImage = null;
            this.BtnCancelar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnCancelar.ButtonText = "Cancelar";
            this.BtnCancelar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnCancelar.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.CornerRadius = 5;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCancelar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnCancelar.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnCancelar.Location = new System.Drawing.Point(22, 325);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(83, 39);
            this.BtnCancelar.TabIndex = 243;
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // NovoTipoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Silver;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(405, 400);
            this.ControlBox = false;
            this.Controls.Add(panel1);
            this.Controls.Add(xuiButton2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "NovoTipoQuarto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoTipoQuarto";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.NovoTipoQuarto_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BtnClose;
        private XanderUI.XUIButton BtnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public XanderUI.XUIButton BtnSave;
        public System.Windows.Forms.TextBox txtPrTipoQuarto;
        public System.Windows.Forms.TextBox txtVlCrianca;
        public System.Windows.Forms.TextBox txtVlAdultos;
        public System.Windows.Forms.TextBox txtMaxAdultos;
        public System.Windows.Forms.TextBox txtNomeTipo;
        public System.Windows.Forms.TextBox txtMaxCriancas;
        private MetroFramework.Controls.MetroRadioButton btnInativo;
        private MetroFramework.Controls.MetroRadioButton btnAtivo;
    }
}

namespace Hotelaria.Views.Pagamentos
{
    partial class NovoPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.Windows.Forms.Label dt_PagamentoLabel;
            System.Windows.Forms.Label tipo_PagamentoLabel;
            System.Windows.Forms.Label label3;
            XanderUI.XUIButton xuiButton7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoPagamento));
            this.BoxHospedagem = new MetroFramework.Controls.MetroComboBox();
            this.DtPagamento = new MetroFramework.Controls.MetroDateTime();
            this.cbxTipoPagamento = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPago = new MaterialSkin.Controls.MaterialSwitch();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new XanderUI.XUIButton();
            this.lblClose = new System.Windows.Forms.Label();
            this.panelConta = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.xuiButton8 = new XanderUI.XUIButton();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.lblQtdDiarias = new System.Windows.Forms.Label();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.lblCrianca = new System.Windows.Forms.Label();
            this.lblQtdInfantil = new System.Windows.Forms.Label();
            this.LblAdultos = new System.Windows.Forms.Label();
            this.lblQtdAdultos = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton4 = new XanderUI.XUIButton();
            this.background = new System.Windows.Forms.Panel();
            dt_PagamentoLabel = new System.Windows.Forms.Label();
            tipo_PagamentoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            xuiButton7 = new XanderUI.XUIButton();
            this.panelConta.SuspendLayout();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_PagamentoLabel
            // 
            dt_PagamentoLabel.AutoSize = true;
            dt_PagamentoLabel.BackColor = System.Drawing.Color.White;
            dt_PagamentoLabel.Location = new System.Drawing.Point(133, 116);
            dt_PagamentoLabel.Name = "dt_PagamentoLabel";
            dt_PagamentoLabel.Size = new System.Drawing.Size(152, 20);
            dt_PagamentoLabel.TabIndex = 214;
            dt_PagamentoLabel.Text = "Data de Pagamento";
            // 
            // tipo_PagamentoLabel
            // 
            tipo_PagamentoLabel.AutoSize = true;
            tipo_PagamentoLabel.BackColor = System.Drawing.Color.White;
            tipo_PagamentoLabel.Location = new System.Drawing.Point(6, 116);
            tipo_PagamentoLabel.Name = "tipo_PagamentoLabel";
            tipo_PagamentoLabel.Size = new System.Drawing.Size(59, 20);
            tipo_PagamentoLabel.TabIndex = 213;
            tipo_PagamentoLabel.Text = "Forma ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(6, 47);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 20);
            label3.TabIndex = 223;
            label3.Text = "Hospedagem";
            // 
            // xuiButton7
            // 
            xuiButton7.BackgroundColor = System.Drawing.Color.White;
            xuiButton7.ButtonImage = null;
            xuiButton7.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            xuiButton7.ButtonText = "";
            xuiButton7.CausesValidation = false;
            xuiButton7.ClickBackColor = System.Drawing.Color.White;
            xuiButton7.ClickTextColor = System.Drawing.Color.White;
            xuiButton7.CornerRadius = 9;
            xuiButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xuiButton7.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            xuiButton7.HoverBackgroundColor = System.Drawing.Color.White;
            xuiButton7.HoverTextColor = System.Drawing.Color.White;
            xuiButton7.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            xuiButton7.Location = new System.Drawing.Point(14, 6);
            xuiButton7.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            xuiButton7.MaximumSize = new System.Drawing.Size(2925, 1418);
            xuiButton7.Name = "xuiButton7";
            xuiButton7.Size = new System.Drawing.Size(747, 369);
            xuiButton7.TabIndex = 227;
            xuiButton7.TextColor = System.Drawing.Color.White;
            xuiButton7.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // BoxHospedagem
            // 
            this.BoxHospedagem.FormattingEnabled = true;
            this.BoxHospedagem.ItemHeight = 23;
            this.BoxHospedagem.Location = new System.Drawing.Point(10, 70);
            this.BoxHospedagem.Name = "BoxHospedagem";
            this.BoxHospedagem.Size = new System.Drawing.Size(332, 29);
            this.BoxHospedagem.TabIndex = 220;
            this.BoxHospedagem.UseSelectable = true;
            this.BoxHospedagem.SelectedIndexChanged += new System.EventHandler(this.BoxHospedagem_SelectedIndexChanged);
            this.BoxHospedagem.SelectedValueChanged += new System.EventHandler(this.BoxHospedagem_SelectedValueChanged);
            // 
            // DtPagamento
            // 
            this.DtPagamento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.DtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPagamento.Location = new System.Drawing.Point(137, 139);
            this.DtPagamento.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtPagamento.Name = "DtPagamento";
            this.DtPagamento.Size = new System.Drawing.Size(205, 29);
            this.DtPagamento.TabIndex = 218;
            this.DtPagamento.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DtPagamento.Value = new System.DateTime(2021, 9, 15, 12, 6, 33, 0);
            // 
            // cbxTipoPagamento
            // 
            this.cbxTipoPagamento.FormattingEnabled = true;
            this.cbxTipoPagamento.ItemHeight = 23;
            this.cbxTipoPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito"});
            this.cbxTipoPagamento.Location = new System.Drawing.Point(9, 139);
            this.cbxTipoPagamento.Name = "cbxTipoPagamento";
            this.cbxTipoPagamento.Size = new System.Drawing.Size(106, 29);
            this.cbxTipoPagamento.TabIndex = 217;
            this.cbxTipoPagamento.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 216;
            this.label2.Text = "Pago?";
            // 
            // btnPago
            // 
            this.btnPago.AutoSize = true;
            this.btnPago.BackColor = System.Drawing.Color.Black;
            this.btnPago.Depth = 0;
            this.btnPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.Location = new System.Drawing.Point(68, 200);
            this.btnPago.Margin = new System.Windows.Forms.Padding(0);
            this.btnPago.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPago.Name = "btnPago";
            this.btnPago.Ripple = true;
            this.btnPago.Size = new System.Drawing.Size(58, 37);
            this.btnPago.TabIndex = 200;
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.CheckedChanged += new System.EventHandler(this.btnPago_CheckedChanged);
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.xuiButton3.ButtonImage = null;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "Cancelar";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(9, 300);
            this.xuiButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(83, 37);
            this.xuiButton3.TabIndex = 211;
            this.xuiButton3.TextColor = System.Drawing.Color.White;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, -8);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 208;
            this.label1.Text = "Novo Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnSave.ButtonImage = null;
            this.btnSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSave.ButtonText = "Salvar";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(632, 300);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 210;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.White;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(682, 2);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 209;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // panelConta
            // 
            this.panelConta.BackColor = System.Drawing.Color.White;
            this.panelConta.Controls.Add(this.label5);
            this.panelConta.Controls.Add(this.label4);
            this.panelConta.Controls.Add(this.lblTotal);
            this.panelConta.Controls.Add(this.xuiButton8);
            this.panelConta.Controls.Add(this.lblDiaria);
            this.panelConta.Controls.Add(this.lblQtdDiarias);
            this.panelConta.Controls.Add(this.xuiButton5);
            this.panelConta.Controls.Add(this.lblCrianca);
            this.panelConta.Controls.Add(this.lblQtdInfantil);
            this.panelConta.Controls.Add(this.LblAdultos);
            this.panelConta.Controls.Add(this.lblQtdAdultos);
            this.panelConta.Controls.Add(this.xuiButton1);
            this.panelConta.Controls.Add(this.xuiButton2);
            this.panelConta.Controls.Add(this.xuiButton4);
            this.panelConta.Location = new System.Drawing.Point(367, 68);
            this.panelConta.Name = "panelConta";
            this.panelConta.Size = new System.Drawing.Size(344, 165);
            this.panelConta.TabIndex = 225;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(14, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 25);
            this.label5.TabIndex = 226;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 266;
            this.label4.Text = "Total a Pagar";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.lblTotal.Location = new System.Drawing.Point(239, 141);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 265;
            this.lblTotal.Text = "Total";
            // 
            // xuiButton8
            // 
            this.xuiButton8.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton8.ButtonImage = null;
            this.xuiButton8.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton8.ButtonText = "";
            this.xuiButton8.ClickBackColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton8.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton8.CornerRadius = 5;
            this.xuiButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton8.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton8.HoverBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton8.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton8.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton8.Location = new System.Drawing.Point(7, 132);
            this.xuiButton8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton8.Name = "xuiButton8";
            this.xuiButton8.Size = new System.Drawing.Size(332, 41);
            this.xuiButton8.TabIndex = 253;
            this.xuiButton8.TextColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton8.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDiaria
            // 
            this.lblDiaria.AutoSize = true;
            this.lblDiaria.BackColor = System.Drawing.Color.White;
            this.lblDiaria.ForeColor = System.Drawing.Color.DimGray;
            this.lblDiaria.Location = new System.Drawing.Point(143, 105);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(58, 20);
            this.lblDiaria.TabIndex = 263;
            this.lblDiaria.Text = "Diárias";
            // 
            // lblQtdDiarias
            // 
            this.lblQtdDiarias.AutoSize = true;
            this.lblQtdDiarias.BackColor = System.Drawing.Color.White;
            this.lblQtdDiarias.ForeColor = System.Drawing.Color.DimGray;
            this.lblQtdDiarias.Location = new System.Drawing.Point(51, 105);
            this.lblQtdDiarias.Name = "lblQtdDiarias";
            this.lblQtdDiarias.Size = new System.Drawing.Size(18, 20);
            this.lblQtdDiarias.TabIndex = 262;
            this.lblQtdDiarias.Text = "0";
            // 
            // xuiButton5
            // 
            this.xuiButton5.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton5.ButtonImage = null;
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton5.ButtonText = "";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.White;
            this.xuiButton5.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton5.CornerRadius = 5;
            this.xuiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.White;
            this.xuiButton5.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(7, 99);
            this.xuiButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(332, 37);
            this.xuiButton5.TabIndex = 229;
            this.xuiButton5.TextColor = System.Drawing.Color.White;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblCrianca
            // 
            this.lblCrianca.AutoSize = true;
            this.lblCrianca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCrianca.ForeColor = System.Drawing.Color.DimGray;
            this.lblCrianca.Location = new System.Drawing.Point(143, 71);
            this.lblCrianca.Name = "lblCrianca";
            this.lblCrianca.Size = new System.Drawing.Size(71, 20);
            this.lblCrianca.TabIndex = 250;
            this.lblCrianca.Text = "Crianças";
            // 
            // lblQtdInfantil
            // 
            this.lblQtdInfantil.AutoSize = true;
            this.lblQtdInfantil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblQtdInfantil.ForeColor = System.Drawing.Color.DimGray;
            this.lblQtdInfantil.Location = new System.Drawing.Point(51, 71);
            this.lblQtdInfantil.Name = "lblQtdInfantil";
            this.lblQtdInfantil.Size = new System.Drawing.Size(18, 20);
            this.lblQtdInfantil.TabIndex = 251;
            this.lblQtdInfantil.Text = "0";
            // 
            // LblAdultos
            // 
            this.LblAdultos.AutoSize = true;
            this.LblAdultos.BackColor = System.Drawing.Color.White;
            this.LblAdultos.ForeColor = System.Drawing.Color.DimGray;
            this.LblAdultos.Location = new System.Drawing.Point(143, 38);
            this.LblAdultos.Name = "LblAdultos";
            this.LblAdultos.Size = new System.Drawing.Size(63, 20);
            this.LblAdultos.TabIndex = 247;
            this.LblAdultos.Text = "Adultos";
            // 
            // lblQtdAdultos
            // 
            this.lblQtdAdultos.AutoSize = true;
            this.lblQtdAdultos.BackColor = System.Drawing.Color.White;
            this.lblQtdAdultos.ForeColor = System.Drawing.Color.DimGray;
            this.lblQtdAdultos.Location = new System.Drawing.Point(51, 38);
            this.lblQtdAdultos.Name = "lblQtdAdultos";
            this.lblQtdAdultos.Size = new System.Drawing.Size(18, 20);
            this.lblQtdAdultos.TabIndex = 248;
            this.lblQtdAdultos.Text = "0";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Conta";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(3, 0);
            this.xuiButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(336, 33);
            this.xuiButton1.TabIndex = 226;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.White;
            this.xuiButton2.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.White;
            this.xuiButton2.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(7, 28);
            this.xuiButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(332, 37);
            this.xuiButton2.TabIndex = 227;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton4
            // 
            this.xuiButton4.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton4.ButtonImage = null;
            this.xuiButton4.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton4.ButtonText = "";
            this.xuiButton4.ClickBackColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton4.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton4.CornerRadius = 5;
            this.xuiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton4.HoverBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton4.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton4.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton4.Location = new System.Drawing.Point(7, 63);
            this.xuiButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton4.Name = "xuiButton4";
            this.xuiButton4.Size = new System.Drawing.Size(332, 37);
            this.xuiButton4.TabIndex = 228;
            this.xuiButton4.TextColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.White;
            this.background.Controls.Add(this.DtPagamento);
            this.background.Controls.Add(label3);
            this.background.Controls.Add(this.xuiButton3);
            this.background.Controls.Add(this.BoxHospedagem);
            this.background.Controls.Add(dt_PagamentoLabel);
            this.background.Controls.Add(this.btnSave);
            this.background.Controls.Add(this.btnPago);
            this.background.Controls.Add(this.cbxTipoPagamento);
            this.background.Controls.Add(this.panelConta);
            this.background.Controls.Add(this.label2);
            this.background.Controls.Add(tipo_PagamentoLabel);
            this.background.Controls.Add(this.label1);
            this.background.Controls.Add(this.lblClose);
            this.background.Location = new System.Drawing.Point(32, 14);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(711, 346);
            this.background.TabIndex = 226;
            // 
            // NovoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(775, 384);
            this.Controls.Add(this.background);
            this.Controls.Add(xuiButton7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovoPagamento";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoPagamento";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.NovoPagamento_Load);
            this.panelConta.ResumeLayout(false);
            this.panelConta.PerformLayout();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSwitch btnPago;
        private XanderUI.XUIButton xuiButton3;
        public System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnSave;
        private System.Windows.Forms.Label lblClose;
        public MetroFramework.Controls.MetroComboBox BoxHospedagem;
        private System.Windows.Forms.Panel panelConta;
        private XanderUI.XUIButton xuiButton5;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton4;
        private System.Windows.Forms.Label LblAdultos;
        private System.Windows.Forms.Label lblQtdAdultos;
        private XanderUI.XUIButton xuiButton8;
        private System.Windows.Forms.Label lblCrianca;
        private System.Windows.Forms.Label lblQtdInfantil;
        private System.Windows.Forms.Label lblDiaria;
        private System.Windows.Forms.Label lblQtdDiarias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel background;
        public System.Windows.Forms.Label lblTotal;
        public MetroFramework.Controls.MetroDateTime DtPagamento;
        public MetroFramework.Controls.MetroComboBox cbxTipoPagamento;
    }
}
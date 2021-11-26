
namespace Hotelaria.Views.Hospedagens
{
    partial class NovaHospedagem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nm_HospedeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaHospedagem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMaxAdultos = new MetroFramework.Controls.MetroComboBox();
            this.btnSelectHospede = new XanderUI.XUIButton();
            this.cbxNomeQuarto = new MetroFramework.Controls.MetroComboBox();
            this.cbxTipoQuarto = new MetroFramework.Controls.MetroComboBox();
            this.LblNomeQuarto = new System.Windows.Forms.Label();
            this.LblCheckIn = new System.Windows.Forms.Label();
            this.DtCheckOut = new MetroFramework.Controls.MetroDateTime();
            this.LblCheckOut = new System.Windows.Forms.Label();
            this.cbxMaxCriancas = new MetroFramework.Controls.MetroComboBox();
            this.btncSearch = new System.Windows.Forms.Label();
            this.DgvHospedes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.LblTipoQuarto = new System.Windows.Forms.Label();
            this.btnReservar = new XanderUI.XUIButton();
            this.xuiButton7 = new XanderUI.XUIButton();
            this.lblVerificar = new System.Windows.Forms.Label();
            this.TxtHospede = new System.Windows.Forms.TextBox();
            this.DtCheckIn = new MetroFramework.Controls.MetroDateTime();
            this.lblHeader = new System.Windows.Forms.Label();
            this.TabHospedagem = new XanderUI.XUIFlatTab();
            this.Hospedagem = new System.Windows.Forms.TabPage();
            this.lblDsInfo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblDisponivel = new System.Windows.Forms.Label();
            this.lblIndisponivel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelConta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrQuarto = new System.Windows.Forms.Label();
            this.xuiButton8 = new XanderUI.XUIButton();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.lblQtdDiarias = new System.Windows.Forms.Label();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.lblCrianca = new System.Windows.Forms.Label();
            this.lblQtdCriancas = new System.Windows.Forms.Label();
            this.lblPrCriancas = new System.Windows.Forms.Label();
            this.LblAdultos = new System.Windows.Forms.Label();
            this.lblQtdAdultos = new System.Windows.Forms.Label();
            this.lblPrAdultos = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton4 = new XanderUI.XUIButton();
            this.LblExtraAdultos = new System.Windows.Forms.Label();
            this.LblExtraCriancas = new System.Windows.Forms.Label();
            this.Hospedes = new System.Windows.Forms.TabPage();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDica = new System.Windows.Forms.Label();
            this.btnNovoHospede = new XanderUI.XUIButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltar = new XanderUI.XUIButton();
            this.btnClose = new System.Windows.Forms.Label();
            this.hospedesTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.HospedesTableAdapter();
            nm_HospedeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHospedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            this.TabHospedagem.SuspendLayout();
            this.Hospedagem.SuspendLayout();
            this.panelConta.SuspendLayout();
            this.Hospedes.SuspendLayout();
            this.SuspendLayout();
            // 
            // nm_HospedeLabel
            // 
            nm_HospedeLabel.AutoSize = true;
            nm_HospedeLabel.ForeColor = System.Drawing.Color.Gray;
            nm_HospedeLabel.Location = new System.Drawing.Point(18, 31);
            nm_HospedeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nm_HospedeLabel.Name = "nm_HospedeLabel";
            nm_HospedeLabel.Size = new System.Drawing.Size(97, 20);
            nm_HospedeLabel.TabIndex = 152;
            nm_HospedeLabel.Text = "Identificador";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(760, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 22);
            this.label5.TabIndex = 256;
            this.label5.Click += new System.EventHandler(this.btnSelectHospede_Click);
            // 
            // cbxMaxAdultos
            // 
            this.cbxMaxAdultos.FormattingEnabled = true;
            this.cbxMaxAdultos.ItemHeight = 23;
            this.cbxMaxAdultos.Items.AddRange(new object[] {
            "Selecione"});
            this.cbxMaxAdultos.Location = new System.Drawing.Point(293, 151);
            this.cbxMaxAdultos.Name = "cbxMaxAdultos";
            this.cbxMaxAdultos.Size = new System.Drawing.Size(101, 29);
            this.cbxMaxAdultos.TabIndex = 222;
            this.cbxMaxAdultos.UseSelectable = true;
            this.cbxMaxAdultos.SelectedValueChanged += new System.EventHandler(this.BoxExtraAdulto_SelectedValueChanged);
            // 
            // btnSelectHospede
            // 
            this.btnSelectHospede.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnSelectHospede.ButtonImage = null;
            this.btnSelectHospede.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSelectHospede.ButtonText = "     Identificador         ";
            this.btnSelectHospede.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnSelectHospede.ClickTextColor = System.Drawing.Color.White;
            this.btnSelectHospede.CornerRadius = 5;
            this.btnSelectHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectHospede.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSelectHospede.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnSelectHospede.HoverTextColor = System.Drawing.Color.White;
            this.btnSelectHospede.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSelectHospede.Location = new System.Drawing.Point(753, 348);
            this.btnSelectHospede.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectHospede.Name = "btnSelectHospede";
            this.btnSelectHospede.Padding = new System.Windows.Forms.Padding(5);
            this.btnSelectHospede.Size = new System.Drawing.Size(144, 29);
            this.btnSelectHospede.TabIndex = 195;
            this.btnSelectHospede.TextColor = System.Drawing.Color.White;
            this.btnSelectHospede.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSelectHospede.Click += new System.EventHandler(this.btnSelectHospede_Click);
            // 
            // cbxNomeQuarto
            // 
            this.cbxNomeQuarto.FormattingEnabled = true;
            this.cbxNomeQuarto.ItemHeight = 23;
            this.cbxNomeQuarto.Items.AddRange(new object[] {
            "Carregando..."});
            this.cbxNomeQuarto.Location = new System.Drawing.Point(22, 218);
            this.cbxNomeQuarto.Name = "cbxNomeQuarto";
            this.cbxNomeQuarto.Size = new System.Drawing.Size(508, 29);
            this.cbxNomeQuarto.TabIndex = 227;
            this.cbxNomeQuarto.UseSelectable = true;
            this.cbxNomeQuarto.SelectedValueChanged += new System.EventHandler(this.cbxNomeQuarto_SelectedValueChanged);
            // 
            // cbxTipoQuarto
            // 
            this.cbxTipoQuarto.FormattingEnabled = true;
            this.cbxTipoQuarto.ItemHeight = 23;
            this.cbxTipoQuarto.Location = new System.Drawing.Point(22, 151);
            this.cbxTipoQuarto.Name = "cbxTipoQuarto";
            this.cbxTipoQuarto.Size = new System.Drawing.Size(237, 29);
            this.cbxTipoQuarto.TabIndex = 221;
            this.cbxTipoQuarto.UseSelectable = true;
            this.cbxTipoQuarto.SelectedValueChanged += new System.EventHandler(this.BoxTipoQuarto_SelectedValueChanged);
            // 
            // LblNomeQuarto
            // 
            this.LblNomeQuarto.AutoSize = true;
            this.LblNomeQuarto.BackColor = System.Drawing.Color.White;
            this.LblNomeQuarto.Location = new System.Drawing.Point(18, 195);
            this.LblNomeQuarto.Name = "LblNomeQuarto";
            this.LblNomeQuarto.Size = new System.Drawing.Size(58, 20);
            this.LblNomeQuarto.TabIndex = 233;
            this.LblNomeQuarto.Text = "Quarto";
            // 
            // LblCheckIn
            // 
            this.LblCheckIn.AutoSize = true;
            this.LblCheckIn.BackColor = System.Drawing.Color.White;
            this.LblCheckIn.Location = new System.Drawing.Point(18, 58);
            this.LblCheckIn.Name = "LblCheckIn";
            this.LblCheckIn.Size = new System.Drawing.Size(72, 20);
            this.LblCheckIn.TabIndex = 228;
            this.LblCheckIn.Text = "Check In";
            // 
            // DtCheckOut
            // 
            this.DtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtCheckOut.Location = new System.Drawing.Point(293, 81);
            this.DtCheckOut.MinDate = new System.DateTime(2021, 9, 15, 0, 0, 0, 0);
            this.DtCheckOut.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtCheckOut.Name = "DtCheckOut";
            this.DtCheckOut.Size = new System.Drawing.Size(237, 29);
            this.DtCheckOut.TabIndex = 219;
            this.DtCheckOut.Value = new System.DateTime(2021, 9, 15, 0, 0, 0, 0);
            this.DtCheckOut.ValueChanged += new System.EventHandler(this.DtCheckOut_ValueChanged);
            // 
            // LblCheckOut
            // 
            this.LblCheckOut.AutoSize = true;
            this.LblCheckOut.BackColor = System.Drawing.Color.White;
            this.LblCheckOut.Location = new System.Drawing.Point(289, 58);
            this.LblCheckOut.Name = "LblCheckOut";
            this.LblCheckOut.Size = new System.Drawing.Size(72, 20);
            this.LblCheckOut.TabIndex = 229;
            this.LblCheckOut.Text = "Check In";
            // 
            // cbxMaxCriancas
            // 
            this.cbxMaxCriancas.FormattingEnabled = true;
            this.cbxMaxCriancas.ItemHeight = 23;
            this.cbxMaxCriancas.Location = new System.Drawing.Point(429, 151);
            this.cbxMaxCriancas.Name = "cbxMaxCriancas";
            this.cbxMaxCriancas.Size = new System.Drawing.Size(101, 29);
            this.cbxMaxCriancas.TabIndex = 223;
            this.cbxMaxCriancas.UseSelectable = true;
            this.cbxMaxCriancas.SelectedValueChanged += new System.EventHandler(this.BoxExtraCrianca_SelectedValueChanged);
            // 
            // btncSearch
            // 
            this.btncSearch.BackColor = System.Drawing.Color.Transparent;
            this.btncSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncSearch.Image = ((System.Drawing.Image)(resources.GetObject("btncSearch.Image")));
            this.btncSearch.Location = new System.Drawing.Point(867, 58);
            this.btncSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btncSearch.Name = "btncSearch";
            this.btncSearch.Size = new System.Drawing.Size(30, 25);
            this.btncSearch.TabIndex = 165;
            this.btncSearch.Click += new System.EventHandler(this.btncSearch_Click);
            // 
            // DgvHospedes
            // 
            this.DgvHospedes.AllowUserToAddRows = false;
            this.DgvHospedes.AllowUserToResizeColumns = false;
            this.DgvHospedes.AllowUserToResizeRows = false;
            this.DgvHospedes.AutoGenerateColumns = false;
            this.DgvHospedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvHospedes.BackgroundColor = System.Drawing.Color.White;
            this.DgvHospedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHospedes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvHospedes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvHospedes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHospedes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvHospedes.ColumnHeadersHeight = 45;
            this.DgvHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvHospedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.nrTelefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DgvHospedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvHospedes.DataSource = this.hospedesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHospedes.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvHospedes.EnableHeadersVisualStyles = false;
            this.DgvHospedes.GridColor = System.Drawing.Color.Silver;
            this.DgvHospedes.Location = new System.Drawing.Point(22, 94);
            this.DgvHospedes.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.DgvHospedes.MultiSelect = false;
            this.DgvHospedes.Name = "DgvHospedes";
            this.DgvHospedes.ReadOnly = true;
            this.DgvHospedes.RowHeadersVisible = false;
            this.DgvHospedes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHospedes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvHospedes.RowTemplate.Height = 28;
            this.DgvHospedes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHospedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHospedes.ShowCellErrors = false;
            this.DgvHospedes.ShowCellToolTips = false;
            this.DgvHospedes.ShowEditingIcon = false;
            this.DgvHospedes.ShowRowErrors = false;
            this.DgvHospedes.Size = new System.Drawing.Size(873, 154);
            this.DgvHospedes.TabIndex = 159;
            this.DgvHospedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHospedes_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Hospede";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nm_Hospede";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nr_Documento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nrTelefoneDataGridViewTextBoxColumn
            // 
            this.nrTelefoneDataGridViewTextBoxColumn.DataPropertyName = "Nr_Telefone";
            this.nrTelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.nrTelefoneDataGridViewTextBoxColumn.Name = "nrTelefoneDataGridViewTextBoxColumn";
            this.nrTelefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hospedesBindingSource
            // 
            this.hospedesBindingSource.DataMember = "Hospedes";
            this.hospedesBindingSource.DataSource = this.hotelariaDataSet;
            // 
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblTipoQuarto
            // 
            this.LblTipoQuarto.AutoSize = true;
            this.LblTipoQuarto.BackColor = System.Drawing.Color.White;
            this.LblTipoQuarto.Location = new System.Drawing.Point(18, 128);
            this.LblTipoQuarto.Name = "LblTipoQuarto";
            this.LblTipoQuarto.Size = new System.Drawing.Size(39, 20);
            this.LblTipoQuarto.TabIndex = 232;
            this.LblTipoQuarto.Text = "Tipo";
            // 
            // btnReservar
            // 
            this.btnReservar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnReservar.ButtonImage = null;
            this.btnReservar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnReservar.ButtonText = "Reservar";
            this.btnReservar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnReservar.ClickTextColor = System.Drawing.Color.White;
            this.btnReservar.CornerRadius = 5;
            this.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReservar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnReservar.HoverTextColor = System.Drawing.Color.White;
            this.btnReservar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnReservar.Location = new System.Drawing.Point(827, 344);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(80, 29);
            this.btnReservar.TabIndex = 196;
            this.btnReservar.TextColor = System.Drawing.Color.White;
            this.btnReservar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // xuiButton7
            // 
            this.xuiButton7.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton7.ButtonImage = null;
            this.xuiButton7.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton7.ButtonText = "";
            this.xuiButton7.ClickBackColor = System.Drawing.Color.White;
            this.xuiButton7.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton7.CornerRadius = 9;
            this.xuiButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton7.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton7.HoverBackgroundColor = System.Drawing.Color.White;
            this.xuiButton7.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton7.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton7.Location = new System.Drawing.Point(16, 10);
            this.xuiButton7.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.xuiButton7.MaximumSize = new System.Drawing.Size(2925, 1418);
            this.xuiButton7.Name = "xuiButton7";
            this.xuiButton7.Size = new System.Drawing.Size(950, 423);
            this.xuiButton7.TabIndex = 262;
            this.xuiButton7.TextColor = System.Drawing.Color.White;
            this.xuiButton7.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblVerificar
            // 
            this.lblVerificar.AutoSize = true;
            this.lblVerificar.Location = new System.Drawing.Point(345, 153);
            this.lblVerificar.Name = "lblVerificar";
            this.lblVerificar.Size = new System.Drawing.Size(223, 20);
            this.lblVerificar.TabIndex = 166;
            this.lblVerificar.Text = "Nenhum Hospede encontrado";
            this.lblVerificar.Visible = false;
            // 
            // TxtHospede
            // 
            this.TxtHospede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHospede.Location = new System.Drawing.Point(28, 59);
            this.TxtHospede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtHospede.Multiline = true;
            this.TxtHospede.Name = "TxtHospede";
            this.TxtHospede.Size = new System.Drawing.Size(875, 27);
            this.TxtHospede.TabIndex = 153;
            this.TxtHospede.Text = "Pesquisar por nome, documento...";
            this.TxtHospede.Click += new System.EventHandler(this.TxtHospede_Click);
            this.TxtHospede.Leave += new System.EventHandler(this.TxtHospede_Leave);
            // 
            // DtCheckIn
            // 
            this.DtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtCheckIn.Location = new System.Drawing.Point(22, 81);
            this.DtCheckIn.MinDate = new System.DateTime(2021, 9, 15, 0, 0, 0, 0);
            this.DtCheckIn.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtCheckIn.Name = "DtCheckIn";
            this.DtCheckIn.Size = new System.Drawing.Size(237, 29);
            this.DtCheckIn.TabIndex = 218;
            this.DtCheckIn.ValueChanged += new System.EventHandler(this.DtCheckIn_ValueChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(24, 14);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(936, 42);
            this.lblHeader.TabIndex = 260;
            this.lblHeader.Text = "    Nova Hospedagem";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.UseCompatibleTextRendering = true;
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // TabHospedagem
            // 
            this.TabHospedagem.ActiveHeaderColor = System.Drawing.Color.White;
            this.TabHospedagem.ActiveTextColor = System.Drawing.Color.Gray;
            this.TabHospedagem.BorderColor = System.Drawing.Color.White;
            this.TabHospedagem.Controls.Add(this.Hospedagem);
            this.TabHospedagem.Controls.Add(this.Hospedes);
            this.TabHospedagem.HeaderBackgroundColor = System.Drawing.Color.White;
            this.TabHospedagem.InActiveHeaderColor = System.Drawing.Color.White;
            this.TabHospedagem.InActiveTextColor = System.Drawing.Color.Gray;
            this.TabHospedagem.ItemSize = new System.Drawing.Size(240, 16);
            this.TabHospedagem.Location = new System.Drawing.Point(24, 10);
            this.TabHospedagem.Name = "TabHospedagem";
            this.TabHospedagem.OnlyTopLine = true;
            this.TabHospedagem.PageColor = System.Drawing.Color.White;
            this.TabHospedagem.SelectedIndex = 0;
            this.TabHospedagem.Size = new System.Drawing.Size(932, 413);
            this.TabHospedagem.TabIndex = 263;
            // 
            // Hospedagem
            // 
            this.Hospedagem.BackColor = System.Drawing.Color.White;
            this.Hospedagem.Controls.Add(this.lblDsInfo);
            this.Hospedagem.Controls.Add(this.label7);
            this.Hospedagem.Controls.Add(this.lblCheck);
            this.Hospedagem.Controls.Add(this.lblDisponivel);
            this.Hospedagem.Controls.Add(this.lblIndisponivel);
            this.Hospedagem.Controls.Add(this.label3);
            this.Hospedagem.Controls.Add(this.panelConta);
            this.Hospedagem.Controls.Add(this.label5);
            this.Hospedagem.Controls.Add(this.cbxMaxAdultos);
            this.Hospedagem.Controls.Add(this.btnSelectHospede);
            this.Hospedagem.Controls.Add(this.cbxNomeQuarto);
            this.Hospedagem.Controls.Add(this.cbxTipoQuarto);
            this.Hospedagem.Controls.Add(this.LblNomeQuarto);
            this.Hospedagem.Controls.Add(this.LblCheckIn);
            this.Hospedagem.Controls.Add(this.DtCheckOut);
            this.Hospedagem.Controls.Add(this.LblTipoQuarto);
            this.Hospedagem.Controls.Add(this.LblCheckOut);
            this.Hospedagem.Controls.Add(this.cbxMaxCriancas);
            this.Hospedagem.Controls.Add(this.DtCheckIn);
            this.Hospedagem.Controls.Add(this.LblExtraAdultos);
            this.Hospedagem.Controls.Add(this.LblExtraCriancas);
            this.Hospedagem.Location = new System.Drawing.Point(4, 20);
            this.Hospedagem.Name = "Hospedagem";
            this.Hospedagem.Padding = new System.Windows.Forms.Padding(3);
            this.Hospedagem.Size = new System.Drawing.Size(924, 389);
            this.Hospedagem.TabIndex = 0;
            this.Hospedagem.Text = "Hospedagem";
            // 
            // lblDsInfo
            // 
            this.lblDsInfo.AutoSize = true;
            this.lblDsInfo.Location = new System.Drawing.Point(25, 294);
            this.lblDsInfo.Name = "lblDsInfo";
            this.lblDsInfo.Size = new System.Drawing.Size(51, 20);
            this.lblDsInfo.TabIndex = 268;
            this.lblDsInfo.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 267;
            this.label7.Text = "Descrição do Quarto";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(110, 60);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(11, 16);
            this.lblCheck.TabIndex = 266;
            this.lblCheck.Text = "-";
            // 
            // lblDisponivel
            // 
            this.lblDisponivel.BackColor = System.Drawing.Color.White;
            this.lblDisponivel.Image = ((System.Drawing.Image)(resources.GetObject("lblDisponivel.Image")));
            this.lblDisponivel.Location = new System.Drawing.Point(87, 56);
            this.lblDisponivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponivel.Name = "lblDisponivel";
            this.lblDisponivel.Size = new System.Drawing.Size(25, 23);
            this.lblDisponivel.TabIndex = 265;
            this.lblDisponivel.Click += new System.EventHandler(this.lblDisponivel_Click);
            // 
            // lblIndisponivel
            // 
            this.lblIndisponivel.BackColor = System.Drawing.Color.White;
            this.lblIndisponivel.Image = ((System.Drawing.Image)(resources.GetObject("lblIndisponivel.Image")));
            this.lblIndisponivel.Location = new System.Drawing.Point(86, 57);
            this.lblIndisponivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndisponivel.Name = "lblIndisponivel";
            this.lblIndisponivel.Size = new System.Drawing.Size(25, 23);
            this.lblIndisponivel.TabIndex = 264;
            this.lblIndisponivel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(561, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 258;
            this.label3.Text = "Informações de pagamento";
            // 
            // panelConta
            // 
            this.panelConta.BackColor = System.Drawing.Color.White;
            this.panelConta.Controls.Add(this.label2);
            this.panelConta.Controls.Add(this.label4);
            this.panelConta.Controls.Add(this.lblTotal);
            this.panelConta.Controls.Add(this.lblPrQuarto);
            this.panelConta.Controls.Add(this.xuiButton8);
            this.panelConta.Controls.Add(this.lblDiaria);
            this.panelConta.Controls.Add(this.lblQtdDiarias);
            this.panelConta.Controls.Add(this.xuiButton5);
            this.panelConta.Controls.Add(this.lblCrianca);
            this.panelConta.Controls.Add(this.lblQtdCriancas);
            this.panelConta.Controls.Add(this.lblPrCriancas);
            this.panelConta.Controls.Add(this.LblAdultos);
            this.panelConta.Controls.Add(this.lblQtdAdultos);
            this.panelConta.Controls.Add(this.lblPrAdultos);
            this.panelConta.Controls.Add(this.xuiButton1);
            this.panelConta.Controls.Add(this.xuiButton2);
            this.panelConta.Controls.Add(this.xuiButton4);
            this.panelConta.Location = new System.Drawing.Point(558, 81);
            this.panelConta.Name = "panelConta";
            this.panelConta.Size = new System.Drawing.Size(348, 167);
            this.panelConta.TabIndex = 257;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(14, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 25);
            this.label2.TabIndex = 226;
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
            // lblPrQuarto
            // 
            this.lblPrQuarto.AutoSize = true;
            this.lblPrQuarto.BackColor = System.Drawing.Color.White;
            this.lblPrQuarto.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrQuarto.Location = new System.Drawing.Point(240, 105);
            this.lblPrQuarto.Name = "lblPrQuarto";
            this.lblPrQuarto.Size = new System.Drawing.Size(18, 20);
            this.lblPrQuarto.TabIndex = 264;
            this.lblPrQuarto.Text = "0";
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
            this.lblDiaria.Location = new System.Drawing.Point(107, 105);
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
            this.lblQtdDiarias.Location = new System.Drawing.Point(15, 105);
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
            this.lblCrianca.Location = new System.Drawing.Point(107, 71);
            this.lblCrianca.Name = "lblCrianca";
            this.lblCrianca.Size = new System.Drawing.Size(71, 20);
            this.lblCrianca.TabIndex = 250;
            this.lblCrianca.Text = "Crianças";
            // 
            // lblQtdCriancas
            // 
            this.lblQtdCriancas.AutoSize = true;
            this.lblQtdCriancas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblQtdCriancas.ForeColor = System.Drawing.Color.DimGray;
            this.lblQtdCriancas.Location = new System.Drawing.Point(15, 71);
            this.lblQtdCriancas.Name = "lblQtdCriancas";
            this.lblQtdCriancas.Size = new System.Drawing.Size(18, 20);
            this.lblQtdCriancas.TabIndex = 251;
            this.lblQtdCriancas.Text = "0";
            // 
            // lblPrCriancas
            // 
            this.lblPrCriancas.AutoSize = true;
            this.lblPrCriancas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrCriancas.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrCriancas.Location = new System.Drawing.Point(240, 71);
            this.lblPrCriancas.Name = "lblPrCriancas";
            this.lblPrCriancas.Size = new System.Drawing.Size(18, 20);
            this.lblPrCriancas.TabIndex = 252;
            this.lblPrCriancas.Text = "0";
            // 
            // LblAdultos
            // 
            this.LblAdultos.AutoSize = true;
            this.LblAdultos.BackColor = System.Drawing.Color.White;
            this.LblAdultos.ForeColor = System.Drawing.Color.DimGray;
            this.LblAdultos.Location = new System.Drawing.Point(107, 38);
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
            this.lblQtdAdultos.Location = new System.Drawing.Point(15, 38);
            this.lblQtdAdultos.Name = "lblQtdAdultos";
            this.lblQtdAdultos.Size = new System.Drawing.Size(18, 20);
            this.lblQtdAdultos.TabIndex = 248;
            this.lblQtdAdultos.Text = "0";
            // 
            // lblPrAdultos
            // 
            this.lblPrAdultos.AutoSize = true;
            this.lblPrAdultos.BackColor = System.Drawing.Color.White;
            this.lblPrAdultos.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrAdultos.Location = new System.Drawing.Point(240, 38);
            this.lblPrAdultos.Name = "lblPrAdultos";
            this.lblPrAdultos.Size = new System.Drawing.Size(18, 20);
            this.lblPrAdultos.TabIndex = 249;
            this.lblPrAdultos.Text = "0";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Conta";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.White;
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
            // LblExtraAdultos
            // 
            this.LblExtraAdultos.AutoSize = true;
            this.LblExtraAdultos.BackColor = System.Drawing.Color.White;
            this.LblExtraAdultos.Location = new System.Drawing.Point(289, 128);
            this.LblExtraAdultos.Name = "LblExtraAdultos";
            this.LblExtraAdultos.Size = new System.Drawing.Size(63, 20);
            this.LblExtraAdultos.TabIndex = 231;
            this.LblExtraAdultos.Text = "Adultos";
            // 
            // LblExtraCriancas
            // 
            this.LblExtraCriancas.AutoSize = true;
            this.LblExtraCriancas.BackColor = System.Drawing.Color.White;
            this.LblExtraCriancas.Location = new System.Drawing.Point(425, 128);
            this.LblExtraCriancas.Name = "LblExtraCriancas";
            this.LblExtraCriancas.Size = new System.Drawing.Size(71, 20);
            this.LblExtraCriancas.TabIndex = 230;
            this.LblExtraCriancas.Text = "Crianças";
            // 
            // Hospedes
            // 
            this.Hospedes.BackColor = System.Drawing.Color.White;
            this.Hospedes.Controls.Add(this.materialDivider2);
            this.Hospedes.Controls.Add(this.label1);
            this.Hospedes.Controls.Add(this.lblDica);
            this.Hospedes.Controls.Add(this.btnNovoHospede);
            this.Hospedes.Controls.Add(this.label6);
            this.Hospedes.Controls.Add(this.btnVoltar);
            this.Hospedes.Controls.Add(this.btnReservar);
            this.Hospedes.Controls.Add(this.lblVerificar);
            this.Hospedes.Controls.Add(this.btncSearch);
            this.Hospedes.Controls.Add(this.DgvHospedes);
            this.Hospedes.Controls.Add(this.TxtHospede);
            this.Hospedes.Controls.Add(nm_HospedeLabel);
            this.Hospedes.Location = new System.Drawing.Point(4, 20);
            this.Hospedes.Name = "Hospedes";
            this.Hospedes.Padding = new System.Windows.Forms.Padding(3);
            this.Hospedes.Size = new System.Drawing.Size(924, 389);
            this.Hospedes.TabIndex = 1;
            this.Hospedes.Text = "Hospedes";
            this.Hospedes.Click += new System.EventHandler(this.Hospedes_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider2.Location = new System.Drawing.Point(22, 80);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(870, 2);
            this.materialDivider2.TabIndex = 266;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(29, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 265;
            this.label1.Click += new System.EventHandler(this.btnNovoHospede_Click);
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.lblDica.Location = new System.Drawing.Point(147, 31);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(372, 20);
            this.lblDica.TabIndex = 258;
            this.lblDica.Text = "Clique na linha para selecionar o hospede desejado";
            this.lblDica.Visible = false;
            // 
            // btnNovoHospede
            // 
            this.btnNovoHospede.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnNovoHospede.ButtonImage = null;
            this.btnNovoHospede.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNovoHospede.ButtonText = "    Novo Hospede   ";
            this.btnNovoHospede.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnNovoHospede.ClickTextColor = System.Drawing.Color.White;
            this.btnNovoHospede.CornerRadius = 5;
            this.btnNovoHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoHospede.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNovoHospede.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.btnNovoHospede.HoverTextColor = System.Drawing.Color.White;
            this.btnNovoHospede.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNovoHospede.Location = new System.Drawing.Point(22, 348);
            this.btnNovoHospede.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoHospede.Name = "btnNovoHospede";
            this.btnNovoHospede.Padding = new System.Windows.Forms.Padding(5);
            this.btnNovoHospede.Size = new System.Drawing.Size(163, 29);
            this.btnNovoHospede.TabIndex = 264;
            this.btnNovoHospede.TextColor = System.Drawing.Color.White;
            this.btnNovoHospede.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNovoHospede.Click += new System.EventHandler(this.btnNovoHospede_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(736, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 22);
            this.label6.TabIndex = 257;
            this.label6.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnVoltar.ButtonImage = null;
            this.btnVoltar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnVoltar.ButtonText = "   Voltar";
            this.btnVoltar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnVoltar.ClickTextColor = System.Drawing.Color.White;
            this.btnVoltar.CornerRadius = 5;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnVoltar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnVoltar.HoverTextColor = System.Drawing.Color.White;
            this.btnVoltar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnVoltar.Location = new System.Drawing.Point(731, 344);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 29);
            this.btnVoltar.TabIndex = 198;
            this.btnVoltar.TextColor = System.Drawing.Color.White;
            this.btnVoltar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(934, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 39);
            this.btnClose.TabIndex = 261;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // hospedesTableAdapter
            // 
            this.hospedesTableAdapter.ClearBeforeFill = true;
            // 
            // NovaHospedagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 491);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.TabHospedagem);
            this.Controls.Add(this.xuiButton7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovaHospedagem";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaHospedagem";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.NovaHospedagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHospedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            this.TabHospedagem.ResumeLayout(false);
            this.Hospedagem.ResumeLayout(false);
            this.Hospedagem.PerformLayout();
            this.panelConta.ResumeLayout(false);
            this.panelConta.PerformLayout();
            this.Hospedes.ResumeLayout(false);
            this.Hospedes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cbxMaxAdultos;
        private XanderUI.XUIButton btnSelectHospede;
        private System.Windows.Forms.Label LblNomeQuarto;
        private System.Windows.Forms.Label LblCheckIn;
        private MetroFramework.Controls.MetroDateTime DtCheckOut;
        private System.Windows.Forms.Label LblCheckOut;
        private MetroFramework.Controls.MetroComboBox cbxMaxCriancas;
        private System.Windows.Forms.Label btncSearch;
        public System.Windows.Forms.DataGridView DgvHospedes;
        private System.Windows.Forms.Label LblTipoQuarto;
        private XanderUI.XUIButton btnReservar;
        private XanderUI.XUIButton xuiButton7;
        private System.Windows.Forms.Label lblVerificar;
        public System.Windows.Forms.TextBox TxtHospede;
        private MetroFramework.Controls.MetroDateTime DtCheckIn;
        public System.Windows.Forms.Label lblHeader;
        private XanderUI.XUIFlatTab TabHospedagem;
        private System.Windows.Forms.TabPage Hospedagem;
        private System.Windows.Forms.Label LblExtraAdultos;
        private System.Windows.Forms.Label LblExtraCriancas;
        private System.Windows.Forms.TabPage Hospedes;
        private System.Windows.Forms.Label label6;
        private XanderUI.XUIButton btnVoltar;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnNovoHospede;
        private System.Windows.Forms.Panel panelConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrQuarto;
        private XanderUI.XUIButton xuiButton8;
        private System.Windows.Forms.Label lblDiaria;
        private System.Windows.Forms.Label lblQtdDiarias;
        private XanderUI.XUIButton xuiButton5;
        private System.Windows.Forms.Label lblCrianca;
        private System.Windows.Forms.Label lblQtdCriancas;
        private System.Windows.Forms.Label lblPrCriancas;
        private System.Windows.Forms.Label LblAdultos;
        private System.Windows.Forms.Label lblQtdAdultos;
        private System.Windows.Forms.Label lblPrAdultos;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmHospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDocumentoDataGridViewTextBoxColumn;
        public MetroFramework.Controls.MetroComboBox cbxNomeQuarto;
        public MetroFramework.Controls.MetroComboBox cbxTipoQuarto;
        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource hospedesBindingSource;
        private HotelariaDataSetTableAdapters.HospedesTableAdapter hospedesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label lblDisponivel;
        private System.Windows.Forms.Label lblIndisponivel;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDsInfo;
    }
}
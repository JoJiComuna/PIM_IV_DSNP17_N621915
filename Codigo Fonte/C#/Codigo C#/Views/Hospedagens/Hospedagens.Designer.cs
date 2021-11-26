
namespace Hotelaria.Views.Hospedagens
{
    partial class Hospedagens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospedagens));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblHospedagensCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNovoHospedagem = new XanderUI.XUIButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.DgvHospedagens = new System.Windows.Forms.DataGridView();
            this.xuiButton14 = new XanderUI.XUIButton();
            this.xuiButton9 = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCheckinCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.lblReserva = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.lblCanceladas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.btnRefresh = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Label();
            this.hospedagensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.hospedagensTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.HospedagensTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Hospede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdCriancasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHospedagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedagensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.DarkGray;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider1.Location = new System.Drawing.Point(24, 40);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(450, 2);
            this.materialDivider1.TabIndex = 185;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.CausesValidation = false;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.Gray;
            this.TxtSearch.Location = new System.Drawing.Point(25, 19);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.MaxLength = 200;
            this.TxtSearch.Multiline = true;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(415, 20);
            this.TxtSearch.TabIndex = 188;
            this.TxtSearch.Text = "Pesquisar Nº de Hospedagem, Nome...";
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            this.TxtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // LblHospedagensCount
            // 
            this.LblHospedagensCount.AutoSize = true;
            this.LblHospedagensCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.LblHospedagensCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHospedagensCount.ForeColor = System.Drawing.Color.White;
            this.LblHospedagensCount.Location = new System.Drawing.Point(105, 444);
            this.LblHospedagensCount.Name = "LblHospedagensCount";
            this.LblHospedagensCount.Size = new System.Drawing.Size(19, 20);
            this.LblHospedagensCount.TabIndex = 191;
            this.LblHospedagensCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 190;
            this.label1.Text = "Hospedagens";
            // 
            // BtnNovoHospedagem
            // 
            this.BtnNovoHospedagem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnNovoHospedagem.ButtonImage = null;
            this.BtnNovoHospedagem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnNovoHospedagem.ButtonText = "Nova Hospedagem";
            this.BtnNovoHospedagem.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnNovoHospedagem.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoHospedagem.CornerRadius = 5;
            this.BtnNovoHospedagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoHospedagem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoHospedagem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnNovoHospedagem.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoHospedagem.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnNovoHospedagem.Location = new System.Drawing.Point(863, 8);
            this.BtnNovoHospedagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovoHospedagem.Name = "BtnNovoHospedagem";
            this.BtnNovoHospedagem.Size = new System.Drawing.Size(153, 34);
            this.BtnNovoHospedagem.TabIndex = 184;
            this.BtnNovoHospedagem.TextColor = System.Drawing.Color.White;
            this.BtnNovoHospedagem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoHospedagem.Click += new System.EventHandler(this.BtnNovoHospedagem_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider2.Location = new System.Drawing.Point(24, 128);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(993, 2);
            this.materialDivider2.TabIndex = 187;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // DgvHospedagens
            // 
            this.DgvHospedagens.AllowUserToAddRows = false;
            this.DgvHospedagens.AllowUserToDeleteRows = false;
            this.DgvHospedagens.AllowUserToResizeColumns = false;
            this.DgvHospedagens.AllowUserToResizeRows = false;
            this.DgvHospedagens.AutoGenerateColumns = false;
            this.DgvHospedagens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvHospedagens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DgvHospedagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHospedagens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvHospedagens.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvHospedagens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHospedagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHospedagens.ColumnHeadersHeight = 60;
            this.DgvHospedagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvHospedagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.ID_Hospede,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.qtdCriancasDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.Finalizar,
            this.Editar,
            this.Deletar});
            this.DgvHospedagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvHospedagens.DataSource = this.hospedagensBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHospedagens.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvHospedagens.EnableHeadersVisualStyles = false;
            this.DgvHospedagens.GridColor = System.Drawing.Color.Silver;
            this.DgvHospedagens.Location = new System.Drawing.Point(24, 68);
            this.DgvHospedagens.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.DgvHospedagens.MultiSelect = false;
            this.DgvHospedagens.Name = "DgvHospedagens";
            this.DgvHospedagens.ReadOnly = true;
            this.DgvHospedagens.RowHeadersVisible = false;
            this.DgvHospedagens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHospedagens.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvHospedagens.RowTemplate.Height = 28;
            this.DgvHospedagens.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHospedagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHospedagens.ShowCellErrors = false;
            this.DgvHospedagens.ShowCellToolTips = false;
            this.DgvHospedagens.ShowEditingIcon = false;
            this.DgvHospedagens.ShowRowErrors = false;
            this.DgvHospedagens.Size = new System.Drawing.Size(991, 338);
            this.DgvHospedagens.TabIndex = 183;
            this.DgvHospedagens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHospedagens_CellContentClick);
            // 
            // xuiButton14
            // 
            this.xuiButton14.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.xuiButton14.ButtonImage = null;
            this.xuiButton14.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton14.ButtonText = "";
            this.xuiButton14.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton14.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton14.CornerRadius = 9;
            this.xuiButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton14.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton14.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton14.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton14.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton14.Location = new System.Drawing.Point(21, 428);
            this.xuiButton14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton14.MaximumSize = new System.Drawing.Size(1950, 922);
            this.xuiButton14.Name = "xuiButton14";
            this.xuiButton14.Size = new System.Drawing.Size(218, 74);
            this.xuiButton14.TabIndex = 189;
            this.xuiButton14.TextColor = System.Drawing.Color.White;
            this.xuiButton14.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton9
            // 
            this.xuiButton9.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton9.ButtonImage = null;
            this.xuiButton9.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton9.ButtonText = "";
            this.xuiButton9.ClickBackColor = System.Drawing.Color.White;
            this.xuiButton9.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton9.CornerRadius = 9;
            this.xuiButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton9.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton9.HoverBackgroundColor = System.Drawing.Color.White;
            this.xuiButton9.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton9.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton9.Location = new System.Drawing.Point(22, 62);
            this.xuiButton9.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.xuiButton9.MaximumSize = new System.Drawing.Size(2925, 1418);
            this.xuiButton9.Name = "xuiButton9";
            this.xuiButton9.Size = new System.Drawing.Size(995, 348);
            this.xuiButton9.TabIndex = 182;
            this.xuiButton9.TextColor = System.Drawing.Color.White;
            this.xuiButton9.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(44, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 43);
            this.label4.TabIndex = 192;
            // 
            // lblCheckinCount
            // 
            this.lblCheckinCount.AutoSize = true;
            this.lblCheckinCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.lblCheckinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckinCount.ForeColor = System.Drawing.Color.White;
            this.lblCheckinCount.Location = new System.Drawing.Point(331, 444);
            this.lblCheckinCount.Name = "lblCheckinCount";
            this.lblCheckinCount.Size = new System.Drawing.Size(19, 20);
            this.lblCheckinCount.TabIndex = 195;
            this.lblCheckinCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(331, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 194;
            this.label3.Text = "Em Checkin";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(270, 446);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 43);
            this.label5.TabIndex = 196;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 9;
            this.xuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(247, 428);
            this.xuiButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton1.MaximumSize = new System.Drawing.Size(1950, 922);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(218, 74);
            this.xuiButton1.TabIndex = 193;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.lblReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.ForeColor = System.Drawing.Color.White;
            this.lblReserva.Location = new System.Drawing.Point(557, 446);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(19, 20);
            this.lblReserva.TabIndex = 199;
            this.lblReserva.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(557, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 198;
            this.label7.Text = "Em Reserva";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(496, 446);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 43);
            this.label8.TabIndex = 200;
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 9;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(473, 428);
            this.xuiButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton2.MaximumSize = new System.Drawing.Size(1950, 922);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(210, 74);
            this.xuiButton2.TabIndex = 197;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lblCanceladas
            // 
            this.lblCanceladas.AutoSize = true;
            this.lblCanceladas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.lblCanceladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanceladas.ForeColor = System.Drawing.Color.White;
            this.lblCanceladas.Location = new System.Drawing.Point(775, 444);
            this.lblCanceladas.Name = "lblCanceladas";
            this.lblCanceladas.Size = new System.Drawing.Size(19, 20);
            this.lblCanceladas.TabIndex = 203;
            this.lblCanceladas.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(775, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 202;
            this.label10.Text = "Canceladas";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(714, 446);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 43);
            this.label11.TabIndex = 204;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.xuiButton3.ButtonImage = null;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.CornerRadius = 9;
            this.xuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(691, 428);
            this.xuiButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton3.MaximumSize = new System.Drawing.Size(1950, 922);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(210, 74);
            this.xuiButton3.TabIndex = 201;
            this.xuiButton3.TextColor = System.Drawing.Color.White;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(951, 84);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 25);
            this.btnRefresh.TabIndex = 227;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.Location = new System.Drawing.Point(451, 16);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(27, 24);
            this.btnProcurar.TabIndex = 229;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // hospedagensBindingSource
            // 
            this.hospedagensBindingSource.DataMember = "Hospedagens";
            this.hospedagensBindingSource.DataSource = this.hotelariaDataSet;
            // 
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospedagensTableAdapter
            // 
            this.hospedagensTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nr_Hospedagem";
            this.dataGridViewTextBoxColumn2.FillWeight = 60.50267F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nº ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ID_Hospede
            // 
            this.ID_Hospede.DataPropertyName = "Nm_Hospede";
            this.ID_Hospede.FillWeight = 98.31684F;
            this.ID_Hospede.HeaderText = "Nome";
            this.ID_Hospede.Name = "ID_Hospede";
            this.ID_Hospede.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dt_CheckIn";
            this.dataGridViewTextBoxColumn4.FillWeight = 68.06551F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Check-In";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Dt_CheckOut";
            this.dataGridViewTextBoxColumn5.FillWeight = 68.06551F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Check-Out";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nr_Quarto";
            this.dataGridViewTextBoxColumn6.FillWeight = 68.06551F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Nº Quarto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Qtd_Adultos";
            this.dataGridViewTextBoxColumn7.FillWeight = 64.2841F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Adultos";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // qtdCriancasDataGridViewTextBoxColumn
            // 
            this.qtdCriancasDataGridViewTextBoxColumn.DataPropertyName = "Qtd_Criancas";
            this.qtdCriancasDataGridViewTextBoxColumn.FillWeight = 64.2841F;
            this.qtdCriancasDataGridViewTextBoxColumn.HeaderText = "Crianças";
            this.qtdCriancasDataGridViewTextBoxColumn.Name = "qtdCriancasDataGridViewTextBoxColumn";
            this.qtdCriancasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ds_Status";
            this.dataGridViewTextBoxColumn8.FillWeight = 75.62834F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Finalizar
            // 
            this.Finalizar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Finalizar.FillWeight = 215.7874F;
            this.Finalizar.HeaderText = "";
            this.Finalizar.Image = ((System.Drawing.Image)(resources.GetObject("Finalizar.Image")));
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.ReadOnly = true;
            this.Finalizar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Finalizar.Width = 35;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.Description = "Editar";
            this.Editar.FillWeight = 33.61654F;
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.MinimumWidth = 15;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.ToolTipText = "Editar";
            this.Editar.Width = 35;
            // 
            // Deletar
            // 
            this.Deletar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Deletar.Description = "Deletar";
            this.Deletar.FillWeight = 35.54622F;
            this.Deletar.HeaderText = "";
            this.Deletar.Image = ((System.Drawing.Image)(resources.GetObject("Deletar.Image")));
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Deletar.Width = 35;
            // 
            // Hospedagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblCanceladas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.xuiButton3);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.lblCheckinCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblHospedagensCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNovoHospedagem);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.DgvHospedagens);
            this.Controls.Add(this.xuiButton9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xuiButton14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hospedagens";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.Text = "Hospedagens";
            this.Load += new System.EventHandler(this.Hospedagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHospedagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedagensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        public System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblHospedagensCount;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton BtnNovoHospedagem;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        public System.Windows.Forms.DataGridView DgvHospedagens;
        private XanderUI.XUIButton xuiButton14;
        private XanderUI.XUIButton xuiButton9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdCriancaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrHospedagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCheckInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCheckOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdAdultosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsStatusDataGridViewTextBoxColumn;
        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource hospedagensBindingSource;
        private HotelariaDataSetTableAdapters.HospedagensTableAdapter hospedagensTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblCheckinCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private XanderUI.XUIButton xuiButton2;
        private System.Windows.Forms.Label lblCanceladas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private XanderUI.XUIButton xuiButton3;
        private System.Windows.Forms.Label btnRefresh;
        private System.Windows.Forms.Label btnProcurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Hospede;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdCriancasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn Finalizar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
    }
}
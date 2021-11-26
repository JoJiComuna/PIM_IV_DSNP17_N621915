
namespace Hotelaria.Views.Hospedes
{
    partial class Hospedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospedes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvHospedes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mostrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.hospedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.BtnNovoHospede = new XanderUI.XUIButton();
            this.xuiButton14 = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblHospedesCount = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.xuiButton9 = new XanderUI.XUIButton();
            this.hospedesTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.HospedesTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHospedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(30, 441);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 43);
            this.label4.TabIndex = 181;
            // 
            // DgvHospedes
            // 
            this.DgvHospedes.AllowUserToAddRows = false;
            this.DgvHospedes.AllowUserToResizeColumns = false;
            this.DgvHospedes.AllowUserToResizeRows = false;
            this.DgvHospedes.AutoGenerateColumns = false;
            this.DgvHospedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvHospedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DgvHospedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHospedes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvHospedes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvHospedes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHospedes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHospedes.ColumnHeadersHeight = 60;
            this.DgvHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvHospedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Mostrar,
            this.Editar,
            this.Deletar});
            this.DgvHospedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvHospedes.DataSource = this.hospedesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHospedes.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvHospedes.EnableHeadersVisualStyles = false;
            this.DgvHospedes.GridColor = System.Drawing.Color.Silver;
            this.DgvHospedes.Location = new System.Drawing.Point(24, 68);
            this.DgvHospedes.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.DgvHospedes.MultiSelect = false;
            this.DgvHospedes.Name = "DgvHospedes";
            this.DgvHospedes.ReadOnly = true;
            this.DgvHospedes.RowHeadersVisible = false;
            this.DgvHospedes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHospedes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvHospedes.RowTemplate.Height = 28;
            this.DgvHospedes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHospedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHospedes.ShowCellErrors = false;
            this.DgvHospedes.ShowCellToolTips = false;
            this.DgvHospedes.ShowEditingIcon = false;
            this.DgvHospedes.ShowRowErrors = false;
            this.DgvHospedes.Size = new System.Drawing.Size(991, 338);
            this.DgvHospedes.TabIndex = 172;
            this.DgvHospedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHospedes_CellContentClick);
            this.DgvHospedes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvHospedes_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Hospede";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nm_Hospede";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nr_Telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.FillWeight = 120F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Mostrar
            // 
            this.Mostrar.FillWeight = 25F;
            this.Mostrar.HeaderText = "";
            this.Mostrar.Image = ((System.Drawing.Image)(resources.GetObject("Mostrar.Image")));
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.ReadOnly = true;
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
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.DarkGray;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider1.Location = new System.Drawing.Point(24, 40);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(450, 2);
            this.materialDivider1.TabIndex = 174;
            this.materialDivider1.Text = "materialDivider1";
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
            this.materialDivider2.TabIndex = 176;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // BtnNovoHospede
            // 
            this.BtnNovoHospede.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnNovoHospede.ButtonImage = null;
            this.BtnNovoHospede.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnNovoHospede.ButtonText = "Novo Hóspede";
            this.BtnNovoHospede.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnNovoHospede.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoHospede.CornerRadius = 5;
            this.BtnNovoHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoHospede.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoHospede.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnNovoHospede.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoHospede.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnNovoHospede.Location = new System.Drawing.Point(871, 17);
            this.BtnNovoHospede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovoHospede.Name = "BtnNovoHospede";
            this.BtnNovoHospede.Size = new System.Drawing.Size(144, 27);
            this.BtnNovoHospede.TabIndex = 173;
            this.BtnNovoHospede.TextColor = System.Drawing.Color.White;
            this.BtnNovoHospede.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoHospede.Click += new System.EventHandler(this.BtnNovoHospede_Click);
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
            this.xuiButton14.Size = new System.Drawing.Size(204, 74);
            this.xuiButton14.TabIndex = 178;
            this.xuiButton14.TextColor = System.Drawing.Color.White;
            this.xuiButton14.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 179;
            this.label1.Text = "Hóspedes";
            // 
            // LblHospedesCount
            // 
            this.LblHospedesCount.AutoSize = true;
            this.LblHospedesCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.LblHospedesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHospedesCount.ForeColor = System.Drawing.Color.White;
            this.LblHospedesCount.Location = new System.Drawing.Point(91, 441);
            this.LblHospedesCount.Name = "LblHospedesCount";
            this.LblHospedesCount.Size = new System.Drawing.Size(19, 20);
            this.LblHospedesCount.TabIndex = 180;
            this.LblHospedesCount.Text = "0";
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
            this.TxtSearch.TabIndex = 177;
            this.TxtSearch.Text = "Pesquisar por nome, documento...";
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            this.TxtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
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
            this.xuiButton9.TabIndex = 171;
            this.xuiButton9.TextColor = System.Drawing.Color.White;
            this.xuiButton9.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // hospedesTableAdapter
            // 
            this.hospedesTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(951, 79);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 25);
            this.btnRefresh.TabIndex = 222;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.Location = new System.Drawing.Point(452, 16);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(27, 24);
            this.btnProcurar.TabIndex = 230;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // Hospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblHospedesCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNovoHospede);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.DgvHospedes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xuiButton9);
            this.Controls.Add(this.xuiButton14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hospedes";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.Text = "Hospedes";
            this.Load += new System.EventHandler(this.Hospedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHospedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView DgvHospedes;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private XanderUI.XUIButton BtnNovoHospede;
        private XanderUI.XUIButton xuiButton14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblHospedesCount;
        public System.Windows.Forms.TextBox TxtSearch;
        private XanderUI.XUIButton xuiButton9;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmHospedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource hospedesBindingSource;
        private HotelariaDataSetTableAdapters.HospedesTableAdapter hospedesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn Mostrar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
        private System.Windows.Forms.Label btnRefresh;
        private System.Windows.Forms.Label btnProcurar;
    }
}
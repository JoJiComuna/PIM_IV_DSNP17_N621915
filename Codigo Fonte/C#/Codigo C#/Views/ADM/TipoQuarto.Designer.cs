
namespace Hotelaria.Views.ADM
{
    partial class TipoQuarto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoQuarto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNovoTipo = new XanderUI.XUIButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.xuiButton9 = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Label();
            this.dgvTipoQuarto = new System.Windows.Forms.DataGridView();
            this.iDTipoQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmTipoQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAdultosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCriancasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prExtraAdultoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prExtraCriancaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tipoQuartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.tipoQuartoTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.TipoQuartoTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoQuarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovoTipo
            // 
            this.BtnNovoTipo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnNovoTipo.ButtonImage = null;
            this.BtnNovoTipo.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnNovoTipo.ButtonText = "Novo Tipo";
            this.BtnNovoTipo.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnNovoTipo.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoTipo.CornerRadius = 5;
            this.BtnNovoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoTipo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoTipo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnNovoTipo.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoTipo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnNovoTipo.Location = new System.Drawing.Point(912, 9);
            this.BtnNovoTipo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnNovoTipo.Name = "BtnNovoTipo";
            this.BtnNovoTipo.Size = new System.Drawing.Size(102, 33);
            this.BtnNovoTipo.TabIndex = 184;
            this.BtnNovoTipo.TextColor = System.Drawing.Color.White;
            this.BtnNovoTipo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoTipo.Click += new System.EventHandler(this.BtnNovoTipo_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider2.Location = new System.Drawing.Point(21, 123);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(993, 2);
            this.materialDivider2.TabIndex = 187;
            this.materialDivider2.Text = "materialDivider2";
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
            this.xuiButton9.Location = new System.Drawing.Point(19, 57);
            this.xuiButton9.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.xuiButton9.MaximumSize = new System.Drawing.Size(4388, 2182);
            this.xuiButton9.Name = "xuiButton9";
            this.xuiButton9.Size = new System.Drawing.Size(995, 348);
            this.xuiButton9.TabIndex = 182;
            this.xuiButton9.TextColor = System.Drawing.Color.White;
            this.xuiButton9.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 194;
            this.label1.Text = "Tipos de Quartos";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(17, 9);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 25);
            this.btnVoltar.TabIndex = 211;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvTipoQuarto
            // 
            this.dgvTipoQuarto.AllowUserToAddRows = false;
            this.dgvTipoQuarto.AllowUserToDeleteRows = false;
            this.dgvTipoQuarto.AllowUserToResizeColumns = false;
            this.dgvTipoQuarto.AllowUserToResizeRows = false;
            this.dgvTipoQuarto.AutoGenerateColumns = false;
            this.dgvTipoQuarto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoQuarto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvTipoQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipoQuarto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvTipoQuarto.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvTipoQuarto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoQuarto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoQuarto.ColumnHeadersHeight = 60;
            this.dgvTipoQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTipoQuarto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTipoQuartoDataGridViewTextBoxColumn,
            this.nmTipoQuartoDataGridViewTextBoxColumn,
            this.maxAdultosDataGridViewTextBoxColumn,
            this.maxCriancasDataGridViewTextBoxColumn,
            this.prQuartoDataGridViewTextBoxColumn,
            this.prExtraAdultoDataGridViewTextBoxColumn,
            this.prExtraCriancaDataGridViewTextBoxColumn,
            this.dsStatusDataGridViewTextBoxColumn,
            this.Editar,
            this.Deletar});
            this.dgvTipoQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTipoQuarto.DataSource = this.tipoQuartoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoQuarto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipoQuarto.EnableHeadersVisualStyles = false;
            this.dgvTipoQuarto.GridColor = System.Drawing.Color.Silver;
            this.dgvTipoQuarto.Location = new System.Drawing.Point(21, 63);
            this.dgvTipoQuarto.Margin = new System.Windows.Forms.Padding(6, 8, 33, 8);
            this.dgvTipoQuarto.MultiSelect = false;
            this.dgvTipoQuarto.Name = "dgvTipoQuarto";
            this.dgvTipoQuarto.ReadOnly = true;
            this.dgvTipoQuarto.RowHeadersVisible = false;
            this.dgvTipoQuarto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoQuarto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTipoQuarto.RowTemplate.Height = 28;
            this.dgvTipoQuarto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoQuarto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoQuarto.ShowCellErrors = false;
            this.dgvTipoQuarto.ShowCellToolTips = false;
            this.dgvTipoQuarto.ShowEditingIcon = false;
            this.dgvTipoQuarto.ShowRowErrors = false;
            this.dgvTipoQuarto.Size = new System.Drawing.Size(991, 338);
            this.dgvTipoQuarto.TabIndex = 193;
            this.dgvTipoQuarto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoQuarto_CellContentClick);
            this.dgvTipoQuarto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTipoQuarto_CellFormatting);
            // 
            // iDTipoQuartoDataGridViewTextBoxColumn
            // 
            this.iDTipoQuartoDataGridViewTextBoxColumn.DataPropertyName = "ID_TipoQuarto";
            this.iDTipoQuartoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iDTipoQuartoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDTipoQuartoDataGridViewTextBoxColumn.Name = "iDTipoQuartoDataGridViewTextBoxColumn";
            this.iDTipoQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmTipoQuartoDataGridViewTextBoxColumn
            // 
            this.nmTipoQuartoDataGridViewTextBoxColumn.DataPropertyName = "Nm_TipoQuarto";
            this.nmTipoQuartoDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nmTipoQuartoDataGridViewTextBoxColumn.HeaderText = "Nome Tipo Quarto";
            this.nmTipoQuartoDataGridViewTextBoxColumn.Name = "nmTipoQuartoDataGridViewTextBoxColumn";
            this.nmTipoQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxAdultosDataGridViewTextBoxColumn
            // 
            this.maxAdultosDataGridViewTextBoxColumn.DataPropertyName = "Max_Adultos";
            this.maxAdultosDataGridViewTextBoxColumn.FillWeight = 80F;
            this.maxAdultosDataGridViewTextBoxColumn.HeaderText = "Adultos";
            this.maxAdultosDataGridViewTextBoxColumn.Name = "maxAdultosDataGridViewTextBoxColumn";
            this.maxAdultosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxCriancasDataGridViewTextBoxColumn
            // 
            this.maxCriancasDataGridViewTextBoxColumn.DataPropertyName = "Max_Criancas";
            this.maxCriancasDataGridViewTextBoxColumn.FillWeight = 80F;
            this.maxCriancasDataGridViewTextBoxColumn.HeaderText = "Crianças";
            this.maxCriancasDataGridViewTextBoxColumn.Name = "maxCriancasDataGridViewTextBoxColumn";
            this.maxCriancasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prQuartoDataGridViewTextBoxColumn
            // 
            this.prQuartoDataGridViewTextBoxColumn.DataPropertyName = "Pr_Quarto";
            this.prQuartoDataGridViewTextBoxColumn.HeaderText = "R$ - Quarto";
            this.prQuartoDataGridViewTextBoxColumn.Name = "prQuartoDataGridViewTextBoxColumn";
            this.prQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prExtraAdultoDataGridViewTextBoxColumn
            // 
            this.prExtraAdultoDataGridViewTextBoxColumn.DataPropertyName = "Pr_ExtraAdulto";
            this.prExtraAdultoDataGridViewTextBoxColumn.HeaderText = "R$ - Adultos";
            this.prExtraAdultoDataGridViewTextBoxColumn.Name = "prExtraAdultoDataGridViewTextBoxColumn";
            this.prExtraAdultoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prExtraCriancaDataGridViewTextBoxColumn
            // 
            this.prExtraCriancaDataGridViewTextBoxColumn.DataPropertyName = "Pr_ExtraCrianca";
            this.prExtraCriancaDataGridViewTextBoxColumn.HeaderText = "R$ - Crianças";
            this.prExtraCriancaDataGridViewTextBoxColumn.Name = "prExtraCriancaDataGridViewTextBoxColumn";
            this.prExtraCriancaDataGridViewTextBoxColumn.ReadOnly = true;
            this.prExtraCriancaDataGridViewTextBoxColumn.ToolTipText = "Valor por Crianças";
            // 
            // dsStatusDataGridViewTextBoxColumn
            // 
            this.dsStatusDataGridViewTextBoxColumn.DataPropertyName = "Ds_Status";
            this.dsStatusDataGridViewTextBoxColumn.FillWeight = 65F;
            this.dsStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.dsStatusDataGridViewTextBoxColumn.Name = "dsStatusDataGridViewTextBoxColumn";
            this.dsStatusDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tipoQuartoBindingSource
            // 
            this.tipoQuartoBindingSource.DataMember = "TipoQuarto";
            this.tipoQuartoBindingSource.DataSource = this.hotelariaDataSet;
            // 
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoQuartoTableAdapter
            // 
            this.tipoQuartoTableAdapter.ClearBeforeFill = true;
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
            // TipoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.dgvTipoQuarto);
            this.Controls.Add(this.BtnNovoTipo);
            this.Controls.Add(this.xuiButton9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TipoQuarto";
            this.Text = "TipoQuarto";
            this.Load += new System.EventHandler(this.TipoQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoQuarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoQuartoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIButton BtnNovoTipo;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private XanderUI.XUIButton xuiButton9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnVoltar;
        public System.Windows.Forms.DataGridView dgvTipoQuarto;
        private System.Windows.Forms.BindingSource tipoQuartoBindingSource;
        private HotelariaDataSet hotelariaDataSet;
        private HotelariaDataSetTableAdapters.TipoQuartoTableAdapter tipoQuartoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmTipoQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAdultosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCriancasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prExtraAdultoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prExtraCriancaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
        private System.Windows.Forms.Label btnRefresh;
    }
}
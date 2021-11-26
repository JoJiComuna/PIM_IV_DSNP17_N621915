
namespace Hotelaria.Views.ADM
{
    partial class Quartos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quartos));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNovoQuarto = new XanderUI.XUIButton();
            this.xuiButton9 = new XanderUI.XUIButton();
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.quartosTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.QuartosTableAdapter();
            this.DgvQuartos = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btnRefresh = new System.Windows.Forms.Label();
            this.nrQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ds_Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 200;
            this.label1.Text = "Quartos";
            // 
            // BtnNovoQuarto
            // 
            this.BtnNovoQuarto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnNovoQuarto.ButtonImage = null;
            this.BtnNovoQuarto.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnNovoQuarto.ButtonText = "Novo Quarto";
            this.BtnNovoQuarto.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnNovoQuarto.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoQuarto.CornerRadius = 5;
            this.BtnNovoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoQuarto.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoQuarto.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnNovoQuarto.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoQuarto.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnNovoQuarto.Location = new System.Drawing.Point(903, 9);
            this.BtnNovoQuarto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovoQuarto.Name = "BtnNovoQuarto";
            this.BtnNovoQuarto.Size = new System.Drawing.Size(111, 35);
            this.BtnNovoQuarto.TabIndex = 197;
            this.BtnNovoQuarto.TextColor = System.Drawing.Color.White;
            this.BtnNovoQuarto.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoQuarto.Click += new System.EventHandler(this.BtnNovoQuarto_Click);
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
            this.xuiButton9.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.xuiButton9.MaximumSize = new System.Drawing.Size(2925, 1418);
            this.xuiButton9.Name = "xuiButton9";
            this.xuiButton9.Size = new System.Drawing.Size(995, 348);
            this.xuiButton9.TabIndex = 195;
            this.xuiButton9.TextColor = System.Drawing.Color.White;
            this.xuiButton9.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton9.Click += new System.EventHandler(this.xuiButton9_Click);
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "Quartos";
            this.quartosBindingSource.DataSource = this.hotelariaDataSet;
            // 
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quartosTableAdapter
            // 
            this.quartosTableAdapter.ClearBeforeFill = true;
            // 
            // DgvQuartos
            // 
            this.DgvQuartos.AllowUserToAddRows = false;
            this.DgvQuartos.AllowUserToDeleteRows = false;
            this.DgvQuartos.AllowUserToResizeColumns = false;
            this.DgvQuartos.AllowUserToResizeRows = false;
            this.DgvQuartos.AutoGenerateColumns = false;
            this.DgvQuartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvQuartos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DgvQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvQuartos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvQuartos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvQuartos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvQuartos.ColumnHeadersHeight = 60;
            this.DgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrQuartoDataGridViewTextBoxColumn,
            this.iDTipoQuartoDataGridViewTextBoxColumn,
            this.nmQuartoDataGridViewTextBoxColumn,
            this.Ds_Info,
            this.dsStatusDataGridViewTextBoxColumn,
            this.Editar,
            this.Deletar});
            this.DgvQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvQuartos.DataSource = this.quartosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvQuartos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvQuartos.EnableHeadersVisualStyles = false;
            this.DgvQuartos.GridColor = System.Drawing.Color.Silver;
            this.DgvQuartos.Location = new System.Drawing.Point(21, 63);
            this.DgvQuartos.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.DgvQuartos.MultiSelect = false;
            this.DgvQuartos.Name = "DgvQuartos";
            this.DgvQuartos.ReadOnly = true;
            this.DgvQuartos.RowHeadersVisible = false;
            this.DgvQuartos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvQuartos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvQuartos.RowTemplate.Height = 28;
            this.DgvQuartos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvQuartos.ShowCellErrors = false;
            this.DgvQuartos.ShowCellToolTips = false;
            this.DgvQuartos.ShowEditingIcon = false;
            this.DgvQuartos.ShowRowErrors = false;
            this.DgvQuartos.Size = new System.Drawing.Size(991, 338);
            this.DgvQuartos.TabIndex = 202;
            this.DgvQuartos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvQuartos_CellContentClick);
            this.DgvQuartos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvQuartos_CellFormatting);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(17, 9);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 25);
            this.btnVoltar.TabIndex = 211;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider2.Location = new System.Drawing.Point(21, 123);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(993, 2);
            this.materialDivider2.TabIndex = 198;
            this.materialDivider2.Text = "materialDivider2";
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
            this.btnRefresh.TabIndex = 223;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // nrQuartoDataGridViewTextBoxColumn
            // 
            this.nrQuartoDataGridViewTextBoxColumn.DataPropertyName = "Nr_Quarto";
            this.nrQuartoDataGridViewTextBoxColumn.HeaderText = "Nº Quarto";
            this.nrQuartoDataGridViewTextBoxColumn.Name = "nrQuartoDataGridViewTextBoxColumn";
            this.nrQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTipoQuartoDataGridViewTextBoxColumn
            // 
            this.iDTipoQuartoDataGridViewTextBoxColumn.DataPropertyName = "ID_TipoQuarto";
            this.iDTipoQuartoDataGridViewTextBoxColumn.HeaderText = "ID Tipo Quarto";
            this.iDTipoQuartoDataGridViewTextBoxColumn.Name = "iDTipoQuartoDataGridViewTextBoxColumn";
            this.iDTipoQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmQuartoDataGridViewTextBoxColumn
            // 
            this.nmQuartoDataGridViewTextBoxColumn.DataPropertyName = "Nm_Quarto";
            this.nmQuartoDataGridViewTextBoxColumn.HeaderText = "Nome do Quarto";
            this.nmQuartoDataGridViewTextBoxColumn.Name = "nmQuartoDataGridViewTextBoxColumn";
            this.nmQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ds_Info
            // 
            this.Ds_Info.DataPropertyName = "Ds_Info";
            this.Ds_Info.HeaderText = "Descrição";
            this.Ds_Info.Name = "Ds_Info";
            this.Ds_Info.ReadOnly = true;
            // 
            // dsStatusDataGridViewTextBoxColumn
            // 
            this.dsStatusDataGridViewTextBoxColumn.DataPropertyName = "Ds_Status";
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
            // Quartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.DgvQuartos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNovoQuarto);
            this.Controls.Add(this.xuiButton9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Quartos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quartos";
            this.Load += new System.EventHandler(this.Quartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvQuartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton BtnNovoQuarto;
        private XanderUI.XUIButton xuiButton9;
        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private HotelariaDataSetTableAdapters.QuartosTableAdapter quartosTableAdapter;
        public System.Windows.Forms.DataGridView DgvQuartos;
        private System.Windows.Forms.Label btnVoltar;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ds_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
    }
}
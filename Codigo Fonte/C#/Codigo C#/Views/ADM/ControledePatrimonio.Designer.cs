
namespace Hotelaria.Views.ADM
{
    partial class ControledePatrimonio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControledePatrimonio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNovaChavedeSeguranca = new XanderUI.XUIButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.DgvPatrimonio = new System.Windows.Forms.DataGridView();
            this.iDPatrimonioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrQuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmPatrimonioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.controledePatrimonioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.xuiButton9 = new XanderUI.XUIButton();
            this.controledePatrimonioTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.ControledePatrimonioTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatrimonio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledePatrimonioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(17, 16);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 25);
            this.btnVoltar.TabIndex = 225;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(57, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 224;
            this.label2.Text = "Patrimônios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnNovaChavedeSeguranca
            // 
            this.BtnNovaChavedeSeguranca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnNovaChavedeSeguranca.ButtonImage = null;
            this.BtnNovaChavedeSeguranca.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnNovaChavedeSeguranca.ButtonText = "Novo Patrimônio";
            this.BtnNovaChavedeSeguranca.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnNovaChavedeSeguranca.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovaChavedeSeguranca.CornerRadius = 5;
            this.BtnNovaChavedeSeguranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovaChavedeSeguranca.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovaChavedeSeguranca.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnNovaChavedeSeguranca.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovaChavedeSeguranca.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnNovaChavedeSeguranca.Location = new System.Drawing.Point(901, 6);
            this.BtnNovaChavedeSeguranca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovaChavedeSeguranca.Name = "BtnNovaChavedeSeguranca";
            this.BtnNovaChavedeSeguranca.Size = new System.Drawing.Size(111, 38);
            this.BtnNovaChavedeSeguranca.TabIndex = 222;
            this.BtnNovaChavedeSeguranca.TextColor = System.Drawing.Color.White;
            this.BtnNovaChavedeSeguranca.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovaChavedeSeguranca.Click += new System.EventHandler(this.BtnNovaChavedeSeguranca_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider2.Location = new System.Drawing.Point(21, 123);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(991, 2);
            this.materialDivider2.TabIndex = 223;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // DgvPatrimonio
            // 
            this.DgvPatrimonio.AllowUserToAddRows = false;
            this.DgvPatrimonio.AllowUserToResizeColumns = false;
            this.DgvPatrimonio.AllowUserToResizeRows = false;
            this.DgvPatrimonio.AutoGenerateColumns = false;
            this.DgvPatrimonio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPatrimonio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DgvPatrimonio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPatrimonio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvPatrimonio.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvPatrimonio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPatrimonio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPatrimonio.ColumnHeadersHeight = 60;
            this.DgvPatrimonio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvPatrimonio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPatrimonioDataGridViewTextBoxColumn,
            this.nrQuartoDataGridViewTextBoxColumn,
            this.nmPatrimonioDataGridViewTextBoxColumn,
            this.dsStatusDataGridViewTextBoxColumn,
            this.Editar,
            this.Deletar});
            this.DgvPatrimonio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvPatrimonio.DataSource = this.controledePatrimonioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPatrimonio.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPatrimonio.EnableHeadersVisualStyles = false;
            this.DgvPatrimonio.GridColor = System.Drawing.Color.Silver;
            this.DgvPatrimonio.Location = new System.Drawing.Point(21, 63);
            this.DgvPatrimonio.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.DgvPatrimonio.MultiSelect = false;
            this.DgvPatrimonio.Name = "DgvPatrimonio";
            this.DgvPatrimonio.ReadOnly = true;
            this.DgvPatrimonio.RowHeadersVisible = false;
            this.DgvPatrimonio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPatrimonio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPatrimonio.RowTemplate.Height = 28;
            this.DgvPatrimonio.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPatrimonio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPatrimonio.ShowCellErrors = false;
            this.DgvPatrimonio.ShowCellToolTips = false;
            this.DgvPatrimonio.ShowEditingIcon = false;
            this.DgvPatrimonio.ShowRowErrors = false;
            this.DgvPatrimonio.Size = new System.Drawing.Size(989, 297);
            this.DgvPatrimonio.TabIndex = 221;
            this.DgvPatrimonio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPatrimonio_CellContentClick);
            this.DgvPatrimonio.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvPatrimonio_CellFormatting);
            // 
            // iDPatrimonioDataGridViewTextBoxColumn
            // 
            this.iDPatrimonioDataGridViewTextBoxColumn.DataPropertyName = "ID_Patrimonio";
            this.iDPatrimonioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPatrimonioDataGridViewTextBoxColumn.Name = "iDPatrimonioDataGridViewTextBoxColumn";
            this.iDPatrimonioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrQuartoDataGridViewTextBoxColumn
            // 
            this.nrQuartoDataGridViewTextBoxColumn.DataPropertyName = "Nr_Quarto";
            this.nrQuartoDataGridViewTextBoxColumn.HeaderText = "Nº Quarto";
            this.nrQuartoDataGridViewTextBoxColumn.Name = "nrQuartoDataGridViewTextBoxColumn";
            this.nrQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmPatrimonioDataGridViewTextBoxColumn
            // 
            this.nmPatrimonioDataGridViewTextBoxColumn.DataPropertyName = "Nm_Patrimonio";
            this.nmPatrimonioDataGridViewTextBoxColumn.HeaderText = "Nome Patrimonio";
            this.nmPatrimonioDataGridViewTextBoxColumn.Name = "nmPatrimonioDataGridViewTextBoxColumn";
            this.nmPatrimonioDataGridViewTextBoxColumn.ReadOnly = true;
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
            // controledePatrimonioBindingSource
            // 
            this.controledePatrimonioBindingSource.DataMember = "ControledePatrimonio";
            this.controledePatrimonioBindingSource.DataSource = this.hotelariaDataSet;
            // 
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.xuiButton9.Size = new System.Drawing.Size(993, 316);
            this.xuiButton9.TabIndex = 220;
            this.xuiButton9.TextColor = System.Drawing.Color.White;
            this.xuiButton9.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // controledePatrimonioTableAdapter
            // 
            this.controledePatrimonioTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(951, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 226;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.DarkGray;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider1.Location = new System.Drawing.Point(317, 39);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(450, 2);
            this.materialDivider1.TabIndex = 227;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.CausesValidation = false;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.Gray;
            this.TxtSearch.Location = new System.Drawing.Point(319, 17);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.MaxLength = 200;
            this.TxtSearch.Multiline = true;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(415, 20);
            this.TxtSearch.TabIndex = 229;
            this.TxtSearch.Text = "Pesquisar por Nº Quarto, Nome Patrimônio..";
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.Location = new System.Drawing.Point(744, 16);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(27, 24);
            this.btnProcurar.TabIndex = 228;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // ControledePatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNovaChavedeSeguranca);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.DgvPatrimonio);
            this.Controls.Add(this.xuiButton9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControledePatrimonio";
            this.Text = "ControledePatrimonio";
            this.Load += new System.EventHandler(this.ControledePatrimonio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatrimonio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledePatrimonioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnVoltar;
        public System.Windows.Forms.Label label2;
        private XanderUI.XUIButton BtnNovaChavedeSeguranca;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        public System.Windows.Forms.DataGridView DgvPatrimonio;
        private XanderUI.XUIButton xuiButton9;
        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource controledePatrimonioBindingSource;
        private HotelariaDataSetTableAdapters.ControledePatrimonioTableAdapter controledePatrimonioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPatrimonioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrQuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmPatrimonioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        public System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label btnProcurar;
    }
}
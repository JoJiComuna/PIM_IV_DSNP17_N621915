
namespace Hotelaria.Views.Hospedes
{
    partial class HospedesInativos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospedesInativos));
            this.hospedesTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.HospedesTableAdapter();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.hospedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DgvHospedes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.xuiButton9 = new XanderUI.XUIButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // hospedesTableAdapter
            // 
            this.hospedesTableAdapter.ClearBeforeFill = true;
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
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospedesBindingSource
            // 
            this.hospedesBindingSource.DataMember = "Hospedes";
            this.hospedesBindingSource.DataSource = this.hotelariaDataSet;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHospedes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvHospedes.ColumnHeadersHeight = 60;
            this.DgvHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvHospedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Editar});
            this.DgvHospedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvHospedes.DataSource = this.hospedesBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHospedes.DefaultCellStyle = dataGridViewCellStyle11;
            this.DgvHospedes.EnableHeadersVisualStyles = false;
            this.DgvHospedes.GridColor = System.Drawing.Color.Silver;
            this.DgvHospedes.Location = new System.Drawing.Point(24, 68);
            this.DgvHospedes.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.DgvHospedes.MultiSelect = false;
            this.DgvHospedes.Name = "DgvHospedes";
            this.DgvHospedes.ReadOnly = true;
            this.DgvHospedes.RowHeadersVisible = false;
            this.DgvHospedes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHospedes.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvHospedes.RowTemplate.Height = 28;
            this.DgvHospedes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHospedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHospedes.ShowCellErrors = false;
            this.DgvHospedes.ShowCellToolTips = false;
            this.DgvHospedes.ShowEditingIcon = false;
            this.DgvHospedes.ShowRowErrors = false;
            this.DgvHospedes.Size = new System.Drawing.Size(991, 338);
            this.DgvHospedes.TabIndex = 183;
            this.DgvHospedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHospedes_CellContentClick);
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
            this.xuiButton9.Location = new System.Drawing.Point(21, 57);
            this.xuiButton9.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.xuiButton9.MaximumSize = new System.Drawing.Size(2925, 1418);
            this.xuiButton9.Name = "xuiButton9";
            this.xuiButton9.Size = new System.Drawing.Size(995, 348);
            this.xuiButton9.TabIndex = 182;
            this.xuiButton9.TextColor = System.Drawing.Color.White;
            this.xuiButton9.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.DarkGray;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider1.Location = new System.Drawing.Point(563, 35);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(450, 2);
            this.materialDivider1.TabIndex = 193;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.CausesValidation = false;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.Gray;
            this.TxtSearch.Location = new System.Drawing.Point(563, 14);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.MaxLength = 200;
            this.TxtSearch.Multiline = true;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(415, 20);
            this.TxtSearch.TabIndex = 195;
            this.TxtSearch.Text = "Pesquisar por nome, documento...";
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            this.TxtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.Location = new System.Drawing.Point(990, 12);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(27, 25);
            this.btnProcurar.TabIndex = 194;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(20, 14);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 25);
            this.btnVoltar.TabIndex = 227;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(60, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 226;
            this.label2.Text = "Hóspedes Inativos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
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
            this.btnRefresh.TabIndex = 228;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // HospedesInativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.DgvHospedes);
            this.Controls.Add(this.xuiButton9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(951, 79);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HospedesInativos";
            this.Text = "HospedesInativos";
            this.Load += new System.EventHandler(this.HospedesInativos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelariaDataSetTableAdapters.HospedesTableAdapter hospedesTableAdapter;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource hospedesBindingSource;
        public System.Windows.Forms.DataGridView DgvHospedes;
        private XanderUI.XUIButton xuiButton9;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        public System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label btnProcurar;
        private System.Windows.Forms.Label btnVoltar;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}
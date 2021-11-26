
namespace Hotelaria.Views.ADM
{
    partial class ChavedeSeguranca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChavedeSeguranca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNovaChavedeSeguranca = new XanderUI.XUIButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.DgvChave = new System.Windows.Forms.DataGridView();
            this.iDChavedeSegurancaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrChavedeSegurancaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.chaveDeSegurancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.xuiButton9 = new XanderUI.XUIButton();
            this.chaveDeSegurancaTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.ChaveDeSegurancaTableAdapter();
            this.tableAdapterManager = new Hotelaria.HotelariaDataSetTableAdapters.TableAdapterManager();
            this.btnRefresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvChave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaveDeSegurancaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(18, 6);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(27, 25);
            this.btnVoltar.TabIndex = 219;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(58, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 218;
            this.label2.Text = "Chaves de Segurança";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // BtnNovaChavedeSeguranca
            // 
            this.BtnNovaChavedeSeguranca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnNovaChavedeSeguranca.ButtonImage = null;
            this.BtnNovaChavedeSeguranca.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnNovaChavedeSeguranca.ButtonText = "Nova Chave";
            this.BtnNovaChavedeSeguranca.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnNovaChavedeSeguranca.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovaChavedeSeguranca.CornerRadius = 5;
            this.BtnNovaChavedeSeguranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovaChavedeSeguranca.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovaChavedeSeguranca.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnNovaChavedeSeguranca.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovaChavedeSeguranca.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnNovaChavedeSeguranca.Location = new System.Drawing.Point(902, 6);
            this.BtnNovaChavedeSeguranca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovaChavedeSeguranca.Name = "BtnNovaChavedeSeguranca";
            this.BtnNovaChavedeSeguranca.Size = new System.Drawing.Size(111, 35);
            this.BtnNovaChavedeSeguranca.TabIndex = 213;
            this.BtnNovaChavedeSeguranca.TextColor = System.Drawing.Color.White;
            this.BtnNovaChavedeSeguranca.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovaChavedeSeguranca.Click += new System.EventHandler(this.BtnNovaChavedeSeguranca_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider2.Location = new System.Drawing.Point(22, 120);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(991, 2);
            this.materialDivider2.TabIndex = 216;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // DgvChave
            // 
            this.DgvChave.AllowUserToAddRows = false;
            this.DgvChave.AllowUserToResizeColumns = false;
            this.DgvChave.AllowUserToResizeRows = false;
            this.DgvChave.AutoGenerateColumns = false;
            this.DgvChave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvChave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DgvChave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvChave.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvChave.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvChave.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvChave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvChave.ColumnHeadersHeight = 60;
            this.DgvChave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvChave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDChavedeSegurancaDataGridViewTextBoxColumn,
            this.nrChavedeSegurancaDataGridViewTextBoxColumn,
            this.dsStatusDataGridViewTextBoxColumn,
            this.Editar,
            this.Deletar});
            this.DgvChave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvChave.DataSource = this.chaveDeSegurancaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvChave.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvChave.EnableHeadersVisualStyles = false;
            this.DgvChave.GridColor = System.Drawing.Color.Silver;
            this.DgvChave.Location = new System.Drawing.Point(22, 60);
            this.DgvChave.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.DgvChave.MultiSelect = false;
            this.DgvChave.Name = "DgvChave";
            this.DgvChave.ReadOnly = true;
            this.DgvChave.RowHeadersVisible = false;
            this.DgvChave.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvChave.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvChave.RowTemplate.Height = 28;
            this.DgvChave.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvChave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvChave.ShowCellErrors = false;
            this.DgvChave.ShowCellToolTips = false;
            this.DgvChave.ShowEditingIcon = false;
            this.DgvChave.ShowRowErrors = false;
            this.DgvChave.Size = new System.Drawing.Size(989, 297);
            this.DgvChave.TabIndex = 212;
            this.DgvChave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChave_CellContentClick);
            this.DgvChave.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvChave_CellFormatting);
            // 
            // iDChavedeSegurancaDataGridViewTextBoxColumn
            // 
            this.iDChavedeSegurancaDataGridViewTextBoxColumn.DataPropertyName = "ID_ChavedeSeguranca";
            this.iDChavedeSegurancaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDChavedeSegurancaDataGridViewTextBoxColumn.Name = "iDChavedeSegurancaDataGridViewTextBoxColumn";
            this.iDChavedeSegurancaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrChavedeSegurancaDataGridViewTextBoxColumn
            // 
            this.nrChavedeSegurancaDataGridViewTextBoxColumn.DataPropertyName = "Nr_ChavedeSeguranca";
            this.nrChavedeSegurancaDataGridViewTextBoxColumn.HeaderText = "Nº";
            this.nrChavedeSegurancaDataGridViewTextBoxColumn.Name = "nrChavedeSegurancaDataGridViewTextBoxColumn";
            this.nrChavedeSegurancaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // chaveDeSegurancaBindingSource
            // 
            this.chaveDeSegurancaBindingSource.DataMember = "ChaveDeSeguranca";
            this.chaveDeSegurancaBindingSource.DataSource = this.hotelariaDataSet;
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
            this.xuiButton9.Location = new System.Drawing.Point(20, 54);
            this.xuiButton9.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.xuiButton9.MaximumSize = new System.Drawing.Size(2925, 1418);
            this.xuiButton9.Name = "xuiButton9";
            this.xuiButton9.Size = new System.Drawing.Size(993, 316);
            this.xuiButton9.TabIndex = 211;
            this.xuiButton9.TextColor = System.Drawing.Color.White;
            this.xuiButton9.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton9.Click += new System.EventHandler(this.xuiButton9_Click);
            // 
            // chaveDeSegurancaTableAdapter
            // 
            this.chaveDeSegurancaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChaveDeSegurancaTableAdapter = this.chaveDeSegurancaTableAdapter;
            this.tableAdapterManager.ControledePatrimonioTableAdapter = null;
            this.tableAdapterManager.EnderecoTableAdapter = null;
            this.tableAdapterManager.HospedagensTableAdapter = null;
            this.tableAdapterManager.HospedesTableAdapter = null;
            this.tableAdapterManager.LoginHospedeTableAdapter = null;
            this.tableAdapterManager.LoginUsuarioTableAdapter = null;
            this.tableAdapterManager.PagamentosTableAdapter = null;
            this.tableAdapterManager.QuartosTableAdapter = null;
            this.tableAdapterManager.TipoQuartoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotelaria.HotelariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
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
            this.btnRefresh.TabIndex = 221;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ChavedeSeguranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNovaChavedeSeguranca);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.DgvChave);
            this.Controls.Add(this.xuiButton9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChavedeSeguranca";
            this.Text = "ChavedeSeguranca";
            this.Load += new System.EventHandler(this.ChavedeSeguranca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvChave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaveDeSegurancaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnVoltar;
        public System.Windows.Forms.Label label2;
        private XanderUI.XUIButton BtnNovaChavedeSeguranca;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        public System.Windows.Forms.DataGridView DgvChave;
        private XanderUI.XUIButton xuiButton9;
        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource chaveDeSegurancaBindingSource;
        private HotelariaDataSetTableAdapters.ChaveDeSegurancaTableAdapter chaveDeSegurancaTableAdapter;
        private HotelariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDChavedeSegurancaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrChavedeSegurancaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
        private System.Windows.Forms.Label btnRefresh;
    }
}
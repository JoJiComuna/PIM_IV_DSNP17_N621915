
namespace Hotelaria.Views.ADM
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblUserCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNovoUsuario = new XanderUI.XUIButton();
            this.btnProcurar = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.xuiButton14 = new XanderUI.XUIButton();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.iDUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ds_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mostrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.xuiButton9 = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Label();
            this.usuarioTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.UsuarioTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.DarkGray;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider1.Location = new System.Drawing.Point(288, 39);
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
            this.TxtSearch.Location = new System.Drawing.Point(290, 17);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.MaxLength = 200;
            this.TxtSearch.Multiline = true;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(415, 20);
            this.TxtSearch.TabIndex = 188;
            this.TxtSearch.Text = "Pesquisar por nome, documento...";
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            this.TxtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // LblUserCount
            // 
            this.LblUserCount.AutoSize = true;
            this.LblUserCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.LblUserCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserCount.ForeColor = System.Drawing.Color.White;
            this.LblUserCount.Location = new System.Drawing.Point(88, 436);
            this.LblUserCount.Name = "LblUserCount";
            this.LblUserCount.Size = new System.Drawing.Size(19, 20);
            this.LblUserCount.TabIndex = 191;
            this.LblUserCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 190;
            this.label1.Text = "Usuários";
            // 
            // BtnNovoUsuario
            // 
            this.BtnNovoUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnNovoUsuario.ButtonImage = null;
            this.BtnNovoUsuario.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnNovoUsuario.ButtonText = "Novo Usuário";
            this.BtnNovoUsuario.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnNovoUsuario.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoUsuario.CornerRadius = 5;
            this.BtnNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoUsuario.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoUsuario.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnNovoUsuario.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnNovoUsuario.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnNovoUsuario.Location = new System.Drawing.Point(903, 9);
            this.BtnNovoUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNovoUsuario.Name = "BtnNovoUsuario";
            this.BtnNovoUsuario.Size = new System.Drawing.Size(111, 35);
            this.BtnNovoUsuario.TabIndex = 184;
            this.BtnNovoUsuario.TextColor = System.Drawing.Color.White;
            this.BtnNovoUsuario.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnNovoUsuario.Click += new System.EventHandler(this.BtnNovoUsuario_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.Location = new System.Drawing.Point(715, 16);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(27, 24);
            this.btnProcurar.TabIndex = 186;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider2.Location = new System.Drawing.Point(22, 128);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(993, 2);
            this.materialDivider2.TabIndex = 187;
            this.materialDivider2.Text = "materialDivider2";
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
            this.xuiButton14.Location = new System.Drawing.Point(19, 418);
            this.xuiButton14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiButton14.MaximumSize = new System.Drawing.Size(1950, 922);
            this.xuiButton14.Name = "xuiButton14";
            this.xuiButton14.Size = new System.Drawing.Size(204, 74);
            this.xuiButton14.TabIndex = 189;
            this.xuiButton14.TextColor = System.Drawing.Color.White;
            this.xuiButton14.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton14.Click += new System.EventHandler(this.xuiButton14_Click);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToResizeColumns = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            this.DgvUsuarios.AutoGenerateColumns = false;
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvUsuarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvUsuarios.ColumnHeadersHeight = 60;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUsuarioDataGridViewTextBoxColumn,
            this.nmUsuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.nrDocumentoDataGridViewTextBoxColumn,
            this.Ds_Status,
            this.Mostrar,
            this.Editar,
            this.Deletar});
            this.DgvUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvUsuarios.DataSource = this.usuarioBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvUsuarios.EnableHeadersVisualStyles = false;
            this.DgvUsuarios.GridColor = System.Drawing.Color.Silver;
            this.DgvUsuarios.Location = new System.Drawing.Point(23, 67);
            this.DgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 22, 5);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvUsuarios.RowTemplate.Height = 28;
            this.DgvUsuarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.ShowCellErrors = false;
            this.DgvUsuarios.ShowEditingIcon = false;
            this.DgvUsuarios.ShowRowErrors = false;
            this.DgvUsuarios.Size = new System.Drawing.Size(991, 338);
            this.DgvUsuarios.TabIndex = 183;
            this.DgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellContentClick);
            this.DgvUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvUsuarios_CellFormatting);
            // 
            // iDUsuarioDataGridViewTextBoxColumn
            // 
            this.iDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDUsuarioDataGridViewTextBoxColumn.Name = "iDUsuarioDataGridViewTextBoxColumn";
            this.iDUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmUsuarioDataGridViewTextBoxColumn
            // 
            this.nmUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Nm_Usuario";
            this.nmUsuarioDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nmUsuarioDataGridViewTextBoxColumn.Name = "nmUsuarioDataGridViewTextBoxColumn";
            this.nmUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrDocumentoDataGridViewTextBoxColumn
            // 
            this.nrDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Nr_Documento";
            this.nrDocumentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.nrDocumentoDataGridViewTextBoxColumn.Name = "nrDocumentoDataGridViewTextBoxColumn";
            this.nrDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ds_Status
            // 
            this.Ds_Status.DataPropertyName = "Ds_Status";
            this.Ds_Status.HeaderText = "Status";
            this.Ds_Status.Name = "Ds_Status";
            this.Ds_Status.ReadOnly = true;
            // 
            // Mostrar
            // 
            this.Mostrar.Description = "Mostrar";
            this.Mostrar.FillWeight = 33F;
            this.Mostrar.HeaderText = "";
            this.Mostrar.Image = ((System.Drawing.Image)(resources.GetObject("Mostrar.Image")));
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.ReadOnly = true;
            this.Mostrar.ToolTipText = "Mostrar";
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
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.hotelariaDataSet;
            // 
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(27, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 43);
            this.label4.TabIndex = 192;
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
            this.xuiButton9.TabIndex = 182;
            this.xuiButton9.TextColor = System.Drawing.Color.White;
            this.xuiButton9.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 209;
            this.label2.Text = "Usuários";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
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
            this.btnVoltar.TabIndex = 210;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
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
            this.label3.TabIndex = 218;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblUserCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNovoUsuario);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xuiButton9);
            this.Controls.Add(this.xuiButton14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        public System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblUserCount;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton BtnNovoUsuario;
        private System.Windows.Forms.Label btnProcurar;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private XanderUI.XUIButton xuiButton14;
        public System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Label label4;
        private XanderUI.XUIButton xuiButton9;
        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private HotelariaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnVoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ds_Status;
        private System.Windows.Forms.DataGridViewImageColumn Mostrar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
    }
}
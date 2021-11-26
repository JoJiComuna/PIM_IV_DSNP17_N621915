
namespace Hotelaria.Views.ADM
{
    partial class NovoQuarto
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
            System.Windows.Forms.Label nm_QuartoLabel;
            System.Windows.Forms.Label iD_TipoQuartoLabel;
            System.Windows.Forms.Label ds_StatusLabel;
            XanderUI.XUIButton xuiButton7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoQuarto));
            System.Windows.Forms.Label label2;
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartosTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.QuartosTableAdapter();
            this.tableAdapterManager = new Hotelaria.HotelariaDataSetTableAdapters.TableAdapterManager();
            this.txtNmQuarto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Label();
            this.BtnSave = new XanderUI.XUIButton();
            this.btnAtivo = new MetroFramework.Controls.MetroRadioButton();
            this.btnInativo = new MetroFramework.Controls.MetroRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTipoQuarto = new MetroFramework.Controls.MetroComboBox();
            this.txtDsQuarto = new System.Windows.Forms.TextBox();
            nm_QuartoLabel = new System.Windows.Forms.Label();
            iD_TipoQuartoLabel = new System.Windows.Forms.Label();
            ds_StatusLabel = new System.Windows.Forms.Label();
            xuiButton7 = new XanderUI.XUIButton();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nm_QuartoLabel
            // 
            nm_QuartoLabel.AutoSize = true;
            nm_QuartoLabel.BackColor = System.Drawing.Color.White;
            nm_QuartoLabel.Location = new System.Drawing.Point(15, 80);
            nm_QuartoLabel.Name = "nm_QuartoLabel";
            nm_QuartoLabel.Size = new System.Drawing.Size(126, 20);
            nm_QuartoLabel.TabIndex = 1;
            nm_QuartoLabel.Text = "Nome do Quarto";
            // 
            // iD_TipoQuartoLabel
            // 
            iD_TipoQuartoLabel.AutoSize = true;
            iD_TipoQuartoLabel.BackColor = System.Drawing.Color.White;
            iD_TipoQuartoLabel.Location = new System.Drawing.Point(15, 155);
            iD_TipoQuartoLabel.Name = "iD_TipoQuartoLabel";
            iD_TipoQuartoLabel.Size = new System.Drawing.Size(92, 20);
            iD_TipoQuartoLabel.TabIndex = 3;
            iD_TipoQuartoLabel.Text = "Tipo Quarto";
            // 
            // ds_StatusLabel
            // 
            ds_StatusLabel.AutoSize = true;
            ds_StatusLabel.BackColor = System.Drawing.Color.White;
            ds_StatusLabel.Location = new System.Drawing.Point(15, 233);
            ds_StatusLabel.Name = "ds_StatusLabel";
            ds_StatusLabel.Size = new System.Drawing.Size(56, 20);
            ds_StatusLabel.TabIndex = 5;
            ds_StatusLabel.Text = "Status";
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
            xuiButton7.Location = new System.Drawing.Point(15, 6);
            xuiButton7.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            xuiButton7.MaximumSize = new System.Drawing.Size(2925, 1418);
            xuiButton7.Name = "xuiButton7";
            xuiButton7.Size = new System.Drawing.Size(278, 496);
            xuiButton7.TabIndex = 207;
            xuiButton7.TextColor = System.Drawing.Color.White;
            xuiButton7.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "Quartos";
            this.quartosBindingSource.DataSource = this.hotelariaDataSet;
            // 
            // quartosTableAdapter
            // 
            this.quartosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChaveDeSegurancaTableAdapter = null;
            this.tableAdapterManager.ControledePatrimonioTableAdapter = null;
            this.tableAdapterManager.EnderecoTableAdapter = null;
            this.tableAdapterManager.HospedagensTableAdapter = null;
            this.tableAdapterManager.HospedesTableAdapter = null;
            this.tableAdapterManager.LoginHospedeTableAdapter = null;
            this.tableAdapterManager.LoginUsuarioTableAdapter = null;
            this.tableAdapterManager.PagamentosTableAdapter = null;
            this.tableAdapterManager.QuartosTableAdapter = this.quartosTableAdapter;
            this.tableAdapterManager.TipoQuartoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotelaria.HotelariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // txtNmQuarto
            // 
            this.txtNmQuarto.Location = new System.Drawing.Point(19, 103);
            this.txtNmQuarto.Name = "txtNmQuarto";
            this.txtNmQuarto.Size = new System.Drawing.Size(220, 26);
            this.txtNmQuarto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Novo Quarto";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(213, 4);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(36, 25);
            this.BtnClose.TabIndex = 208;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnSave.ButtonImage = null;
            this.BtnSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnSave.ButtonText = "Salvar";
            this.BtnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSave.CornerRadius = 5;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnSave.Location = new System.Drawing.Point(161, 424);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(78, 38);
            this.BtnSave.TabIndex = 205;
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnAtivo
            // 
            this.btnAtivo.AutoSize = true;
            this.btnAtivo.Checked = true;
            this.btnAtivo.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.btnAtivo.Location = new System.Drawing.Point(28, 256);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(70, 25);
            this.btnAtivo.TabIndex = 209;
            this.btnAtivo.TabStop = true;
            this.btnAtivo.Text = "Ativo";
            this.btnAtivo.UseSelectable = true;
            this.btnAtivo.CheckedChanged += new System.EventHandler(this.btnAtivo_CheckedChanged);
            // 
            // btnInativo
            // 
            this.btnInativo.AutoSize = true;
            this.btnInativo.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.btnInativo.Location = new System.Drawing.Point(104, 256);
            this.btnInativo.Name = "btnInativo";
            this.btnInativo.Size = new System.Drawing.Size(82, 25);
            this.btnInativo.TabIndex = 210;
            this.btnInativo.Text = "Inativo";
            this.btnInativo.UseSelectable = true;
            this.btnInativo.CheckedChanged += new System.EventHandler(this.btnInativo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(ds_StatusLabel);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtDsQuarto);
            this.panel1.Controls.Add(this.btnInativo);
            this.panel1.Controls.Add(this.cbxTipoQuarto);
            this.panel1.Controls.Add(this.btnAtivo);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNmQuarto);
            this.panel1.Controls.Add(nm_QuartoLabel);
            this.panel1.Controls.Add(iD_TipoQuartoLabel);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 467);
            this.panel1.TabIndex = 213;
            // 
            // cbxTipoQuarto
            // 
            this.cbxTipoQuarto.BackColor = System.Drawing.Color.White;
            this.cbxTipoQuarto.FormattingEnabled = true;
            this.cbxTipoQuarto.ItemHeight = 23;
            this.cbxTipoQuarto.Location = new System.Drawing.Point(19, 178);
            this.cbxTipoQuarto.Name = "cbxTipoQuarto";
            this.cbxTipoQuarto.Size = new System.Drawing.Size(220, 29);
            this.cbxTipoQuarto.TabIndex = 209;
            this.cbxTipoQuarto.UseSelectable = true;
            // 
            // txtDsQuarto
            // 
            this.txtDsQuarto.Location = new System.Drawing.Point(19, 329);
            this.txtDsQuarto.Multiline = true;
            this.txtDsQuarto.Name = "txtDsQuarto";
            this.txtDsQuarto.Size = new System.Drawing.Size(221, 87);
            this.txtDsQuarto.TabIndex = 211;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(14, 306);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 20);
            label2.TabIndex = 212;
            label2.Text = "Tipo Quarto";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NovoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(xuiButton7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovoQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoQuarto";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.NovoQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private HotelariaDataSetTableAdapters.QuartosTableAdapter quartosTableAdapter;
        private HotelariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BtnClose;
        private MetroFramework.Controls.MetroRadioButton btnAtivo;
        private MetroFramework.Controls.MetroRadioButton btnInativo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtNmQuarto;
        public MetroFramework.Controls.MetroComboBox cbxTipoQuarto;
        public XanderUI.XUIButton BtnSave;
        public System.Windows.Forms.TextBox txtDsQuarto;
    }
}
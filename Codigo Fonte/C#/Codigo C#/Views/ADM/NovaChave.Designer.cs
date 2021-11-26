
namespace Hotelaria.Views.ADM
{
    partial class NovaChave
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
            System.Windows.Forms.Label nr_ChavedeSegurancaLabel;
            System.Windows.Forms.Label label1;
            XanderUI.XUIButton xuiButton7;
            System.Windows.Forms.Label ds_StatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaChave));
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.chaveDeSegurancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chaveDeSegurancaTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.ChaveDeSegurancaTableAdapter();
            this.tableAdapterManager = new Hotelaria.HotelariaDataSetTableAdapters.TableAdapterManager();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new XanderUI.XUIButton();
            this.BtnSalvar = new XanderUI.XUIButton();
            this.BtnClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInativo = new MetroFramework.Controls.MetroRadioButton();
            this.btnAtivo = new MetroFramework.Controls.MetroRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            nr_ChavedeSegurancaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            xuiButton7 = new XanderUI.XUIButton();
            ds_StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaveDeSegurancaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nr_ChavedeSegurancaLabel
            // 
            nr_ChavedeSegurancaLabel.AutoSize = true;
            nr_ChavedeSegurancaLabel.BackColor = System.Drawing.Color.White;
            nr_ChavedeSegurancaLabel.Location = new System.Drawing.Point(17, 67);
            nr_ChavedeSegurancaLabel.Name = "nr_ChavedeSegurancaLabel";
            nr_ChavedeSegurancaLabel.Size = new System.Drawing.Size(97, 20);
            nr_ChavedeSegurancaLabel.TabIndex = 1;
            nr_ChavedeSegurancaLabel.Text = "Nº da Chave";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(16, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 25);
            label1.TabIndex = 216;
            label1.Text = "Nova Chave";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            xuiButton7.Location = new System.Drawing.Point(15, 8);
            xuiButton7.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            xuiButton7.MaximumSize = new System.Drawing.Size(2925, 1418);
            xuiButton7.Name = "xuiButton7";
            xuiButton7.Size = new System.Drawing.Size(256, 298);
            xuiButton7.TabIndex = 217;
            xuiButton7.TextColor = System.Drawing.Color.White;
            xuiButton7.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // ds_StatusLabel
            // 
            ds_StatusLabel.AutoSize = true;
            ds_StatusLabel.BackColor = System.Drawing.Color.White;
            ds_StatusLabel.Location = new System.Drawing.Point(17, 134);
            ds_StatusLabel.Name = "ds_StatusLabel";
            ds_StatusLabel.Size = new System.Drawing.Size(56, 20);
            ds_StatusLabel.TabIndex = 261;
            ds_StatusLabel.Text = "Status";
            // 
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chaveDeSegurancaBindingSource
            // 
            this.chaveDeSegurancaBindingSource.DataMember = "ChaveDeSeguranca";
            this.chaveDeSegurancaBindingSource.DataSource = this.hotelariaDataSet;
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
            // txtChave
            // 
            this.txtChave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chaveDeSegurancaBindingSource, "Nr_ChavedeSeguranca", true));
            this.txtChave.Location = new System.Drawing.Point(21, 90);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(190, 26);
            this.txtChave.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.BtnCancelar.ButtonImage = null;
            this.BtnCancelar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnCancelar.ButtonText = "Cancelar";
            this.BtnCancelar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnCancelar.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.CornerRadius = 5;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCancelar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnCancelar.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnCancelar.Location = new System.Drawing.Point(19, 211);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 44);
            this.BtnCancelar.TabIndex = 213;
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.BtnSalvar.ButtonImage = null;
            this.BtnSalvar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.BtnSalvar.ButtonText = "Salvar";
            this.BtnSalvar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.BtnSalvar.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSalvar.CornerRadius = 5;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSalvar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.BtnSalvar.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.BtnSalvar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BtnSalvar.Location = new System.Drawing.Point(133, 211);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(78, 44);
            this.BtnSalvar.TabIndex = 212;
            this.BtnSalvar.TextColor = System.Drawing.Color.White;
            this.BtnSalvar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(193, 4);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(36, 25);
            this.BtnClose.TabIndex = 218;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnInativo);
            this.panel1.Controls.Add(this.btnAtivo);
            this.panel1.Controls.Add(ds_StatusLabel);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(nr_ChavedeSegurancaLabel);
            this.panel1.Controls.Add(this.txtChave);
            this.panel1.Location = new System.Drawing.Point(26, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 278);
            this.panel1.TabIndex = 219;
            // 
            // btnInativo
            // 
            this.btnInativo.AutoSize = true;
            this.btnInativo.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.btnInativo.Location = new System.Drawing.Point(97, 157);
            this.btnInativo.Name = "btnInativo";
            this.btnInativo.Size = new System.Drawing.Size(82, 25);
            this.btnInativo.TabIndex = 263;
            this.btnInativo.Text = "Inativo";
            this.btnInativo.UseSelectable = true;
            this.btnInativo.CheckedChanged += new System.EventHandler(this.btnInativo_CheckedChanged);
            // 
            // btnAtivo
            // 
            this.btnAtivo.AutoSize = true;
            this.btnAtivo.Checked = true;
            this.btnAtivo.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.btnAtivo.Location = new System.Drawing.Point(21, 157);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(70, 25);
            this.btnAtivo.TabIndex = 262;
            this.btnAtivo.TabStop = true;
            this.btnAtivo.Text = "Ativo";
            this.btnAtivo.UseSelectable = true;
            this.btnAtivo.CheckedChanged += new System.EventHandler(this.btnAtivo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(26, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 278);
            this.panel2.TabIndex = 220;
            // 
            // NovaChave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(xuiButton7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovaChave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaChave";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.NovaChave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaveDeSegurancaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource chaveDeSegurancaBindingSource;
        private HotelariaDataSetTableAdapters.ChaveDeSegurancaTableAdapter chaveDeSegurancaTableAdapter;
        private HotelariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private XanderUI.XUIButton BtnCancelar;
        private System.Windows.Forms.Label BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroRadioButton btnInativo;
        private MetroFramework.Controls.MetroRadioButton btnAtivo;
        public XanderUI.XUIButton BtnSalvar;
        public System.Windows.Forms.TextBox txtChave;
    }
}
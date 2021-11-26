
namespace Hotelaria.Views.ADM
{
    partial class NovoPatrimonio
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
            System.Windows.Forms.Label nr_QuartoLabel;
            System.Windows.Forms.Label nm_PatrimonioLabel;
            XanderUI.XUIButton xuiButton2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoPatrimonio));
            System.Windows.Forms.Label ds_StatusLabel;
            this.BtnCancelar = new XanderUI.XUIButton();
            this.BtnSalvar = new XanderUI.XUIButton();
            this.BtnClose = new System.Windows.Forms.Label();
            this.hotelariaDataSet = new Hotelaria.HotelariaDataSet();
            this.controledePatrimonioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controledePatrimonioTableAdapter = new Hotelaria.HotelariaDataSetTableAdapters.ControledePatrimonioTableAdapter();
            this.tableAdapterManager = new Hotelaria.HotelariaDataSetTableAdapters.TableAdapterManager();
            this.txtNmPatrimonio = new System.Windows.Forms.TextBox();
            this.lblNovoHospede = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNrQuarto = new System.Windows.Forms.TextBox();
            this.btnInativo = new MetroFramework.Controls.MetroRadioButton();
            this.btnAtivo = new MetroFramework.Controls.MetroRadioButton();
            nr_QuartoLabel = new System.Windows.Forms.Label();
            nm_PatrimonioLabel = new System.Windows.Forms.Label();
            xuiButton2 = new XanderUI.XUIButton();
            ds_StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledePatrimonioBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nr_QuartoLabel
            // 
            nr_QuartoLabel.AutoSize = true;
            nr_QuartoLabel.Location = new System.Drawing.Point(17, 127);
            nr_QuartoLabel.Name = "nr_QuartoLabel";
            nr_QuartoLabel.Size = new System.Drawing.Size(82, 20);
            nr_QuartoLabel.TabIndex = 225;
            nr_QuartoLabel.Text = "Nr Quarto:";
            // 
            // nm_PatrimonioLabel
            // 
            nm_PatrimonioLabel.AutoSize = true;
            nm_PatrimonioLabel.Location = new System.Drawing.Point(15, 61);
            nm_PatrimonioLabel.Name = "nm_PatrimonioLabel";
            nm_PatrimonioLabel.Size = new System.Drawing.Size(116, 20);
            nm_PatrimonioLabel.TabIndex = 226;
            nm_PatrimonioLabel.Text = "Nm Patrimonio:";
            // 
            // xuiButton2
            // 
            xuiButton2.BackgroundColor = System.Drawing.Color.White;
            xuiButton2.ButtonImage = null;
            xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            xuiButton2.ButtonText = "";
            xuiButton2.CausesValidation = false;
            xuiButton2.ClickBackColor = System.Drawing.Color.White;
            xuiButton2.ClickTextColor = System.Drawing.Color.White;
            xuiButton2.CornerRadius = 9;
            xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            xuiButton2.HoverBackgroundColor = System.Drawing.Color.White;
            xuiButton2.HoverTextColor = System.Drawing.Color.White;
            xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            xuiButton2.Location = new System.Drawing.Point(10, 2);
            xuiButton2.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            xuiButton2.MaximumSize = new System.Drawing.Size(4388, 2182);
            xuiButton2.Name = "xuiButton2";
            xuiButton2.Size = new System.Drawing.Size(270, 348);
            xuiButton2.TabIndex = 242;
            xuiButton2.TabStop = false;
            xuiButton2.TextColor = System.Drawing.Color.White;
            xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.BtnCancelar.Location = new System.Drawing.Point(21, 279);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 44);
            this.BtnCancelar.TabIndex = 223;
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
            this.BtnSalvar.Location = new System.Drawing.Point(168, 279);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(78, 44);
            this.BtnSalvar.TabIndex = 222;
            this.BtnSalvar.TextColor = System.Drawing.Color.White;
            this.BtnSalvar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(222, -3);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(36, 25);
            this.BtnClose.TabIndex = 224;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // hotelariaDataSet
            // 
            this.hotelariaDataSet.DataSetName = "HotelariaDataSet";
            this.hotelariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controledePatrimonioBindingSource
            // 
            this.controledePatrimonioBindingSource.DataMember = "ControledePatrimonio";
            this.controledePatrimonioBindingSource.DataSource = this.hotelariaDataSet;
            // 
            // controledePatrimonioTableAdapter
            // 
            this.controledePatrimonioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChaveDeSegurancaTableAdapter = null;
            this.tableAdapterManager.ControledePatrimonioTableAdapter = this.controledePatrimonioTableAdapter;
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
            // txtNmPatrimonio
            // 
            this.txtNmPatrimonio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controledePatrimonioBindingSource, "Nm_Patrimonio", true));
            this.txtNmPatrimonio.Location = new System.Drawing.Point(19, 84);
            this.txtNmPatrimonio.Name = "txtNmPatrimonio";
            this.txtNmPatrimonio.Size = new System.Drawing.Size(227, 26);
            this.txtNmPatrimonio.TabIndex = 227;
            // 
            // lblNovoHospede
            // 
            this.lblNovoHospede.BackColor = System.Drawing.Color.White;
            this.lblNovoHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNovoHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.lblNovoHospede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNovoHospede.Location = new System.Drawing.Point(6, 3);
            this.lblNovoHospede.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblNovoHospede.Name = "lblNovoHospede";
            this.lblNovoHospede.Size = new System.Drawing.Size(203, 27);
            this.lblNovoHospede.TabIndex = 228;
            this.lblNovoHospede.Text = "Novo Patrimônio";
            this.lblNovoHospede.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNovoHospede.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnInativo);
            this.panel1.Controls.Add(this.btnAtivo);
            this.panel1.Controls.Add(ds_StatusLabel);
            this.panel1.Controls.Add(this.lblNovoHospede);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.txtNrQuarto);
            this.panel1.Controls.Add(nm_PatrimonioLabel);
            this.panel1.Controls.Add(nr_QuartoLabel);
            this.panel1.Controls.Add(this.txtNmPatrimonio);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 328);
            this.panel1.TabIndex = 232;
            // 
            // txtNrQuarto
            // 
            this.txtNrQuarto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controledePatrimonioBindingSource, "Nr_Quarto", true));
            this.txtNrQuarto.Location = new System.Drawing.Point(21, 150);
            this.txtNrQuarto.Name = "txtNrQuarto";
            this.txtNrQuarto.Size = new System.Drawing.Size(78, 26);
            this.txtNrQuarto.TabIndex = 226;
            // 
            // btnInativo
            // 
            this.btnInativo.AutoSize = true;
            this.btnInativo.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.btnInativo.Location = new System.Drawing.Point(97, 220);
            this.btnInativo.Name = "btnInativo";
            this.btnInativo.Size = new System.Drawing.Size(82, 25);
            this.btnInativo.TabIndex = 231;
            this.btnInativo.Text = "Inativo";
            this.btnInativo.UseSelectable = true;
            this.btnInativo.CheckedChanged += new System.EventHandler(this.btnInativo_CheckedChanged);
            // 
            // btnAtivo
            // 
            this.btnAtivo.AutoSize = true;
            this.btnAtivo.Checked = true;
            this.btnAtivo.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.btnAtivo.Location = new System.Drawing.Point(21, 220);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(70, 25);
            this.btnAtivo.TabIndex = 230;
            this.btnAtivo.TabStop = true;
            this.btnAtivo.Text = "Ativo";
            this.btnAtivo.UseSelectable = true;
            this.btnAtivo.CheckedChanged += new System.EventHandler(this.btnAtivo_CheckedChanged);
            // 
            // ds_StatusLabel
            // 
            ds_StatusLabel.AutoSize = true;
            ds_StatusLabel.BackColor = System.Drawing.Color.White;
            ds_StatusLabel.Location = new System.Drawing.Point(17, 197);
            ds_StatusLabel.Name = "ds_StatusLabel";
            ds_StatusLabel.Size = new System.Drawing.Size(56, 20);
            ds_StatusLabel.TabIndex = 229;
            ds_StatusLabel.Text = "Status";
            // 
            // NovoPatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(286, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(xuiButton2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovoPatrimonio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoPatrimonio";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.Load += new System.EventHandler(this.NovoPatrimonio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledePatrimonioBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton BtnCancelar;
        private System.Windows.Forms.Label BtnClose;
        private HotelariaDataSet hotelariaDataSet;
        private System.Windows.Forms.BindingSource controledePatrimonioBindingSource;
        private HotelariaDataSetTableAdapters.ControledePatrimonioTableAdapter controledePatrimonioTableAdapter;
        private HotelariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Label lblNovoHospede;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroRadioButton btnInativo;
        private MetroFramework.Controls.MetroRadioButton btnAtivo;
        public System.Windows.Forms.TextBox txtNmPatrimonio;
        public System.Windows.Forms.TextBox txtNrQuarto;
        public XanderUI.XUIButton BtnSalvar;
    }
}
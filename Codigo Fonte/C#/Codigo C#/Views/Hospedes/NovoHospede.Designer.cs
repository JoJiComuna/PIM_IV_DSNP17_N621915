
namespace Hotelaria.Views.Hospedes
{
    partial class NovoHospede
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nr_TelefoneLabel;
            System.Windows.Forms.Label nr_DocumentoLabel;
            System.Windows.Forms.Label nm_HospedeLabel;
            XanderUI.XUIButton xuiButton7;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoHospede));
            this.BtnClose = new System.Windows.Forms.Label();
            this.hospedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.TxtNomeHospede = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.txtNrEndereco = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new XanderUI.XUIButton();
            this.lblNovoHospede = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.BtnCancelar = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            emailLabel = new System.Windows.Forms.Label();
            nr_TelefoneLabel = new System.Windows.Forms.Label();
            nr_DocumentoLabel = new System.Windows.Forms.Label();
            nm_HospedeLabel = new System.Windows.Forms.Label();
            xuiButton7 = new XanderUI.XUIButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = System.Drawing.Color.Gray;
            emailLabel.Location = new System.Drawing.Point(4, 95);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(48, 20);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            // 
            // nr_TelefoneLabel
            // 
            nr_TelefoneLabel.AutoSize = true;
            nr_TelefoneLabel.ForeColor = System.Drawing.Color.Gray;
            nr_TelefoneLabel.Location = new System.Drawing.Point(359, 95);
            nr_TelefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nr_TelefoneLabel.Name = "nr_TelefoneLabel";
            nr_TelefoneLabel.Size = new System.Drawing.Size(71, 20);
            nr_TelefoneLabel.TabIndex = 6;
            nr_TelefoneLabel.Text = "Telefone";
            // 
            // nr_DocumentoLabel
            // 
            nr_DocumentoLabel.AutoSize = true;
            nr_DocumentoLabel.ForeColor = System.Drawing.Color.Gray;
            nr_DocumentoLabel.Location = new System.Drawing.Point(363, 27);
            nr_DocumentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nr_DocumentoLabel.Name = "nr_DocumentoLabel";
            nr_DocumentoLabel.Size = new System.Drawing.Size(92, 20);
            nr_DocumentoLabel.TabIndex = 4;
            nr_DocumentoLabel.Text = "Documento";
            // 
            // nm_HospedeLabel
            // 
            nm_HospedeLabel.AutoSize = true;
            nm_HospedeLabel.ForeColor = System.Drawing.Color.Gray;
            nm_HospedeLabel.Location = new System.Drawing.Point(4, 27);
            nm_HospedeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nm_HospedeLabel.Name = "nm_HospedeLabel";
            nm_HospedeLabel.Size = new System.Drawing.Size(123, 20);
            nm_HospedeLabel.TabIndex = 2;
            nm_HospedeLabel.Text = "Nome Completo";
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
            xuiButton7.Location = new System.Drawing.Point(5, 4);
            xuiButton7.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            xuiButton7.MaximumSize = new System.Drawing.Size(2925, 1418);
            xuiButton7.Name = "xuiButton7";
            xuiButton7.Size = new System.Drawing.Size(705, 371);
            xuiButton7.TabIndex = 203;
            xuiButton7.TextColor = System.Drawing.Color.White;
            xuiButton7.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.ForeColor = System.Drawing.Color.Gray;
            label1.Location = new System.Drawing.Point(290, 94);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 20);
            label1.TabIndex = 159;
            label1.Text = "Rua";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.Gray;
            label2.Location = new System.Drawing.Point(6, 94);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 20);
            label2.TabIndex = 157;
            label2.Text = "Bairro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.ForeColor = System.Drawing.Color.Gray;
            label3.Location = new System.Drawing.Point(76, 24);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 20);
            label3.TabIndex = 155;
            label3.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.ForeColor = System.Drawing.Color.Gray;
            label5.Location = new System.Drawing.Point(581, 96);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(26, 20);
            label5.TabIndex = 166;
            label5.Text = "Nº";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.ForeColor = System.Drawing.Color.Gray;
            label4.Location = new System.Drawing.Point(6, 24);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(31, 20);
            label4.TabIndex = 154;
            label4.Text = "UF";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(673, 10);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 204;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // hospedesBindingSource
            // 
            this.hospedesBindingSource.DataMember = "Hospedes";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(17, 26);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(652, 220);
            this.metroTabControl1.TabIndex = 199;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
            this.metroTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage1.Controls.Add(this.TxtNomeHospede);
            this.metroTabPage1.Controls.Add(emailLabel);
            this.metroTabPage1.Controls.Add(this.TxtEmail);
            this.metroTabPage1.Controls.Add(nr_TelefoneLabel);
            this.metroTabPage1.Controls.Add(this.TxtTelefone);
            this.metroTabPage1.Controls.Add(nr_DocumentoLabel);
            this.metroTabPage1.Controls.Add(this.TxtDocumento);
            this.metroTabPage1.Controls.Add(nm_HospedeLabel);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.ForeColor = System.Drawing.Color.DimGray;
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 23;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(644, 172);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Informações";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 22;
            // 
            // TxtNomeHospede
            // 
            this.TxtNomeHospede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNomeHospede.Location = new System.Drawing.Point(8, 52);
            this.TxtNomeHospede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNomeHospede.MaxLength = 120;
            this.TxtNomeHospede.Multiline = true;
            this.TxtNomeHospede.Name = "TxtNomeHospede";
            this.TxtNomeHospede.Size = new System.Drawing.Size(326, 28);
            this.TxtNomeHospede.TabIndex = 150;
            this.TxtNomeHospede.WordWrap = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.White;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Location = new System.Drawing.Point(8, 120);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(325, 28);
            this.TxtEmail.TabIndex = 9;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefone.Location = new System.Drawing.Point(364, 120);
            this.TxtTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelefone.MaxLength = 11;
            this.TxtTelefone.Multiline = true;
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(118, 28);
            this.TxtTelefone.TabIndex = 7;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDocumento.Location = new System.Drawing.Point(363, 52);
            this.TxtDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDocumento.MaxLength = 11;
            this.TxtDocumento.Multiline = true;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(119, 28);
            this.TxtDocumento.TabIndex = 5;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.metroTabPage2.Controls.Add(this.txtNrEndereco);
            this.metroTabPage2.Controls.Add(label5);
            this.metroTabPage2.Controls.Add(this.txtEstado);
            this.metroTabPage2.Controls.Add(label1);
            this.metroTabPage2.Controls.Add(this.txtRua);
            this.metroTabPage2.Controls.Add(label2);
            this.metroTabPage2.Controls.Add(this.txtBairro);
            this.metroTabPage2.Controls.Add(label3);
            this.metroTabPage2.Controls.Add(this.txtCidade);
            this.metroTabPage2.Controls.Add(label4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(644, 172);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Endereço";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 1;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // txtNrEndereco
            // 
            this.txtNrEndereco.BackColor = System.Drawing.Color.White;
            this.txtNrEndereco.Location = new System.Drawing.Point(585, 125);
            this.txtNrEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNrEndereco.MaxLength = 5;
            this.txtNrEndereco.Multiline = true;
            this.txtNrEndereco.Name = "txtNrEndereco";
            this.txtNrEndereco.Size = new System.Drawing.Size(50, 28);
            this.txtNrEndereco.TabIndex = 167;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(10, 53);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(50, 28);
            this.txtEstado.TabIndex = 162;
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.White;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Location = new System.Drawing.Point(294, 125);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRua.MaxLength = 150;
            this.txtRua.Multiline = true;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(265, 28);
            this.txtRua.TabIndex = 160;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(10, 125);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBairro.MaxLength = 150;
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(256, 28);
            this.txtBairro.TabIndex = 158;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(80, 53);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.MaxLength = 150;
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(341, 28);
            this.txtCidade.TabIndex = 156;
            this.txtCidade.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            this.BtnSalvar.Location = new System.Drawing.Point(578, 255);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(78, 44);
            this.BtnSalvar.TabIndex = 200;
            this.BtnSalvar.TextColor = System.Drawing.Color.White;
            this.BtnSalvar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblNovoHospede
            // 
            this.lblNovoHospede.BackColor = System.Drawing.Color.White;
            this.lblNovoHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNovoHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.lblNovoHospede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNovoHospede.Location = new System.Drawing.Point(33, 23);
            this.lblNovoHospede.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblNovoHospede.Name = "lblNovoHospede";
            this.lblNovoHospede.Size = new System.Drawing.Size(222, 29);
            this.lblNovoHospede.TabIndex = 198;
            this.lblNovoHospede.Text = "Novo Hóspede";
            this.lblNovoHospede.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNovoHospede.UseCompatibleTextRendering = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.DarkGray;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider1.Location = new System.Drawing.Point(318, 38);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(350, 10);
            this.materialDivider1.TabIndex = 205;
            this.materialDivider1.Text = "materialDivider1";
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
            this.BtnCancelar.Location = new System.Drawing.Point(29, 255);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(78, 44);
            this.BtnCancelar.TabIndex = 202;
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 308);
            this.panel1.TabIndex = 206;
            // 
            // NovoHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.lblNovoHospede);
            this.Controls.Add(xuiButton7);
            this.Controls.Add(this.materialDivider1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovoHospede";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoHospede";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.NovoHospede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BtnClose;
        private System.Windows.Forms.BindingSource hospedesBindingSource;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        public System.Windows.Forms.TextBox TxtNomeHospede;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.TextBox TxtTelefone;
        public System.Windows.Forms.TextBox TxtDocumento;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        public System.Windows.Forms.Label lblNovoHospede;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
 
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.TextBox txtRua;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtNrEndereco;
        private XanderUI.XUIButton BtnCancelar;
        public XanderUI.XUIButton BtnSalvar;
        private System.Windows.Forms.Panel panel1;
    }
}
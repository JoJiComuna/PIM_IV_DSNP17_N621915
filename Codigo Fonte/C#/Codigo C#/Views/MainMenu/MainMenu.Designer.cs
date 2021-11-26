
namespace Hotelaria.Views.Menu
{
    partial class MainMenu
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
            MaterialSkin.Controls.MaterialTabControl tabMainMenu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Inicio = new System.Windows.Forms.TabPage();
            this.PanelInicio = new System.Windows.Forms.Panel();
            this.Relatorios = new System.Windows.Forms.TabPage();
            this.panelRelatorios = new System.Windows.Forms.Panel();
            this.Hospedes = new System.Windows.Forms.TabPage();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.PanelHospedes = new System.Windows.Forms.Panel();
            this.Hospedagens = new System.Windows.Forms.TabPage();
            this.PanelHospedagens = new System.Windows.Forms.Panel();
            this.Pagamentos = new System.Windows.Forms.TabPage();
            this.PanelPagamentos = new System.Windows.Forms.Panel();
            this.ADM = new System.Windows.Forms.TabPage();
            this.PanelADM = new System.Windows.Forms.Panel();
            this.MenuImageList = new System.Windows.Forms.ImageList(this.components);
            tabMainMenu = new MaterialSkin.Controls.MaterialTabControl();
            tabMainMenu.SuspendLayout();
            this.Inicio.SuspendLayout();
            this.Relatorios.SuspendLayout();
            this.Hospedes.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.Hospedagens.SuspendLayout();
            this.Pagamentos.SuspendLayout();
            this.ADM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainMenu
            // 
            tabMainMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            tabMainMenu.AllowDrop = true;
            tabMainMenu.Controls.Add(this.Inicio);
            tabMainMenu.Controls.Add(this.Relatorios);
            tabMainMenu.Controls.Add(this.Hospedes);
            tabMainMenu.Controls.Add(this.Hospedagens);
            tabMainMenu.Controls.Add(this.Pagamentos);
            tabMainMenu.Controls.Add(this.ADM);
            tabMainMenu.Depth = 0;
            tabMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            tabMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabMainMenu.ImageList = this.MenuImageList;
            tabMainMenu.ImeMode = System.Windows.Forms.ImeMode.Off;
            tabMainMenu.ItemSize = new System.Drawing.Size(90, 31);
            tabMainMenu.Location = new System.Drawing.Point(0, 64);
            tabMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabMainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            tabMainMenu.Multiline = true;
            tabMainMenu.Name = "tabMainMenu";
            tabMainMenu.SelectedIndex = 0;
            tabMainMenu.ShowToolTips = true;
            tabMainMenu.Size = new System.Drawing.Size(1097, 533);
            tabMainMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            tabMainMenu.TabIndex = 1;
            tabMainMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMainMenu_Selected);
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.White;
            this.Inicio.Controls.Add(this.PanelInicio);
            this.Inicio.ImageKey = "Inicio.png";
            this.Inicio.Location = new System.Drawing.Point(4, 35);
            this.Inicio.Margin = new System.Windows.Forms.Padding(0);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(1089, 494);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Início";
            this.Inicio.ToolTipText = "Início";
            this.Inicio.UseVisualStyleBackColor = true;
            // 
            // PanelInicio
            // 
            this.PanelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInicio.Location = new System.Drawing.Point(0, 0);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Size = new System.Drawing.Size(1089, 494);
            this.PanelInicio.TabIndex = 0;
            // 
            // Relatorios
            // 
            this.Relatorios.BackColor = System.Drawing.Color.Gainsboro;
            this.Relatorios.Controls.Add(this.panelRelatorios);
            this.Relatorios.ImageKey = "Relatorios.png";
            this.Relatorios.Location = new System.Drawing.Point(4, 35);
            this.Relatorios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Relatorios.Size = new System.Drawing.Size(1089, 494);
            this.Relatorios.TabIndex = 1;
            this.Relatorios.Text = "Relatórios";
            // 
            // panelRelatorios
            // 
            this.panelRelatorios.BackColor = System.Drawing.Color.White;
            this.panelRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRelatorios.Location = new System.Drawing.Point(4, 5);
            this.panelRelatorios.Name = "panelRelatorios";
            this.panelRelatorios.Size = new System.Drawing.Size(1081, 484);
            this.panelRelatorios.TabIndex = 0;
            // 
            // Hospedes
            // 
            this.Hospedes.BackColor = System.Drawing.Color.White;
            this.Hospedes.Controls.Add(this.ContentPanel);
            this.Hospedes.ImageKey = "Hospedes.png";
            this.Hospedes.Location = new System.Drawing.Point(4, 35);
            this.Hospedes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hospedes.Name = "Hospedes";
            this.Hospedes.Size = new System.Drawing.Size(1089, 494);
            this.Hospedes.TabIndex = 3;
            this.Hospedes.Text = "Hóspedes";
            this.Hospedes.UseVisualStyleBackColor = true;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.PanelHospedes);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1089, 494);
            this.ContentPanel.TabIndex = 0;
            // 
            // PanelHospedes
            // 
            this.PanelHospedes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHospedes.Location = new System.Drawing.Point(0, 0);
            this.PanelHospedes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelHospedes.Name = "PanelHospedes";
            this.PanelHospedes.Size = new System.Drawing.Size(1089, 494);
            this.PanelHospedes.TabIndex = 1;
            // 
            // Hospedagens
            // 
            this.Hospedagens.Controls.Add(this.PanelHospedagens);
            this.Hospedagens.ImageKey = "quartos.png";
            this.Hospedagens.Location = new System.Drawing.Point(4, 35);
            this.Hospedagens.Name = "Hospedagens";
            this.Hospedagens.Size = new System.Drawing.Size(1089, 494);
            this.Hospedagens.TabIndex = 7;
            this.Hospedagens.Text = "Hospedagens";
            this.Hospedagens.UseVisualStyleBackColor = true;
            // 
            // PanelHospedagens
            // 
            this.PanelHospedagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHospedagens.Location = new System.Drawing.Point(0, 0);
            this.PanelHospedagens.Name = "PanelHospedagens";
            this.PanelHospedagens.Size = new System.Drawing.Size(1089, 494);
            this.PanelHospedagens.TabIndex = 0;
            // 
            // Pagamentos
            // 
            this.Pagamentos.Controls.Add(this.PanelPagamentos);
            this.Pagamentos.ImageKey = "Pagamentos.png";
            this.Pagamentos.Location = new System.Drawing.Point(4, 35);
            this.Pagamentos.Name = "Pagamentos";
            this.Pagamentos.Padding = new System.Windows.Forms.Padding(3);
            this.Pagamentos.Size = new System.Drawing.Size(1089, 494);
            this.Pagamentos.TabIndex = 5;
            this.Pagamentos.Text = "Pagamentos";
            this.Pagamentos.UseVisualStyleBackColor = true;
            // 
            // PanelPagamentos
            // 
            this.PanelPagamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPagamentos.Location = new System.Drawing.Point(3, 3);
            this.PanelPagamentos.Name = "PanelPagamentos";
            this.PanelPagamentos.Size = new System.Drawing.Size(1083, 488);
            this.PanelPagamentos.TabIndex = 0;
            // 
            // ADM
            // 
            this.ADM.Controls.Add(this.PanelADM);
            this.ADM.ImageKey = "administracao.png";
            this.ADM.Location = new System.Drawing.Point(4, 35);
            this.ADM.Name = "ADM";
            this.ADM.Padding = new System.Windows.Forms.Padding(3);
            this.ADM.Size = new System.Drawing.Size(1089, 494);
            this.ADM.TabIndex = 6;
            this.ADM.Text = "Administração";
            this.ADM.ToolTipText = "Administração";
            this.ADM.UseVisualStyleBackColor = true;
            // 
            // PanelADM
            // 
            this.PanelADM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelADM.Location = new System.Drawing.Point(3, 3);
            this.PanelADM.Name = "PanelADM";
            this.PanelADM.Size = new System.Drawing.Size(1083, 488);
            this.PanelADM.TabIndex = 0;
            // 
            // MenuImageList
            // 
            this.MenuImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MenuImageList.ImageStream")));
            this.MenuImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MenuImageList.Images.SetKeyName(0, "administração.png");
            this.MenuImageList.Images.SetKeyName(1, "calendario.png");
            this.MenuImageList.Images.SetKeyName(2, "Hospedes.png");
            this.MenuImageList.Images.SetKeyName(3, "Inicio.png");
            this.MenuImageList.Images.SetKeyName(4, "Pagamentos.png");
            this.MenuImageList.Images.SetKeyName(5, "quartos.png");
            this.MenuImageList.Images.SetKeyName(6, "Relatorios.png");
            this.MenuImageList.Images.SetKeyName(7, "administracao.png");
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(tabMainMenu);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIndicatorWidth = 6;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = tabMainMenu;
            this.DrawerWidth = 220;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Início";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            tabMainMenu.ResumeLayout(false);
            this.Inicio.ResumeLayout(false);
            this.Relatorios.ResumeLayout(false);
            this.Hospedes.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.Hospedagens.ResumeLayout(false);
            this.Pagamentos.ResumeLayout(false);
            this.ADM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabPage Inicio;
        public System.Windows.Forms.Panel PanelInicio;
        public System.Windows.Forms.TabPage Relatorios;
        private System.Windows.Forms.TabPage Pagamentos;
        private System.Windows.Forms.Panel PanelPagamentos;
        private System.Windows.Forms.TabPage Hospedes;
        private System.Windows.Forms.Panel ContentPanel;
        public System.Windows.Forms.Panel PanelHospedes;
        private System.Windows.Forms.TabPage ADM;
        public System.Windows.Forms.Panel PanelADM;
        private System.Windows.Forms.TabPage Hospedagens;
        private System.Windows.Forms.Panel PanelHospedagens;
        public System.Windows.Forms.ImageList MenuImageList;
        private System.Windows.Forms.Panel panelRelatorios;
    }
}
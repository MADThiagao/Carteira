namespace Carteira
{
    partial class Login
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
            this.lcBase = new DevExpress.XtraLayout.LayoutControl();
            this.lcbtnentrar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcTxtSenha = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcTxUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcbutton = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcBase)).BeginInit();
            this.lcBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTxtSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lcBase
            // 
            this.lcBase.Controls.Add(this.panelControl1);
            this.lcBase.Controls.Add(this.lcbtnentrar);
            this.lcBase.Controls.Add(this.txtSenha);
            this.lcBase.Controls.Add(this.txtUsuario);
            this.lcBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcBase.Location = new System.Drawing.Point(0, 0);
            this.lcBase.Name = "lcBase";
            this.lcBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2104, 261, 427, 350);
            this.lcBase.Root = this.layoutControlGroup1;
            this.lcBase.Size = new System.Drawing.Size(274, 331);
            this.lcBase.TabIndex = 0;
            this.lcBase.Text = "layoutControl1";
            // 
            // lcbtnentrar
            // 
            this.lcbtnentrar.Location = new System.Drawing.Point(82, 297);
            this.lcbtnentrar.Name = "lcbtnentrar";
            this.lcbtnentrar.Size = new System.Drawing.Size(110, 22);
            this.lcbtnentrar.StyleController = this.lcBase;
            this.lcbtnentrar.TabIndex = 6;
            this.lcbtnentrar.Text = "Entrar";
            this.lcbtnentrar.Click += new System.EventHandler(this.lcbtnentrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(57, 239);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(160, 20);
            this.txtSenha.StyleController = this.lcBase;
            this.txtSenha.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(57, 189);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtUsuario.StyleController = this.lcBase;
            this.txtUsuario.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcTxtSenha,
            this.lcTxUsuario,
            this.emptySpaceItem2,
            this.lcbutton,
            this.emptySpaceItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(274, 331);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcTxtSenha
            // 
            this.lcTxtSenha.Control = this.txtSenha;
            this.lcTxtSenha.Location = new System.Drawing.Point(0, 211);
            this.lcTxtSenha.Name = "lcTxtSenha";
            this.lcTxtSenha.Size = new System.Drawing.Size(254, 40);
            this.lcTxtSenha.Spacing = new DevExpress.XtraLayout.Utils.Padding(45, 45, 0, 0);
            this.lcTxtSenha.Text = "Senha";
            this.lcTxtSenha.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcTxtSenha.TextSize = new System.Drawing.Size(36, 13);
            // 
            // lcTxUsuario
            // 
            this.lcTxUsuario.Control = this.txtUsuario;
            this.lcTxUsuario.Location = new System.Drawing.Point(0, 161);
            this.lcTxUsuario.Name = "lcTxUsuario";
            this.lcTxUsuario.Size = new System.Drawing.Size(254, 40);
            this.lcTxUsuario.Spacing = new DevExpress.XtraLayout.Utils.Padding(45, 45, 0, 0);
            this.lcTxUsuario.Text = "Usuario";
            this.lcTxUsuario.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcTxUsuario.TextSize = new System.Drawing.Size(36, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 252);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(253, 35);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcbutton
            // 
            this.lcbutton.Control = this.lcbtnentrar;
            this.lcbutton.Location = new System.Drawing.Point(0, 285);
            this.lcbutton.Name = "lcbutton";
            this.lcbutton.Size = new System.Drawing.Size(254, 26);
            this.lcbutton.Spacing = new DevExpress.XtraLayout.Utils.Padding(70, 70, 0, 0);
            this.lcbutton.TextSize = new System.Drawing.Size(0, 0);
            this.lcbutton.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 202);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(253, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImage = global::Carteira.Properties.Resources.carteira128;
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(250, 157);
            this.panelControl1.TabIndex = 8;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(254, 161);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 331);
            this.Controls.Add(this.lcBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(290, 370);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.lcBase)).EndInit();
            this.lcBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTxtSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcBase;
        private DevExpress.XtraEditors.SimpleButton lcbtnentrar;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lcTxtSenha;
        private DevExpress.XtraLayout.LayoutControlItem lcTxUsuario;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem lcbutton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}


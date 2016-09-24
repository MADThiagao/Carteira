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
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcTxtSenha = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcTxUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcbtnentrar = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lcBase
            // 
            this.lcBase.Controls.Add(this.panelControl2);
            this.lcBase.Controls.Add(this.panelControl1);
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
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(47, 246);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(180, 20);
            this.txtSenha.StyleController = this.lcBase;
            this.txtSenha.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(47, 196);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(180, 20);
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
            this.emptySpaceItem3,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(274, 331);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcTxtSenha
            // 
            this.lcTxtSenha.Control = this.txtSenha;
            this.lcTxtSenha.Location = new System.Drawing.Point(0, 228);
            this.lcTxtSenha.Name = "lcTxtSenha";
            this.lcTxtSenha.Size = new System.Drawing.Size(274, 40);
            this.lcTxtSenha.Spacing = new DevExpress.XtraLayout.Utils.Padding(45, 45, 0, 0);
            this.lcTxtSenha.Text = "Senha";
            this.lcTxtSenha.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcTxtSenha.TextSize = new System.Drawing.Size(36, 13);
            // 
            // lcTxUsuario
            // 
            this.lcTxUsuario.Control = this.txtUsuario;
            this.lcTxUsuario.Location = new System.Drawing.Point(0, 178);
            this.lcTxUsuario.Name = "lcTxUsuario";
            this.lcTxUsuario.Size = new System.Drawing.Size(274, 40);
            this.lcTxUsuario.Spacing = new DevExpress.XtraLayout.Utils.Padding(45, 45, 0, 0);
            this.lcTxUsuario.Text = "Usuario";
            this.lcTxUsuario.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcTxUsuario.TextSize = new System.Drawing.Size(36, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 268);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(274, 21);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 218);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(274, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lcbtnentrar);
            this.panelControl2.Location = new System.Drawing.Point(2, 291);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(270, 38);
            this.panelControl2.TabIndex = 9;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 289);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(274, 42);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lcbtnentrar
            // 
            this.lcbtnentrar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lcbtnentrar.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.lcbtnentrar.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lcbtnentrar.Appearance.Options.UseBackColor = true;
            this.lcbtnentrar.Appearance.Options.UseBorderColor = true;
            this.lcbtnentrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lcbtnentrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lcbtnentrar.Image = global::Carteira.Properties.Resources.Enter_24;
            this.lcbtnentrar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.lcbtnentrar.Location = new System.Drawing.Point(0, -2);
            this.lcbtnentrar.MaximumSize = new System.Drawing.Size(0, 40);
            this.lcbtnentrar.MinimumSize = new System.Drawing.Size(0, 40);
            this.lcbtnentrar.Name = "lcbtnentrar";
            this.lcbtnentrar.Size = new System.Drawing.Size(270, 40);
            this.lcbtnentrar.TabIndex = 6;
            this.lcbtnentrar.Click += new System.EventHandler(this.lcbtnentrar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImage = global::Carteira.Properties.Resources.carteira2;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(270, 174);
            this.panelControl1.TabIndex = 8;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(274, 178);
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}


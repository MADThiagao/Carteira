namespace Carteira
{
    partial class LancamentoCadastro
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dtData = new DevExpress.XtraEditors.DateEdit();
            this.rdTipo = new DevExpress.XtraEditors.RadioGroup();
            this.cboCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lgMenu = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcMenu = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcGrupo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.dtData);
            this.layoutControl1.Controls.Add(this.rdTipo);
            this.layoutControl1.Controls.Add(this.cboCategoria);
            this.layoutControl1.Controls.Add(this.txtValor);
            this.layoutControl1.Controls.Add(this.txtDescricao);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2150, 291, 541, 489);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(364, 176);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Controls.Add(this.btnSalvar);
            this.panelControl1.Location = new System.Drawing.Point(2, 134);
            this.panelControl1.MaximumSize = new System.Drawing.Size(0, 40);
            this.panelControl1.MinimumSize = new System.Drawing.Size(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(360, 40);
            this.panelControl1.TabIndex = 11;
            // 
            // dtData
            // 
            this.dtData.EditValue = null;
            this.dtData.Location = new System.Drawing.Point(237, 33);
            this.dtData.Name = "dtData";
            this.dtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtData.Size = new System.Drawing.Size(120, 20);
            this.dtData.StyleController = this.layoutControl1;
            this.dtData.TabIndex = 10;
            // 
            // rdTipo
            // 
            this.rdTipo.EditValue = "R";
            this.rdTipo.Location = new System.Drawing.Point(61, 85);
            this.rdTipo.Name = "rdTipo";
            this.rdTipo.Properties.Columns = 2;
            this.rdTipo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rdTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("R", "Receita"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("D", "Despesa")});
            this.rdTipo.Size = new System.Drawing.Size(296, 25);
            this.rdTipo.StyleController = this.layoutControl1;
            this.rdTipo.TabIndex = 9;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Location = new System.Drawing.Point(61, 59);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descricao")});
            this.cboCategoria.Properties.DisplayMember = "Descricao";
            this.cboCategoria.Properties.NullText = "";
            this.cboCategoria.Properties.ShowFooter = false;
            this.cboCategoria.Properties.ShowHeader = false;
            this.cboCategoria.Properties.ValueMember = "Id";
            this.cboCategoria.Size = new System.Drawing.Size(296, 20);
            this.cboCategoria.StyleController = this.layoutControl1;
            this.cboCategoria.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(61, 33);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Mask.EditMask = "#,##0.00;";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Size = new System.Drawing.Size(116, 20);
            this.txtValor.StyleController = this.layoutControl1;
            this.txtValor.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(61, 7);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(296, 20);
            this.txtDescricao.StyleController = this.layoutControl1;
            this.txtDescricao.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lgMenu,
            this.lcGrupo});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(364, 176);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lgMenu
            // 
            this.lgMenu.GroupBordersVisible = false;
            this.lgMenu.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcMenu});
            this.lgMenu.Location = new System.Drawing.Point(0, 134);
            this.lgMenu.Name = "lgMenu";
            this.lgMenu.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lgMenu.Size = new System.Drawing.Size(364, 42);
            this.lgMenu.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.lgMenu.TextVisible = false;
            // 
            // lcMenu
            // 
            this.lcMenu.Control = this.panelControl1;
            this.lcMenu.Location = new System.Drawing.Point(0, 0);
            this.lcMenu.Name = "lcMenu";
            this.lcMenu.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 2);
            this.lcMenu.Size = new System.Drawing.Size(364, 42);
            this.lcMenu.TextSize = new System.Drawing.Size(0, 0);
            this.lcMenu.TextVisible = false;
            // 
            // lcGrupo
            // 
            this.lcGrupo.CustomizationFormText = "layoutControlGroup3";
            this.lcGrupo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcGrupo.GroupBordersVisible = false;
            this.lcGrupo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.lcGrupo.Location = new System.Drawing.Point(0, 0);
            this.lcGrupo.Name = "lcGrupo";
            this.lcGrupo.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcGrupo.Size = new System.Drawing.Size(364, 134);
            this.lcGrupo.Text = "Cadastro de Lancamento";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 109);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.emptySpaceItem2.Size = new System.Drawing.Size(356, 17);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDescricao;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(356, 26);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem3.Text = "Descrição:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtValor;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(176, 26);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem4.Text = "Valor:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cboCategoria;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(356, 26);
            this.layoutControlItem5.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem5.Text = "Categoria:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.rdTipo;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(356, 31);
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem6.Text = "Tipo:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dtData;
            this.layoutControlItem7.Location = new System.Drawing.Point(176, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(180, 26);
            this.layoutControlItem7.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem7.Text = "Data:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(51, 13);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.Appearance.Options.UseForeColor = true;
            this.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Image = global::Carteira.Properties.Resources.Cancel_24;
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(38, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Appearance.Options.UseBackColor = true;
            this.btnSalvar.Appearance.Options.UseForeColor = true;
            this.btnSalvar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.Image = global::Carteira.Properties.Resources.Ok_24;
            this.btnSalvar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSalvar.Location = new System.Drawing.Point(322, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(38, 40);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // LancamentoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 176);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 215);
            this.Name = "LancamentoCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lgMenu;
        private DevExpress.XtraLayout.LayoutControlGroup lcGrupo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.RadioGroup rdTipo;
        private DevExpress.XtraEditors.LookUpEdit cboCategoria;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DateEdit dtData;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem lcMenu;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}
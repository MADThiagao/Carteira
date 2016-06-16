namespace Carteira
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lcBase = new DevExpress.XtraLayout.LayoutControl();
            this.AccordionMenu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AddLancamento = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AddCategoria = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gcLancamento = new DevExpress.XtraGrid.GridControl();
            this.gvLancamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.IcoMenu = new DevExpress.XtraEditors.PanelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgNav = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lGrupoGrid = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcGroupMenu = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lcBase)).BeginInit();
            this.lcBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccordionMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLancamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLancamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGrupoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGroupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // lcBase
            // 
            this.lcBase.Controls.Add(this.AccordionMenu);
            this.lcBase.Controls.Add(this.gcLancamento);
            this.lcBase.Controls.Add(this.panelControl1);
            this.lcBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcBase.Location = new System.Drawing.Point(0, 0);
            this.lcBase.Name = "lcBase";
            this.lcBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1924, 412, 654, 619);
            this.lcBase.Root = this.layoutControlGroup1;
            this.lcBase.Size = new System.Drawing.Size(889, 517);
            this.lcBase.TabIndex = 0;
            this.lcBase.Text = "layoutControl1";
            // 
            // AccordionMenu
            // 
            this.AccordionMenu.Appearance.AccordionControl.BackColor = System.Drawing.Color.Transparent;
            this.AccordionMenu.Appearance.AccordionControl.BackColor2 = System.Drawing.Color.Transparent;
            this.AccordionMenu.Appearance.AccordionControl.BorderColor = System.Drawing.Color.Transparent;
            this.AccordionMenu.Appearance.AccordionControl.Options.UseBackColor = true;
            this.AccordionMenu.Appearance.AccordionControl.Options.UseBorderColor = true;
            this.AccordionMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.AccordionMenu.Location = new System.Drawing.Point(2, 52);
            this.AccordionMenu.Name = "AccordionMenu";
            this.AccordionMenu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.AccordionMenu.Size = new System.Drawing.Size(141, 463);
            this.AccordionMenu.StyleController = this.lcBase;
            this.AccordionMenu.TabIndex = 6;
            this.AccordionMenu.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.AddLancamento,
            this.AddCategoria});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Adicionar";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // AddLancamento
            // 
            this.AddLancamento.Name = "AddLancamento";
            this.AddLancamento.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AddLancamento.Text = "Lançamento";
            this.AddLancamento.Click += new System.EventHandler(this.AddLancamento_Click);
            // 
            // AddCategoria
            // 
            this.AddCategoria.Name = "AddCategoria";
            this.AddCategoria.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AddCategoria.Text = "Categoria";
            // 
            // gcLancamento
            // 
            this.gcLancamento.Location = new System.Drawing.Point(159, 203);
            this.gcLancamento.MainView = this.gvLancamento;
            this.gcLancamento.Name = "gcLancamento";
            this.gcLancamento.Size = new System.Drawing.Size(716, 300);
            this.gcLancamento.TabIndex = 5;
            this.gcLancamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLancamento});
            // 
            // gvLancamento
            // 
            this.gvLancamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvLancamento.GridControl = this.gcLancamento;
            this.gvLancamento.Name = "gvLancamento";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.IcoMenu);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.MaximumSize = new System.Drawing.Size(0, 50);
            this.panelControl1.MinimumSize = new System.Drawing.Size(0, 50);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(889, 50);
            this.panelControl1.TabIndex = 4;
            // 
            // IcoMenu
            // 
            this.IcoMenu.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.IcoMenu.Appearance.Options.UseBackColor = true;
            this.IcoMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.IcoMenu.ContentImage = global::Carteira.Properties.Resources.menu_24;
            this.IcoMenu.Location = new System.Drawing.Point(0, 12);
            this.IcoMenu.Name = "IcoMenu";
            this.IcoMenu.Size = new System.Drawing.Size(36, 38);
            this.IcoMenu.TabIndex = 0;
            this.IcoMenu.Click += new System.EventHandler(this.IcoMenu_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgNav});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(889, 517);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcgNav
            // 
            this.lcgNav.AllowHide = false;
            this.lcgNav.GroupBordersVisible = false;
            this.lcgNav.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup4,
            this.lcGroupMenu});
            this.lcgNav.Location = new System.Drawing.Point(0, 0);
            this.lcgNav.Name = "lcgNav";
            this.lcgNav.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgNav.Size = new System.Drawing.Size(889, 517);
            this.lcgNav.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgNav.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(889, 50);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lGrupoGrid,
            this.layoutControlGroup6});
            this.layoutControlGroup4.Location = new System.Drawing.Point(145, 50);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup4.Size = new System.Drawing.Size(744, 467);
            this.layoutControlGroup4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // lGrupoGrid
            // 
            this.lGrupoGrid.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcGrid});
            this.lGrupoGrid.Location = new System.Drawing.Point(0, 121);
            this.lGrupoGrid.Name = "lGrupoGrid";
            this.lGrupoGrid.Size = new System.Drawing.Size(744, 346);
            // 
            // lcGrid
            // 
            this.lcGrid.Control = this.gcLancamento;
            this.lcGrid.Location = new System.Drawing.Point(0, 0);
            this.lcGrid.Name = "lcGrid";
            this.lcGrid.Size = new System.Drawing.Size(720, 304);
            this.lcGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lcGrid.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(744, 121);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(720, 79);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcGroupMenu
            // 
            this.lcGroupMenu.AppearanceGroup.BackColor = System.Drawing.Color.Transparent;
            this.lcGroupMenu.AppearanceGroup.Options.UseBackColor = true;
            this.lcGroupMenu.BackgroundImageVisible = true;
            this.lcGroupMenu.GroupBordersVisible = false;
            this.lcGroupMenu.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.lcGroupMenu.Location = new System.Drawing.Point(0, 50);
            this.lcGroupMenu.Name = "lcGroupMenu";
            this.lcGroupMenu.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcGroupMenu.Size = new System.Drawing.Size(145, 467);
            this.lcGroupMenu.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcGroupMenu.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.AccordionMenu;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(145, 467);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdLancamento";
            this.gridColumn1.CustomizationCaption = "IdLancamento";
            this.gridColumn1.FieldName = "IdLancamento";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Data";
            this.gridColumn2.CustomizationCaption = "Data";
            this.gridColumn2.FieldName = "Data";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo";
            this.gridColumn3.CustomizationCaption = "Tipo";
            this.gridColumn3.FieldName = "Tipo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Descricao";
            this.gridColumn4.CustomizationCaption = "Descricao";
            this.gridColumn4.FieldName = "Descricao";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Valor";
            this.gridColumn5.CustomizationCaption = "Valor";
            this.gridColumn5.FieldName = "Valor";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 517);
            this.Controls.Add(this.lcBase);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.lcBase)).EndInit();
            this.lcBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccordionMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLancamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLancamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcoMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGrupoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcGroupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcBase;
        private DevExpress.XtraGrid.GridControl gcLancamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLancamento;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgNav;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup lGrupoGrid;
        private DevExpress.XtraLayout.LayoutControlItem lcGrid;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup lcGroupMenu;
        private DevExpress.XtraEditors.PanelControl IcoMenu;
        private DevExpress.XtraBars.Navigation.AccordionControl AccordionMenu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AddLancamento;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AddCategoria;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
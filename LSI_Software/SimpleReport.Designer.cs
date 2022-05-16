namespace LSI_Software
{
    partial class SimpleReport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lcOfElements = new DevExpress.XtraLayout.LayoutControl();
            this.gcListOfExportHistory = new DevExpress.XtraGrid.GridControl();
            this.exportHistoryElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvListOfExportHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTimeOfExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTimeOfExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExportLocalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCriteriaOfRepot = new DevExpress.XtraEditors.GroupControl();
            this.lcReportCriteria = new DevExpress.XtraLayout.LayoutControl();
            this.sbConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.deDateTo = new DevExpress.XtraEditors.DateEdit();
            this.deDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.teLocalName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcOfElements)).BeginInit();
            this.lcOfElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListOfExportHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportHistoryElementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListOfExportHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCriteriaOfRepot)).BeginInit();
            this.gcCriteriaOfRepot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcReportCriteria)).BeginInit();
            this.lcReportCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lcOfElements
            // 
            this.lcOfElements.Controls.Add(this.gcListOfExportHistory);
            this.lcOfElements.Controls.Add(this.gcCriteriaOfRepot);
            this.lcOfElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcOfElements.Location = new System.Drawing.Point(0, 0);
            this.lcOfElements.Name = "lcOfElements";
            this.lcOfElements.Root = this.Root;
            this.lcOfElements.Size = new System.Drawing.Size(800, 450);
            this.lcOfElements.TabIndex = 0;
            this.lcOfElements.Text = "layoutControl1";
            // 
            // gcListOfExportHistory
            // 
            this.gcListOfExportHistory.DataSource = this.exportHistoryElementBindingSource;
            this.gcListOfExportHistory.Location = new System.Drawing.Point(232, 12);
            this.gcListOfExportHistory.MainView = this.gvListOfExportHistory;
            this.gcListOfExportHistory.Name = "gcListOfExportHistory";
            this.gcListOfExportHistory.Size = new System.Drawing.Size(556, 426);
            this.gcListOfExportHistory.TabIndex = 5;
            this.gcListOfExportHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListOfExportHistory});
            // 
            // exportHistoryElementBindingSource
            // 
            this.exportHistoryElementBindingSource.DataSource = typeof(LSI_Software.Model.ExportHistoryElement);
            // 
            // gvListOfExportHistory
            // 
            this.gvListOfExportHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDateTimeOfExport,
            this.gcTimeOfExport,
            this.colUserName,
            this.colExportLocalName});
            this.gvListOfExportHistory.GridControl = this.gcListOfExportHistory;
            this.gvListOfExportHistory.Name = "gvListOfExportHistory";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colName
            // 
            this.colName.Caption = "Nazwa";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDateTimeOfExport
            // 
            this.colDateTimeOfExport.Caption = "Data";
            this.colDateTimeOfExport.FieldName = "DateTimeOfExport";
            this.colDateTimeOfExport.Name = "colDateTimeOfExport";
            this.colDateTimeOfExport.OptionsColumn.AllowEdit = false;
            this.colDateTimeOfExport.Visible = true;
            this.colDateTimeOfExport.VisibleIndex = 1;
            // 
            // gcTimeOfExport
            // 
            this.gcTimeOfExport.Caption = "Godzina";
            this.gcTimeOfExport.DisplayFormat.FormatString = "t";
            this.gcTimeOfExport.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcTimeOfExport.FieldName = "DateTimeOfExport";
            this.gcTimeOfExport.Name = "gcTimeOfExport";
            this.gcTimeOfExport.OptionsColumn.AllowEdit = false;
            this.gcTimeOfExport.Visible = true;
            this.gcTimeOfExport.VisibleIndex = 2;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Użytkownik";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 3;
            // 
            // colExportLocalName
            // 
            this.colExportLocalName.Caption = "Lokal";
            this.colExportLocalName.FieldName = "ExportLocalName";
            this.colExportLocalName.Name = "colExportLocalName";
            this.colExportLocalName.OptionsColumn.AllowEdit = false;
            this.colExportLocalName.Visible = true;
            this.colExportLocalName.VisibleIndex = 4;
            // 
            // gcCriteriaOfRepot
            // 
            this.gcCriteriaOfRepot.Controls.Add(this.lcReportCriteria);
            this.gcCriteriaOfRepot.Location = new System.Drawing.Point(12, 12);
            this.gcCriteriaOfRepot.Name = "gcCriteriaOfRepot";
            this.gcCriteriaOfRepot.Size = new System.Drawing.Size(216, 426);
            this.gcCriteriaOfRepot.TabIndex = 4;
            this.gcCriteriaOfRepot.Text = "Kryteria raportu";
            // 
            // lcReportCriteria
            // 
            this.lcReportCriteria.AllowCustomization = false;
            this.lcReportCriteria.Controls.Add(this.sbConfirm);
            this.lcReportCriteria.Controls.Add(this.deDateTo);
            this.lcReportCriteria.Controls.Add(this.deDateFrom);
            this.lcReportCriteria.Controls.Add(this.teLocalName);
            this.lcReportCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcReportCriteria.Location = new System.Drawing.Point(2, 23);
            this.lcReportCriteria.Name = "lcReportCriteria";
            this.lcReportCriteria.Root = this.layoutControlGroup1;
            this.lcReportCriteria.Size = new System.Drawing.Size(212, 401);
            this.lcReportCriteria.TabIndex = 0;
            this.lcReportCriteria.Text = "layoutControl1";
            // 
            // sbConfirm
            // 
            this.sbConfirm.Location = new System.Drawing.Point(12, 367);
            this.sbConfirm.Name = "sbConfirm";
            this.sbConfirm.Size = new System.Drawing.Size(188, 22);
            this.sbConfirm.StyleController = this.lcReportCriteria;
            this.sbConfirm.TabIndex = 7;
            this.sbConfirm.Text = "Zatwierdź";
            this.sbConfirm.Click += new System.EventHandler(this.sbConfirm_Click);
            // 
            // deDateTo
            // 
            this.deDateTo.EditValue = null;
            this.deDateTo.Location = new System.Drawing.Point(12, 60);
            this.deDateTo.Name = "deDateTo";
            this.deDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateTo.Properties.MaskSettings.Set("mask", "MM/dd/yyyy");
            this.deDateTo.Properties.NullText = "Do:";
            this.deDateTo.Properties.UseMaskAsDisplayFormat = true;
            this.deDateTo.Size = new System.Drawing.Size(188, 20);
            this.deDateTo.StyleController = this.lcReportCriteria;
            this.deDateTo.TabIndex = 6;
            // 
            // deDateFrom
            // 
            this.deDateFrom.EditValue = null;
            this.deDateFrom.Location = new System.Drawing.Point(12, 36);
            this.deDateFrom.Name = "deDateFrom";
            this.deDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateFrom.Properties.MaskSettings.Set("mask", "MM/dd/yyyy");
            this.deDateFrom.Properties.NullText = "Od:";
            this.deDateFrom.Properties.UseMaskAsDisplayFormat = true;
            this.deDateFrom.Size = new System.Drawing.Size(188, 20);
            this.deDateFrom.StyleController = this.lcReportCriteria;
            this.deDateFrom.TabIndex = 5;
            // 
            // teLocalName
            // 
            this.teLocalName.Location = new System.Drawing.Point(12, 12);
            this.teLocalName.Name = "teLocalName";
            this.teLocalName.Properties.MaxLength = 50;
            this.teLocalName.Properties.NullText = "Lokal:";
            this.teLocalName.Size = new System.Drawing.Size(188, 20);
            this.teLocalName.StyleController = this.lcReportCriteria;
            this.teLocalName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(212, 401);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teLocalName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(192, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(192, 283);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.deDateFrom;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(192, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.deDateTo;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(192, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sbConfirm;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 355);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(192, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcCriteriaOfRepot;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(220, 430);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcListOfExportHistory;
            this.layoutControlItem2.Location = new System.Drawing.Point(220, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(560, 430);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // SimpleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lcOfElements);
            this.Name = "SimpleReport";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcOfElements)).EndInit();
            this.lcOfElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListOfExportHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportHistoryElementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListOfExportHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCriteriaOfRepot)).EndInit();
            this.gcCriteriaOfRepot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcReportCriteria)).EndInit();
            this.lcReportCriteria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcOfElements;
        private DevExpress.XtraGrid.GridControl gcListOfExportHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListOfExportHistory;
        private DevExpress.XtraEditors.GroupControl gcCriteriaOfRepot;
        private DevExpress.XtraLayout.LayoutControl lcReportCriteria;
        private DevExpress.XtraEditors.SimpleButton sbConfirm;
        private DevExpress.XtraEditors.DateEdit deDateTo;
        private DevExpress.XtraEditors.DateEdit deDateFrom;
        private DevExpress.XtraEditors.TextEdit teLocalName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource exportHistoryElementBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTimeOfExport;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colExportLocalName;
        private DevExpress.XtraGrid.Columns.GridColumn gcTimeOfExport;
    }
}

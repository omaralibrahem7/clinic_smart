
namespace CLINIC_OMAR_05541456466.frm_ADD
{
    partial class frm_APO_ADD
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
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_SEARCH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TXT_TIME = new System.Windows.Forms.MaskedTextBox();
            this.BTN_UPDATE = new DevExpress.XtraEditors.SimpleButton();
            this.BTN_DELETE = new DevExpress.XtraEditors.SimpleButton();
            this.BTN_CEALE = new DevExpress.XtraEditors.SimpleButton();
            this.BTN_SAVE = new DevExpress.XtraEditors.SimpleButton();
            this.TXT_DOC_ID = new System.Windows.Forms.ComboBox();
            this.TXT_DOC_NAME = new System.Windows.Forms.ComboBox();
            this.BTN_DOC_LIST = new DevExpress.XtraEditors.SimpleButton();
            this.TXT_NOTE = new DevExpress.XtraEditors.TextEdit();
            this.TXT_NAME = new DevExpress.XtraEditors.TextEdit();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.TXT_DODE = new DevExpress.XtraEditors.TextEdit();
            this.TXT_CUST_ID = new System.Windows.Forms.ComboBox();
            this.TXT_CUST_NAME = new System.Windows.Forms.ComboBox();
            this.BTN_CUST_LIST = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_SEARCH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NOTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_DODE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl10.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl10.Enabled = false;
            this.labelControl10.ImageOptions.SvgImage = global::CLINIC_OMAR_05541456466.Properties.Resources.zoom1;
            this.labelControl10.Location = new System.Drawing.Point(375, 35);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(32, 35);
            this.labelControl10.TabIndex = 44;
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.Location = new System.Drawing.Point(12, 40);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Properties.Appearance.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_SEARCH.Properties.Appearance.Options.UseFont = true;
            this.TXT_SEARCH.Size = new System.Drawing.Size(357, 30);
            this.TXT_SEARCH.TabIndex = 43;
            this.TXT_SEARCH.EditValueChanged += new System.EventHandler(this.TXT_SEARCH_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(214)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl8.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl8.Enabled = false;
            this.labelControl8.Location = new System.Drawing.Point(496, -38);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(275, 35);
            this.labelControl8.TabIndex = 42;
            this.labelControl8.Text = "اضافة -تعديل مريض";
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Font = new System.Drawing.Font("Marlett", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.gridControl1.Location = new System.Drawing.Point(12, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(687, 558);
            this.gridControl1.TabIndex = 41;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.AppearancePrint.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.AppearancePrint.FilterPanel.BorderColor = System.Drawing.Color.Black;
            this.gridView1.AppearancePrint.FilterPanel.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.FilterPanel.Options.UseBorderColor = true;
            this.gridView1.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.AppearancePrint.GroupRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.AppearancePrint.GroupRow.BorderColor = System.Drawing.Color.Black;
            this.gridView1.AppearancePrint.GroupRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.GroupRow.Options.UseBorderColor = true;
            this.gridView1.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsPrint.PrintFooter = false;
            this.gridView1.OptionsPrint.PrintGroupFooter = false;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(110)))));
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.TXT_TIME);
            this.groupControl1.Controls.Add(this.BTN_UPDATE);
            this.groupControl1.Controls.Add(this.BTN_DELETE);
            this.groupControl1.Controls.Add(this.BTN_CEALE);
            this.groupControl1.Controls.Add(this.BTN_SAVE);
            this.groupControl1.Controls.Add(this.TXT_DOC_ID);
            this.groupControl1.Controls.Add(this.TXT_DOC_NAME);
            this.groupControl1.Controls.Add(this.BTN_DOC_LIST);
            this.groupControl1.Controls.Add(this.TXT_NOTE);
            this.groupControl1.Controls.Add(this.TXT_NAME);
            this.groupControl1.Controls.Add(this.txt_date);
            this.groupControl1.Controls.Add(this.TXT_DODE);
            this.groupControl1.Controls.Add(this.TXT_CUST_ID);
            this.groupControl1.Controls.Add(this.TXT_CUST_NAME);
            this.groupControl1.Controls.Add(this.BTN_CUST_LIST);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(744, 131);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(434, 419);
            this.groupControl1.TabIndex = 40;
            this.groupControl1.Text = "المواعيد";
            // 
            // TXT_TIME
            // 
            this.TXT_TIME.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold);
            this.TXT_TIME.Location = new System.Drawing.Point(90, 144);
            this.TXT_TIME.Mask = "90:00";
            this.TXT_TIME.Name = "TXT_TIME";
            this.TXT_TIME.Size = new System.Drawing.Size(214, 30);
            this.TXT_TIME.TabIndex = 82;
            this.TXT_TIME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_TIME.ValidatingType = typeof(System.DateTime);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(110)))));
            this.BTN_UPDATE.Appearance.Font = new System.Drawing.Font("Mudir MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_UPDATE.Appearance.Options.UseBackColor = true;
            this.BTN_UPDATE.Appearance.Options.UseFont = true;
            this.BTN_UPDATE.ImageOptions.SvgImage = global::CLINIC_OMAR_05541456466.Properties.Resources.updatedataextract;
            this.BTN_UPDATE.Location = new System.Drawing.Point(156, 329);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(83, 43);
            this.BTN_UPDATE.TabIndex = 81;
            this.BTN_UPDATE.Text = "تعديل";
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(110)))));
            this.BTN_DELETE.Appearance.Font = new System.Drawing.Font("Mudir MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_DELETE.Appearance.Options.UseBackColor = true;
            this.BTN_DELETE.Appearance.Options.UseFont = true;
            this.BTN_DELETE.ImageOptions.SvgImage = global::CLINIC_OMAR_05541456466.Properties.Resources.deletedatasource;
            this.BTN_DELETE.Location = new System.Drawing.Point(245, 329);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(83, 43);
            this.BTN_DELETE.TabIndex = 80;
            this.BTN_DELETE.Text = "حذف";
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_CEALE
            // 
            this.BTN_CEALE.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(110)))));
            this.BTN_CEALE.Appearance.Font = new System.Drawing.Font("Mudir MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_CEALE.Appearance.Options.UseBackColor = true;
            this.BTN_CEALE.Appearance.Options.UseFont = true;
            this.BTN_CEALE.ImageOptions.SvgImage = global::CLINIC_OMAR_05541456466.Properties.Resources.clearheaderandfooter;
            this.BTN_CEALE.Location = new System.Drawing.Point(334, 329);
            this.BTN_CEALE.Name = "BTN_CEALE";
            this.BTN_CEALE.Size = new System.Drawing.Size(83, 43);
            this.BTN_CEALE.TabIndex = 79;
            this.BTN_CEALE.Text = "مسح";
            this.BTN_CEALE.Click += new System.EventHandler(this.BTN_CEALE_Click);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(110)))));
            this.BTN_SAVE.Appearance.Font = new System.Drawing.Font("Mudir MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_SAVE.Appearance.Options.UseBackColor = true;
            this.BTN_SAVE.Appearance.Options.UseFont = true;
            this.BTN_SAVE.ImageOptions.SvgImage = global::CLINIC_OMAR_05541456466.Properties.Resources.saveas;
            this.BTN_SAVE.Location = new System.Drawing.Point(67, 329);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(83, 43);
            this.BTN_SAVE.TabIndex = 78;
            this.BTN_SAVE.Text = "حفظ";
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // TXT_DOC_ID
            // 
            this.TXT_DOC_ID.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold);
            this.TXT_DOC_ID.FormattingEnabled = true;
            this.TXT_DOC_ID.Location = new System.Drawing.Point(238, 251);
            this.TXT_DOC_ID.Name = "TXT_DOC_ID";
            this.TXT_DOC_ID.Size = new System.Drawing.Size(66, 31);
            this.TXT_DOC_ID.TabIndex = 76;
            // 
            // TXT_DOC_NAME
            // 
            this.TXT_DOC_NAME.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold);
            this.TXT_DOC_NAME.FormattingEnabled = true;
            this.TXT_DOC_NAME.Location = new System.Drawing.Point(90, 251);
            this.TXT_DOC_NAME.Name = "TXT_DOC_NAME";
            this.TXT_DOC_NAME.Size = new System.Drawing.Size(142, 31);
            this.TXT_DOC_NAME.TabIndex = 77;
            // 
            // BTN_DOC_LIST
            // 
            this.BTN_DOC_LIST.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(214)))));
            this.BTN_DOC_LIST.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.BTN_DOC_LIST.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(131)))), ((int)(((byte)(53)))));
            this.BTN_DOC_LIST.Appearance.Options.UseBorderColor = true;
            this.BTN_DOC_LIST.Appearance.Options.UseFont = true;
            this.BTN_DOC_LIST.Appearance.Options.UseForeColor = true;
            this.BTN_DOC_LIST.Location = new System.Drawing.Point(313, 254);
            this.BTN_DOC_LIST.Name = "BTN_DOC_LIST";
            this.BTN_DOC_LIST.Size = new System.Drawing.Size(113, 28);
            this.BTN_DOC_LIST.TabIndex = 75;
            this.BTN_DOC_LIST.Text = "اسم الطبيب";
            this.BTN_DOC_LIST.Click += new System.EventHandler(this.BTN_DOC_LIST_Click);
            // 
            // TXT_NOTE
            // 
            this.TXT_NOTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NOTE.Location = new System.Drawing.Point(90, 215);
            this.TXT_NOTE.Name = "TXT_NOTE";
            this.TXT_NOTE.Properties.Appearance.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_NOTE.Properties.Appearance.Options.UseFont = true;
            this.TXT_NOTE.Size = new System.Drawing.Size(214, 30);
            this.TXT_NOTE.TabIndex = 74;
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(90, 179);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Properties.Appearance.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_NAME.Properties.Appearance.Options.UseFont = true;
            this.TXT_NAME.Size = new System.Drawing.Size(214, 30);
            this.TXT_NAME.TabIndex = 73;
            // 
            // txt_date
            // 
            this.txt_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_date.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_date.Location = new System.Drawing.Point(90, 107);
            this.txt_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(214, 30);
            this.txt_date.TabIndex = 71;
            // 
            // TXT_DODE
            // 
            this.TXT_DODE.Location = new System.Drawing.Point(90, 71);
            this.TXT_DODE.Name = "TXT_DODE";
            this.TXT_DODE.Properties.Appearance.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_DODE.Properties.Appearance.Options.UseFont = true;
            this.TXT_DODE.Size = new System.Drawing.Size(214, 30);
            this.TXT_DODE.TabIndex = 68;
            // 
            // TXT_CUST_ID
            // 
            this.TXT_CUST_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_CUST_ID.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold);
            this.TXT_CUST_ID.FormattingEnabled = true;
            this.TXT_CUST_ID.Location = new System.Drawing.Point(238, 34);
            this.TXT_CUST_ID.Name = "TXT_CUST_ID";
            this.TXT_CUST_ID.Size = new System.Drawing.Size(66, 31);
            this.TXT_CUST_ID.TabIndex = 66;
            // 
            // TXT_CUST_NAME
            // 
            this.TXT_CUST_NAME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_CUST_NAME.Font = new System.Drawing.Font("Mudir MT", 9F, System.Drawing.FontStyle.Bold);
            this.TXT_CUST_NAME.FormattingEnabled = true;
            this.TXT_CUST_NAME.Location = new System.Drawing.Point(90, 34);
            this.TXT_CUST_NAME.Name = "TXT_CUST_NAME";
            this.TXT_CUST_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_CUST_NAME.Size = new System.Drawing.Size(142, 31);
            this.TXT_CUST_NAME.TabIndex = 67;
            // 
            // BTN_CUST_LIST
            // 
            this.BTN_CUST_LIST.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(214)))));
            this.BTN_CUST_LIST.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.BTN_CUST_LIST.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(131)))), ((int)(((byte)(53)))));
            this.BTN_CUST_LIST.Appearance.Options.UseBorderColor = true;
            this.BTN_CUST_LIST.Appearance.Options.UseFont = true;
            this.BTN_CUST_LIST.Appearance.Options.UseForeColor = true;
            this.BTN_CUST_LIST.Location = new System.Drawing.Point(313, 37);
            this.BTN_CUST_LIST.Name = "BTN_CUST_LIST";
            this.BTN_CUST_LIST.Size = new System.Drawing.Size(113, 28);
            this.BTN_CUST_LIST.TabIndex = 56;
            this.BTN_CUST_LIST.Text = "اسم المريض";
            this.BTN_CUST_LIST.Click += new System.EventHandler(this.BTN_CUST_LIST_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(131)))), ((int)(((byte)(53)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl5.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl5.Enabled = false;
            this.labelControl5.Location = new System.Drawing.Point(313, 113);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 18);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "تاريخ الموعد";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(131)))), ((int)(((byte)(53)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl4.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(313, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 18);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "وقت الموعد";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(131)))), ((int)(((byte)(53)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl3.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(313, 185);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 18);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "اسم الموعد";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(131)))), ((int)(((byte)(53)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl2.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(316, 218);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 18);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "ملاحظات";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(131)))), ((int)(((byte)(53)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl1.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(313, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 18);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "كود المريض";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(110)))));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl9.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl9.Enabled = false;
            this.labelControl9.Location = new System.Drawing.Point(531, 12);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(260, 35);
            this.labelControl9.TabIndex = 45;
            this.labelControl9.Text = "اضافة -تعديل موعد";
            // 
            // frm_APO_ADD
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(162)))), ((int)(((byte)(51)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 646);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.TXT_SEARCH);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_APO_ADD";
            this.Text = "frm_APO_ADD";
            this.Load += new System.EventHandler(this.frm_APO_ADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TXT_SEARCH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NOTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_DODE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TXT_SEARCH;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton BTN_CUST_LIST;
        private DevExpress.XtraEditors.TextEdit TXT_DODE;
        private System.Windows.Forms.ComboBox TXT_CUST_ID;
        private System.Windows.Forms.ComboBox TXT_CUST_NAME;
        private System.Windows.Forms.DateTimePicker txt_date;
        private DevExpress.XtraEditors.TextEdit TXT_NOTE;
        private DevExpress.XtraEditors.TextEdit TXT_NAME;
        private System.Windows.Forms.ComboBox TXT_DOC_ID;
        private System.Windows.Forms.ComboBox TXT_DOC_NAME;
        private DevExpress.XtraEditors.SimpleButton BTN_DOC_LIST;
        private DevExpress.XtraEditors.SimpleButton BTN_UPDATE;
        private DevExpress.XtraEditors.SimpleButton BTN_DELETE;
        private DevExpress.XtraEditors.SimpleButton BTN_CEALE;
        private DevExpress.XtraEditors.SimpleButton BTN_SAVE;
        private System.Windows.Forms.MaskedTextBox TXT_TIME;
    }
}
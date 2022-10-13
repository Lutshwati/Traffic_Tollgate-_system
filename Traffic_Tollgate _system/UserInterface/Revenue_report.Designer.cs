
namespace Traffic_Tollgate__system.UserInterface
{
    partial class Revenue_report
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.userInfoDataSet = new Traffic_Tollgate__system.UserInfoDataSet();
            this.dBMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_MainTableAdapter = new Traffic_Tollgate__system.UserInfoDataSetTableAdapters.DB_MainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Traffic_Tollgate__system.Reports.Revenue_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // userInfoDataSet
            // 
            this.userInfoDataSet.DataSetName = "UserInfoDataSet";
            this.userInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBMainBindingSource
            // 
            this.dBMainBindingSource.DataMember = "DB_Main";
            this.dBMainBindingSource.DataSource = this.userInfoDataSet;
            // 
            // dB_MainTableAdapter
            // 
            this.dB_MainTableAdapter.ClearBeforeFill = true;
            // 
            // Revenue_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Revenue_report";
            this.Text = "Revenue_report";
            this.Load += new System.EventHandler(this.Revenue_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private UserInfoDataSet userInfoDataSet;
        private System.Windows.Forms.BindingSource dBMainBindingSource;
        private UserInfoDataSetTableAdapters.DB_MainTableAdapter dB_MainTableAdapter;
    }
}
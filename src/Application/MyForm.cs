using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XmlNotepad {

    /// <summary>
    /// Example subclass of the XmlNotepad main Form.
    /// </summary>
    public class MyForm : FormMain {

        public override void SaveConfig() {
            base.SaveConfig();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.tabPageTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageTreeView
            // 
            this.tabPageTreeView.Location = new System.Drawing.Point(0, 23);
            this.tabPageTreeView.Size = new System.Drawing.Size(1223, 656);
            // 
            // tabPageHtmlView
            // 
            this.tabPageHtmlView.Location = new System.Drawing.Point(0, 23);
            this.tabPageHtmlView.Size = new System.Drawing.Size(1223, 656);
            // 
            // MyForm
            // 
            this.Caption = "SLQJXML";
            this.ClientSize = new System.Drawing.Size(1223, 845);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tabPageTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
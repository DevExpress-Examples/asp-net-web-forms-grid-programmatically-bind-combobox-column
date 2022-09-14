using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using DevExpress.Web;

namespace Solution {
    public partial class Default : System.Web.UI.Page {
        List<BugStatus> statuses;
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView1.DataSource = Bug.GetBugList();
            ASPxGridView1.KeyFieldName = "Id";

            statuses = BugStatus.GetStatusesList();
            ((GridViewDataComboBoxColumn)ASPxGridView1.Columns["Status"]).PropertiesComboBox.DataSource = statuses;
        }
        protected void Page_Load(object sender, EventArgs e) {
            ASPxGridView1.DataBind();
        }


        protected void ASPxGridView1_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e) {
            if (e.Column.FieldName == "Status") {
                ASPxComboBox combo = (ASPxComboBox)e.Editor;
                combo.DataBind();
            }
        }

        protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
            // this demo does not fully implement editing capabilities
            e.Cancel = true;
            ASPxGridView1.CancelEdit();
        }
    }
}
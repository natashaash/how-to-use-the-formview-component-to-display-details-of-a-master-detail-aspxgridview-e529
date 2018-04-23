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
using DevExpress.Web.ASPxGridView;

namespace FormViewAsDetail {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load (object sender, EventArgs e) {

        }
        protected void FormView1_DataBinding (object sender, EventArgs e) {
            FormView fv = (FormView)sender;
            GridViewDetailRowTemplateContainer row = (GridViewDetailRowTemplateContainer)fv.Parent;
            fv.DataSource = SqlDataSource2;
            SqlDataSource2.SelectParameters["CategoryID"].DefaultValue = row.KeyValue.ToString();
        }
    }
}

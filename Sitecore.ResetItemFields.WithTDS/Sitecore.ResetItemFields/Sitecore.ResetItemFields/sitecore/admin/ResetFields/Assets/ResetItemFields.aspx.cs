using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sitecore.ResetItemFields.sitecore.admin.ResetFields.Assets
{
    public partial class ResetItemFields : Sitecore.sitecore.admin.AdminPage
    {
        protected override void OnInit(EventArgs e)
        {
            base.CheckSecurity(true); 
            base.OnInit(e);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
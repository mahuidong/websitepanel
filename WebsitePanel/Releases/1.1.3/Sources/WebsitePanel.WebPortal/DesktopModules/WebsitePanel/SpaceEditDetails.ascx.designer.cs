//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsitePanel.Portal {
    
    public partial class SpaceEditDetails {
        protected System.Web.UI.WebControls.Label lblMessage;
        protected System.Web.UI.HtmlControls.HtmlTable tblEditPackage;
        protected System.Web.UI.WebControls.Label lblSpaceName;
        protected System.Web.UI.WebControls.TextBox txtName;
        protected System.Web.UI.WebControls.RequiredFieldValidator nameValidator;
        protected System.Web.UI.WebControls.Label lblComments;
        protected System.Web.UI.WebControls.TextBox txtComments;
        protected System.Web.UI.WebControls.Label lblCreationDate;
        protected WebsitePanel.Portal.CalendarControl PurchaseDate;
        protected System.Web.UI.WebControls.Label lblHostingPlan;
        protected System.Web.UI.WebControls.DropDownList ddlPlan;
        protected System.Web.UI.WebControls.RequiredFieldValidator planValidator;
        protected System.Web.UI.WebControls.Label lblTargetServer;
        protected WebsitePanel.Portal.ServerDetails serverDetails;
        protected WebsitePanel.Portal.CollapsiblePanel secAddons;
        protected System.Web.UI.WebControls.Panel AddonsPanel;
        protected System.Web.UI.WebControls.Button btnAddAddon;
        protected System.Web.UI.WebControls.GridView gvAddons;
        protected WebsitePanel.Portal.CollapsiblePanel secQuotas;
        protected System.Web.UI.WebControls.Panel QuotasPanel;
        protected System.Web.UI.HtmlControls.HtmlTable tblQuotas;
        protected System.Web.UI.HtmlControls.HtmlTable tblOverrideQuotas;
        protected System.Web.UI.WebControls.RadioButton rbPlanQuotas;
        protected System.Web.UI.WebControls.RadioButton rbPackageQuotas;
        protected WebsitePanel.Portal.SpaceQuotasControl packageQuotas;
        protected WebsitePanel.Portal.HostingPlansQuotas editPackageQuotas;
        protected System.Web.UI.WebControls.Button btnSave;
        protected System.Web.UI.WebControls.Button btnCancel;
    }
}

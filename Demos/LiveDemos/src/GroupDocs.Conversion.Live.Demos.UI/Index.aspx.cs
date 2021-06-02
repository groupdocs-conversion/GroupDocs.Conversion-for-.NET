using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupDocs.Conversion.Live.Demos.UI.Models;
using GroupDocs.Conversion.Live.Demos.UI.Config;
using GroupDocs.Conversion.Live.Demos.UI.Helpers;

namespace GroupDocs.Conversion.Live.Demos.UI
{
	public partial class Index : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string productName = "";
				Control _productFamily;

				if (Page.RouteData.Values.Count > 0)
				{
					productName = Page.RouteData.Values["PageName"].ToString();
				}
				if (productName != "")
				{
					if (productName == "conversion")
					{
						//Load the control   
						_productFamily = (Control)Page.LoadControl("MasterControls/CtrlConversions.ascx");

						// Add the control to the panel  
						phPages.Controls.Add(_productFamily);
					}
					else if (productName != "WebResource.axd")
					{
						Response.Redirect("~/errorpage");
					}
				}
			}

		}
	}
}
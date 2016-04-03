using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace WebApplication3
{
    public partial class Small_Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GuesRespone rvsp = new GuesRespone();

                if (TryUpdateModel(rvsp, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    ResponeRepository.GetRespon().addRespone(rvsp);

                    if (rvsp.WILLATTEND.HasValue == true && rvsp.WILLATTEND.Value == true)
                    {
                        Response.Redirect("seeyouthere.html");
                    }
                    else
                    {
                        Response.Redirect("sorryyoucancome.html");
                    }
                }
                
            }
        }
    }
}
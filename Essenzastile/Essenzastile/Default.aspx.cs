using Essenzastile.DataProvider;
using System;

namespace Essenzastile
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ProductoDataProvider productoDataProvider = new ProductoDataProvider();
                rptProdPortal.DataSource = productoDataProvider.GetAllProducts();
                rptProdPortal.DataBind();
            }
        }

        public string SetPricesProduct(decimal precioProducto )
        {
            return "S/ " + precioProducto.ToString();

        }

    }
}
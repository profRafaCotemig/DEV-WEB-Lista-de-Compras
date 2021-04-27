using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV_Lista_de_Compras
{
    public partial class ListaCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            item.Focus();
        }

        protected void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (item.Text.Length == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Digite um item para adicionar!')", true);
            }
            else {
                ListItens.Items.Add(item.Text);
                item.Text = "";
            }
        }

        protected void BtnRemoverSelecao_Click(object sender, EventArgs e)
        {

        }

        protected void BtnRemoverTodos_Click(object sender, EventArgs e)
        {

        }

        protected void BtnOrdenar_Click(object sender, EventArgs e)
        {

        }
    }
}
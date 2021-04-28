using System;
using System.Collections;
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
            if (ListItens.SelectedIndex < 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Selecione um item para remover!')", true);
            }
            else {
                ListItens.Items.RemoveAt(ListItens.SelectedIndex);
            }
        }

        protected void BtnRemoverTodos_Click(object sender, EventArgs e)
        {
            if (ListItens.Items.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Não tem itens a ser removido!')", true);
            }
            else {
                ListItens.Items.Clear();
            }
        }

        protected void BtnOrdenar_Click(object sender, EventArgs e)
        {
            if (ListItens.Items.Count < 2)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Não tem itens suficiente para ordenar!')", true);
            }
            else {
                ArrayList ListBoxArray = new ArrayList();

                for (int i = 0; i < ListItens.Items.Count; i++) {
                    ListBoxArray.Add(ListItens.Items[i].Value);
                }
                ListItens.Items.Clear();

                ListBoxArray.Sort();

                ListItens.DataSource = ListBoxArray;
                ListItens.DataBind();
            }
        }
    }
}
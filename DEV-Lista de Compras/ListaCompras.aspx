<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaCompras.aspx.cs" Inherits="DEV_Lista_de_Compras.ListaCompras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Lista Compras</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    
</head>
<body>
    <form id="form1" runat="server">

        <h1 class="text-center p-3 mb-2 bg-primary text-white">Minha Lista de Compras</h1>

        <div>
            <asp:Label for="item" runat="server" Text="Entre com um novo item:"></asp:Label>
            <asp:TextBox ID="item" runat="server"></asp:TextBox>
            <asp:Button ID="BtnAdicionar" Text="Adicionar item"
                Class="btn btn-outline-success" runat="server"
                OnClick="BtnAdicionar_Click" />
        </div>
        <div class="media">
            <asp:ListBox Rows="10" ID="ListItens" runat="server" Width="426px"></asp:ListBox>
        </div>
        <div>
            <asp:Button ID="BtnRemoverSelecao" runat="server" Text="Remover selecionado"
                Class="btn btn-outline-success" OnClick="BtnRemoverSelecao_Click" />
            <asp:Button ID="BtnRemoverTodos" runat="server" Text="Remover todos"
                Class="btn btn-outline-success" OnClick="BtnRemoverTodos_Click" />
            <asp:Button ID="BtnOrdenar" runat="server" Text="Ordenar"
                Class="btn btn-outline-success" OnClick="BtnOrdenar_Click" />
        </div>
    </form>
</body>
</html>

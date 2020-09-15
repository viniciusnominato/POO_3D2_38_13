<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLivraria.aspx.cs" Inherits="POO_3D2_38_13.UI.FrmLivraria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Livro</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
           <h1 class="h3 mb-3 font-weight-normal">CRUD Livraria</h1>
            
             
             <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
              <br />
             <asp:Label ID="lblTitulo" runat="server" Text="Titulo "></asp:Label>
             <asp:TextBox ID="txtTitulo" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblNumPaginas" runat="server" Text="Número de Páginas "></asp:Label>
             <asp:TextBox ID="txtNumPaginas" type="number" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblValor" runat="server" Text="Valor"></asp:Label>
             <asp:TextBox ID="txtValor" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblEditora" runat="server" Text="Editora"></asp:Label>
             <asp:DropDownList ID="drpEditora" runat="server" CssClass="form-control"></asp:DropDownList>

             <asp:Label ID="lblAutor" runat="server" Text="Autor"></asp:Label>
             <asp:DropDownList ID="drpAutor" runat="server" CssClass="form-control"></asp:DropDownList>

            <br />
            <br />
            <asp:Button ID="btnInserir" class="btn btn-lg btn-primary" runat="server" Text="Gravar" OnClick="btnInserir_Click" />
            <br />
            <br />
            <br />
                <asp:GridView ID="GridClientes"  CssClass="table table-striped" runat="server" OnRowCancelingEdit="GridClientes_RowCancelingEdit" OnRowDeleting="GridClientes_RowDeleting" OnRowEditing="GridClientes_RowEditing" OnRowUpdating="GridClientes_RowUpdating" >
             
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                        <asp:CommandField ButtonType="Button" ShowEditButton="True" UpdateText="Salvar" />
                    </Columns>
                    
                </asp:GridView>
      
        </div>

    </form>
</body>
</html>
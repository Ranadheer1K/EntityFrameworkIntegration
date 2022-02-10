<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="EntityFrameworkIntegration.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox> <br/> <br/>

            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox> <br/> <br/>

            <asp:Label ID="lblCrs" runat="server" Text="Course"></asp:Label>
            <asp:TextBox ID="txtCrs" runat="server"></asp:TextBox> <br/> <br/>

            <asp:Label ID="lblFee" runat="server" Text="Fee"></asp:Label>
            <asp:TextBox ID="txtFee" runat="server"></asp:TextBox> <br/> <br/>

            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        </div>
    </form>
</body>
</html>

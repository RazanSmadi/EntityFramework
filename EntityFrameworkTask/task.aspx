<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="task.aspx.cs" Inherits="EntityFrameworkTask.task" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>

</head>
<body>
      <nav class="navbar navbar-expand-lg navbar-light bg-light">
  <div class="container-fluid">
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo01" aria-controls="navbarTogglerDemo01" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarTogglerDemo01">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="task.aspx">admin</a>
        </li>
          <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="view_C.aspx">view</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
    <form id="form1" runat="server">
           <div>
            <h1>create new Customer:</h1>
            <table class="table table-striped">
                <tr>
                    <td>name:</td>
                    <td>
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>age:</td>
                    <td>
                        <asp:TextBox ID="age" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>city:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>phone:</td>
                    <td>
                        <asp:TextBox ID="phone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>email:</td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>photo:</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>

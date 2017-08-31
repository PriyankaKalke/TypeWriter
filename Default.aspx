<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TypeWriter._Default" %>

<html>
<head>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<script>
    $(document).ready(function () {
        $("button").click(function () {
            $("#test").hide();
        });
    });
</script>
</head>

    
    <head>
        <script type = "text/javascript" src = "https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>

      <script type = "text/javascript">
          $(document).ready(function () {
              $("#btnCompare").click(function () {
                  $("p").hide();
              });
          });
      </script>         
    </head>
    <body>
        <form id="form1" runat="server">
        <h3>Type Writer</h3>
        <table>
            <tr>
                <td>
                    <div>
                        <asp:TextBox ID="txtInput" runat="server" Height="200px" Width="400px" Wrap="true" TextMode="MultiLine"></asp:TextBox>
                        
                    </div>
                </td>
                <td>
                    <div>
                        <asp:TextBox ID="txtOutput" runat="server" Height="200px" Width="400px" Wrap="true" TextMode="MultiLine" ></asp:TextBox>

                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                <asp:Label ID="lbltext" runat="server"></asp:Label>
                <td colspan="2">
            </tr>
            <tr>
                <td colspan="2">                
                    <asp:Button ID="btnCompare" runat="server"  Text="Compare" OnClick="btnCompare_Click" />
                </td>
            </tr>
        </table>

        </form>

    </body>
        
</html>




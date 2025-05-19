<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuadraticEquations.aspx.cs" Inherits="UsingWebservicesFinal.QuadraticEquations" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quadratic Equation Solver</title>
    <style>
        table {
            margin-top: 50px;
            border-collapse: collapse;
        }
        td {
            padding: 10px;
        }
        input[type="text"] {
            width: 100px;
        }
        .btn {
            margin-right: 10px;
            padding: 8px 16px;
        }
        .result {
            margin-top: 20px;
            font-weight: bold;
            color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h2>Quadratic Equation Solver</h2>
            <table border="0">
                <tr>
                    <td>Enter coefficient a:</td>
                    <td><asp:TextBox ID="txtA" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter coefficient b:</td>
                    <td><asp:TextBox ID="txtB" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter coefficient c:</td>
                    <td><asp:TextBox ID="txtC" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnFormula" CssClass="btn" runat="server" Text="Solve by Formula" OnClick="btnFormula_Click" />
                        <asp:Button ID="btnSquare" CssClass="btn" runat="server" Text="Complete the Square" OnClick="btnSquare_Click" />
                        <asp:Button ID="btnFactor" CssClass="btn" runat="server" Text="Solve by Factoring" OnClick="btnFactor_Click" />
                    </td>
                </tr>
            </table>

            <asp:Label ID="lblResult" runat="server" CssClass="result"></asp:Label>
        </div>
    </form>
</body>
</html>

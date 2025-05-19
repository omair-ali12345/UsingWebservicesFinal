<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UsingWebservicesFinal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Currency Converter</title>
    <style>
         body { font-family: Arial; padding: 50px; }
 label { display: block; margin-top: 15px; }
 select, input, button { padding: 8px; width: 200px; margin-top: 5px; }
 .result { margin-top: 20px; font-size: 1.2em; color: green; }
    </style>
        
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 50px;">
            <h2>Currency Converter</h2>

            <label>From Currency:</label>
            <select id="fromCurrency" runat="server">
                <option value="USD">USD</option>
                <option value="EUR">EUR</option>
                <option value="GBP">GBP</option>
                <option value="INR">INR</option>
                <option value="JPY">JPY</option>
                <option value="CAD">CAD</option>
                <option value="AUD">AUD</option>
                <option value="CHF">CHF</option>
                <option value="CNY">CNY</option>
                <option value="SGD">SGD</option>
            </select>
            <br /><br />

            <label>To Currency:</label>
            <select id="toCurrency" runat="server">
                <option value="USD">USD</option>
                <option value="EUR">EUR</option>
                <option value="GBP">GBP</option>
                <option value="INR">INR</option>
                <option value="JPY">JPY</option>
                <option value="CAD">CAD</option>
                <option value="AUD">AUD</option>
                <option value="CHF">CHF</option>
                <option value="CNY">CNY</option>
                <option value="SGD">SGD</option>
            </select>
            <br /><br />

            <label>Amount:</label>
            <input type="text" id="amount" runat="server" />
            <br /><br />

            <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
            <br /><br />

            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

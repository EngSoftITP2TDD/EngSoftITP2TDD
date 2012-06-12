<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    
   

</head>
<body>
    <h1>VERIFICA POTZ!</h1>
    <form id="frmVerificarPotz" runat="server">
			<label>Digite o numero do Cupom POTZ</label>
			<input name="txtPotz" type="text"/>			
            <br/>
			<asp:Button 
                        id="btnVerificaPOTZ"
                        runat="server"
                        onclick="btnTesteVerificar_Click" 
                        text="Verificar POTZ">
            </asp:Button>
			<br/>
			<asp:Button 
                        id="btnTesteVerificar"
                        runat="server"
                        onclick="btnTesteVerificar_Click" 
                        text="Teste: Verificar POTZ">
            </asp:Button>
	</form>
    
    <div>
    <br />
    <asp:Label id="lblResultado" runat="server"></asp:Label>
    </div>

</body>
</html>

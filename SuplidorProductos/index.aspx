<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SuplidorProductos.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="mystyle.css">
    <title></title>
</head>
<body>
<form runat="server">
<div class="form-style-2">
<div class="form-style-2-heading">Provide your information</div>
<form action="" method="post">
<label for="field1"><span>Name <span class="required">*</span></span><asp:TextBox ID="name" runat="server" type="text" class="input-field" name="field1" value=""/></label>
<label for="field2"><span>Email <span class="required">*</span></span><asp:TextBox ID="email" runat="server" type="text" class="input-field" name="field2" value="" /></label>
<label><span>Telephone</span><asp:TextBox runat="server" ID="tel1" type="text" class="tel-number-field" name="tel_no_1" value="" maxlength="3" />-<asp:TextBox ID="tel2" runat="server" type="text" class="tel-number-field" name="tel_no_2" value="" maxlength="3"  />-<asp:TextBox ID="tel3" runat="server" type="text" class="tel-number-field" name="tel_no_3" value="" maxlength="4"  /></label>
<label for="field5"><span>Message <span class="required">*</span></span><asp:TextBox ID="message" runat="server" TextMode="MultiLine" name="field5" class="textarea-field"></asp:TextBox></label>

<label><span>&nbsp;</span><asp:Button runat="server" Text="Submit" OnClick="Unnamed7_Click" /></label>
</form>
</div>
    </form>
</body>
</html>

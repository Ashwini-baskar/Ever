<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlipEverLogin.aspx.cs" Inherits="FlipEver.FlipEverLogin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="latestJs_1.11/jquery.min.js"></script>
    <link href="style/FlipEver.css" rel="stylesheet" />
   <script src="Script/External/jquery.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.2.1.min.js"></script>
   
</head>
<body id="formbody">
    <form id="form2" runat="server">
    <div id="logh1">  <pre>
    <h1 > login Page</h1>
      
    UserName: <input id="txt_UserName" type="text" />
            
    Password: <input id="txt_password" type="text" />
       
    <h1> vanakam Sir</h1>
    <input id="Btn_log" type="button" value="login"  />
        </pre>
  </div>
        <pre><a href="FlipEverReg.aspx">Register Here</a></pre>

    
        <asp:Button Id="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
        <asp:FileUpload ID="FileUpload_bt" runat="server" />
        <asp:Image ID="Image1" runat="server" />
    
       
    </form>
    <script src="Script/Internal/Pagescript/FlipEverLogin.js"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    
</body>
</html>

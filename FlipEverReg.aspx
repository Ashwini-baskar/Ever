<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlipEverReg.aspx.cs" Inherits="FlipEver.FlipEverReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="style/FlipEver.css" rel="stylesheet" />
   <script src="Script/External/jquery.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.2.1.min.js"></script>
</head>
<body id="formbody">
    <form id="form1" runat="server">
    <div>
        <div id="logh1">  <pre>
    <h1 > Registration Page</h1>
      
   Enter your Name: <input id="txt_UserName" type="text" />
            
   Enter your Password: <input id="txt_password" type="text" />
       
    
    <input id="Btn_Reg" type="button" value="Register"  />
        </pre>
  </div><pre>
       <input type="file" class="upload"  id="f_UploadImage"><br />
       <img id="myUploadedImg" alt="Photo" style="width:180px;" src="" />
        </pre>
      
       
   
    <script src="Script/Internal/Pagescript/FlipEverLogin.js"></script>
   
       
    </form>
       
</body>
</html>

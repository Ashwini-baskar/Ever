<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlipEverHomePage.aspx.cs" Inherits="FlipEver.FlipEverHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>www.Flipever</title>
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.2.1.min.js"></script>
    <script src="Script/External/jquery.min.js"></script>
    <link href="style/FlipEver.css" rel="stylesheet" />
</head>
<body id="formbody">
    
    <form id="form1" runat="server">
        <div id="h1div">
    <h1>FlipEver</h1></div>
        <div id="divccss">
       
            <pre>
        Product categories:<select id="Select_Prodt" >
             <option>Dress</option>
             <option>cosmeticitem</option>
             <option>Stationary</option>
             </select>

        Product Name: <input id="Txt_pdname" type="text" />

        Product Id :  <input id="Txt_pdid" type="text" /> 

        price      :  <input id="Txt_price" type="text" />

        Quantity   :  <input id="Txt_qty" type="text" />
                
        Message    :  <input id="Txt_Billamt" type="text" /> 
    </pre>
            
<pre>
       
     <input id="Btn_Save" type="button" value="Add To Cart" />   <input id="Btn_Edit" type="button" value="Edit" /> <input id="Btn_Del" type="button" value="Delete" />  
          
    <input id="Btn_view" type="button" value="ViewAmount and ProductDetails" />  <input id="Btn_Select" type="button" value="All Item Details"  /> 
       
      <asp:Button ID="Bt_upload" runat="server" Text="show image" OnClick="Bt_upload_Click" />    <asp:FileUpload ID="FileUpload_file" runat="server"></asp:FileUpload>

     <asp:Button ID="Button_download" runat="server" Text="download file/image" OnClick="Button_download_Click"></asp:Button> 
     

</pre><div>          
  <asp:Image ID="Image_display" runat="server" />
 </div>   
         
 
        <div id="divData">

        </div></div>
    </form>
    
</body>
<script src="Script/Internal/Pagescript/FlipEverHomePage.js"></script>
</html>

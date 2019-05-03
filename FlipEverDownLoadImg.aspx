<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="FlipEverDownLoadImg.aspx.cs" Inherits="FlipEver.WebForm1" Async="true" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.2.1.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
        <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal">
        <ItemTemplate>
        <center>
            <asp:Image ID="Image1" ImageUrl='<%#"MediaUpload/" + Container.DataItem %>' runat="server" Width="150" Height="150" />
            <br />
           
           
             <a href='<%#string.Format("DownloadHandler.ashx?ImageName={0}",Container.DataItem)%>' target="_blank">Download</a>
         
            </center>
        </ItemTemplate>
        </asp:DataList>
    </div>
        

        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" EmptyDataText="No files available">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:CheckBox ID="chkSelect" runat="server" />
                <asp:Label ID="lblFilePath" runat="server" Text='<%# Eval("Value") %>' Visible="false"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Text" HeaderText="File Name" />
    </Columns>
</asp:GridView>
<br />
<asp:Button ID="Button2" runat="server" Text="Download" OnClick="DownloadFiles" />
        </div>

        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" /> &nbsp; <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
    <asp:FileUpload ID="FileUpload2" runat="server" /> &nbsp; <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
    <asp:FileUpload ID="FileUpload3" runat="server" /> &nbsp; <asp:Label ID="Label3" runat="server" Text=""></asp:Label><br /><br />
    <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
        </div>
    </form>
</body>
</html>

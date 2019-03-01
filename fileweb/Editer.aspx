<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editer.aspx.cs" Inherits="fileweb.Editer" %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

       <asp:Label ID="Label1" runat="server" Text="文章标题" BorderStyle="None" 
           Font-Size="Large"></asp:Label>
&nbsp;：&nbsp; 
    <asp:TextBox ID="TextBox1" runat="server" BorderColor="#66CCFF" 
        BorderStyle="Solid">Article_Chapter_One</asp:TextBox>
&nbsp;<br />
  <FTB:FreeTextBox ID="FreeTextBox1" runat="server" ButtonSet="OfficeMac" 
    Height="400px" Width="100%" DownLevelMode="TextArea"> </FTB:FreeTextBox>
        
       <br />

       <asp:Button ID="Button1" runat="server" Text="保存" 
    onclick="Button1_Click" BackColor="#999999" BorderColor="#999999" 
    BorderStyle="Solid" Width="100%" />

    <div runat="server" style="position:fixed; top:0px; left:0px; z-index:0;">
    
            <table style="width:80px;">
           <%=pagedir()%>
          </table>
    
    </div>
</asp:Content>

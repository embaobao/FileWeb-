<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="fileweb._Default" %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <h2>
        欢迎使用 we room!
    </h2>
  <div>

<asp:UpdatePanel ID="UpdatePanel2" runat="server" ChildrenAsTriggers="False" 
          UpdateMode="Conditional">
    <ContentTemplate>
        <p> 公共消息：&nbsp;</p>  

          <asp:ListBox ID="ListBox1" runat="server" Height="113px" Width="60%">
          </asp:ListBox>

          <div style="position:fixed; left:2%; top:2%;">
         <asp:Repeater ID="Repeater1" runat="server" >
        <HeaderTemplate>
        <table>
        </HeaderTemplate>
        <ItemTemplate>
        
        
        </ItemTemplate>
        <AlternatingItemTemplate></AlternatingItemTemplate>
        <FooterTemplate>
           </table>
        </FooterTemplate>
        </asp:Repeater>
        </div>
          <p>
    <asp:Label ID="Label2" runat="server" Text="您的消息准备发射中..."></asp:Label>
    </p>

    </ContentTemplate>
    <Triggers>
    <asp:AsyncPostBackTrigger  EventName="Tick"  ControlID="Timer1"/>
    </Triggers>
    </asp:UpdatePanel>

          <asp:UpdatePanel ID="UpdatePanel3" runat="server" ChildrenAsTriggers="False" 
               UpdateMode="Conditional" RenderMode="Inline">
        <ContentTemplate>

            <p>
               向下面的文本框输入 ↓  向我的世界 发送公共消息：</p>
           <p>
                &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="325px"></asp:TextBox>
                &nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="发送" 
                    BorderColor="#99CCFF" BorderStyle="Solid" BorderWidth="1px" Height="23px" 
                    style="margin-top: 0px" Width="71px" />
            </p>


        </ContentTemplate>
       <Triggers>
       <asp:AsyncPostBackTrigger  ControlID="Button2"  EventName ="click" />
       </Triggers>
</asp:UpdatePanel>
       
    <asp:FileUpload ID="FileUpload1" runat="server" />
   <asp:Button ID="Button1" runat="server"   Text="上传" onclick="Button1_Click" />
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
      <asp:Label ID="Label1" runat="server" Text="文件共享机制"></asp:Label><br />
      <table>
      <%=filetxt%>
      </table>
         
    </ContentTemplate>
    <Triggers>
    <asp:PostBackTrigger ControlID="Button1" />
    </Triggers>
    </asp:UpdatePanel>
</div>
    <asp:Timer ID="Timer1" runat="server" ontick="Timer1_Tick">
    </asp:Timer>
</asp:Content>

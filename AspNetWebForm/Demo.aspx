<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master"
    EnableEventValidation="false"
    AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="AspNetWebForm._Demo" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="BodyContent" runat="server" >

    <div class="jumbotron" >
        <h1>ASP.NET</h1>
        <p class="lead" >Demo</p>
        <p>
            <a class="btn btn-lg btn-primary" href="http://www.asp.net" >Books</a>
        </p>
    </div>

    <div class="row" >
        <asp:GridView runat="server" ID="gv" OnRowDataBound="gv_OnRowDataBound" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="Title" HeaderText="標題" >
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Author" HeaderText="作者" >
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Genre" HeaderText="類型" >
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="價格" >
                    <ItemTemplate>
                        <asp:Label ID="lb_price" runat="server" ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="出版日期">
                    <ItemTemplate>
                        <asp:Label ID="lb_publish_date" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="功能列">
                    <ItemTemplate>
                        <asp:Button ID="btn_edit" runat="server" Text="編輯" CommandName="Edit" OnClick="btn_edit_Click" ></asp:Button>
                        <asp:Button ID="btn_delete" runat="server" Text="刪除" CommandName="Delete" OnClick="btn_delete_Click" ></asp:Button>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>

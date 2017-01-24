<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RssFeedWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Read RSS Feed from the Keskisuomalainen</h3>

    <div style="max-height:350px; overflow:auto">
        <asp:GridView ID="gvRss" runat="server" AutoGenerateColumns="false" ShowHeader="false" Width="90%">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table border="0">
                            <tr>
                                <td>
                                    <h3><%#Eval("Title") %></h3>
                                </td>
                                <td>
                                    <%#Eval("PublishDate") %>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <%#Eval("Description") %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="<%#Eval("Link") %>" target="_blank">Read More...</a>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>

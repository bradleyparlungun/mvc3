<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MvcEmule._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#button").click(function () {
                var input = $("#input").val();
                var url = "/home/test/" + input;
                window.location = url;
            });
        });
    </script>
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to the 'ASP.NET MVC Simulator'!
    </h2>
    <p>
        Enter some text: 
        <input id="input" type="text" value="65" />
        <input id="button" type="button" value="Place the call" />
    </p>
    <p>
        ... or just follow the <a href="/home/test/34">link</a>.
    </p>
</asp:Content>

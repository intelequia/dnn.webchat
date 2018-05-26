<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="Intelequia.Bot.Dnn.Modules.Webchat.View" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>

<dnn:DnnCssInclude runat="server" FilePath="~/DesktopModules/dnn.webchat/Css/botchat.css"></dnn:DnnCssInclude>
<dnn:DnnCssInclude runat="server" FilePath="~/DesktopModules/dnn.webchat/Css/bubbledWebChat.css"></dnn:DnnCssInclude>

<dnn:DnnJsInclude runat="server" FilePath="~/DesktopModules/dnn.webchat/Scripts/botchat.js" Priority="18"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" FilePath="~/DesktopModules/dnn.webchat/Scripts/CustomWebchat.js" Priority="19"></dnn:DnnJsInclude>
<dnn:DnnJsInclude runat="server" FilePath="~/DesktopModules/dnn.webchat/Scripts/View.js" Priority="20"></dnn:DnnJsInclude>



<div id="chatBody">
    
</div>

<script>
    $(document).on("keypress",
    "#chatBody input",
    function (e) {
        if (e.which === 13) {
            e.preventDefault();
            e.stopPropagation();
        }
    });
</script>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Settings.ascx.cs" Inherits="Intelequia.Bot.Dnn.Modules.Webchat.Settings" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>




<!-- uncomment the code below to start using the DNN Form pattern to create and update settings -->


<%@ Register TagName="label" TagPrefix="dnn" Src="~/controls/labelcontrol.ascx" %>

<h2 id="dnnSitePanel-BasicSettings" class="dnnFormSectionHead"><a href="" class=""><%=LocalizeString("BasicSettings")%></a></h2>

<div class="dnnFormItem">
    <dnn:Label runat="server" ControlName="ChoiceDropDown" ResourceKey="lblChoiceDropDown" />
    <asp:DropDownList runat="server" ID="ChoiceDropDown" CssClass="SelectChannel">
        <asp:ListItem Text="-- Make a Choice --" />
        <asp:ListItem Text="Web Chat" />
        <asp:ListItem Text="Skype" />
        <asp:ListItem Text="Facebook" />
    </asp:DropDownList>
</div>
<hr />

<!-- Webchat section -->
<div id="webchatSection">
    <h4>Web Chat Options</h4>
    <div class="dnnFormItem">
    <dnn:Label runat="server" ControlName="WebchatType" ResourceKey="lblWebchatType" />
    <asp:DropDownList runat="server" ID="WebchatType" CssClass="SelectWebchatType">
        <asp:ListItem Text="Classic Webchat"/>
        <asp:ListItem Text="Bubbled Side Webchat" />
    </asp:DropDownList>
</div>
    <div class="dnnFormItem">
        <dnn:Label ID="WebchatBotName" runat="server" />
        <asp:TextBox ID="txtWebchatBotName" runat="server" />
    </div>
    <div class="dnnFormItem">
        <dnn:Label ID="WebchatSetting1" runat="server" />
        <asp:TextBox ID="txtWebchatSetting1" runat="server" />
    </div>
    <hr />
    <h4>Css options</h4>
    <a class="ExpandOrContract" onclick="expandOrContract()">
        Expandir todo
    </a>
    <div class="mspsContent dnnClear">
        <h2 id="dnnPanel-ModuleAppearance1" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Font General Settings</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:Label ID="WcFontFamily" runat="server" />
                <asp:TextBox ID="txtWcFontFamily" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:Label ID="WcFontSize" runat="server" />
                <asp:TextBox ID="txtWcFontSize" runat="server" />
            </div>
        </fieldset>


        <h2 id="dnnPanel-ModuleAppearance2" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Buttons</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:Label ID="WcButtonBackgroundColor" runat="server" />
                <input type="color" id="colorButton3" />
                <asp:TextBox ID="txtWcButtonBackgroundColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:Label ID="WcButtonBorderColor" runat="server" />
                <input type="color" id="colorButton4" />
                <asp:TextBox ID="txtWcButtonBorderColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:Label ID="WcButtonTextColor" runat="server" />
                <input type="color" id="colorButton5" />
                <asp:TextBox ID="txtWcButtonTextColor" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance3" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Header</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcHeaderBackgroundColor" runat="server" />
                <input type="color" id="colorButton6" />
                <asp:TextBox ID="txtWcHeaderBackgroundColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcHeaderBoxshadowColor" runat="server" />
                <input type="color" id="colorButton7" />
                <asp:TextBox ID="txtWcHeaderBoxshadowColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcHeaderTextColor" runat="server" />
                <input type="color" id="colorButton8" />
                <asp:TextBox ID="txtWcHeaderTextColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcHeaderHeight" runat="server" />
                <asp:TextBox ID="txtWcHeaderHeight" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcHeaderPadding" runat="server" />
                <asp:TextBox ID="txtWcHeaderPadding" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance4" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Buttons</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcTimeTextColor" runat="server" />
                <input type="color" id="colorButton9" />
                <asp:TextBox ID="txtWcTimeTextColor" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance5" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Message text position</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageBottom" runat="server" />
                <asp:TextBox ID="txtWcMessageBottom" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageBoxTop" runat="server" />
                <asp:TextBox ID="txtWcMessageBoxTop" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance6" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Suggested actions</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedActionsBottom" runat="server" />
                <asp:TextBox ID="txtWcSuggestedActionsBottom" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedTextButtonColor" runat="server" />
                <input type="color" id="colorButton10" />
                <asp:TextBox ID="txtWcSuggestedTextButtonColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedTextButtonColorFocus" runat="server" />
                <input type="color" id="colorButton11" />
                <asp:TextBox ID="txtWcSuggestedTextButtonColorFocus" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedBorderColorFocus" runat="server" />
                <input type="color" id="colorButton12" />
                <asp:TextBox ID="txtWcSuggestedBorderColorFocus" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedButtonBackgroundcolorFocus" runat="server" />
                <input type="color" id="colorButton13" />
                <asp:TextBox ID="txtWcSuggestedButtonBackgroundcolorFocus" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedTextButtonColorActive" runat="server" />
                <input type="color" id="colorButton14" />
                <asp:TextBox ID="txtWcSuggestedTextButtonColorActive" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedBorderColorActive" runat="server" />
                <input type="color" id="colorButton15" />
                <asp:TextBox ID="txtWcSuggestedBorderColorActive" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedButtonBackgroundcolorActive" runat="server" />
                <input type="color" id="colorButton16" />
                <asp:TextBox ID="txtWcSuggestedButtonBackgroundcolorActive" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedButtonScrollBackgroundcolor" runat="server" />
                <input type="color" id="colorButton17" />
                <asp:TextBox ID="txtWcSuggestedButtonScrollBackgroundcolor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedButtonScrollBackgroundcolorFocus" runat="server" />
                <input type="color" id="colorButton18" />
                <asp:TextBox ID="txtWcSuggestedButtonScrollBackgroundcolorFocus" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcSuggestedButtonScrollSvgFillColor" runat="server" />
                <input type="color" id="colorButton19" />
                <asp:TextBox ID="txtWcSuggestedButtonScrollSvgFillColor" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance7" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Message Content From</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageContentBoxShadowColor" runat="server" />
                <input type="color" id="colorButton20" />
                <asp:TextBox ID="txtWcMessageContentBoxShadowColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageContentSelectedBoxShadowColor" runat="server" />
                <input type="color" id="colorButton21" />
                <asp:TextBox ID="txtWcMessageContentSelectedBoxShadowColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageFromTextColor" runat="server" />
                <input type="color" id="colorButton22" />
                <asp:TextBox ID="txtWcMessageFromTextColor" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance8" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Cards</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcCardBackgroundColor" runat="server" />
                <input type="color" id="colorButton23" />
                <asp:TextBox ID="txtWcCardBackgroundColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcCardButtonTextColor" runat="server" />
                <input type="color" id="colorButton24" />
                <asp:TextBox ID="txtWcCardButtonTextColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcCardButtonTextColorHover" runat="server" />
                <input type="color" id="colorButton25" />
                <asp:TextBox ID="txtWcCardButtonTextColorHover" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcCardButtonBorderColorHover" runat="server" />
                <input type="color" id="colorButton26" />
                <asp:TextBox ID="txtWcCardButtonBorderColorHover" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcCardButtonTextColorActive" runat="server" />
                <input type="color" id="colorButton27" />
                <asp:TextBox ID="txtWcCardButtonTextColorActive" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcCardButtonBorderColorActive" runat="server" />
                <input type="color" id="colorButton28" />
                <asp:TextBox ID="txtWcCardButtonBorderColorActive" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcCardButtonBackgroundcolorActive" runat="server" />
                <input type="color" id="colorButton29" />
                <asp:TextBox ID="txtWcCardButtonBackgroundcolorActive" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance9" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Carousel</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcCarouselButtonScrollBackgroundcolor" runat="server" />
                <input type="color" id="colorButton30" />
                <asp:TextBox ID="txtWcCarouselButtonScrollBackgroundcolor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcCarouselButtonScrollBackgroundcolorFocus" runat="server" />
                <input type="color" id="colorButton31" />
                <asp:TextBox ID="txtWcCarouselButtonScrollBackgroundcolorFocus" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcCarouselButtonScrollSvgFillColor" runat="server" />
                <input type="color" id="colorButton32" />
                <asp:TextBox ID="txtWcCarouselButtonScrollSvgFillColor" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance10" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Message from me</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageFromMeBackgroundcolor" runat="server" />
                <input type="color" id="colorButton33" />
                <asp:TextBox ID="txtWcMessageFromMeBackgroundcolor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageFromMeTextColor" runat="server" />
                <input type="color" id="colorButton34" />
                <asp:TextBox ID="txtWcMessageFromMeTextColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageFromMeSvgFillColor" runat="server" />
                <input type="color" id="colorButton35" />
                <asp:TextBox ID="txtWcMessageFromMeSvgFillColor" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance11" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Message from bot</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageFromBotBackgroundcolor" runat="server" />
                <input type="color" id="colorButton36" />
                <asp:TextBox ID="txtWcMessageFromBotBackgroundcolor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageFromBotTextColor" runat="server" />
                <input type="color" id="colorButton37" />
                <asp:TextBox ID="txtWcMessageFromBotTextColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcMessageFromBotSvgFillColor" runat="server" />
                <input type="color" id="colorButton38" />
                <asp:TextBox ID="txtWcMessageFromBotSvgFillColor" runat="server" />
            </div>
        </fieldset>

        <h2 id="dnnPanel-ModuleAppearance12" class="dnnFormSectionHead">
            <a class="hiddenField" href="">Console</a></h2>
        <fieldset class="hiddenOptions" style="display: none;">
            <div class="dnnFormItem">
                <dnn:label ID="WcConsoleBorderColor" runat="server" />
                <input type="color" id="colorButton39" />
                <asp:TextBox ID="txtWcConsoleBorderColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcConsoleHeight" runat="server" />
                <asp:TextBox ID="txtWcConsoleHeight" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcConsoleSvgFillColor" runat="server" />
                <input type="color" id="colorButton40" />
                <asp:TextBox ID="txtWcConsoleSvgFillColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcConsoleHasTextSvgFillColor" runat="server" />
                <input type="color" id="colorButton41" />
                <asp:TextBox ID="txtWcConsoleHasTextSvgFillColor" runat="server" />
            </div>
            <div class="dnnFormItem">
                <dnn:label ID="WcConsoleSvgBackgroundcolor" runat="server" />
                <input type="color" id="colorButton42" />
                <asp:TextBox ID="txtWcConsoleSvgBackgroundcolor" runat="server" />
            </div>
        </fieldset>
    </div>
    <hr />
</div>

<!-- Skype section -->
<div id="skypeSection">
    <fieldset>
        <h4>Skype Options</h4>
        <div class="dnnFormItem">
            <dnn:label ID="SkypeSetting1" runat="server" />
            <asp:TextBox ID="txtSkypeSetting1" runat="server" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="ChoiceSkypeStyleSelected" ResourceKey="lblChoiceSkypeStyleSelected" />
            <asp:DropDownList runat="server" ID="ChoiceSkypeStyleSelected">
                <asp:ListItem Text="Bubble" />
                <asp:ListItem Text="Rounded" />
                <asp:ListItem Text="Rectangle" />
            </asp:DropDownList>
        </div>
        <div class="dnnFormItem">
            <dnn:label ID="SkypeTextButton" runat="server" />
            <asp:TextBox ID="txtSkypeTextButton" runat="server" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="SkypeDataCollapse" ResourceKey="lblSkypeDataCollapse" />
            <asp:CheckBox runat="server" ID="txtSkypeDataCollapse" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="SkypeDataClose" ResourceKey="lblSkypeDataClose" />
            <asp:CheckBox runat="server" ID="txtSkypeDataClose" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="SkypeDataUploadFile" ResourceKey="lblSkypeDataUploadFile" />
            <asp:CheckBox runat="server" ID="txtSkypeDataUploadFile" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="SkypeShowHeader" ResourceKey="lblSkypeShowHeader" />
            <asp:CheckBox runat="server" ID="txtSkypeShowHeader" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="SkypeAnimationEntry" ResourceKey="lblSkypeAnimationEntry" />
            <asp:CheckBox runat="server" ID="txtSkypeAnimationEntry" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ID="SkypeAlternativeCssUrl" />
            <asp:TextBox runat="server" ID="txtSkypeAlternativeCssUrl" />
        </div>
        <h4>Customize colors</h4>
        <div class="dnnFormItem">
            <dnn:label ID="SkypeColorButton" runat="server" />
            <input type="color" id="colorButton" />
            <asp:TextBox ID="txtSkypeColorButton" runat="server" />
        </div>

    </fieldset>
    <hr />
</div>

<!-- Facebook section -->
<div id="facebookSection">
    <fieldset>
        <h4>Facebook Messenger Options</h4>
        <div class="dnnFormItem">
            <dnn:label ID="FacebookAppId" runat="server" />
            <asp:TextBox ID="txtFacebookAppId" runat="server" />
        </div>
        <div class="dnnFormItem">
            <dnn:label ID="FacebookPageId" runat="server" />
            <asp:TextBox ID="txtFacebookPageId" runat="server" />
        </div>
        <div class="dnnFormItem">
            <dnn:label ID="FacebookWelcomeMessage" runat="server" />
            <asp:TextBox ID="txtFacebookWelcomeMessage" runat="server" />
        </div>
        <div class="dnnFormItem">
            <dnn:label ID="FacebookExitMessage" runat="server" />
            <asp:TextBox ID="txtFacebookExitMessage" runat="server" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label runat="server" ControlName="FacebookDisplayGreeting" ResourceKey="lblFacebookDisplayGreeting" />
            <asp:DropDownList runat="server" ID="FacebookDisplayGreeting">
                <asp:ListItem Text="show" />
                <asp:ListItem Text="hide" />
                <asp:ListItem Text="fade" />
            </asp:DropDownList>
        </div>
        <h4>Customize colors</h4>
        <div class="dnnFormItem">
            <dnn:label ID="FacebookThemeColor" runat="server" />
            <input type="color" id="colorButton2" />
            <asp:TextBox ID="txtFacebookThemeColor" runat="server" />
        </div>
    </fieldset>
</div>

<!-- Color button control scrripts -->

<script>
    function expandOrContract() {
        if ($('.hiddenOptions').css("display") === "none") {
            $('.ExpandOrContract').text("Contraer todo");
                $('.hiddenField').addClass("dnnSectionExpanded"); 
            $('.hiddenOptions').css("display", "block");
        } else {
            $('.ExpandOrContract').text("Expandir todo");
                $('.hiddenField').removeClass("dnnSectionExpanded");
                $('.hiddenOptions').css("display", "none");
            }
            
    };

    $(document).ready(function () {
        refreshSelectChannel();
        $('#colorButton').change(function () {
            $('#colorButton').next().val($('#colorButton').val());
        });

        $('#colorButton').val($('#colorButton').next().val());

        $('#colorButton2').change(function () {
            $('#colorButton2').next().val($('#colorButton2').val());
        });

        $('#colorButton2').val($('#colorButton2').next().val());

        $('#colorButton3').change(function () {
            $('#colorButton3').next().val($('#colorButton3').val());
        });

        $('#colorButton3').val($('#colorButton3').next().val());

        $('#colorButton4').change(function () {
            $('#colorButton4').next().val($('#colorButton4').val());
        });

        $('#colorButton4').val($('#colorButton4').next().val());

        $('#colorButton5').change(function () {
            $('#colorButton5').next().val($('#colorButton5').val());
        });

        $('#colorButton5').val($('#colorButton5').next().val());

        $('#colorButton6').change(function () {
            $('#colorButton6').next().val($('#colorButton6').val());
        });

        $('#colorButton6').val($('#colorButton6').next().val());

        $('#colorButton7').change(function () {
            $('#colorButton7').next().val($('#colorButton7').val());
        });

        $('#colorButton7').val($('#colorButton7').next().val());

        $('#colorButton8').change(function () {
            $('#colorButton8').next().val($('#colorButton8').val());
        });

        $('#colorButton8').val($('#colorButton8').next().val());

        $('#colorButton9').change(function () {
            $('#colorButton9').next().val($('#colorButton9').val());
        });

        $('#colorButton9').val($('#colorButton9').next().val());

        $('#colorButton10').change(function () {
            $('#colorButton10').next().val($('#colorButton10').val());
        });

        $('#colorButton10').val($('#colorButton10').next().val());

        $('#colorButton11').change(function () {
            $('#colorButton11').next().val($('#colorButton11').val());
        });

        $('#colorButton11').val($('#colorButton11').next().val());

        $('#colorButton12').change(function () {
            $('#colorButton12').next().val($('#colorButton12').val());
        });

        $('#colorButton12').val($('#colorButton12').next().val());

        $('#colorButton13').change(function () {
            $('#colorButton13').next().val($('#colorButton13').val());
        });

        $('#colorButton13').val($('#colorButton13').next().val());

        $('#colorButton14').change(function () {
            $('#colorButton14').next().val($('#colorButton14').val());
        });

        $('#colorButton14').val($('#colorButton14').next().val());

        $('#colorButton15').change(function () {
            $('#colorButton15').next().val($('#colorButton15').val());
        });

        $('#colorButton15').val($('#colorButton15').next().val());

        $('#colorButton16').change(function () {
            $('#colorButton16').next().val($('#colorButton16').val());
        });

        $('#colorButton16').val($('#colorButton16').next().val());

        $('#colorButton17').change(function () {
            $('#colorButton17').next().val($('#colorButton17').val());
        });

        $('#colorButton17').val($('#colorButton17').next().val());

        $('#colorButton18').change(function () {
            $('#colorButton18').next().val($('#colorButton18').val());
        });

        $('#colorButton18').val($('#colorButton18').next().val());

        $('#colorButton19').change(function () {
            $('#colorButton19').next().val($('#colorButton19').val());
        });

        $('#colorButton19').val($('#colorButton19').next().val());

        $('#colorButton20').change(function () {
            $('#colorButton20').next().val($('#colorButton20').val());
        });

        $('#colorButton20').val($('#colorButton20').next().val());

        $('#colorButton21').change(function () {
            $('#colorButton21').next().val($('#colorButton21').val());
        });

        $('#colorButton21').val($('#colorButton21').next().val());

        $('#colorButton22').change(function () {
            $('#colorButton22').next().val($('#colorButton22').val());
        });

        $('#colorButton22').val($('#colorButton22').next().val());

        $('#colorButton23').change(function () {
            $('#colorButton23').next().val($('#colorButton23').val());
        });

        $('#colorButton23').val($('#colorButton23').next().val());

        $('#colorButton24').change(function () {
            $('#colorButton24').next().val($('#colorButton24').val());
        });

        $('#colorButton24').val($('#colorButton24').next().val());

        $('#colorButton25').change(function () {
            $('#colorButton25').next().val($('#colorButton25').val());
        });

        $('#colorButton25').val($('#colorButton25').next().val());

        $('#colorButton26').change(function () {
            $('#colorButton26').next().val($('#colorButton26').val());
        });

        $('#colorButton26').val($('#colorButton26').next().val());

        $('#colorButton27').change(function () {
            $('#colorButton27').next().val($('#colorButton27').val());
        });

        $('#colorButton27').val($('#colorButton27').next().val());

        $('#colorButton28').change(function () {
            $('#colorButton28').next().val($('#colorButton28').val());
        });

        $('#colorButton28').val($('#colorButton28').next().val());

        $('#colorButton29').change(function () {
            $('#colorButton29').next().val($('#colorButton29').val());
        });

        $('#colorButton29').val($('#colorButton29').next().val());

        $('#colorButton30').change(function () {
            $('#colorButton30').next().val($('#colorButton30').val());
        });

        $('#colorButton30').val($('#colorButton30').next().val());

        $('#colorButton31').change(function () {
            $('#colorButton31').next().val($('#colorButton31').val());
        });

        $('#colorButton31').val($('#colorButton31').next().val());

        $('#colorButton32').change(function () {
            $('#colorButton32').next().val($('#colorButton32').val());
        });

        $('#colorButton32').val($('#colorButton32').next().val());

        $('#colorButton33').change(function () {
            $('#colorButton33').next().val($('#colorButton33').val());
        });

        $('#colorButton33').val($('#colorButton33').next().val());

        $('#colorButton34').change(function () {
            $('#colorButton34').next().val($('#colorButton34').val());
        });

        $('#colorButton34').val($('#colorButton34').next().val());

        $('#colorButton35').change(function () {
            $('#colorButton35').next().val($('#colorButton35').val());
        });

        $('#colorButton35').val($('#colorButton35').next().val());

        $('#colorButton36').change(function () {
            $('#colorButton36').next().val($('#colorButton36').val());
        });

        $('#colorButton36').val($('#colorButton36').next().val());

        $('#colorButton37').change(function () {
            $('#colorButton37').next().val($('#colorButton37').val());
        });

        $('#colorButton37').val($('#colorButton37').next().val());

        $('#colorButton38').change(function () {
            $('#colorButton38').next().val($('#colorButton38').val());
        });

        $('#colorButton38').val($('#colorButton38').next().val());

        $('#colorButton39').change(function () {
            $('#colorButton39').next().val($('#colorButton39').val());
        });

        $('#colorButton39').val($('#colorButton39').next().val());

        $('#colorButton40').change(function () {
            $('#colorButton40').next().val($('#colorButton40').val());
        });

        $('#colorButton40').val($('#colorButton40').next().val());

        $('#colorButton41').change(function () {
            $('#colorButton41').next().val($('#colorButton41').val());
        });

        $('#colorButton41').val($('#colorButton41').next().val());


        $(".SelectChannel").change(function () {
            refreshSelectChannel();
        });



        function refreshSelectChannel() {
            var ChannelSelected = $(".SelectChannel").val();

            if (ChannelSelected == 'Web Chat') {
                $('#webchatSection').css("visibility", "visible");
                $('#webchatSection').css("display", "inline");
                $('#skypeSection').css("visibility", "hidden");
                $('#skypeSection').css("display", "none");
                $('#facebookSection').css("visibility", "hidden");
                $('#facebookSection').css("display", "none");
            } else if (ChannelSelected == 'Skype') {
                $('#webchatSection').css("visibility", "hidden");
                $('#webchatSection').css("display", "none");
                $('#skypeSection').css("visibility", "visible");
                $('#skypeSection').css("display", "inline");
                $('#facebookSection').css("visibility", "hidden");
                $('#facebookSection').css("display", "none");
            } else if (ChannelSelected == 'Facebook') {
                $('#webchatSection').css("visibility", "hidden");
                $('#webchatSection').css("display", "none");
                $('#skypeSection').css("visibility", "hidden");
                $('#skypeSection').css("display", "none");
                $('#facebookSection').css("visibility", "visible");
                $('#facebookSection').css("display", "inline");
            } else {
                $('#webchatSection').css("visibility", "hidden");
                $('#webchatSection').css("display", "none");
                $('#skypeSection').css("visibility", "hidden");
                $('#skypeSection').css("display", "none");
                $('#facebookSection').css("visibility", "hidden");
                $('#facebookSection').css("display", "none");
            }
        };
    });
</script>


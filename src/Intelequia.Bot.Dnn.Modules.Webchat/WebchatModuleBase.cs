/*
' Copyright (c) 2018  Intelequia
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using DotNetNuke.Entities.Modules;
using DotNetNuke.UI.Utilities;

namespace Intelequia.Bot.Dnn.Modules.Webchat
{
    public class WebchatModuleBase : PortalModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Webchat Settings Variables

            ClientAPI.RegisterClientVariable(Page, "WebchatSetting1", Settings["WebchatSetting1"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WebchatType", Settings["WebchatType"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WebchatBotName", Settings["WebchatBotName"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcFontFamily", Settings["WcFontFamily"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcFontSize", Settings["WcFontSize"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcButtonBackgroundColor", Settings["WcButtonBackgroundColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcButtonBorderColor", Settings["WcButtonBorderColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcButtonTextColor", Settings["WcButtonTextColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcHeaderBackgroundColor", Settings["WcHeaderBackgroundColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcHeaderBoxshadowColor", Settings["WcHeaderBoxshadowColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcHeaderTextColor", Settings["WcHeaderTextColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcHeaderHeight", Settings["WcHeaderHeight"]?.ToString(), true); //total header height - (padding-top + padding bottom)
            ClientAPI.RegisterClientVariable(Page, "WcHeaderPadding", Settings["WcHeaderPadding"]?.ToString(), true); //top right bottom left
            ClientAPI.RegisterClientVariable(Page, "WcTimeTextColor", Settings["WcTimeTextColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageBoxBottom", Settings["WcMessageBottom"]?.ToString(), true); //console height
            ClientAPI.RegisterClientVariable(Page, "WcMessageBoxTop", Settings["WcMessageBoxTop"]?.ToString(), true); //header total height
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedActionsBottom", Settings["WcSuggestedActionsBottom"]?.ToString(), true); //console height
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedTextButtonColor", Settings["WcSuggestedTextButtonColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedTextButtonColorFocus", Settings["WcSuggestedTextButtonColorFocus"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedBorderColorFocus", Settings["WcSuggestedBorderColorFocus"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedButtonBackgroundcolorFocus", Settings["WcSuggestedButtonBackgroundcolorFocus"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedTextButtonColorActive", Settings["WcSuggestedTextButtonColorActive"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedBorderColorActive", Settings["WcSuggestedBorderColorActive"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedButtonBackgroundcolorActive", Settings["WcSuggestedButtonBackgroundcolorActive"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedButtonScrollBackgroundcolor", Settings["WcSuggestedButtonScrollBackgroundcolor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedButtonScrollBackgroundcolorFocus", Settings["WcSuggestedButtonScrollBackgroundcolorFocus"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcSuggestedButtonScrollSvgFillColor", Settings["WcSuggestedButtonScrollSvgFillColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageContentBoxShadowColor", Settings["WcMessageContentBoxShadowColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageContentSelectedBoxShadowColor", Settings["WcMessageContentSelectedBoxShadowColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageFromTextColor", Settings["WcMessageFromTextColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCardBackgroundColor", Settings["WcCardBackgroundColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCardButtonTextColor", Settings["WcCardButtonTextColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCardButtonTextColorHover", Settings["WcCardButtonTextColorHover"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCardButtonBorderColorHover", Settings["WcCardButtonBorderColorHover"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCardButtonTextColorActive", Settings["WcCardButtonTextColorActive"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCardButtonBorderColorActive", Settings["WcCardButtonBorderColorActive"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCardButtonBackgroundcolorActive", Settings["WcCardButtonBackgroundcolorActive"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCarouselButtonScrollBackgroundcolor", Settings["WcCarouselButtonScrollBackgroundcolor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCarouselButtonScrollBackgroundcolorFocus", Settings["WcCarouselButtonScrollBackgroundcolorFocus"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcCarouselButtonScrollSvgFillColor", Settings["WcCarouselButtonScrollSvgFillColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageFromMeBackgroundcolor", Settings["WcMessageFromMeBackgroundcolor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageFromMeTextColor", Settings["WcMessageFromMeTextColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageFromMeSvgFillColor", Settings["WcMessageFromMeSvgFillColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageFromBotBackgroundcolor", Settings["WcMessageFromBotBackgroundcolor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageFromBotTextColor", Settings["WcMessageFromBotTextColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcMessageFromBotSvgFillColor", Settings["WcMessageFromBotSvgFillColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcConsoleBorderColor", Settings["WcConsoleBorderColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcConsoleHeight", Settings["WcConsoleHeight"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcConsoleSvgFillColor", Settings["WcConsoleSvgFillColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcConsoleHasTextSvgFillColor", Settings["WcConsoleHasTextSvgFillColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "WcConsoleSvgBackgroundcolor", Settings["WcConsoleSvgBackgroundcolor"]?.ToString(), true);


            // Skype Settings Variables

            ClientAPI.RegisterClientVariable(Page, "SkypeSetting1", Settings["SkypeSetting1"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "SkypeStyleSelected", Settings["SkypeStyleSelected"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "SkypeColorButton", Settings["SkypeColorButton"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "SkypeTextButton", Settings["SkypeTextButton"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "SkypeDataCollapse", Settings["SkypeDataCollapse"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "SkypeDataClose", Settings["SkypeDataClose"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "SkypeDataUploadFile", Settings["SkypeDataUploadFile"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "SkypeShowHeader", Settings["SkypeShowHeader"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "SkypeAlternativeCssUrl", Settings["SkypeAlternativeCssUrl"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "SkypeAnimationEntry", Settings["SkypeAnimationEntry"]?.ToString(), true);


            // Facebook Settings Variables

            ClientAPI.RegisterClientVariable(Page, "FacebookAppId", Settings["FacebookAppId"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "FacebookPageId", Settings["FacebookPageId"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "FacebookWelcomeMessage", Settings["FacebookWelcomeMessage"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "FacebookExitMessage", Settings["FacebookExitMessage"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "FacebookThemeColor", Settings["FacebookThemeColor"]?.ToString(), true);
            ClientAPI.RegisterClientVariable(Page, "FacebookDisplayGreeting", Settings["FacebookDisplayGreeting"]?.ToString(), true);


            // Channel selection variable

            ClientAPI.RegisterClientVariable(Page, "ChannelSelected", Settings["ChannelSelected"]?.ToString(), true);
        }
    }
}
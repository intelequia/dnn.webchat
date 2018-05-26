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
using DotNetNuke.Collections;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Exceptions;

namespace Intelequia.Bot.Dnn.Modules.Webchat
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Settings class manages Module Settings
    /// 
    /// Typically your settings control would be used to manage settings for your module.
    /// There are two types of settings, ModuleSettings, and TabModuleSettings.
    /// 
    /// ModuleSettings apply to all "copies" of a module on a site, no matter which page the module is on. 
    /// 
    /// TabModuleSettings apply only to the current module on the current page, if you copy that module to
    /// another page the settings are not transferred.
    /// 
    /// If you happen to save both TabModuleSettings and ModuleSettings, TabModuleSettings overrides ModuleSettings.
    /// 
    /// Below we have some examples of how to access these settings but you will need to uncomment to use.
    /// 
    /// Because the control inherits from WebchatModuleSettingsBase you have access to any custom properties
    /// defined there, as well as properties from DNN such as PortalId, ModuleId, TabId, UserId and many more.
    /// </summary>
    /// -----------------------------------------------------------------------------
    public partial class Settings : WebchatModuleSettingsBase
    {
        #region Base Method Implementations

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// LoadSettings loads the settings from the Database and displays them
        /// </summary>
        /// -----------------------------------------------------------------------------
        public override void LoadSettings()
        {
            
            try
            {
                if (Page.IsPostBack == false)
                {
                    // Webchat DirectLine Options
                    
                    if(Settings.Contains("WebchatSetting1"))
                        txtWebchatSetting1.Text = Settings["WebchatSetting1"].ToString();

                    if (Settings.Contains("WebchatType"))
                        WebchatType.SelectedValue = Settings["WebchatType"].ToString();

                    if (Settings.Contains("WebchatBotName"))
                        txtWebchatBotName.Text = Settings["WebchatBotName"].ToString();

                    if (Settings.Contains("WcFontFamily"))
                        txtWcFontFamily.Text = Settings["WcFontFamily"].ToString();

                    if (Settings.Contains("WcFontSize"))
                        txtWcFontSize.Text = Settings["WcFontSize"].ToString();

                    if (Settings.Contains("WcButtonBackgroundColor"))
                        txtWcButtonBackgroundColor.Text = Settings["WcButtonBackgroundColor"].ToString();

                    if (Settings.Contains("WcButtonBorderColor"))
                        txtWcButtonBorderColor.Text = Settings["WcButtonBorderColor"].ToString();

                    if (Settings.Contains("WcButtonTextColor"))
                        txtWcButtonTextColor.Text = Settings["WcButtonTextColor"].ToString();

                    if (Settings.Contains("WcHeaderBackgroundColor"))
                        txtWcHeaderBackgroundColor.Text = Settings["WcHeaderBackgroundColor"].ToString();

                    if (Settings.Contains("WcHeaderBoxshadowColor"))
                        txtWcHeaderBoxshadowColor.Text = Settings["WcHeaderBoxshadowColor"].ToString();

                    if (Settings.Contains("WcHeaderTextColor"))
                        txtWcHeaderTextColor.Text = Settings["WcHeaderTextColor"].ToString();

                    if (Settings.Contains("WcHeaderHeight"))
                        txtWcHeaderHeight.Text = Settings["WcHeaderHeight"].ToString();

                    if (Settings.Contains("WcHeaderPadding"))
                        txtWcHeaderPadding.Text = Settings["WcHeaderPadding"].ToString();

                    if (Settings.Contains("WcTimeTextColor"))
                        txtWcTimeTextColor.Text = Settings["WcTimeTextColor"].ToString();

                    if (Settings.Contains("WcMessageBottom"))
                        txtWcMessageBottom.Text = Settings["WcMessageBottom"].ToString();

                    if (Settings.Contains("WcMessageBoxTop"))
                        txtWcMessageBoxTop.Text = Settings["WcMessageBoxTop"].ToString();

                    if (Settings.Contains("WcSuggestedActionsBottom"))
                        txtWcSuggestedActionsBottom.Text = Settings["WcSuggestedActionsBottom"].ToString();

                    if (Settings.Contains("WcSuggestedTextButtonColor"))
                        txtWcSuggestedTextButtonColor.Text = Settings["WcSuggestedTextButtonColor"].ToString();

                    if (Settings.Contains("WcSuggestedTextButtonColorFocus"))
                        txtWcSuggestedTextButtonColorFocus.Text = Settings["WcSuggestedTextButtonColorFocus"].ToString();

                    if (Settings.Contains("WcSuggestedBorderColorFocus"))
                        txtWcSuggestedBorderColorFocus.Text = Settings["WcSuggestedBorderColorFocus"].ToString();

                    if (Settings.Contains("WcSuggestedButtonBackgroundcolorFocus"))
                        txtWcSuggestedButtonBackgroundcolorFocus.Text = Settings["WcSuggestedButtonBackgroundcolorFocus"].ToString();

                    if (Settings.Contains("WcSuggestedTextButtonColorActive"))
                        txtWcSuggestedTextButtonColorActive.Text = Settings["WcSuggestedTextButtonColorActive"].ToString();

                    if (Settings.Contains("WcSuggestedBorderColorActive"))
                        txtWcSuggestedBorderColorActive.Text = Settings["WcSuggestedBorderColorActive"].ToString();

                    if (Settings.Contains("WcSuggestedButtonBackgroundcolorActive"))
                        txtWcSuggestedButtonBackgroundcolorActive.Text = Settings["WcSuggestedButtonBackgroundcolorActive"].ToString();

                    if (Settings.Contains("WcSuggestedButtonScrollBackgroundcolor"))
                        txtWcSuggestedButtonScrollBackgroundcolor.Text = Settings["WcSuggestedButtonScrollBackgroundcolor"].ToString();

                    if (Settings.Contains("WcSuggestedButtonScrollBackgroundcolorFocus"))
                        txtWcSuggestedButtonScrollBackgroundcolorFocus.Text = Settings["WcSuggestedButtonScrollBackgroundcolorFocus"].ToString();

                    if (Settings.Contains("WcSuggestedButtonScrollSvgFillColor"))
                        txtWcSuggestedButtonScrollSvgFillColor.Text = Settings["WcSuggestedButtonScrollSvgFillColor"].ToString();

                    if (Settings.Contains("WcMessageContentBoxShadowColor"))
                        txtWcMessageContentBoxShadowColor.Text = Settings["WcMessageContentBoxShadowColor"].ToString();

                    if (Settings.Contains("WcMessageContentSelectedBoxShadowColor"))
                        txtWcMessageContentSelectedBoxShadowColor.Text = Settings["WcMessageContentSelectedBoxShadowColor"].ToString();

                    if (Settings.Contains("WcMessageFromTextColor"))
                        txtWcMessageFromTextColor.Text = Settings["WcMessageFromTextColor"].ToString();

                    if (Settings.Contains("WcCardBackgroundColor"))
                        txtWcCardBackgroundColor.Text = Settings["WcCardBackgroundColor"].ToString();

                    if (Settings.Contains("WcCardButtonTextColor"))
                        txtWcCardButtonTextColor.Text = Settings["WcCardButtonTextColor"].ToString();

                    if (Settings.Contains("WcCardButtonTextColorHover"))
                        txtWcCardButtonTextColorHover.Text = Settings["WcCardButtonTextColorHover"].ToString();

                    if (Settings.Contains("WcCardButtonBorderColorHover"))
                        txtWcCardButtonBorderColorHover.Text = Settings["WcCardButtonBorderColorHover"].ToString();

                    if (Settings.Contains("WcCardButtonTextColorActive"))
                        txtWcCardButtonTextColorActive.Text = Settings["WcCardButtonTextColorActive"].ToString();

                    if (Settings.Contains("WcCardButtonBorderColorActive"))
                        txtWcCardButtonBorderColorActive.Text = Settings["WcCardButtonBorderColorActive"].ToString();

                    if (Settings.Contains("WcCardButtonBackgroundcolorActive"))
                        txtWcCardButtonBackgroundcolorActive.Text = Settings["WcCardButtonBackgroundcolorActive"].ToString();

                    if (Settings.Contains("WcCarouselButtonScrollBackgroundcolor"))
                        txtWcCarouselButtonScrollBackgroundcolor.Text = Settings["WcCarouselButtonScrollBackgroundcolor"].ToString();

                    if (Settings.Contains("WcCarouselButtonScrollBackgroundcolorFocus"))
                        txtWcCarouselButtonScrollBackgroundcolorFocus.Text = Settings["WcCarouselButtonScrollBackgroundcolorFocus"].ToString();

                    if (Settings.Contains("WcCarouselButtonScrollSvgFillColor"))
                        txtWcCarouselButtonScrollSvgFillColor.Text = Settings["WcCarouselButtonScrollSvgFillColor"].ToString();

                    if (Settings.Contains("WcMessageFromMeBackgroundcolor"))
                        txtWcMessageFromMeBackgroundcolor.Text = Settings["WcMessageFromMeBackgroundcolor"].ToString();

                    if (Settings.Contains("WcMessageFromMeTextColor"))
                        txtWcMessageFromMeTextColor.Text = Settings["WcMessageFromMeTextColor"].ToString();

                    if (Settings.Contains("WcMessageFromMeSvgFillColor"))
                        txtWcMessageFromMeSvgFillColor.Text = Settings["WcMessageFromMeSvgFillColor"].ToString();

                    if (Settings.Contains("WcMessageFromBotBackgroundcolor"))
                        txtWcMessageFromBotBackgroundcolor.Text = Settings["WcMessageFromBotBackgroundcolor"].ToString();

                    if (Settings.Contains("WcMessageFromBotTextColor"))
                        txtWcMessageFromBotTextColor.Text = Settings["WcMessageFromBotTextColor"].ToString();

                    if (Settings.Contains("WcMessageFromBotSvgFillColor"))
                        txtWcMessageFromBotSvgFillColor.Text = Settings["WcMessageFromBotSvgFillColor"].ToString();

                    if (Settings.Contains("WcConsoleBorderColor"))
                        txtWcConsoleBorderColor.Text = Settings["WcConsoleBorderColor"].ToString();

                    if (Settings.Contains("WcConsoleHeight"))
                        txtWcConsoleHeight.Text = Settings["WcConsoleHeight"].ToString();

                    if (Settings.Contains("WcConsoleSvgFillColor"))
                        txtWcConsoleSvgFillColor.Text = Settings["WcConsoleSvgFillColor"].ToString();

                    if (Settings.Contains("WcConsoleHasTextSvgFillColor"))
                        txtWcConsoleHasTextSvgFillColor.Text = Settings["WcConsoleHasTextSvgFillColor"].ToString();

                    if (Settings.Contains("WcConsoleSvgBackgroundcolor"))
                        txtWcConsoleSvgBackgroundcolor.Text = Settings["WcConsoleSvgBackgroundcolor"].ToString();



                    // Skype Options

                    if (Settings.Contains("SkypeSetting1"))
                        txtSkypeSetting1.Text = Settings["SkypeSetting1"].ToString();

                    if (Settings.Contains("SkypeStyleSelected"))
                        ChoiceSkypeStyleSelected.SelectedValue = Settings["SkypeStyleSelected"].ToString();

                    if (Settings.Contains("SkypeColorButton"))
                        txtSkypeColorButton.Text = Settings["SkypeColorButton"].ToString();
                        

                    if (Settings.Contains("SkypeTextButton"))
                        txtSkypeTextButton.Text = Settings["SkypeTextButton"].ToString();

                    if (Settings.Contains("SkypeDataCollapse"))
                    {
                        bool.TryParse(Settings["SkypeDataCollapse"].ToString(), out var dataCollapse);
                        txtSkypeDataCollapse.Checked = Settings.GetValueOrDefault(dataCollapse.ToString(), false);
                    }
                    

                    if (Settings.Contains("SkypeDataClose"))
                    {
                        bool.TryParse(Settings["SkypeDataClose"].ToString(), out var dataClose);
                        txtSkypeDataClose.Checked = Settings.GetValueOrDefault(dataClose.ToString(), true);
                    }
                    

                    if (Settings.Contains("SkypeDataUploadFile"))
                    {
                        bool.TryParse(Settings["SkypeDataUploadFile"].ToString(), out var uploadFile);
                        txtSkypeDataUploadFile.Checked = Settings.GetValueOrDefault(uploadFile.ToString(), false);
                    }
                    

                    if (Settings.Contains("SkypeShowHeader"))
                    {
                        bool.TryParse(Settings["SkypeShowHeader"].ToString(), out var header);
                        txtSkypeShowHeader.Checked = Settings.GetValueOrDefault(header.ToString(), true);
                    }
                        

                    if (Settings.Contains("SkypeAlternativeCssUrl"))
                        txtSkypeAlternativeCssUrl.Text = Settings["SkypeAlternativeCssUrl"].ToString();

                    if (Settings.Contains("SkypeAnimationEntry"))
                    {
                        bool.TryParse(Settings["SkypeAnimationEntry"].ToString(), out var entry);
                        txtSkypeAnimationEntry.Checked = Settings.GetValueOrDefault(entry.ToString(), true);
                    }
                        


                    // Facebook Options

                    if (Settings.Contains("FacebookPageId"))
                        txtFacebookPageId.Text = Settings["FacebookPageId"].ToString();

                    if (Settings.Contains("FacebookAppId"))
                        txtFacebookAppId.Text = Settings["FacebookAppId"].ToString();

                    if (Settings.Contains("FacebookWelcomeMessage"))
                        txtFacebookWelcomeMessage.Text = Settings["FacebookWelcomeMessage"].ToString();

                    if (Settings.Contains("FacebookExitMessage"))
                        txtFacebookExitMessage.Text = Settings["FacebookExitMessage"].ToString();

                    if (Settings.Contains("FacebookThemeColor"))
                        txtFacebookThemeColor.Text = Settings["FacebookThemeColor"].ToString();

                    if (Settings.Contains("FacebookDisplayGreeting"))
                        FacebookDisplayGreeting.SelectedValue = Settings["FacebookDisplayGreeting"].ToString();


                    // Channel Selection

                    if (Settings.Contains("ChannelSelected"))
                        ChoiceDropDown.SelectedValue = Settings["ChannelSelected"].ToString();

                    

                }
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpdateSettings saves the modified settings to the Database
        /// </summary>
        /// -----------------------------------------------------------------------------
        public override void UpdateSettings()
        {
            try
            {
                var modules = new ModuleController();

                modules.UpdateModuleSetting(ModuleId, "WebchatSetting1", txtWebchatSetting1.Text);
                modules.UpdateModuleSetting(ModuleId, "WebchatType", WebchatType.SelectedValue);
                modules.UpdateModuleSetting(ModuleId, "WebchatBotName", txtWebchatBotName.Text);
                modules.UpdateModuleSetting(ModuleId, "WcFontFamily", txtWcFontFamily.Text);
                modules.UpdateModuleSetting(ModuleId, "WcFontSize", txtWcFontSize.Text);
                modules.UpdateModuleSetting(ModuleId, "WcButtonBackgroundColor", txtWcButtonBackgroundColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcButtonBorderColor", txtWcButtonBorderColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcButtonTextColor", txtWcButtonTextColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcHeaderBackgroundColor", txtWcHeaderBackgroundColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcHeaderBoxshadowColor", txtWcHeaderBoxshadowColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcHeaderTextColor", txtWcHeaderTextColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcHeaderHeight", txtWcHeaderHeight.Text);
                modules.UpdateModuleSetting(ModuleId, "WcHeaderPadding", txtWcHeaderPadding.Text);
                modules.UpdateModuleSetting(ModuleId, "WcTimeTextColor", txtWcTimeTextColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageBottom", txtWcMessageBottom.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageBoxTop", txtWcMessageBoxTop.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedActionsBottom", txtWcSuggestedActionsBottom.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedTextButtonColor", txtWcSuggestedTextButtonColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedTextButtonColorFocus", txtWcSuggestedTextButtonColorFocus.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedBorderColorFocus", txtWcSuggestedBorderColorFocus.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedButtonBackgroundcolorFocus", txtWcSuggestedButtonBackgroundcolorFocus.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedTextButtonColorActive", txtWcSuggestedTextButtonColorActive.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedBorderColorActive", txtWcSuggestedBorderColorActive.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedButtonBackgroundcolorActive", txtWcSuggestedButtonBackgroundcolorActive.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedButtonScrollBackgroundcolor", txtWcSuggestedButtonScrollBackgroundcolor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedButtonScrollBackgroundcolorFocus", txtWcSuggestedButtonScrollBackgroundcolorFocus.Text);
                modules.UpdateModuleSetting(ModuleId, "WcSuggestedButtonScrollSvgFillColor", txtWcSuggestedButtonScrollSvgFillColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageContentBoxShadowColor", txtWcMessageContentBoxShadowColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageContentSelectedBoxShadowColor", txtWcMessageContentSelectedBoxShadowColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageFromTextColor", txtWcMessageFromTextColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCardBackgroundColor", txtWcCardBackgroundColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCardButtonTextColor", txtWcCardButtonTextColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCardButtonTextColorHover", txtWcCardButtonTextColorHover.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCardButtonBorderColorHover", txtWcCardButtonBorderColorHover.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCardButtonTextColorActive", txtWcCardButtonTextColorActive.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCardButtonBorderColorActive", txtWcCardButtonBorderColorActive.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCardButtonBackgroundcolorActive", txtWcCardButtonBackgroundcolorActive.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCarouselButtonScrollBackgroundcolor", txtWcCarouselButtonScrollBackgroundcolor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCarouselButtonScrollBackgroundcolorFocus", txtWcCarouselButtonScrollBackgroundcolorFocus.Text);
                modules.UpdateModuleSetting(ModuleId, "WcCarouselButtonScrollSvgFillColor", txtWcCarouselButtonScrollSvgFillColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageFromMeBackgroundcolor", txtWcMessageFromMeBackgroundcolor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageFromMeTextColor", txtWcMessageFromMeTextColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageFromMeSvgFillColor", txtWcMessageFromMeSvgFillColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageFromBotBackgroundcolor", txtWcMessageFromBotBackgroundcolor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageFromBotTextColor", txtWcMessageFromBotTextColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcMessageFromBotSvgFillColor", txtWcMessageFromBotSvgFillColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcConsoleBorderColor", txtWcConsoleBorderColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcConsoleHeight", txtWcConsoleHeight.Text);
                modules.UpdateModuleSetting(ModuleId, "WcConsoleSvgFillColor", txtWcConsoleSvgFillColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcConsoleHasTextSvgFillColor", txtWcConsoleHasTextSvgFillColor.Text);
                modules.UpdateModuleSetting(ModuleId, "WcConsoleSvgBackgroundcolor", txtWcConsoleSvgBackgroundcolor.Text);



                modules.UpdateModuleSetting(ModuleId, "SkypeSetting1", txtSkypeSetting1.Text);
                modules.UpdateModuleSetting(ModuleId, "SkypeStyleSelected", ChoiceSkypeStyleSelected.SelectedValue);
                modules.UpdateModuleSetting(ModuleId, "SkypeColorButton", txtSkypeColorButton.Text);
                modules.UpdateModuleSetting(ModuleId, "SkypeTextButton", txtSkypeTextButton.Text);
                modules.UpdateModuleSetting(ModuleId, "SkypeDataCollapse", txtSkypeDataCollapse.Checked.ToString());
                modules.UpdateModuleSetting(ModuleId, "SkypeDataClose", txtSkypeDataClose.Checked.ToString());
                modules.UpdateModuleSetting(ModuleId, "SkypeDataUploadFile", txtSkypeDataUploadFile.Checked.ToString());
                modules.UpdateModuleSetting(ModuleId, "SkypeShowHeader", txtSkypeShowHeader.Checked.ToString());
                modules.UpdateModuleSetting(ModuleId, "SkypeAlternativeCssUrl", txtSkypeAlternativeCssUrl.Text);
                modules.UpdateModuleSetting(ModuleId, "SkypeAnimationEntry", txtSkypeAnimationEntry.Checked.ToString());


                modules.UpdateModuleSetting(ModuleId, "FacebookAppId", txtFacebookAppId.Text);
                modules.UpdateModuleSetting(ModuleId, "FacebookPageId", txtFacebookPageId.Text);
                modules.UpdateModuleSetting(ModuleId, "FacebookWelcomeMessage", txtFacebookWelcomeMessage.Text);
                modules.UpdateModuleSetting(ModuleId, "FacebookExitMessage", txtFacebookExitMessage.Text);
                modules.UpdateModuleSetting(ModuleId, "FacebookThemeColor", txtFacebookThemeColor.Text);
                modules.UpdateModuleSetting(ModuleId, "FacebookDisplayGreeting", FacebookDisplayGreeting.SelectedValue);


                modules.UpdateModuleSetting(ModuleId, "ChannelSelected", ChoiceDropDown.SelectedValue);
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        #endregion
    }
}
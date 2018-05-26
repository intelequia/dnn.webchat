function modifyWebchatCss() {
    var WcFontFamily = dnn.getVar("WcFontFamily");
    var WcFontSize = dnn.getVar("WcFontSize");
    var WcButtonBackgroundColor = dnn.getVar("WcButtonBackgroundColor");
    var WcButtonBorderColor = dnn.getVar("WcButtonBorderColor");
    var WcButtonTextColor = dnn.getVar("WcButtonTextColor");
    var WcHeaderBackgroundColor = dnn.getVar("WcHeaderBackgroundColor");
    var WcHeaderBoxshadowColor = dnn.getVar("WcHeaderBoxshadowColor");
    var WcHeaderTextColor = dnn.getVar("WcHeaderTextColor");
    var WcHeaderHeight = dnn.getVar("WcHeaderHeight");
    var WcHeaderPadding = dnn.getVar("WcHeaderPadding");
    var WcTimeTextColor = dnn.getVar("WcTimeTextColor");
    var WcMessageBottom = dnn.getVar("WcMessageBottom");
    var WcMessageBoxTop = dnn.getVar("WcMessageBoxTop");
    var WcSuggestedActionsBottom = dnn.getVar("WcSuggestedActionsBottom");
    var WcSuggestedTextButtonColor = dnn.getVar("WcSuggestedTextButtonColor");
    var WcSuggestedTextButtonColorFocus = dnn.getVar("WcSuggestedTextButtonColorFocus");
    var WcSuggestedBorderColorFocus = dnn.getVar("WcSuggestedBorderColorFocus");
    var WcSuggestedButtonBackgroundcolorFocus = dnn.getVar("WcSuggestedButtonBackgroundcolorFocus");
    var WcSuggestedTextButtonColorActive = dnn.getVar("WcSuggestedTextButtonColorActive");
    var WcSuggestedBorderColorActive = dnn.getVar("WcSuggestedBorderColorActive");
    var WcSuggestedButtonBackgroundcolorActive = dnn.getVar("WcSuggestedButtonBackgroundcolorActive");
    var WcSuggestedButtonScrollBackgroundcolor = dnn.getVar("WcSuggestedButtonScrollBackgroundcolor");
    var WcSuggestedButtonScrollBackgroundcolorFocus = dnn.getVar("WcSuggestedButtonScrollBackgroundcolorFocus");
    var WcSuggestedButtonScrollSvgFillColor = dnn.getVar("WcSuggestedButtonScrollSvgFillColor");
    var WcMessageContentBoxShadowColor = dnn.getVar("WcMessageContentBoxShadowColor");
    var WcMessageContentSelectedBoxShadowColor = dnn.getVar("WcMessageContentSelectedBoxShadowColor");
    var WcMessageFromTextColor = dnn.getVar("WcMessageFromTextColor");
    var WcCardBackgroundColor = dnn.getVar("WcCardBackgroundColor");
    var WcCardButtonTextColor = dnn.getVar("WcCardButtonTextColor");
    var WcCardButtonTextColorHover = dnn.getVar("WcCardButtonTextColorHover");
    var WcCardButtonBorderColorHover = dnn.getVar("WcCardButtonBorderColorHover");
    var WcCardButtonTextColorActive = dnn.getVar("WcCardButtonTextColorActive");
    var WcCardButtonBorderColorActive = dnn.getVar("WcCardButtonBorderColorActive");
    var WcCardButtonBackgroundcolorActive = dnn.getVar("WcCardButtonBackgroundcolorActive");
    var WcCarouselButtonScrollBackgroundcolor = dnn.getVar("WcCarouselButtonScrollBackgroundcolor");
    var WcCarouselButtonScrollBackgroundcolorFocus = dnn.getVar("WcCarouselButtonScrollBackgroundcolorFocus");
    var WcCarouselButtonScrollSvgFillColor = dnn.getVar("WcCarouselButtonScrollSvgFillColor");
    var WcMessageFromMeBackgroundcolor = dnn.getVar("WcMessageFromMeBackgroundcolor");
    var WcMessageFromMeTextColor = dnn.getVar("WcMessageFromMeTextColor");
    var WcMessageFromMeSvgFillColor = dnn.getVar("WcMessageFromMeSvgFillColor");
    var WcMessageFromBotBackgroundcolor = dnn.getVar("WcMessageFromBotBackgroundcolor");
    var WcMessageFromBotTextColor = dnn.getVar("WcMessageFromBotTextColor");
    var WcMessageFromBotSvgFillColor = dnn.getVar("WcMessageFromBotSvgFillColor");
    var WcConsoleBorderColor = dnn.getVar("WcConsoleBorderColor");
    var WcConsoleHeight = dnn.getVar("WcConsoleHeight");
    var WcConsoleSvgFillColor = dnn.getVar("WcConsoleSvgFillColor");
    var WcConsoleHasTextSvgFillColor = dnn.getVar("WcConsoleHasTextSvgFillColor");
    var WcConsoleSvgBackgroundcolor = dnn.getVar("WcConsoleSvgBackgroundcolor");


    if (WcFontFamily !== null) {
        $('body .wc-app, .wc-app button, .wc-app input, .wc-app textarea').css("font-family", WcFontFamily);
    }
    if (WcFontSize !== null) {
        $('body .wc-app, .wc-app button, .wc-app input, .wc-app textarea').css("font-size", WcFontSize);
    }



    if (WcButtonBackgroundColor !== null) {
        $('.wc-app button').css("background-color", WcButtonBackgroundColor);
    }
    if (WcButtonBorderColor !== null) {
        $('.wc-app button').css("border", "1px solid " + WcButtonBorderColor);
    }
    if (WcButtonTextColor !== null) {
        $('.wc-app button').css("color", WcButtonTextColor);
    }


    if (WcHeaderBackgroundColor !== null) {
        $('.wc-header').css("background-color", WcHeaderBackgroundColor);
    }
    if (WcHeaderBoxshadowColor !== null) {
        $('.wc-header').css("box-shadow", "0 1px " + WcHeaderBoxshadowColor);
    }
    if (WcHeaderTextColor !== null) {
        $('.wc-header').css("color", WcHeaderTextColor);
    }
    if (WcHeaderHeight !== null) {
        $('.wc-header').css("height", WcHeaderHeight);
    }
    if (WcHeaderPadding !== null) {
        $('.wc-header').css("padding", WcHeaderPadding);
    }


    if (WcTimeTextColor !== null) {
        $('.wc-time').css("color", WcTimeTextColor);
    }


    if (WcMessageBottom !== null) {
        $('.wc-message-groups').css("bottom", WcMessageBottom);
    }
    if (WcMessageBoxTop !== null) {
        $('.wc-message-groups').css("top", WcMessageBoxTop);
    }


    if (WcSuggestedActionsBottom !== null) {
        $('.wc-suggested-actions').css("bottom", WcSuggestedActionsBottom);
    }
    if (WcSuggestedTextButtonColor !== null) {
        $('.wc-suggested-actions button').css("color", WcSuggestedTextButtonColor);
    }
    // .wc-suggested-actions button:hover
    if (WcSuggestedTextButtonColorFocus !== null) {
        $('.wc-suggested-actions button:focus').css("color", WcSuggestedTextButtonColorFocus);
    }
    if (WcSuggestedTextButtonColorFocus !== null) {
        $('.wc-suggested-actions button:hover').css("color", WcSuggestedTextButtonColorFocus);
    }
    // .wc-suggested-actions button:hover
    if (WcSuggestedBorderColorFocus !== null) {
        $('.wc-suggested-actions button:focus').css("border-color", WcSuggestedBorderColorFocus);
    }
    if (WcSuggestedBorderColorFocus !== null) {
        $('.wc-suggested-actions button:hover').css("border-color", WcSuggestedBorderColorFocus);
    }
    // .wc-suggested-actions button:hover
    if (WcSuggestedButtonBackgroundcolorFocus !== null) {
        $('.wc-suggested-actions button:focus').css("background-color", WcSuggestedButtonBackgroundcolorFocus);
    }
    if (WcSuggestedButtonBackgroundcolorFocus !== null) {
        $('.wc-suggested-actions button:hover').css("background-color", WcSuggestedButtonBackgroundcolorFocus);
    }
    if (WcSuggestedTextButtonColorActive !== null) {
        $('.wc-suggested-actions button:active').css("color", WcSuggestedTextButtonColorActive);
    }
    if (WcSuggestedBorderColorActive !== null) {
        $('.wc-suggested-actions button:active').css("border-color", WcSuggestedBorderColorActive);
    }
    if (WcSuggestedButtonBackgroundcolorActive !== null) {
        $('.wc-suggested-actions button:active').css("background-color", WcSuggestedButtonBackgroundcolorActive);
    }
    if (WcSuggestedButtonScrollBackgroundcolor !== null) {
        $('.wc-suggested-actions button.scroll').css("background-color", WcSuggestedButtonScrollBackgroundcolor);
    }
    // button.scroll:hover
    if (WcSuggestedButtonScrollBackgroundcolorFocus !== null) {
        $('.wc-suggested-actions button.scroll:focus').css("background-color", WcSuggestedButtonScrollBackgroundcolorFocus);
    }
    if (WcSuggestedButtonScrollBackgroundcolorFocus !== null) {
        $('.wc-suggested-actions button.scroll:hover').css("background-color", WcSuggestedButtonScrollBackgroundcolorFocus);
    }
    if (WcSuggestedButtonScrollSvgFillColor !== null) {
        $('.wc-suggested-actions button.scroll svg').css("fill", WcSuggestedButtonScrollSvgFillColor);
    }


    if (WcMessageContentBoxShadowColor !== null) {
        $('.wc-message-content').css("box-shadow", "0px 1px 1px 0px " + WcMessageContentBoxShadowColor);
    }
    if (WcMessageContentSelectedBoxShadowColor !== null) {
        $('.wc-message-content.selected').css("box-shadow", "0px 1px 1px 0px " + WcMessageContentSelectedBoxShadowColor);
    }


    if (WcMessageFromTextColor !== null) {
        $('.wc-message-from').css("color", WcMessageFromTextColor);
    }


    if (WcCardBackgroundColor !== null) {
        $('.wc-card').css("background-color", WcCardBackgroundColor);
    }
    if (WcCardButtonTextColor !== null) {
        $('.wc-card button').css("color", WcCardButtonTextColor);
    }
    if (WcCardButtonTextColorHover !== null) {
        $('.wc-card button:hover').css("color", WcCardButtonTextColorHover);
    }
    if (WcCardButtonBorderColorHover !== null) {
        $('.wc-card button:hover').css("border-color", WcCardButtonBorderColorHover);
    }
    if (WcCardButtonTextColorActive !== null) {
        $('.wc-card button:active').css("color", WcCardButtonTextColorActive);
    }
    if (WcCardButtonBorderColorActive !== null) {
        $('.wc-card button:active').css("border-color", WcCardButtonBorderColorActive);
    }
    if (WcCardButtonBackgroundcolorActive !== null) {
        $('.wc-card button:active').css("background-color", WcCardButtonBackgroundcolorActive);
    }



    if (WcCarouselButtonScrollBackgroundcolor !== null) {
        $('.wc-carousel button.scroll').css("background-color", WcCarouselButtonScrollBackgroundcolor);
    }
    // button.scroll:hover
    if (WcCarouselButtonScrollBackgroundcolorFocus !== null) {
        $('.wc-carousel button.scroll:focus').css("background-color", WcCarouselButtonScrollBackgroundcolorFocus);
    }
    if (WcCarouselButtonScrollBackgroundcolorFocus !== null) {
        $('.wc-carousel button.scroll:hover').css("background-color", WcCarouselButtonScrollBackgroundcolorFocus);
    }
    if (WcCarouselButtonScrollSvgFillColor !== null) {
        $('.wc-carousel button.scroll svg').css("fill", WcCarouselButtonScrollSvgFillColor);
    }



    if (WcMessageFromMeBackgroundcolor !== null) {
        $('.wc-message-from-me .wc-message-content').css("background-color", WcMessageFromMeBackgroundcolor);
    }
    if (WcMessageFromMeTextColor !== null) {
        $('.wc-message-from-me .wc-message-content').css("color", WcMessageFromMeTextColor);
    }
    if (WcMessageFromMeSvgFillColor !== null) {
        $('.wc-message-from-me svg.wc-message-callout path').css("fill", WcMessageFromMeSvgFillColor);
    }



    if (WcMessageFromBotBackgroundcolor !== null) {
        $('.wc-message-from-bot .wc-message-content').css("background-color", WcMessageFromBotBackgroundcolor);
    }
    if (WcMessageFromBotTextColor !== null) {
        $('.wc-message-from-bot .wc-message-content').css("color", WcMessageFromBotTextColor);
    }
    if (WcMessageFromBotSvgFillColor !== null) {
        $('.wc-message-from-bot svg.wc-message-callout path').css("fill", WcMessageFromBotSvgFillColor);
    }



    if (WcConsoleBorderColor !== null) {
        $('.wc-console').css("border", "5px solid " + WcConsoleBorderColor);
    }
    if (WcConsoleHeight !== null) {
        $('.wc-console').css("height", WcConsoleHeight);
    }
    if (WcConsoleSvgFillColor !== null) {
        $('.wc-console svg').css("fill", WcConsoleSvgFillColor);
    }
    if (WcConsoleHasTextSvgFillColor !== null) {
        $('.wc-console.has-text .wc-send svg').css("fill", WcConsoleHasTextSvgFillColor);
    }
    if (WcConsoleSvgBackgroundcolor !== null) {
        $('.wc-send').css("background-color", WcConsoleSvgBackgroundcolor);
    }
}
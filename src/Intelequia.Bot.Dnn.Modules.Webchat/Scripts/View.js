$(document).ready(function () {
    //debugger;
    var ChannelSelected = dnn.getVar("ChannelSelected");
    var WebchatType = dnn.getVar("WebchatType");
    var WebchatSetting1 = dnn.getVar("WebchatSetting1");
    var WebchatBotName = dnn.getVar("WebchatBotName");
    var SkypeSetting1 = dnn.getVar("SkypeSetting1");
    var SkypeStyleSelected = dnn.getVar("SkypeStyleSelected");
    var SkypeColorButton = dnn.getVar("SkypeColorButton");
    var SkypeTextButton = dnn.getVar("SkypeTextButton");
    var SkypeDataCollapse = dnn.getVar("SkypeDataCollapse");
    var SkypeDataClose = dnn.getVar("SkypeDataClose");
    var SkypeDataUploadFile = dnn.getVar("SkypeDataUploadFile");
    var SkypeShowHeader = dnn.getVar("SkypeShowHeader");
    var SkypeAlternativeCssUrl = dnn.getVar("SkypeAlternativeCssUrl");
    var SkypeAnimationEntry = dnn.getVar("SkypeAnimationEntry");
    var FacebookAppId = dnn.getVar("FacebookAppId");
    var FacebookPageId = dnn.getVar("FacebookPageId");
    var FacebookWelcomeMessage = dnn.getVar("FacebookWelcomeMessage");
    var FacebookExitMessage = dnn.getVar("FacebookExitMessage");
    var FacebookThemeColor = dnn.getVar("FacebookThemeColor");
    var FacebookDisplayGreeting = dnn.getVar("FacebookDisplayGreeting");



    if (ChannelSelected == 'Web Chat') {
        $('#chatBody').empty();
        if (WebchatType == 'Classic Webchat') {
            BotChat.App({
                    directLine: { secret: WebchatSetting1 },
                    user: { id: "user" },
                    bot: { id: WebchatBotName },
                    resize: "detect"
                },
                document.getElementById("chatBody"));

            $('#chatBody').css("height", "600px");
            $('#wc-upload-input').css('display', 'none');
            modifyWebchatCss();
        } else {
            $('#chatBody').empty();
            var txt5 = '<div id="HelpBot">' +
                '<div class="bot-tab">' +
                '<div class="bot-tab-icon"></div>' +
                '</div>' +
                '<div class="bot-chat" id="bot-chatId">' +
                '<div style="padding-top: 7px; padding-left: 5px; position: absolute;">' +
                '</div>' +
                '</div>' +
                '</div>';
            $('#chatBody').append(txt5);
            BotChat.App({
                directLine: { secret: WebchatSetting1 },
                user: { id: "user" },
                bot: { id: WebchatBotName },
                resize: "detect"
            }, document.getElementById("bot-chatId"));
            var txt6 = '<div class="bot-close"></div>';
            $('#bot-chatId').append(txt6);
            $('#wc-upload-input').css('display', 'none');
            modifyWebchatCss(); 
        }
        

    } else if (ChannelSelected == 'Skype') {
        $('#chatBody').empty();
        var txt2 = '<div id="SkypeChat"><span class="skype-button ' + SkypeStyleSelected + '" data-bot-id="' + SkypeSetting1 + '"' +
            ' data-color="' + SkypeColorButton + '" data-text="' + SkypeTextButton + '"></span><span class="skype-chat" data-can-collapse="' + SkypeDataCollapse + '" data-can-close="' + SkypeDataClose + '" data-can-upload-file="' + SkypeDataUploadFile + '" data-show-header="' + SkypeShowHeader + '" data-css-url="' + SkypeAlternativeCssUrl + '" data-entry-animation="' + SkypeAnimationEntry + '"></span>' +
            '<script src="https://swc.cdn.skype.com/sdk/v1/sdk.min.js"></script></div>';
        $('#chatBody').append(txt2);
    } else if (ChannelSelected == 'Facebook') {
        $('#chatBody').empty();
        var txt3 =
            '<script>' +
            'window.fbAsyncInit = function () {' +
            'FB.init({' +
            'appId: ' +
            FacebookAppId +
            ',' +
            'autoLogAppEvents: true,' +
            'xfbml: true,' +
            'version: "v2.12" ' +
            '});' +
            '};' +
            '(function (d, s, id) {' +
            'var js, fjs = d.getElementsByTagName(s)[0];' +
            'if (d.getElementById(id)) { return; }' +
            'js = d.createElement(s); js.id = id;' +
            'js.src = "https://connect.facebook.net/en_US/sdk.js";' +
            'fjs.parentNode.insertBefore(js, fjs);' +
            '}(document, "script", "facebook-jssdk"));' +
            '</script >' +
            '<div class="fb-customerchat"' +
            'page_id="' +
            FacebookPageId +
            '"' +
            'theme_color="' +
            FacebookThemeColor +
            '"' +
            'greeting_dialog_display="' +
            FacebookDisplayGreeting +
            '"' +
            'logged_in_greeting="' +
            FacebookWelcomeMessage +
            '"' +
            'logged_out_greeting="' +
            FacebookExitMessage +
            '">' +
            '</div>';
        $('#chatBody').append(txt3);
    }  else {
        $('#chatBody').empty();
        var txt4 = '<h2>Select channel in WebChat settings tab</h2>';
        $('#chatBody').append(txt4);
    }

    
});

var dnnBot = dnnBot || {
    showTab: function () {
        $('.bot-tab').removeClass('bot-tab-hide');
    },
    hideTab: function () {
        $('.bot-tab').addClass('bot-tab-hide');
    },
    showChat: function () {
        $('.bot-chat').addClass('bot-chat-show');
    },
    hideChat: function () {
        $('.bot-chat').removeClass('bot-chat-show');
    }
};

jQuery(function () {
    $('.bot-tab').click(function () {
        dnnBot.hideTab();
        setTimeout('dnnBot.showChat()', 200);
    });

    $('.bot-close').click(function () {
        dnnBot.hideChat();
        setTimeout('dnnBot.showTab()', 300);
    });

});
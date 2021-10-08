function createChatWidget(functionName, container, id, dotNetComponent) {
    if (!ensureKendoAndJquery()) { return "failed with no kendo"; }

    // create the jQuery widgets here
    window[functionName]($(container).find("#" + id), dotNetComponent);
    return "success";
}
function ensureKendoAndJquery() {
    if (!window.$ || !window.kendo) {
        alert("something went wrong with loading the Kendo library, review the script references");
        // implement your own preferred error handling and/or CDN fallback
        return false;
    }
    return true;
}
function createChat(dotNetComponent, id) {
    
    window.chatHub = new signalR.HubConnectionBuilder().withUrl('https://localhost:5001/chatHub').configureLogging(signalR.LogLevel.Debug).build();
    window.chatHub.start().catch(function (err) {
        console.error(err.toString());
    });
    
    var chat = $("#chatComp1").kendoChat({
        // Each instance of the application will generate a unique username.
        // In this way, the SignalR Hub "knows" who is the user that sends the message
        // and who are the clients that have to receive that message.
        user: {
            name: kendo.guid(),
            iconUrl: "https://demos.telerik.com/kendo-ui/content/chat/avatar.png"
        },
        // This will notify the SignallR Hub that the current client is typing.
        // The Hub, in turn, will notify all the other clients
        // that the user has started typing.
        // The post handler will send the user data and the typed text to the SignalR Hub.
        // The Hub will then forward that info to the other clients.
        post: function (args) {
            console.info(chat.getUser());
            var info = chat.getUser().id;
            var text = args.text.toString();
            chatHub.invoke("sendMessage", info, text).catch(function (err) {
                console.info(err.toString());
            });;

        },
    }).data("kendoChat");
    try {
        return dotNetComponent.invokeMethodAsync('RaiseResponseChat','hello','steve');
    }
    catch (e) {
        console.info(e);
    }
    chatHub.on('ReceiveMessage', function (sender, message) {
        if (sender == chat.getUser().id) {
            var message = {
                type: 'text',
                text: message
            };
            chat.renderMessage(message, chat.getUser());
           
            
        }
    });
}
    


function destroyWidgets(container) {
    if (!ensureKendoAndJquery()) { return; }

    // dispose the Kendo widgets in the container to avoid memory leaks when Blazor removes their DOM elements
    // if you have your own jQuery events attached, detach them here as well
    kendo.destroy(container);
    // if you have issues with Blazor not clearing all the DOM generated through jQuery, you may need to do it yourself
    // for example, widgets generating popup elements outside of the current container may remain in the DOM and
    // you may need to remove them yourself (e.g., before destroying the Kendo widgets, so you can use the references they offer)
    // $(container).find("#" + ganttId).empty();
}
function sendMessage() {
    var userMessage = document.getElementById("userMessage").val();

    $.post("/", { userMessage: userMessage }, function (data) {
        $("#chatBox").append("<p>User: " + userMessage + "</p>");
        $("#chatBox").append("<p>AI: " + data.response + "</p>");
    });
}
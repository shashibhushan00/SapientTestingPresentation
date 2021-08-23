function getDateTime() {
    //Ajax 
    var dateTimeURL = "api/servertime"
    var httpRequest = new XMLHttpRequest();
    httpRequest.onreadystatechange = onAjaxRequestStateChanged;
    httpRequest.open("GET", dateTimeURL, true);
    httpRequest.send();
    function onAjaxRequestStateChanged() {
        console.log("Request State Changed " + httpRequest.readyState);
        if (httpRequest.readyState == 4 && httpRequest.status == 200) {
            document.getElementById("resultArea").innerText = httpRequest.responseText;
        }
    }
}
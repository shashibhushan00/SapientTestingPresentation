var EMI_API_URL = "EMICalculator";

var calculateEMI = () => {
    var principal = $("#principal").val();
    var roi = $("#roi").val();
    var tenure = $("#tenure").val();

    var data = {
        principal: principal,
        roi: roi,
        tenure: tenure
    }

    $.get(EMI_API_URL, data,
        function (data, textStatus) {
            if (textStatus === "success")
                populateResults(data);
            else
                alert(`Response status ${textStatus}`);
        }
    );
}

var populateResults = (data) => {
    console.log(data);
    $("#result-container").removeClass("hidden");
    $("#emi").text(data.monthlyEMI);
    $("#interest").text(data.totalInterestAmount);
    $("#amount").text(data.totalAmountPayable);
}
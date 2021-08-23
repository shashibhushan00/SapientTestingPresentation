$(window).on('load', () => {
    $("#emi-form").submit(function (e) {
        e.preventDefault();
    });

    $("#submit").click(function (e) {
        e.preventDefault();
        calculateEMI();
    });
})
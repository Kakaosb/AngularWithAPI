var continentsList = [
    {
        index: 0,
        value: "Africa"
    },
    {
        index: 1,
        value: "Antarctica"
    },
    {
        index: 2,
        value: "Australia"
    },
    {
        index: 3,
        value: "Eurasia"
    },
    {
        index: 4,
        value: "North America"
    },
    {
        index: 5,
        value: "South America"
    },
];

function ShowMessage(message) {
    $("#message").text(message);

    setTimeout(resetMessage, 5000);
}

function resetMessage() {
    $("#message").text("");
}
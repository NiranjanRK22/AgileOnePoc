function accessDOMElement() {
    var tribute = new Tribute({
        values: [
            { key: 'Phil Heartman', value: 'pheartman' },
            { key: 'Gordon Ramsey', value: 'gramsey' },
            { key: 'Jordan Humphreys', value: 'jhumphreys' },
            { key: 'Howard Johnson', value: 'hjohnson' }
        ]
    });
    var elem = document.getElementById("defaultRTE");
    tribute.attach(elem.querySelector(".e-content"));

}
// JavaScript Document

// Code by Byt3z :3

var number = 0;

start();
function start() {

    update(1);
}

function update(type) {

    if (type == 1) {

        alert("started loop");

    } else if (type == 2) {

        number += 1;
        alert("updated loop");

        if (number > 5) {
            alert("STOP UPDATING THE LOOP AAAAAH-");
            if (number > 7) {]
                alert("ok, so you won't stop...");
                number = 0;
            }
        }

    }
    update(2);

}
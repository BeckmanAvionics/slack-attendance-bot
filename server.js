var admins = ["ashwingupta2000"];

/*
!!!
need to make a timeout for polls
!!!
*/

var express = require("express");
var bodyParser = require("body-parser");
var glob = require("glob");
var fs = require('fs');
var app = express();
var poll_pwd = "never-use-me";
var attendance_pwd = "also-dont-use-me";
//Here we are configuring express to use body-parser as middle-ware.
app.use(bodyParser.urlencoded({
    extended: false
}));
app.use(bodyParser.json());

app.post('/handle', function(request, response) {
    //console.log(request);

    // console.log("recieved POST");
    //response.sendStatus(200);

    function pollActive() {
        return true;
    }

    if (request.body.command == "/makepoll") {
        if (admins.includes(request.body.user_name)) {
            if (!isNaN(request.body.text)) {
                var today = new Date("2020-05-07");
                response.write("Made poll for " + today);
                poll_pwd = request.body.text;
                response.send("Set poll password to: " + poll_pwd);
                console.log("Set poll password to: " + poll_pwd);
            } else {
                response.send("Poll not created, input not a number");
            }
        } else {
            response.send("Failed to make poll, you don't have permission");
            console.log(request.body.user_name + " does not have permission to make poll");
        }
    }

    if (request.body.command == "/poll") {
        if (pollActive()) {
            if (request.body.text == poll_pwd) {
                var date = new Date("2020-05-07");

                var file = glob.sync("poll_logs/*.json");


                console.log(file);

                if (file.includes("poll_logs/" + date + ".json")) {
                    var data = fs.readFileSync("poll_logs/" + date + ".json");
                    var inputD = JSON.parse(data);
                } else {
                    var inputD = {
                        "students": []
                    };
                }
                console.log(inputD);
                inputD["students"].push(request.body.user_name);
                console.log(inputD);
                var outData = JSON.stringify(inputD);
                fs.writeFileSync("poll_logs/" + date + ".json", outData);
                response.send("Check-in Successful");
            } else {
                response.send("Failed to check-in, bad password");
                console.log(request.body.user_name + "Failed to check-in, bad password");
            }
        } else {
            response.send("The poll time has expired");
            consolee.log(request.body.user_name + "attempted to check-in past the allotted time");
        }
    }

    // setpwd and login commands for reference - regular attendance
    if (request.body.command == "/setpwd") {
        if (admins.includes(request.body.user_name)) {
            attendance_pwd = request.body.text;
            response.send("Set password to: " + attendance_pwd);
            console.log("Set password to: " + attendance_pwd);
        } else {
            response.send("Failed to set password, you don't have permission");
            console.log(request.body.user_name + " does not have permission to set pwd");
        }
    }

    if (request.body.command == "/login") {
        if (request.body.text == attendance_pwd) {
            var today = new Date();
            //console.log(today);
            var date = "" + today.getFullYear() + "-" + (today.getMonth() + 1) + "-" + today.getDate();

            var file = glob.sync("attendance_logs/*.json");


            console.log(file);

            if (file.includes("attendance_logs/" + date + ".json")) {
                var data = fs.readFileSync("attendance_logs/" + date + ".json");
                var inputD = JSON.parse(data);
            } else {
                var inputD = {
                    "students": []
                };
            }
            console.log(inputD);
            inputD["students"].push(request.body.user_name);
            console.log(inputD);
            var outData = JSON.stringify(inputD);
            fs.writeFileSync("attendance_logs/" + date + ".json", outData);
            response.send("Login Successful");

        } else {
            response.send("Failed to login, bad password");
            console.log(request.body.user_name + "Failed to login, bad password");
        }

    }



    response.end();

});

app.listen(8000, function() {


    console.log("Started Server on PORT 8000");
})
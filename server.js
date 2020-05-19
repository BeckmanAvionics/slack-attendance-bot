var admins = ["jonathonbower14"];

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
var poll_status = new Boolean();
var init_time = new Date();
var attendance_end;
var attendance_timer = false;
var attendance_active = false;

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
        if (poll_status) {
            hours = init_time.getHours();
            var end_hour = hours + 24;
            if (hours < end_hour) {
                return poll_status;
            } else {
                poll_status = Boolean(False);
                return poll_status;
            }
        }
    }

    if (request.body.command == "/setpollpwd") {
        if (admins.includes(request.body.user_name)) {
            poll_pwd = request.body.text;
            response.send("Set poll password to: " + poll_pwd);
            console.log("Set poll password to: " + poll_pwd);
        }
        else {
            response.send("Failed to set poll password, you don't have permission");
            console.log(request.body.user_name + " does not have permission to set poll pwd");
        }
    }


    if (request.body.command == "/setattendancepwd") {
        if (admins.includes(request.body.user_name)) {
            if(request.body.text.indexOf(",")>-1){
                attendance_pwd = request.body.text.substring(0,request.body.text.indexOf(","));
                attendance_end = init_time.getHours()+parseInt(request.body.text.substring(request.body.indexOf(",")+1));
                attendance_timer=true;
                attendance_active = true;
            }
            else{
                attendance_pwd = request.body.text;
                attendance_timer = false;
                attendance_active = true;
                response.send("Set password to: " + attendance_pwd + ", no timer");
                console.log("Set password to: " + attendance_pwd + ", no timer");
            }
        } else {
            response.send("Failed to set password, you don't have permission");
            console.log(request.body.user_name + " does not have permission to set pwd");
        }
    }

    if (request.body.command == "/makepoll") {
        if (admins.includes(request.body.user_name)) {
            if (!isNaN(request.body.text)) {
                var today = new Date("2020-05-07");
                response.write("Made poll for " + today);
                poll_status = Boolean(True);
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
            poll_status = Boolean(False);
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

    /// Works with UI - can someone verify that this will return the json contents of the requested file?
    // Ensure that the UI application is the source of the request.
    if (request.body.token == "UI") {

        // Exclude '/' to disallow users from sending these commands.
        if (request.body.command == "attendance" || request.body.command == "poll") {
            var file = glob.sync(request.body.command + "_logs/*.json");

            // e.g. attendance_logs/2020-10-31.json
            var fileName = request.body.command + "_logs/" + request.body.text + ".json";

            if (file.includes(fileName)) {
                response.send(fs.readFileSync(fileName));
            }
        }
    }


    response.end();

});

app.listen(8000, function() {


    console.log("Started Server on PORT 8000");
})


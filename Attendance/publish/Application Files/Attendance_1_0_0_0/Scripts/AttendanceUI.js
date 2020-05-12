/// Include in server.js

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

/// Include in server.js
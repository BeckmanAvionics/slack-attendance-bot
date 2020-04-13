
var admins = ["ashwingupta2000"];


var express = require("express");
var bodyParser = require("body-parser");
var glob = require("glob");
var fs = require('fs');
var app = express();
var pwd = "never-use-me";
//Here we are configuring express to use body-parser as middle-ware.
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.post('/handle',function(request,response){
  //console.log(request);
  
 // console.log("recieved POST");
   //response.sendStatus(200);
  
  
  
  if(request.body.command == "/setpwd") {
    if(admins.includes(request.body.user_name)) {
      pwd = request.body.text; 
      response.send("Set password to: " + pwd);
      console.log("Set password to: " + pwd);
    } else {
      response.send("Failed to set password, you don't have permission");
      console.log(request.body.user_name + " does not have permission to set pwd");
    }
  }
  
  if(request.body.command == "/login") {
    if(request.body.text == pwd) {
      var today = new Date();
      //console.log(today);
      var date = "" + today.getFullYear() + "-" +(today.getMonth()+1) + "-" + today.getDate();
	 
      var file = glob.sync("logs/*.json");
		
	  
	  console.log(file);	

      if(file.includes("logs/"+date+".json")) {
		  var data = fs.readFileSync("logs/"+date+".json");
	      var inputD = JSON.parse(data);
	  }
	  else {
		  var inputD = {
			 "students": []
		  };
	  }
	  console.log(inputD); 
	  inputD["students"].push(request.body.user_name);
	  console.log(inputD); 
	  var outData = JSON.stringify(inputD);
	  fs.writeFileSync("logs/"+date+".json", outData);
	  response.send("Login Successful");

    } else {
      response.send("Failed to login, bad password");
      console.log(request.body.user_name + "Failed to login, bad password");
    }
     
  }  
  
  
 
  response.end();
  
});

app.listen(8000,function(){

  
  console.log("Started Server on PORT 8000");
}) 

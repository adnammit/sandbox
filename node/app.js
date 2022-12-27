var http = require('http');
var username = 'amandaryman';

function printMessage (username, badgeCount, points) {
    var message = username + " has " + badgeCount + " total badge(s) and " + points + " points.";
    console.log(message);
}

var request = http.get("http://teamtreehouse.com/" + username + ".json", function(response) {
  var body = "";
  response.on('data', function(chunk) {
    body += chunk;
  });
  response.on('end', function() {
    console.log(body);
    console.log(typeof body);
  });
});

request.on('error', function(e) {
  console.error(e.message);
});

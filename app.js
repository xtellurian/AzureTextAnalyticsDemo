var fs = require('fs');
var term = require('terminal-kit').terminal;
var request = require('request');

const endpoint = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/sentiment";

// get API key
var key = JSON.parse(fs.readFileSync('AppSettings.json'))["api-key"];

console.log("loaded key " + key);

// set up exit key
term.grabInput();
term.on('key', function (name, matches, data) {
    // Detect CTRL-C and exit 'manually'
    if (name === 'CTRL_C') {
        process.exit();
    } else {

    }
});


function runTerminal() {
    term.magenta("Say something: ");
    term.inputField(
        function (error, input) {
            if (input) {
                console.log("\n");
                request({
                    method: 'POST',
                    uri: endpoint,
                    headers: {
                        'content-type': 'application/json',
                        'Ocp-Apim-Subscription-Key': key
                    },
                    body: JSON.stringify({
                        documents: [{
                            id: 1,
                            text: input
                        }]
                    })
                }, function (error, response, body) {
                    var res = JSON.parse(body).documents[0].score;
                    console.log("Has sentiment: " + res);
                    runTerminal();
                });
            }
        }
    );
}

runTerminal();

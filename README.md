# Azure Cognitive Services - Text Analytics Demo

## C#

### Prerequisits

* Download and install the dotnet core runtime https://www.microsoft.com/net/core

* Sign up for Azure Cognitive Services - Text Analytics https://azure.microsoft.com/en-au/try/cognitive-services/?api=text-analytics

### Getting Started

* `git clone https://github.com/xtellurian/AzureTextAnalyticsDemo`

* `dotnet restore`

* `dotnet build`

* Add your cognitive services API key to AppSettings.json file in root folder

    `
    {
        "api-key" : <your-key-here>
    }
    `

* `dotnet run`


## NodeJS

### Prerequisits

* Download and install NVM https://github.com/creationix/nvm

* Download and install nodejs `nvm install node`

* Sign up for Azure Cognitive Services - Text Analytics https://azure.microsoft.com/en-au/try/cognitive-services/?api=text-analytics

### Getting Started

* `git clone https://github.com/xtellurian/AzureTextAnalyticsDemo`

* Add your cognitive services API key to AppSettings.json file in root folder

    `
    {
        "api-key" : <your-key-here>
    }
    `

* `npm install`

* `node app.js`



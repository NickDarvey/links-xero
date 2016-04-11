Links Xero
======
An Azure Logic App Connector for the Xero API.

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

## Setup
1. [Set up a private application in Xero] (http://developer.xero.com/documentation/getting-started/private-applications/)

1. Export your PKCS12 as a base 64 string

   After you've completed the [public/private key pair steps] (http://developer.xero.com/documentation/advanced-docs/public-private-keypair/),
   you'll need to export this so we can pass it in during deployment.
   (As an aside: if anyone wants to do an Azure Key Vault implementation of AuthorizationService.cs---please fork this.)

   Run `openssl base64 -in .\public_privatekey.pfx -out .\pkcs12Content.txt`.

1. [Deploy Links Xero to Azure] (https://azuredeploy.net/)

   Tap the 'Deploy to Azure' button above and fill out the parameters. You can create new resources or reference existing ones.
   * Service Plan Name (the name of a new or existing App Service Plan)
   * Tier (for your App Service Plan, [detailed here] (https://azure.microsoft.com/en-us/pricing/details/app-service/))
   * Scale (the number of instances for your App Service Plan)
   * Xero API Endpoint (from [your application in Xero's My Applications] (https://app.xero.com/Application/List))
   * Xero Consumer Key (from [your application in Xero's My Applications] (https://app.xero.com/Application/List))
   * Xero Pkcs12 Content (from `pkcs12Content.txt`)
   * Xero Pkcs12 Password (that you created)
   * Xero Consumer Key (from [your application in Xero's My Applications] (https://app.xero.com/Application/List))
   * Xero Consumer Secret (from [your application in Xero's My Applications] (https://app.xero.com/Application/List))

1. [Secure your API App] (https://azure.microsoft.com/en-us/documentation/articles/app-service-logic-custom-hosted-api/) (and your Logic App, if you haven't already)
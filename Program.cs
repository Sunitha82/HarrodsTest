using Pulumi;
using Pulumi.AzureNative.Resources;
using Pulumi.AzureNative.Storage;
using Pulumi.AzureNative.Storage.Inputs;
using System.Collections.Generic;

return await Pulumi.Deployment.RunAsync(() =>
{
    var resourceGroupName = "MyResourceGroup";
    var region = "UKSouth";

    // Create a resource group
    var resourceGroup = new ResourceGroup(resourceGroupName, new ResourceGroupArgs
    {
        Location = region
    });

});
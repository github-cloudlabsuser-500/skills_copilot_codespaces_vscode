# Login to Azure
Connect-AzAccount

# Variables
$resourceGroupName = "example-resources"
$location = "East US"
$storageAccountName = "examplestoraccount"

# Create Resource Group if it doesn't exist
$resourceGroup = Get-AzResourceGroup -Name $resourceGroupName -ErrorAction SilentlyContinue
if (-not $resourceGroup) {
    $resourceGroup = New-AzResourceGroup -Name $resourceGroupName -Location $location
}

# Create Storage Account
$storageAccount = New-AzStorageAccount -ResourceGroupName $resourceGroupName `
                                        -Name $storageAccountName `
                                        -Location $location `
                                        -SkuName "Standard_LRS" `
                                        -Kind "StorageV2" `
                                        -EnableHttpsTrafficOnly $true

# Output the storage account name
Write-Output "Storage Account '$($storageAccount.StorageAccountName)' created successfully."
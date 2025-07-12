# AssetTrackerSuite
A comprehensive .NET repository featuring a Razor Pages Fixed Asset Management mini-system and a C# console application for straight-line depreciation tracking, demonstrating full-stack asset lifecycle management and calculation logic.

## 2. Database Setup 🛢️

1. Update the connection string in `appsettings.json` to match your database credentials.

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
   }

2. Run the EF Core Migrations

    ```sh
    # Navigate to the src directory
    cd DepreciationTracker
    
    # Update the database
    dotnet ef database update
    ```


## 📸 UI Screenshots

### 🧭 Asset List

![Asset List](./Screenshots/asset-list.png)

### ➕ Create Asset

![Create Asset](./screenshots/create-asset.png)

### 🧾 Edit Asset

![Edit Asset](./screenshots/edit-asset.png)

### 📊 Delete Asset

![Delete Asset](./screenshots/delete-asset.png)

### Console Application
![Console App](./screenshots/console-app.png)
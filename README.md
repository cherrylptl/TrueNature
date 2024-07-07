# True Nature: ASP.NET Core MVC Website with SQLite and CRUD Operations

## Objective

Enhance a basic ASP.NET Core MVC website by integrating a SQLite database to perform CRUD (Create, Read, Update, Delete) operations on a list of items. Additionally, implement a feature to display the details of an item when clicked from the list using Entity Framework with a "Code-First" approach.


### CRUD Operations

1. **Create a Plant**:
   - Navigate to the "Create Plant" page using the navigation bar.
   - Fill in the `Name` and `Description` fields.
   - Click the "Create" button to add the plant to the database.

2. **View Plant Details**:
   - On the home page, click on the name of a plant to view its details.
   - The details page will display the `Name` and `Description` of the plant.

3. **Edit a Plant**:
   - On the home page, click the "Edit" button next to a plant.
   - Update the `Name` and `Description` fields as needed.
   - Click the "Save" button to update the plant in the database.

4. **Delete a Plant**:
   - On the home page, click the "Delete" button next to a plant.
   - Confirm the deletion to remove the plant from the database.


## Setup

- Ensure the .NET Core SDK is installed on your machine.


## Getting Started

### Prerequisites

- .NET Core SDK
- Visual Studio or Visual Studio Code

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/cherrylptl/TrueNature.git
   cd Assignment2

### Run 
2. Open Terminal:
   ```sh
   dotnet run

# Mini_Project

**How to setup:**
1. Download the folder with all of its components
2. Create a database and a tables
<details>
  CREATE TABLE clothes (
	clothes_id INT IDENTITY(1,1) PRIMARY KEY,
	clothingItem VARCHAR (50),
	color VARCHAR (50),
	size VARCHAR (10),
	brand VARCHAR (50),
	available VARCHAR (10)
);

CREATE TABLE user_info (
	userID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR (50),
	LastName VARCHAR (50),
	email VARCHAR (50),
	address VARCHAR (50),
	arrivalTime DATE,
	clothes_id INT,
	FOREIGN KEY (clothes_id) REFERENCES clothes(clothes_id)
);

CREATE TABLE staff_info (
	username VARCHAR (50),
	password VARCHAR (50)
);
</details>
3. Open the .sln file through Visual Studio
4. Run the program :)

**Functionalities:**
  - save notes
  - edit notes
  - delete notes
  - view notes

#Overview

The Clothing Catalog is a comprehensive platform designed to cater to both end-users and staff members. End-users can browse and purchase clothes through a user-friendly interface, while staff members have access to functionalities for managing the clothing catalog.

#User Features

    Browse and Purchase: Users can explore a wide range of clothing items using four different filters: type of clothing item, color, size, and brand. They can also utilize the search function to find specific items within each category.
    Availability: Users can view the availability status of each clothing item.
    Ordering: Users can place orders by entering their personal information.

#Staff Features

    Authentication: Staff members are required to log in to their accounts to access the catalog management functionalities.
    Catalog Management: Once authenticated, staff members can add, edit, and delete clothing items from the catalog.

#Authentication and Authorization

    User Roles: Only staff members have access to the authentication system and are assigned staff accounts.
    Access Control: Staff accounts are granted permissions to edit the catalog upon successful authentication.

#Data Management

    Database Structure:
        Clothing Information Table
        User Purchase Information Table
        Staff Accounts Table
    Clothing Information: Stores details about each clothing item, including type, color, size, and brand.
    User Purchase Information: Records user details for order processing and delivery.
    Staff Accounts: Stores credentials for staff members to access the catalog management system.

#User Interface

    Layout: The user interface is designed to be intuitive and easy to navigate.
    Filtering and Search: Users can utilize filters and the search function to find desired clothing items efficiently.

# Inventory Management System

A Windows Forms application developed in C# for manufacturing businesses to track inventory of parts and products.

## Screenshots

![Main Form](https://github.com/MatthewMorrow/C968-inventory-management-system/blob/main/Screenshots/MainForm.png)
![Add Part Form](https://github.com/MatthewMorrow/C968-inventory-management-system/blob/main/Screenshots/AddPartForm.png)
![Modify Part Form](https://github.com/MatthewMorrow/C968-inventory-management-system/blob/main/Screenshots/ModifyPartForm.png)
![Add Product Form](https://github.com/MatthewMorrow/C968-inventory-management-system/blob/main/Screenshots/AddProductForm.png)
![Modify Product Form](https://github.com/MatthewMorrow/C968-inventory-management-system/blob/main/Screenshots/ModifyProductForm.png)

## Features

- **Part Management**: Create, modify, and delete parts with support for In-House or Outsourced classification
- **Product Assembly**: Associate multiple parts with products to create assemblies
- **Inventory Tracking**: Monitor stock levels with min/max constraints and validation
- **Search Functionality**: Quickly find parts and products by ID or name
- **Data Validation**: Prevents logical errors such as:
  - Non-numeric values in numeric fields
  - Inventory levels outside min/max bounds
  - Deleting parts associated with products
  - Accidental deletions

## Usage

1. **Parts Management**: Add parts with unique identifiers, specifying whether they are manufactured in-house or outsourced
2. **Products Assembly**: Create products by combining parts from inventory
3. **Inventory Control**: Update stock levels and set minimum/maximum thresholds

## Technical Details

- Built with C# and Windows Forms
- Uses object-oriented principles including inheritance, encapsulation, and polymorphism
- Implements BindingList for dynamic UI updates

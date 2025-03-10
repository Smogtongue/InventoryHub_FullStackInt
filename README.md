# InventoryHub Enhancement Project

## Project Summary

This project focused on enhancing the InventoryHub application by addressing integration issues, formatting product prices, and improving the visual styling of product cards.

### Key Enhancements via Copilot

1. **Resolved Integration Issues:**
   - Debugged and resolved integration issues between the Blazor front-end and Minimal API back-end.
   - Refined JSON structures for API responses in the back-end.

2. **Implemented Formatting for Price:**
   - Ensured that product prices are formatted to display two decimal places using `String.Format("{0:0.00}", product.Price)`.

3. **Enhanced UI with CSS:**
   - Created a `styles.css` file to style product cards with rounded corners, dark grey background, and light text for better contrast.
   - Updated the `index.html` file to include the new stylesheet.

4. **Updated `FetchProducts.razor` Logic:**
   - Provided code updates for `FetchProducts.razor` to correctly display formatted prices and categories.
   - Separated CSS logic from the functionality of the Razor file.

5. **Verified Dependencies:**
   - Ensured that necessary dependencies like `System.Text.Json` were referenced correctly to handle JSON deserialization.
  
## Proof of Functionality
  
### Home Page
  <img src= https://github.com/Smogtongue/InventoryHub_FullStackInt/blob/454f239d562514d7f17e2cc501061a4fe3687d4b/Readme_IMGS/HomePage.png >

### Fetch Products Page
<img src= https://github.com/Smogtongue/InventoryHub_FullStackInt/blob/454f239d562514d7f17e2cc501061a4fe3687d4b/Readme_IMGS/FetchProductsPage.png>

### Successful GET of backend Data with 200 code. Dev Inspector + Swagger.

<img src= https://github.com/Smogtongue/InventoryHub_FullStackInt/blob/454f239d562514d7f17e2cc501061a4fe3687d4b/Readme_IMGS/200OK_DevInspector.png>

<img src= https://github.com/Smogtongue/InventoryHub_FullStackInt/blob/454f239d562514d7f17e2cc501061a4fe3687d4b/Readme_IMGS/SWAGGER_APIpost_Success.png>

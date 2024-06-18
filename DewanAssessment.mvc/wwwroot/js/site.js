// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.



// import DataTable from 'datatables.net-dt';
// import 'datatables.net-responsive-dt';
 
// let table = new DataTable('#myTable', {
//     responsive: true
// });

// (document).ready( function () {
//     $('#myTable').DataTable();
// } );

new DataTable('#myTable');

function moveToCart(item) {
    var itemDetails = item
    // Retrieve existing cart items from local storage
         var cartItems = JSON.parse(localStorage.getItem('cart')) || [];
                 // Add the new item to the cart

        cartItems.push(itemDetails);

        // Store the updated cart back in local storage
        localStorage.setItem('cart', JSON.stringify(cartItems));
        console.log(cartItems(1).Name);
        console.log(item.Name);

    location.reload();

      
}

function getCartItems() {
    var cartItems = JSON.parse(localStorage.getItem('cart')) || [];
    
    for (let value in cartItems) {
        console.log(cartItems[value].Id);
        console.log(cartItems[value].Name);
        console.log(cartItems[value].Quantity);
        console.log(cartItems[value].Price);
    }
    


// Reference to the container where cart items will be displayed
var cartItemsContainer = document.getElementById('cartItemsContainer');

// Clear the container before adding items to prevent duplication
cartItemsContainer.innerHTML = '';

// Iterate over cart items and display each item
cartItems.forEach(function(item) {
    // Create a div element to represent each cart item
    var cartItemDiv = document.createElement('div');
    cartItemDiv.classList.add('cart-item');

    // Populate the cart item div with item details
    // Assuming each item is an object with properties Name, Price, and Quantity
    cartItemDiv.innerHTML = `
        <span>Name: ${item.Name}</span>
        <span>Price: ${item.Price}</span>
        <span>Quantity: ${item.Quantity}</span>
    `;

    // Append the cart item div to the container
    cartItemsContainer.appendChild(cartItemDiv);
});


            return cartItems;
}

onload =  getCartItems();
// Retrieve cart items from local storage



// if (cartItemsString) {
//     try {
//         cartItems = JSON.parse(cartItemsString);
//     } catch (error) {
//         console.error('Error parsing cart items:', error);
//     }
// }



// var DataTable = require( 'datatables.net' );

// require( 'datatables.net-responsive' );
 
// let table = new DataTable('#myTable', {
//     responsive: true
// });
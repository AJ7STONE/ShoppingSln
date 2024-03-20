using System;
using System.Collections.ObjectModel;

namespace Shopping
{
    using System;
    using Microsoft.Maui.Controls;

    namespace Shopping
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                
            }

            // Define the event handler method for the "Add to Cart" button click event
            private void AddToCart_Clicked(object sender, EventArgs e)
            {
                // Add your logic here to handle adding the item to the cart
            }
        }
    }

    public partial class ShoppingCartPage : ContentPage
    {
        ListView cartListView; // Declare cartListView
        public ObservableCollection<ShoppingItem> CartItems { get; set; }

        public ShoppingCartPage()
        {
            // Initialize CartItems with the items in the shopping cart
            // This can be obtained from a ViewModel or another source
            CartItems = new ObservableCollection<ShoppingItem>();

            // Initialize cartListView
            cartListView = new ListView();
            cartListView.SetBinding(ListView.ItemsSourceProperty, new Binding("CartItems"));

            // Assign the item template (assuming there's a DataTemplate named "CartItemTemplate")
            cartListView.ItemTemplate = new DataTemplate(typeof(ShoppingItem)); // Custom cell for displaying shopping items

            // Assign event handler for removing an item from the cart
            cartListView.ItemSelected += RemoveItem_Clicked;

            // Add cartListView to your layout
            Content = new StackLayout
            {
                Children = { cartListView }
            };
        }

        // Event handler for removing an item from the cart
        private void RemoveItem_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedItem = e.SelectedItem as ShoppingItem;
            CartItems.Remove(selectedItem);
            // Update total or other relevant data

            ((ListView)sender).SelectedItem = null; // Deselect the item
        }

        // Event handler for proceeding to checkout
        private void ProceedToCheckout_Clicked(object sender, EventArgs e)
        {
            // Implement the logic for proceeding to checkout
        }

        private void AddToCart_Clicked(object sender, EventArgs e)
        {
            // Add your logic here to handle adding the item to the cart
        }

    }
}

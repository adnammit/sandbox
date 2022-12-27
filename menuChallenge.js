

var menuItems = [
    { name: 'Fruit', price: 2.15 },
    { name: 'Fries', price: 2.75 },
    { name: 'Salad', price: 3.35 },
    { name: 'Wings', price: 3.55 },
    { name: 'Mozzarella', price: 4.20 },
    { name: 'Pizza', price: 5.80 },
];



// fruit * 7
// fruit + 2*wings + pizza



function getItems(menuItems, total, currItems) {
    let success;
    if(total < 0) {
        return 0;
    }
    else if (total == 0) {
        return 1;
    }
    else {
        menuItems.forEach(function(item) {
            if(getItems(menuItems, total-item.price, currItems)) {
                currentItems.push(item);
            }
        });
    }
}

var total = 15.05;
var currItems = [];

getItems(menuItems, total, currItems);

// Post-processing:
currItems.forEach(function(item) {

    console.log()
});

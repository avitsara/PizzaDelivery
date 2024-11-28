CREATE TABLE Order_Items (
    order_item_id INTEGER PRIMARY KEY AUTOINCREMENT,
    order_id INTEGER,
    pizza_id INTEGER,
    quantity INTEGER,
    price DECIMAL
);
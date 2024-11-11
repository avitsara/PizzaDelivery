CREATE TABLE Order_Items (
    order_item_id INTEGER PRIMARY KEY,
    order_id INTEGER,
    pizza_id INTEGER,
    quantity INTEGER NOT NULL,
    FOREIGN KEY (order_id) REFERENCES "Order"(order_id) ON DELETE CASCADE,
    FOREIGN KEY (pizza_id) REFERENCES Pizza(pizza_id) ON DELETE CASCADE
);
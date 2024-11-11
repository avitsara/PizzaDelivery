CREATE TABLE "Order" (
    order_id INTEGER PRIMARY KEY,
    user_id INTEGER NOT NULL,
    total_price REAL NOT NULL,
    mode_of_order TEXT NOT NULL
);
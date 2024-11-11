CREATE TABLE Pizza_Ingredients (
    pizza_id INTEGER,
    ingredient_id INTEGER,
    PRIMARY KEY (pizza_id, ingredient_id),
    FOREIGN KEY (pizza_id) REFERENCES Pizza(pizza_id) ON DELETE CASCADE,
    FOREIGN KEY (ingredient_id) REFERENCES Ingredients(ingredient_id) ON DELETE CASCADE
);
const express = require('express');
const app = express();
const port = 3000;

// Simulated database
const recipes = [
    { name: "recept a", category: null, steps: "postup pro recept a", ingredients: ["Rajče", "Česnek"] },
    { name: "recept b", category: "Bez lepku", steps: "postup pro recept b", ingredients: ["Cibule", "Česnek"] },
    // Add more recipes as needed
];

app.use(express.json());

app.get('/recipes', (req, res) => {
    res.json(recipes);
});

app.listen(port, () => {
    console.log(`Server running at http://localhost:${port}`);
});

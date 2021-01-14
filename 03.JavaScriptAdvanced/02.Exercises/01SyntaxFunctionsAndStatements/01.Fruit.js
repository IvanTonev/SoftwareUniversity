function calculateFruitPrice(fruit, weightGrams, price) {
    let weightKilograms = weightGrams / 1000;
    let money = weightKilograms * price;
    console.log(`I need $${money.toFixed(2)} to buy ${weightKilograms.toFixed(2)} kilograms ${fruit}.`);
}

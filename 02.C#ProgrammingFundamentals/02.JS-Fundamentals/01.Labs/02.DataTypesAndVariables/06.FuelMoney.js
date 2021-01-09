function solve(distance, passengers, price) {
    let consumption = (distance / 100 * 7) + (0.1 * passengers);
    let neededMoney = consumption * price;
    console.log(`Needed money for that trip is ${neededMoney}lv.`)
}

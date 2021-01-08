function solve(count, type, day) {
    let personPrice;
    let totalPrice;
    switch (type) {
        case 'Students':
            switch (day) {
                case 'Friday':
                    personPrice = 8.45;
                    break;
                case 'Saturday':
                    personPrice = 9.8;
                    break;
                case 'Sunday':
                    personPrice = 10.46;
                    break;    
            }
            totalPrice = count * personPrice;
            if (count >= 30) {
                totalPrice -= 0.15 * totalPrice;
            }
            break;
        case 'Business':
            if (count >= 100) {
                count -= 10;
            }
            switch (day) {
                case 'Friday':
                    personPrice = 10.9;
                    break;
                case 'Saturday':
                    personPrice = 15.6;
                    break;
                case 'Sunday':
                    personPrice = 16;
                    break;
            }
            totalPrice = count * personPrice;
            break;
        case 'Regular':
            switch (day) {
                case 'Friday':
                    personPrice = 15;
                    break;
                case 'Saturday':
                    personPrice = 20;
                    break;
                case 'Sunday':
                    personPrice = 22.5;
                    break;
            }
            totalPrice = count * personPrice;
            if (10 <= count && count <= 20) {
                totalPrice -= 0.05 * totalPrice;
            }
            break;
    }
    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}

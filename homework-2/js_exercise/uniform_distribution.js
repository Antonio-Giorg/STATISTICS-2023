
let random = new Random();
let variables = [];
let lowerBound = 0.0;
let upperBound = 0.0;


let numberOfN = 50;
let kNumber = 12;
let count = 1;


for (let _ = 0; _ < numberOfN; _++) {
    variables.push(Math.random());
}



for (let i = 0; i < kNumber; i++) {
    lowerBound = i / kNumber;
    upperBound = (i + 1) / kNumber;

    console.log("From " + lowerBound +" to" + upperBound);

    let count = 1;
    variables.forEach((num) => {
        if (num >= lowerBound && num < upperBound) {
            console.log(`${count} - ${num}`);
            count++;
        }
    });

    count = 1;
    console.log("\n ================================================================ \n\n");
}




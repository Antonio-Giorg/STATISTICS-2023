const fs = require('fs');

function calculateJointDistribution(variable1, variable2) {
    const jointDistribution = {};

    for (const key1 in variable1) {
        for (const key2 in variable2) {
            if (key1 === key2) {
                const key = `${key1},${key2}`;
                if (jointDistribution[key]) {
                    jointDistribution[key] += variable1[key1] * variable2[key2];
                } else {
                    jointDistribution[key] = variable1[key1] * variable2[key2];
                }
            }
        }
    }

    return jointDistribution;
}

function generalJointDistribution(...variables) {
    let jointDistribution = { ...variables[0] };

    for (let i = 1; i < variables.length; i++) {
        const currentVariable = variables[i];
        for (const key in jointDistribution) {
            if (currentVariable.hasOwnProperty(key)) {
                jointDistribution[key] *= currentVariable[key];
            } else {
                delete jointDistribution[key];
            }
        }
    }

    return jointDistribution;
}

function calculateFrequencies(data) {
    let totalLength = 0;
    for (const key in data) {
        console.log(`Frequenza assoluta di: ${key}, Valore: ${data[key]}`);
        totalLength += data[key];
    }

    console.log();

    for (const key in data) {
        const frequency = data[key] / totalLength;
        console.log(`Frequenza relativa di: ${key}, Valore: ${frequency.toFixed(4)} In percentuale: ${(frequency * 100).toFixed(2)}%`);
    }
}

function convertFileIntoVariable(fileName) {
    const result = {};

    try {
        const lines = fs.readFileSync(fileName, 'utf8').split('\n');
        for (const line of lines) {
            const current = line.toLowerCase().trim();
            if (current.length === 0) {
                result['None'] = (result['None'] || 0) + 1;
            } else {
                result[current] = (result[current] || 0) + 1;
            }
        }
    } catch (error) {
        console.error("Si è verificato un errore: " + error.message);
    }

    return result;
}

const leaderOrPlayer = convertFileIntoVariable("leader_or_player.txt");
const heightValue = convertFileIntoVariable("height.txt");
const hardWork = convertFileIntoVariable("hard_work.txt");

calculateFrequencies(leaderOrPlayer);
console.log();
calculateFrequencies(heightValue);
console.log();
calculateFrequencies(hardWork);
console.log();

const jointDistribution = calculateJointDistribution(hardWork, leaderOrPlayer);
console.log("Distribuzione congiunta tra valori di altezza e ruolo di leader o giocatore:");
for (const key in jointDistribution) {
    console.log(`P(${key.split(',')[0]}, ${key.split(',')[1]}) = ${jointDistribution[key] / Object.keys(heightValue).length}`);
}

const generalDistribution = generalJointDistribution(heightValue, hardWork, leaderOrPlayer);
console.log("Distribuzione congiunta generale:");
for (const key in generalDistribution) {
    console.log(`Variabile: ${key}, Count: ${generalDistribution[key]}`);
}

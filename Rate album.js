const fs = require('fs');
const readline = require('readline');
const path = require('path');

const readLine = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

const filename = path.join(__dirname ,"..", 'OneDrive/Desktop/Ratings.txt');

async function main() {
    while (true) {
        let album = await question("Please enter album name\n");
        let artist = await question("Please enter artist name\n");
        let year = await question("Please enter the year the album was released\n");
        let tracks = await question("Please enter the number of tracks\n");

        let three = await question("Please enter the number of 3 star songs\n");
        let four = await question("Please enter the number of 4 star songs\n");
        let five = await question("Please enter the number of 5 star songs\n");

        five = (1 / tracks) * five;
        four = (1 / tracks) * (four * 0.55);
        three = (1 / tracks) * (three * 0.35);

        let score = 100 * (five + four + three);
        score = Math.ceil(score);

        fs.appendFileSync(filename, `Album: ${album}, Artist: ${artist}, Year: ${year}, Score: ${score}\n`);

        console.log(score);
        console.clear();
    }
}

function question(query) {
    return new Promise(resolve => {
        readLine.question(query, answer => {
            resolve(answer);
        });
    });
}

main();

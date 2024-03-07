// 1.
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};

let sum = 0;
for (let key in salaries) {
    sum += salaries[key];
}

console.log(sum); // Should log 390

// 2.
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

function multiplyNumeric(obj) {
    for (let key in obj) {
        if (typeof obj[key] === 'number') {
            obj[key] *= 2;
        }
    }
}

multiplyNumeric(menu);

console.log(menu);
// After the call, menu should be:
// width: 400,
// height: 600,
// title: "My menu"


// 3.
function checkEmailId(str) {
    let atIndex = str.indexOf('@');
    let exclIndex = str.indexOf('!', atIndex);

    // Check if both '@' and '!' are present and '@' comes before '!'
    if (atIndex < 0 || exclIndex < 0) return false;

    // Ensure there are characters between '@' and '!'
    return exclIndex - atIndex > 1;
}

// Example usage
console.log(checkEmailId('test@example.com')); // Expected: false, as there's no '!'
console.log(checkEmailId('test@example!com')); // Expected: true
console.log(checkEmailId('test@!example.com')); // Expected: false, as '!' does not come after '@' with characters in between


// 4.
function truncate(str, maxlength) {
    if (str.length > maxlength) {
        // Subtract 2 from maxlength to account for the two characters in ".."
        return str.slice(0, maxlength - 2) + "..";
    }
    return str;
}

// Example usage
console.log(truncate("What I'd like to tell on this topic is:", 20)); // "What I'd like to te.."
console.log(truncate("Hi everyone!", 20)); // "Hi everyone!"

// 5.
let styles = ["James", "Brennie"];

// Append "Robert" to the end
styles.push("Robert");

// Replace the value in the middle with "Calvin"
let middleIndex = Math.floor(styles.length / 2);
styles[middleIndex] = "Calvin";

// Remove the first value of the array and show it
let first = styles.shift();
console.log(first); // "James"

// Prepend "Rose" and "Regal" to the array
styles.unshift("Rose", "Regal");

// The array should now be: ["Rose", "Regal", "Calvin", "Robert"]
console.log(styles);


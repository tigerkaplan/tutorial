//!  06_day_loops PRACTICES
//? Level1
const countries = [
  "Albania",
  "Bolivia",
  "Canada",
  "Denmark",
  "Ethiopia",
  "Finland",
  "Germany",
  "Hungary",
  "Ireland",
  "Japan",
  "Kenya"
];

const webTechs = [
  "HTML",
  "CSS",
  "JavaScript",
  "React",
  "Redux",
  "Node",
  "MongoDB"
];

const mernStack = [
  "MongoDB",
  "Express",
  "React",
  "Node"
]; /* console.log("i, i^2, i^3");
 for (let i = 0; i<=10; i++){
  console.log(i + " " + (i*i) + " " + (i*i*i));
 } 

console.log ("--------------------")

console.log ( "i, i^2, i^3");
for (let i = 10; i >=0; i--) {
  console.log(i + " " + (i*i) + " " + (i*i*i));
}
/* -------------------------------------------------------------------------- */ /*  A7 ----------------------------------------------------------------------- */ // Loop to print the pattern // Loop to print only even numbers from 0 to 100 // for (let i =0; i<=100; i++) { //** Q7.Use for loop to iterate from 0 to 100 and print only even numbers //   if (i%2===0) { //     console.log(i); //   } // }

//1. Iterate 0 to 10 using for loop, do the same using while and do while loop

//2. Iterate 10 to 0 using for loop, do the same using while and do while loop

//3.Iterate 0 to n using for loop

//  1.a Using for Loop
// for (let i= 0; i <=10; i++) {
//     console.log(i)
// }

// // Using for loop
// console.log("Using for loop:(0-10)");
// // for (let i = 0; i <= 10; i++) {
// //     console.log(i);
// // }

// //  1.b Using for while

// console.log("Using for while Loop: (0-10)");
// // let i = 0;
// // while (i <= 10) {
// //   console.log(i);
// //   i++;
// // }

// //  1.c  do while loop (0-10)
// console.log("Using for do while Loop: (0-10)");
// // let i = 0;
// // do {
// //   console.log(i);
// //   i++;
// //   } while (i<=10);

// //2a. Iterate 10 to 0 using for loop

// // console.log("Using for loop (10-0)");
// // for (let i=10; i>=0; i--){
// //   console.log(i);
// //}
// //2b. Iterate 10 to 0 using for  while
// // console.log("Using for while loop (10-0)");
// // let j = 10;
// // while (j>=0) {
// //   console.log (j);
// //   j--;
// // }
// //2c. Iterate 10 to 0 using for  do while loop
// // console.log("Using for do while loop (10-0)");
// // let k = 10;
// // do {
// //   console.log (k);
// //     k--;
// // } while (k>=0);

// /* Using for loop / while / do while loop
// 0
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9
// 10
// */

// //3.Iterate 0 to n using for loop
// const n = 6;
// //a. for Loop
// console.log("for loop (0-6)");
// for (let i = 0; i <= n; i++) {
//   console.log(i);
// }

// //b. while
// console.log("while (0-6)");
// let j = 0;
// while (j <= n) {
//   console.log(j);
//   j++;
// }

// //c. do while
// console.log(" do while (0-6)");
// let k = 0;
// do {
//   console.log(k);
//   k++;
// } while (k <= n);

// Q4. Write a loop that makes the following pattern using console.log():

//     #
//     ##
//     ###
//     ####
//     #####
//     ######
//     #######

//A4
// // 1-define the number of rows  in the current pattern

// const numberOfRows = 7;

// // 2- Outer loop for rows
// for (let i = 1; i <= numberOfRows; i++) {
//   let row = "";
//   // 3- Inner loop for rows
//   for (let j = 1; j <= i; j++) {
//     row += "#"; // add"#" to the row" right hand  side
//   }
//   console.log(row);
// }

// Q4. Write a loop that makes the following pattern using console.log():

//     #######
//     ######
//     #####
//     ####
//     ###
//     ##
//     #

// const nOr = 7
// for (let i=7; i >=1; i--) {
//   let row = '';
//   //Inner loop for rows
//   for (let j=1; j<+i; j++) {
//     row += "#";

//   }
//   console.log(row);
// }

// Q5. Use loop to print the following pattern:

// 0 x 0 = 0
// 1 x 1 = 1
// 2 x 2 = 4
// 3 x 3 = 9
// 4 x 4 = 16
// 5 x 5 = 25
// 6 x 6 = 36
// 7 x 7 = 49
// 8 x 8 = 64
// 9 x 9 = 81
// 10 x 10 = 100

//**********************************
//  * A5 LOOP TO PRINT THE PATTERN *
//  **********************************/
// for (let i = 0; i <=10; i++){
//   console.log(i + "x" + i + " = " + (i*i));
// }
// console.log("------------------------------------------");

// for (let i = 1; i <= 10; i++) {
//   for (let j = 1; j <= 10; j++) {
//     console.log(i + "x" + j + "=" + i * j);
//   }
//   console.log("------------------------------------------");
// }

//***********************************************
//  * //Q6 USING LOOP PRINT THE FOLLOWING PATTERN *
//  *             //  I    I^2   I^3              *
//  *              //  0    0     0               *
//  *              //  1    1     1               *
//  *              //  2    4     8               *
//  *              //  3    9     27              *
//  *              //  4    16    64              *
//  *             //  5    25    125              *
//  *             //  6    36    216              *
//  *             //  7    49    343              *
//  *             //  8    64    512              *
//  *             //  9    81    729              *
//  *             //  10   100   1000             *
//* TODO - *********************************************** *!SECTION//

/*  A6 ----------------------------------------------------------------------- */ //* Q8.Use for loop to iterate from 0 to 100 and print only odd numbers
/*  A8 ----------------------------------------------------------------------- 
for (let i=0; i<=100; i++) {
  if (i%2===1) {
    console.log(i);
  }
}

//* Q9. Use for loop to iterate from 0 to 100 and print only prime numbers
  A9 -----------------------------------------------------------------------*/
//REVIEW -
//Function to check i a number is prime

// function isPrime(num){
//   if (num <=1) {
//     return false;
//   }
//   for (let i=2; i <=Math.sqrt(num); i++) {
//     if (num %i === 0) {
//       return false;
//     }
//   }
//   return true;
// }

// // loop to print only prime numbers 0 to 100
// console.log("Prime numbers from 0 to 100:");
// for (let i=0; i<=100; i++) {
//   if (isPrime(i)) {
//     console.log(i);
//   }
// }

//* Q10. Use for loop to iterate from 0 to 100 and print the sum of all numbers.
//A10 -----------------------------------------------------------------------*/

// Initialize a variable to store the sum

// let sum = 0;
// for (let i=0; i<=100; i++){
//   sum +=i;
// }
// // print the sum
// console.log("Sum of all numbers from 0 to 100 is ", sum +".");

//* Q11. Use for loop to iterate from 0 to 100 and print the sum of all evens and the sum of all odds.
//A11 -----------------------------------------------------------------------*/

// // Initialize a variable to store the sum

// let sumOdds =0;
// let sumEvens =0;

// // Loop to iterate from 0 to 100 and calculate the sum of even and odd numbers

// for (let i=0; i<=100; i++) {
//   if (i%2===0) {
//     sumEvens += i;
//   } else {
//     sumOdds += i;
//   }
// }
//   // print the sum
// console.log("Sum of all evens 0 to 100 is", sumEvens +". And sum of all odds 0 to 100 is", sumOdds +".")

//* Q12. Use for loop to iterate from 0 to 100 and print the sum of all evens and the sum of all odds. Print sum of evens and sum of odds as array

//A12 -----------------------------------------------------------------------*/

// let sumOdds =0;
// let sumEvens =0;

// // Loop to iterate from 0 to 100 and calculate the sum of even and odd numbers

// for (let i=0; i<=100; i++) {
//   if (i%2===0) {
//     sumEvens += i;
//   } else {
//     sumOdds += i;
//   }
// }
// // Create an array to store the sums of even and odd numbers
// let sums = [sumEvens, sumOdds];

// // Print the array containing the sum of even and odd numbers
// console.log("Sum of even and odd numbers:", sums);

//* Q13. Develop a small script which generate array of 5 random numbers
//A13 -----------------------------------------------------------------------*/

// // Function to generate an array of 5 random numbers
// function generateRandomNumbers() {
//   let randomNumbers = []; // initialize an empty array to store random numbers
//   //Loo to generate 5 random numbers
//   for (let i = 0; i < 5; i++) {
//     // generate a random number between 0 (inclusive) and 1 (exclusive),
//     // then scale it to be between 0 and 100 ( both inclusive)
//     let randomNumber = Math.floor(Math.random() * 101);

//     //push he random number to the array
//     randomNumbers.push(randomNumber);
//   }
//   return randomNumbers; // return the array of random numbers
// }
// // Call the function to generate random numbers and store them in  a variable
// let randomArray = generateRandomNumbers();

// // Print the generated array
// console.log("Generated random array:", randomArray);

//* Q14. Develop a small script which generate array of 5 random numbers and the numbers must be unique
//A14 -----------------------------------------------------------------------*/

//Function to generate an array of 5 unique random numbers
// function generateUniqueRandomNumbers() {
//   let randomNumbers = []; // initialize an empty array to store random numbers

//   while (randomNumbers.length < 5) {
//     let randomNumber = Math.floor(Math.random() * 101);
//     if (!randomNumbers.includes(randomNumber)) {
//       randomNumbers.push(randomNumber);
//     }
//   }
//   //return the first 5 elements of shuffled array
//   return randomNumbers;
// }
// //call the function to generate unique random numbers and store them in a variable
// let randomArray = generateUniqueRandomNumbers();
// //print the generated array

// console.log("Generate array of 5 unique random numbers:", randomArray);

//* Q15. Develop a small script which generate a six characters random id:
//REVIEW - to  capital, lowercase, and number
//A15 -----------------------------------------------------------------------*/

// //function to generate a random 6-character ID
// function generateRandomId() {
//   let characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
//   let randomId = "";
//   for (let i=0; i<6; i++){
//     randomId += characters.charAt(Math.floor(Math.random()* characters.length));
//   }
//   return randomId;
// }
// // call the function to generate a random ID and store it in a variable
// let randomId = generateRandomId();

// //Print the generated random ID

// console.log("Generated random ID:", randomId);

//? Level2
//* Q1. Develop a small script which generate any number of characters random id:

// //function to generate a random ID
// function generateRandomID(length) {
//   let characters =
//     "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
//   let randomID = "";

//   for (let i = 0; i < length; i++) {
//     randomID += characters.charAt(
//       Math.floor(Math.random() * characters.length)
//     );
//   }
//   return randomID;
// }

// //call the unction to generate a random ID with a specified characters
// let randomID = generateRandomID(10);

// //Print the generated random ID
// console.log("Generated random ID:", randomID);

//* Q2. Write a script which generates a random hexadecimal number.
function generateRandomHexadecimal() {
  let randomInt = Math.floor(Math.random() * 16777216);
  //Convert the random integer to its hexadecimal representation
  let randomHexadecimal = randomInt.toString(16).toUpperCase();
  // ensure that the hexadecimal number has exactly
  randomHexadecimal = randomHexadecimal.padStart(6, "0");

  return randomHexadecimal;
  //
}

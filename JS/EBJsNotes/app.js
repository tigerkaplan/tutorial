// * Mantiksal Operators

/* 
&& : and
: or
! : not 

== : Esit mi? 
!= Esit degil mi? 


Diolog box


alert
prompt
confirm
*/

// ! * ? // ~ & ^
// * Switch Case Lesson 25

//? very rare use
//? same logic for if-else
//?  alternative to if-else
//? value hangi case ile eslesiyorsa ona gidiyor. hicbiri yoksa "default" taki deger calisir.
// switch (value) {
//     case 1:
//     // ~ codes

//     break;
//     case 2:
//     // ~ codes

//     break;
//     case 3:
//     // ~ codes

//     break;
//     default:
//     // ~ codes

//     break;
// }

// * Type Conversion  Lesson 29

// let a = 5
// let b = "10"

// String veri tipinden number veri tipine donusturmek

//let c = Number(b);
// console.log( typeof c);
//console.log (a+c);

//parseInt()

// console.log(window)

// let a = 8;
// let b = parseInt("12");
// console.log (a+b);

// * For

// for (variable; condition; increase - decrease) {
//   // codes
// }

// for (let i = 1; i <= 10; i++) {
//   console.log(i);
// }

// write from 1 to 10

// for (let i=1; i<=10; i++) {
//     console.log (i);
// }

// even numbers from 1 to 10

// for (let i=0; i<=10; i=i+2) {
//     console.log (i);
// }

// odd numbers from 1 to 10
// for (let i=1; i<=10; i=i+2) {
//     console.log (i);
// }

/*
hi
Husniye
hi
Husniye
hi
Husniye
*/

// for (let i = 1; i <= 10; i++) {
//   if (i % 2 == 1) {
//     console.log("Husniye"); //  odd number
//   } else {
//     console.log("hi"); // even number
//   }
// }

// //50 den 1 e kadar gidip toplamlari bul
// let total = 0;

// for (let i = 50; i >= 1; i--) {
//   total = total + i;
//   console.log(i);
//   // console.log("Total:" , total)
// }
// console.log("Total:", total);

// * While

// while (condition) {
//   // codes
//   //
// }

// 1 to 10 evens and odds

// let counter = 0;
// while (counter <= 10) {
// //   if (counter % 2 == 0) {
//     if (counter % 2 == 1) {
//     console.log(counter);
//   }
//   counter++;
// // }

// let counter = 2;
// while (true) {
//     console.log(counter);
//     if (counter ==7) {
//         break;
//     }
// counter ++;
// }

// * Do While

// do {
//     //codes
// } while (condition);

//* Example 1
// write 1 to 10
// let counter = 1;

// do {
//     console.log(counter);
// //     counter++;
// // } while (counter<=10);

// //Example 2     // total of odd numbers between 1 to 20

// // let counter = 1;
// // let total = 0;

// // do {
// //   if (counter%2== 1) {
// //     total += counter;
// //   }
// //   counter++;
// // } while (counter <= 20);
// // console.log("Total:", total);

// // * Break and continue

// //*Example 3 // Calculator

// for (let i = 1; i <= 10; i++) {
//   for (let j = 1; j <= 10; j++) {
//     //(x), (=) stringleri  birlestitmek icin (1x1=1) yapmak icin (+) kullanilir
//     console.log(i + "x" + j + "=" + i * j);
//   }
//   console.log("------------------------------------------");
// }

// //*Example 4 // Find prime numbers

//
// 15 = 2,3,4,5,6,7

// let a = Math.floor(7.9);
// console.log(a);

// let value = Number(prompt("Enter a number, please"));
// let result = true;

// for (let i = 2; i <= Math.floor(value / 2); i++) {
//   if (value % i == 0) {
//     //not prime number
//     result = false;
//     break;
//   }
// }
// if (result){
//     alert ( value + " is prime.");
// } else {
//     alert (value + " is not prime.");
// }

//*Example 5 // Calculate Factorial

// //5!= 5.4.3.2.1 = 120

// let value = Number(prompt("Enter a number, please"));
// let times = 1;

// for (let i = 1; i<= value; i++) {
//   times = times * i;
// }
// alert("Result :" + times);

//*Example 5 // Calculate Factorial

// 153 370 407 armstrong number

// let value = prompt("please enter a number");
// let total = 0;

// for (let i = 0; i < value.length; i++) {
//   let digit = value.charAt(i);
//   total += digit ** 3;
// }

// if (Number (value)==total) {
//     alert("It is an armstrong number :) ");
// } else {
//     alert("It is not an armstrong number :(");
// }

//? for of loop - for of döngüsü

// for (const element of arr) {
//     // uygulamak istediğimiz kod
//   }

//* Functions (Methods) Lesson 44

// function print () {
//   console.log("Husniye");
// }

// print();
// debugger;
// print();

// // Function Declaration
// //declaring a function without a parameter
// function functionName() {
//   // code goes here
// }
// functionName() // calling function by its name and with parentheses

//Function without a parameter and return
//Function can be declared without a parameter.

//*Example
// function without parameter,  a function which make a number square
// function square(){
//   let num =2
//   let sq = num*num
//   console.log(sq)
// }

// square() //4

// // function without parameter
// function addTwoNumbers() {
//   let numOne = 10
//   let numTwo = 20
//   let sum = numOne + numTwo

//   console.log(sum)
// }

// addTwoNumbers() //30

// console.log(addTwoNumbers())
//Function with a parameter
//In a function we can pass different data types(number, string, boolean, object, function) as a parameter.

//*Return
// let r = cube(2); //return
// // square(r); //64

// function square(n1) {
//   let s1 = n1 * n1;
//   // console.log(s1)
//   return s1; // 64  //result
// }
/*
    1.return den sonra yazilan kodlar erisilmez

// function cube (n) {
//   let s =n * n * n    //number
//   return s; // 8  //result
//   /*
//   1.return den sonra yazilan kodlar erisilmez
// 2. bir degeri fonksiyonu disina cikarmak icin kullanilir

//   */
// }

// let dd =  cube(2);

// function kA (s) {
//   let so =  s*s*s;
//   return so; // 8  //result
// }

//*Example 1 - find the number of word
let text = " I am learning the JS functions.";

//TODO - Version 1

// let letter = prompt("please, enter a letter");

// let result = find(letter); // call the function
// alert("Number of letters found:" + result);

// function find(letter) {
//   let total = 0;
//   for (let i = 0; i < text.length; i++) {
//     if (text.charAt(i).toLowerCase=== letter.toLowerCase) total++;{
//       total += 1;
//     }
//   }
//   return total;

//}

//TODO - Version 1 call more than once

// find("a");
// find("b");
// find("s");

// function  find (letter) {
//   let total = 0;
//   for (let i = 0; i < text.length; i++) {
//     if (text.charAt(i).toLowerCase()=== letter.toLowerCase()) {
//       total += 1;
//     }
//   }
//   // return total;
//   console.log("Number of letters found:" + total);
// }

//*Example 2 - find perfect number

/****
 6 / 28 /496

 6 =  1/2/3/6 12= 6*2
 ****/
// isPerfectNumber (6)
// function isPerfectNumber(number) {
//   let total = 0;
//   for (let i = 2; i <= number / 2; i++) {
//     if (number % i == 0) {
//       total += i;
//     }
//   }
//   total += 1 + number;
//   if (total == number * 2) {
//     console.log(number + " is a prime number");
//   } else {
//     console.log(number + " is not a prime number");
//   }
// }

//*Example 3 Decimal to Binary  Conversion

convertDecimalToBinary(25);

function convertDecimalToBinary(number) {
  let binary = "";
  while (true) {
    binary += (number % 2).toString();
    number = Math.floor(number / 2);
    if (number == 1) {
      // no more division
      binary += 1;
      break;
    }
  }
  let result = reverse(binary);
  console.log("Result:" + result);
}

function reverse(binary) {
  let reverseBinary = "";
  for (let i = binary.length - 1; i >= 0; i--) {
    reverseBinary += binary.charAt(i);
  }
  return reverseBinary;
}

//*Example 4 Binary to Decimal Conversion (2 to 10 )

let binary = "10110010101";

convertBinaryToDecimal(binary);

function convertBinaryToDecimal(binary) {
  let total = 0;
  let power = 0;

  for (let i = binary.length - 1; i >= 0; i--) {
    if (Number(binary.charAt(i)) != 0) {
      total += Number(binary.charAt(i)) * Math.pow(2, power);
    }
    power++;
  }
  console.log("Result :" + total);
}

//? function with one parameter
// function functionName(parm1) {
// }
// functionName(parm1) //during calling or invoking one argument needed

// function areaOfCircle(r) {
//   let area = Math.PI * r * r
//   return area
// }
// console.log(areaOfCircle(10))

// function square (number) {
//   return number * number
// }

// console.log(square(5))

//* Function with two parameters
// function with two parameters

// functionName(parm1, parm2)
// function sumTwoNumbers (numOne, numTwo) {
//   let sum = numOne + numTwo
//   console.log(sum)
// }
// sumTwoNumbers(10, 20)

// --------------
// function printFullName (firstName, lastName) {
//   return `${firstName} ${lastName}`
// }

// console.log(printFullName("Husniye", "Erparun"))

//* Function with many parameters
// // function with multiple parameters
// function functionName(parm1, parm2, parm3,...){
//   //code goes here
// }
//functionName(parm1,parm2,parm3,...) // during calling or invoking three arguments needed

//this function takes array as a parameter and sum up the numbers in the array

// function sumArrayValues (arr) {
//   let sum = 0;
//   for (let i=0; i<arr.length; i++) {
//     sum = sum + arr[i];
//   }
//   return sum;
// }
// const numbers = [1,2,3,4,5];
// // calling a function
// console.log (sumArrayValues(numbers));

// const areaOfCircle = (radius) => {
//   let area = Math.PI * radius * radius;
//   return area;
// }
// console.log(areaOfCircle(10))

//------------------

//* Function with unlimited number of parameters

// Let us access the arguments object

// function sumAllNums () {
//   console.log (arguments)
// }
// sumAllNums(1,2,3,4)

// function Declaration

// const sumAllNums = (...args) => {
//   let sum = 0 
//   for (const element of args) {
//     sum += element 
//   }
//   return sum
// }

// console.log(sumAllNums(1,2,3,4,5)) //10
// console.log(sumAllNums(10,20, 13,40,10)) //93

//*Anonymous Function
// Anonymous function or without name

// const anonymousFun = function() {
//   console.log(
//     'I am an anonymous function and my value is stored in anonymousFun'
//   )
// }

//* Function with default parameters -Default parametre ile fonksiyon kullanımı

// syntax - soz dizimi
// fonksiyon kullanimi

function functionName (param= value){
  //codes
}
// // call function
// functionName()
// functionName(arg)
//Example
function greetings (name = "Husniye") {
  let message = `${name}, welcome to 30 days of JS`
  return message
}
console.log(greetings())
console.log(greetings("Husniye"))
//-------------------------------------

function generateFullName(firstName = "Husniye ", lastName= "Erparun"){
  let space= ""
  let fullName= firstName + space + lastName
  return fullName
}
console.log(generateFullName())
console.log(generateFullName("Husniye", "Erparun"))

//-------------------------------------

function calculateAge(birthYear, currentYear=2024) {
  let age = currentYear - birthYear
  return age
}
console.log ("Age:", calculateAge(1819))

//-------------------------------------

const weightOfObject = (mass, gravity=9.81) => mass * gravity +" N"

console.log ("Weight of an object in Newton:", weightOfObject(100))
console.log ("Weight of an object in Newton:", weightOfObject(100, 1.62))
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

let value = prompt("please enter a number");
let total = 0;

for (let i = 0; i < value.length; i++) {
  let digit = value.charAt(i);
  total += digit ** 3;
}

if (Number (value)==total) {
    alert("It is an armstrong number :) ");
} else {
    alert("It is not an armstrong number :(");
}



//? for of loop - for of döngüsü


// for (const element of arr) {
//     // uygulamak istediğimiz kod
//   }


//!  06_day_loops PRACTICES
//? Level1
//* Q1- Declare a function fullName and it print out your full name.
//  A1- Declare a function
function fullName () {
  console.log("I am Husniye Erparun");
}
// call the function
fullName();

//* Q2- Declare a function fullName and now it takes firstName, lastName as a parameter and it returns your full - name.

function fullName (firstName, lastName) {
  // return firstName + "" + lastName
  return `${firstName} ${lastName}`
}

// const  myFullName = fullName("Husniye", "Erparun");
// console.log(myFullName);
console.log(fullName("Husniye", "Erparun")); // Husniye Erparun

//* Q3- Declare a function addNumbers and it takes two two parameters and it returns sum.

function addNumbers (num1, num2) {
  let sum = num1 * num2;
  return sum;
}

console.log(addNumbers(20,30)); //600

//* Q4- An area of a rectangle is calculated as follows: area = length x width. Write a function which calculates areaOfRectangle.
function areaOfRectangle (length, width) {
  let area = length * width;
    return area;
}

console.log(areaOfRectangle(20,40)); //800


//* Q5- A perimeter of a rectangle is calculated as follows: perimeter= 2x(length + width). Write a function which calculates perimeterOfRectangle.


function perimeterOfRectangle(length, width) {
  let perimeter = 2 * (length + width);
  return perimeter;
}

console.log(perimeterOfRectangle(20, 40)); //120



//* Q6- A volume of a rectangular prism is calculated as follows: volume = length x width x height. Write a function which calculates volumeOfRectPrism.

function volumeOfRectPrism (length, width, height) {
  let volume = length * width * height;
    return volume;
}

console.log(volumeOfRectPrism(20, 40, 30)); //24000


//* Q7- Area of a circle is calculated as follows: area = π x r x r. Write a function which calculates areaOfCircle

//* Q8- Circumference of a circle is calculated as follows: circumference = 2πr. Write a function which calculates circumOfCircle

//* Q9-Density of a substance is calculated as follows:density= mass/volume. Write a function which calculates density.

//* Q10-
//* Q11-
//* Q12-
//* Q13-
//* Q14-
//* Q15-




//? Level2

//? Level3

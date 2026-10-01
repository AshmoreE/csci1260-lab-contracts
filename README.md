# CSCI 1260 - Lab: Implementing C# Built-in Interfaces

## Student Information

**Name:** Ethan Ashmore  
**Course:** CSCI 1260 - UML and Object-Oriented Programming  
**Section:** 002

## Track Information

**Track:** Track A  
**World:** Shop - River City Supply
**Language:** C#

## How to Run

Open the project in Visual Studio and run the program using Ctrl + F5. The program will display the results for all four contracts in the console and create the `count-log.txt` file.

## README Question

Treating records 1 and 5 as equal makes sense if I only care about identifying the shelf location, since they both represent aisle DAIRY and slot 3. However, this could be a problem if I needed to keep separate inventory measurements taken at different times, because the values 21.50 and 18.75 would still be considered equal. If I wanted the measurements to make the records different, I would add `ValueOnHand` to the `Equals()` comparison and also include it in `GetHashCode()`.

## Unfinished Items

None.
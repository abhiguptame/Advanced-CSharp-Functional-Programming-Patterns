# Advanced C#: Functional Programming (FP) Patterns

### => Relies on expressions and declarations rather than code staments.
### => Functional syntax is condensed and different.

## Functional Terminology:
### => Functions First: A foundation of FP.
### => Pure Functions: Computes a value from input.
### => Higher Order Function: Accepts function parameters or return a function.
### => Functional Composition: Creates a new function from other function.
### => Avoid Shared States: Functions that share common data are coupled and fragile.
### => Immutability: All data should be unchangeable.
### => Transformations: Don't mutate it or transform it.
### => Avoid Side Effects: Don't have state changes that occur outside the function.
### => Map
### => Reduce
### => Select
### => Option
### => Bind
### => Flatten
### => Scan
### => Unit
### => Fold
### => Filter
### => Aggregate
### => Either


## What is a Function Side Effect?
### => Mutates global state
### => Mutates input arguments
### => Throws exception
### => Perform I/O operations (Solution: We should build our code to isolate I/O in special functions.)

## A Pure Function:
### => Given the same input, it will always return the same output.
### => Doesn not have any observable side efects.

## Benefit of Pure Functions:
### => Are cacheable
### => Are testable
### => Can run in parallel
### => Self-documenting

## Immutable Type:
### => Immutable types are not changeable after creation.

## Simple approach to make immutable type:
### => Make properties or fields readonly.
### => Set all properties in the constructors.

### => Immutability isn't about forbidding change, its about how to handle change.

## Good Design for an Immutable Type:
### => No hidden private fields
### => Provide access to member data with read-only property
### => Instance methods must be pure functions
### => Impure functions must be static methods or extracted into another type
### => Create methods that allow modification to the properties
### => Conside making a sealed class














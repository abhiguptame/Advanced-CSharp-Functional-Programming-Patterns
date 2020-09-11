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

## Favour expressions over statemnets:
### => Statements: Statements perform actions and will have side effects.
### => Expressions represent a value, oftern from a calculation.
### => An expression yields a value and can be used in places where a value is expected.
### => Expressions can consist of a literal value, a method invocation, an operator and its operands, or a simple name. Simple names can be the name of a variable, type member, method parameter, namespace or type.

## Composition Patterns:
### => Functional Composition
### => Currying
### => Pipelining

## Functional Composition:
### => Combining functions into a new function

## Currying:
### => A pattern for deconstruction functions with many arguments.

## Pipeline Pattern:
### => Provides a way to group function calls.


















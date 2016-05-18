# Introduction-to-async-programming
For internal development, a brief introduction to async programming

Useful definitions
==================

Something is asynchronous when you don’t have to stop and wait for it

Does not require a multithread environment. For example an IO operation.

Multithreading means multiple execution context in the application

Parallel computing means that multiple operations are carried out simultaneously.

Key takeaways
=============

Async/await

What it should returns?

Control flow

Some examples

async/await
===========

Highlights
-------

 - Syntaxt sugar for invoking and chaining Tasks.

Pros

 - Easy syntax
 - Allows update the UI thread

Cons

- More overhead than sync methods

What can be accomplished using async and await keywords
-------

1. Writing an asynchronous code with a synchronous code structure.

2. In UI applications, the UI will be responsive during the asynchronous operation and will not be grayed out.

3. Exception handling can be done just similar to a synchronous code.


What is and what is not
-------

###async###

- False: This method is asynchronous.

- True: In this method we’ll call asynchronous methods

###await###

- False: Program flow will be waiting until the method is completely executed.

- True: Calling this method will return immediately the control to the caller, when method end, the execution will continue from that point

What should it returns?
-------

Async methods can return the following types:

void
Task
Task<T>



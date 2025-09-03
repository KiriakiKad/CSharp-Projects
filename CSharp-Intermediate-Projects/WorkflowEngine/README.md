   WORKFLOW ENGINE EXAMPLE (C# PROJECT)
=============================================

This project demonstrates how to design a simple 
workflow engine in C# using interfaces, composition, 
and polymorphism.

The goal is to represent a workflow as a collection 
of activities, where each activity follows a common 
contract (`IActivity`). The workflow engine executes 
all activities in sequence, without knowing their 
specific implementation.

---------------------------------------------
FEATURES
---------------------------------------------
- Interface: IActivity
  * Defines the contract for all activities
  * Requires implementation of Execute()

- Concrete classes: UploadVideo & SendEmail
  * Provide specific logic for different activities
  * For this example, they just print to the console

- Workflow class
  * Holds a collection of activities
  * Provides Add() method to include new activities

- WorkflowEnginee class
  * Iterates through the workflow’s activities
  * Calls Execute() on each activity

- Extensibility
  * New activities can be added without modifying 
    the existing engine or workflow logic

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
var workflow = new Workflow();
workflow.Add(new UploadVideo());
workflow.Add(new SendEmail());

var engine = new WorkflowEnginee();
engine.Run(workflow);

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
Uploading video...
Sending email...

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- Interfaces: common contract for extensibility
- Polymorphism: different activities share the same interface
- Composition: workflow is built by combining activities
- Separation of concerns: the engine doesn’t care 
  about the specific activity details

---------------------------------------------
NOTE
---------------------------------------------
This project is for educational purposes only and does 
NOT actually upload videos or send real emails.

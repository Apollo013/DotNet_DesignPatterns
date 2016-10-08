# DotNet_DesignPatterns_CreationalPatterns

Demonstration of various creational design patterns

---

Developed with Visual Studio 2015 Community

---

###Techs
|Tech|
|----|
|C#|
|Visual Paradigm|

---
###Design Patterns

|Pattern|Description|UML Included|
|-------|-----------|------------|
|Builder Pattern| Straight forward builder pattern example | Yes |
|Factory Pattern| Demonstrates simple, abstract/concrete implementations and another that uses reflection to load all types for a particulr interface | Yes |
|Prototype Pattern| Straight forward prototype pattern example | Yes |
|Singleton Pattern| Demonstraes 4 ways to implement the single pattern including static initialization, double-checking, nested class & basic examples| No |
|Null Object Pattern| A consequence of the Factory Pattern | No |

---

###Builder Pattern 

####Definition
Separate the construction of a complex object from its representation so that the same construction process can create different representations.

This allows the client application will simply specify the parameters that should be used to create the complex object and the builder will take care of building the complex object. 

####Resources
|Title|Author|Website|
|-----|------|-------|
|[Builder Pattern](http://www.csharpstar.com/creational-design-patterns/)| | CSharpstar |
|[Builder](http://www.dofactory.com/net/builder-design-pattern)| | doFactory |


---

###Factory Pattern 

####Definition
Define an interface for creating an object, but let subclasses decide which class to instantiate.

####Resources
|Title|Author|Website|
|-----|------|-------|
|[Exploring the Factory Design Pattern](https://msdn.microsoft.com/en-us/library/ee817667.aspx)| | MSDN |
|[Design patterns and practices in .NET: the Factory Patterns](https://dotnetcodr.com/2015/09/29/design-patterns-and-practices-in-net-the-factory-patterns-concrete-static-abstract/)|Andras Nemes| dotnetcodr|
|[Factory Method](http://www.dofactory.com/net/factory-method-design-pattern)| | doFactory |

---

###Prototype Pattern 

####Definition
Specifies the kind of objects to create using a prototypical instance, and create new objects by copying this prototype

It is used to create a duplicate object or clone of the current object to enhance performance.

####Resources
|Title|Author|Website|
|-----|------|-------|
|[Prototype](http://www.dofactory.com/net/prototype-design-pattern)| | doFactory |
|[Prototype Pattern](http://www.csharpstar.com/creational-design-patterns/)|| CSharpStar|
|[Design patterns and practices in .NET: the Prototype pattern](https://dotnetcodr.com/2013/08/05/design-patterns-and-practices-in-net-the-prototype-pattern/)|Andras Nemes| dotnetcodr |

---

###Singleton Pattern 

####Definition
Ensure a class has only one instance and provide a global point of access to it.

####Resources
|Title|Author|Website|
|-----|------|-------|
|[Implementing Singleton in C#](https://msdn.microsoft.com/en-us/library/ff650316.aspx)| | MSDN |
|[Design patterns and practices in .NET: the Singleton pattern](https://dotnetcodr.com/2013/05/09/design-patterns-and-practices-in-net-the-singleton-pattern/)|Andras Nemes| dotnetcodr|

---

###More Resources
|Title|Author|Website|
|-----|------|-------|
|[.NET Design Patterns](http://www.dofactory.com/net/design-patterns)| | dofactory |
|[Architecture and patterns](https://dotnetcodr.com/architecture-and-patterns/)|Andras Nemes|dotnetcodr|
|[Creational Design Patterns](http://www.csharpstar.com/creational-design-patterns/)| | CShapster |
|[patterns & practices](https://msdn.microsoft.com/en-us/library/ff921345.aspx)||MSDN|
|[Design Patterns in Java Tutorial](https://www.tutorialspoint.com/design_pattern/index.htm)||TutorialsPoint|

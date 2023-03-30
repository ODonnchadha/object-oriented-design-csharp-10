## Object-oriented Design with C# 10 by Mel Grubb

- OVERVIEW:
  - Objects aren’t just an implementation mechanism, they’re every bit as important as artifacts of design. 
  - This course will teach you object oriented principles not merely as syntax, but as elements of your project’s design.
  - C# 10. Visual Studio 2022. Markdown Editor. NUnit 3.

- INTRODUCTION:
  - Object-oriented programming is not: Object-oriented design. Object-oriented language. GOTO still exists in C#.
    - OO design: Thinking in objects. Commitment to organization of responsibilities.
      - Classes are tools, used by other classes, with other responsibilities.
  - Mermaid: UML disgrams right in your documentation. Editable from within IDE.
      - FLowcharts:
          ```mermaid
               graph LR
               A[Starting Point] --> B
               A --> C
               B --> D
               C --> D[Welcome to Mermaid]
          ```
    - Class Diagrams:
        ```mermaid
            classDiagram
            class IValidateObject {
                <<interface>>
                Validate() IEnumerable~ValidationResult~
            }
            class Person {
                +Id: Guid, 
                +FirstName: string,
                #ProtectedProperty: string,
                %InternalProperty : string
                +Validate() IEnumerable~ValidationResult~
            }
            Person ..|> IValidateObject
         ```

    - Four Principles:
        - Abstraction: Information hiding.
        - Encapsulation: Data hiding.
        - Inheritrance: Object taxonomy.
        - Polymorphism: Object interchangeability.
    - SOLID Principles:
        - Single Responsibility Pinciple.
        - Open/Closed Principle.
        - Liskov Substitution Principle.
        - Inerface Segregation Principle.
        - Dependency Inversion Principle.
        - Other OO vocabulary:
            - Cohesion.
            - Coupling.
            - Orthogonality.
    - Coupling & Cohesion:
        - Dependency changes can force consumer changes.
        - Flexible versus brittle. e.g.: loggers.
        - Implementing a common interface.
    - Nouns, Verbs, Adjectives, & Entities.
        - "Parts of speech."
        - Nouns: Classes.
        - Verbs: Methods.
        - Adjectives: Interfaces. (Properties and methods.)

- FOUR PILLARS:
    - Abstraction:
        - Abstraction is basically just a model hiding its internal complexity and presenting a simplified interface to its consumers. 
        - Every deatil that is exposed results in a detail that someone might leverage. One more detail that becomes a promise/contract.
    - Encapsulation:
    - Inheritance:
    - Polymorphism:
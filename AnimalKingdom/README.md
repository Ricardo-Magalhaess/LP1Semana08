```mermaid
---
title: Uml of AnimalKingdom
---
    classDiagram
        Animal <|-- Bee
        Animal <|-- Bat
        Animal <|-- Dog
        Animal <|-- Cat
        ICanFly <|.. Bee
        ICanFly <|.. Bat
        IMammal <|.. Cat
        IMammal <|.. Dog
        IMammal <|.. Bat

    class Animal
        class Dog
        class Cat
        class Bat
        class Bee
        class IMammal
        <<interface>> IMammal
        class ICanFly
        <<interface>> ICanFly

```

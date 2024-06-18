using System;

namespace HelloWorld1;

public class Person {
    // Fields
    private String name;
    private int age;

    // Constructor
    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }

    // Getter for name
    public String getName() {
        return name;
    }

    // Setter for age
    public void setAge(int age) {
        this.age = age;
    }

    // Method
    public void introduce() {
        Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");
    }
}

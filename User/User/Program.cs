using System;

class User
{
    string log; 
    string firstname;
    string secondname;
    int age;

    readonly DateTime dateOfCreation;

    public User(string log, string firstname, string secondname, int age)
    {
        this.log = log;
        this.firstname = firstname;
        this.secondname = secondname;
        this.age = age;

        this.dateOfCreation = DateTime.Now;
    }

    public string getInfo() {
        return $"{log} {firstname} {secondname} {age}. Registered: {this.dateOfCreation.ToString()}";
    }
}
class Student {
    fullName: string;
    constructor(public firstName, public middleName, public lastName) {
        this.fullName = this.firstName + " " + this.middleName + " " + this.lastName;
    }
}

interface Person {
    firstName: string;
    lastName: string;
}

function greeter(person: Person){
    return "Hello, " + person.firstName + " " + person.lastName
}

var user = new Student("Jsfj", "M>", "Sharp")

document.body.innerHTML = greeter(user);
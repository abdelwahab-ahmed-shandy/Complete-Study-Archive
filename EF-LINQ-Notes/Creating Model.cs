// Now you will create a folder called models.

// Then you will create a customization inside this folder and say a class that represents a table or entity in the database :

// As an example, for example, inside the class it will be in the following form:

internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }
    }


// About something you want from the classes inside a folder model :
// But do not forget something important, we will not talk yet about how to connect one table to another, 
// whether it is 
// One To Many
// One To One
// Many To Many

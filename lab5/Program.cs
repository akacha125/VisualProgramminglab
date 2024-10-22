/*  lab Activity
/*using System;
class Program
{
    public class WorkItem
    {
      
        private static int currentID = 0; 

        public int ID { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; }
        public TimeSpan JobLength { get; set; } 

        public WorkItem()
        {
            ID = 0; 
            Title = "Default Title";
            Description = "Default Description.";
            JobLength = new TimeSpan();
        }
        public WorkItem(string title, string description, TimeSpan jobLength)
        {
            ID = GetNextID(); 
            Title = title;
            Description = description;
            JobLength = jobLength;
        }

        static WorkItem()
        {
            currentID = 0; 
        }

        protected int GetNextID()
        {
            return ++currentID; 
        }

        public void Update(string title, TimeSpan jobLength)
        {
            Title = title;
            JobLength = jobLength;
        }

        public override string ToString()
        {
            return $"WorkItem ID: {ID}, Title: {Title}";
        }
    }

    public class ChangeRequest : WorkItem
    {
      
        public int OriginalItemID { get; set; }

        public ChangeRequest(string title, string description, TimeSpan jobLength, int originalItemID)
            : base(title, description, jobLength) 
        {
            OriginalItemID = originalItemID;
        }

       
        public ChangeRequest() : base() 
        {
        }

        public override string ToString()
        {
            return $"ChangeRequest (derived from WorkItem): {base.ToString()}, Original Item ID: {OriginalItemID}";
        }
    }
    static void Main(string[] args)
    {

        ChangeRequest changeRequest = new ChangeRequest(
            "Change Base Class Design", "Add members to the class", new TimeSpan(4, 0, 0), 1);
        
        Console.WriteLine(changeRequest.ToString());

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}*/
/*  Exercise 1
using System;

public enum Department
{
   ComputerScience,
   ElectricalEngineering,
   MechanicalEngineering
}

public class Person
{
   private string name;

   public Person()
   {
       name = null;
   }

   public Person(string name)
   {
       this.name = name;
   }

   public string Name
   {
       get { return name; }
       set { name = value; }
   }
}

   public class Student : Person
   {
       private string regNo;
       private int age;
       private Department program;

       public Student() : base()
       {
           regNo = null;
           age = 0;
           program = Department.ComputerScience;
       }

       public Student(string name, string regNo, int age, Department program) : base(name)
       {
           this.regNo = regNo;
           this.age = age;
           this.program = program;
       }

       public string RegNo
       {
           get { return regNo; }
           set { regNo = value; }
       }

       public int Age
       {
           get { return age; }
           set { age = value; }
       }

       public Department Program
       {
           get { return program; }
           set { program = value; }
       }
}


public class Program
{
   public static void Main()
   {

       Student student = new Student("Muhammad Muzamil", "233514", 21, Department.ComputerScience);

       Console.WriteLine("Student Name: " + student.Name);
       Console.WriteLine("Student Registration Number: " + student.RegNo);
       Console.WriteLine("Student Age: " + student.Age);
       Console.WriteLine("Student Program: " + student.Program);
   }
}
*/
/*   Exercise 2
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public enum Department
    {
        ComputerScience,
        Mathematics,
        Physics,
        Chemistry,
        Biology
    }

    public class Person
    {
        public string Name { get; set; }

  
        public Person()
        {
            Name = null;
        }

  
        public Person(string name)
        {
            Name = name;
        }
    }

    public class Student : Person
    {
        public string RegNo { get; set; }
        public int Age { get; set; }
        public Department Program { get; set; }
        public Student() : base()
        {
            RegNo = null;
            Age = 0;
            Program = default(Department);
        }

        public Student(string name, string regNo, int age, Department program) : base(name)
        {
            RegNo = regNo;
            Age = age;
            Program = program;
        }
    }

    public enum CustomerType
    {
        Corporate,
        Retail
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Customer()
        {
        }

        public Customer(int customerId, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string email, string password)
        {
            CustomerId = customerId;
            LastName = lastName;
            FirstName = firstName;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            Phone = phone;
            Email = email;
            Password = password;
        }
    }

    public class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string CreditCardType { get; set; }
        public string CreditCardNo { get; set; }
        public string BillingAccountNo { get; set; }

        public CorporateCustomer() : base()
        {
        }

        public CorporateCustomer(int customerId, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string email, string password, string companyName, string creditCardType, string creditCardNo, string billingAccountNo)
            : base(customerId, lastName, firstName, street, city, state, zipCode, phone, email, password)
        {
            CompanyName = companyName;
            CreditCardType = creditCardType;
            CreditCardNo = creditCardNo;
            BillingAccountNo = billingAccountNo;
        }
    }

    public class RetailCustomer : Customer
    {
        public int FrequentFlyerPts { get; set; }

        public RetailCustomer() : base()
        {
        }

        public RetailCustomer(int customerId, string lastName, string firstName, string street, string city, string state, string zipCode, string phone, string email, string password, int frequentFlyerPts)
            : base(customerId, lastName, firstName, street, city, state, zipCode, phone, email, password)
        {
            FrequentFlyerPts = frequentFlyerPts;
        }
    }

    public class Seat
    {
        public int RowNo { get; set; }
        public int SeatNo { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

        public Seat(int rowNo, int seatNo, decimal price, string status)
        {
            RowNo = rowNo;
            SeatNo = seatNo;
            Price = price;
            Status = status;
        }
    }

    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime Date { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public int SeatingCapacity { get; set; }

        public Flight(int flightId, DateTime date, string origin, string destination, TimeSpan departureTime, TimeSpan arrivalTime, int seatingCapacity)
        {
            FlightId = flightId;
            Date = date;
            Origin = origin;
            Destination = destination;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            SeatingCapacity = seatingCapacity;
        }
    }

    public class Reservation
    {
        public int ReservationNo { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public Flight Flight { get; set; }
        public Seat Seat { get; set; }

        public Reservation(int reservationNo, DateTime date, Customer customer, Flight flight, Seat seat)
        {
            ReservationNo = reservationNo;
            Date = date;
            Customer = customer;
            Flight = flight;
            Seat = seat;
        }
    }

    public static void Main(string[] args)
    {
       
        Student student1 = new Student();
        Console.WriteLine($"Student1 - Name:Ahsan {student1.Name}, RegNo:233516  {student1.RegNo}, Age:19 {student1.Age}, Program:  cs{student1.Program}");

     
        Student student2 = new Student("Muzamil", "2023-CS-001", 21, Department.ComputerScience);
        Console.WriteLine($"Student2 - Name: {student2.Name}, RegNo: 233514{student2.RegNo}, Age:21 {student2.Age}, Program: cs{student2.Program}");

        // Demonstrate Reservation System
        Customer customer = new RetailCustomer(1, "Doe", "John", "123 Main St", "Anytown", "Anystate", "12345", "555-1234", "john@example.com", "password123", 10000);
        Flight flight = new Flight(101, DateTime.Now, "LAX", "JFK", new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0), 180);
        Seat seat = new Seat(1, 1, 299.99m, "Reserved");
        Reservation reservation = new Reservation(1, DateTime.Now, customer, flight, seat);

        Console.WriteLine($"Reservation No: {reservation.ReservationNo}");
        Console.WriteLine($"Customer: {reservation.Customer.FirstName} {reservation.Customer.LastName}");
        Console.WriteLine($"Flight: {reservation.Flight.Origin} to {reservation.Flight.Destination}");
        Console.WriteLine($"Seat: Row {reservation.Seat.RowNo}, Seat {reservation.Seat.SeatNo}");
        Console.WriteLine($"Price: ${reservation.Seat.Price}");
    }
}*/
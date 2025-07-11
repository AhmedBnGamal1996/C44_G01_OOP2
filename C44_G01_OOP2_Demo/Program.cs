using C44_G01_OOP2_Demo.Class;
using C44_G01_OOP2_Demo.Encapsulation;
using C44_G01_OOP2_Demo.Encapsulation.Indexer;
using C44_G01_OOP2_Demo.Inhiretance;
using Common;

namespace C44_G01_OOP2_Demo;
internal class Program
{
    static void Main(string[] args)
    {

        #region Video 1 Enacpsulation 

        #region  Enacpsulation [ Employee ex ] , Properties [Automatic Prop , Full Prop]
        //Employee employee;
        //// Varible [ Value Type ]

        //employee = new Employee(1, "Mariam", 1000);

        //Console.WriteLine(employee);
        //employee.Id = -1000; // Validation is not 
        //Console.WriteLine(employee.Id);

        //Employee emp1 = new Employee(1, "Mariam", 1000);

        //emp1.SetName("Mariam Shindy");

        //Console.WriteLine(emp1.GetName());
        //Console.WriteLine(emp1);

        //Employee employee = new Employee(1, "Mariam", 1000);

        //// Console.WriteLine(employee.empName);
        //employee.Salary = 2000;
        //Console.WriteLine(employee.Salary);



        #endregion


        #endregion



        #region  Video 2 Indexer - PhoneBook

        //PhoneBook phoneBook = new PhoneBook(3);
        //phoneBook.AddNewPerson(0,"Ali", 123);
        //phoneBook.AddNewPerson(1,"Mona", 456);
        //phoneBook.AddNewPerson(2,"Samy", 789);


        //phoneBook.SetNumber("Mona", 999);


        //phoneBook["Mona"] = 999;
        //Console.WriteLine(phoneBook["Mona"]);

        //for (int i = 0; i < phoneBook.Size; i++)
        //{
        //    Console.WriteLine(phoneBook[i]);
        //}

        //foreach (var person in phoneBook)
        //{
        //    Console.WriteLine(person);
        //}









        #endregion




        #region Video 3 Class & Constructor Chaining

        // Car c1;
        // Create Reference [ Spacial Variable ] 
        // CLR will allocate 4 bytes in stack for the reference 
        // CLR will allocate 0 bytes in Heap

        // c1 = new(1, "BMW", "Red");


        // c1 ==> Can refer to an instance from Car or any class that inhiret 

        // Compiler will generate the parameterless constructor 
        // Parameterless Ctor in class ==> do nothing

        // 1] Allocate required bytes in heap 12 bytes
        // 2] initailize with the default value 
        // 3] Calll user defined Ctor if exist 
        // 4] Assign instance to the referenced in the stack 




        #region Class & Constructor Chaining [ Car ex ]

        //Car c1 = new Car(1, "Toyota", "Black");
        //Console.WriteLine(c1);

        //Car c2 = new Car(2, "BMW");
        //Console.WriteLine(c2);

        //Car c3 = new Car(3);
        //Console.WriteLine(c3);

        #endregion












        #endregion


        #region  Video 5 Inhiretance [ Parent , Child Ex ] 

        //Parent p1;
        // Create Reference [4byte in stack ] 
        //p1 = new Parent(10, 20);
        //Console.WriteLine(p1);
        //Console.WriteLine(p1.ToString());
        //Console.WriteLine( p1.Product());
        //p1.MyFun();


        //Child c1 = new Child(1, 2, 3);

        //Console.WriteLine(c1.Product());

        //Console.WriteLine(c1);


        //Child c1 = new Child(1, 2, 3);
        //Console.WriteLine(c1);

        //Console.WriteLine(c1.Product());

        //Console.WriteLine(c1);

        //c1.MyFun();





        #endregion








        #region Video 6 Access Modifiers [ Protected ]

        //TypeA typeA = new TypeA();

        //typeA.A = 1;    // Private InValid
        //typeA.B = 2;    // Internal InValid 
        //typeA.C = 3;    // Public  Valid
        //typeA.x = 4;    // Private  InValid
        //typeA.y = 5;    // Private   InValid
        //typeA.z = 6;    // internal   InValid




        //TypeD typeD = new TypeD();
        //typeD.C = 10;       // Public 

        // TypeD.y = 20;   // Private - Invalid 

        // TypeD.z = 30;       // Private - Invalid 

       





        #endregion

    }

}
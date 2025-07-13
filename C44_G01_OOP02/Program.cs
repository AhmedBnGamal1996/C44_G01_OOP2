using System.Diagnostics;

namespace C44_G01_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region    Part 1

            // Try all what we have learned in the lecture

            /*     اتعلمت اول حاجه و هى Encapsultion 
    و ان من خلاله قدرت احل 3 مشاكل مهمين و هما التغيير في class كان لازم اروح اغير في كل مكان و مشكلة Validation و ان اقدر  اخلي properity  Read Only 
    بعد كدا اتعملت ان عندى انواع Properity و هما 
    Automatic - Full - Indexer 
    و ان كل واحد منهم له طريقة مختصره اقدر اكتبه بيها و كمان اتعلمت اعملت Indexer Overloading و ان اخلي بالى من الترتيب اى بيتنفذ قبل اى 

    بعد كدا خدنا class و انه بقدر اكتب جواها attribute - events - properties - function 
    و كمان اتعلمت الفرق بين class - Struct و الـ processing اللى بتحصل في الميموررى وقت create و طريقة تخزينهم في Heap - Stack و اللي بيحصل وقت ما باخد instance و بعدها خدنا مفهوم مهم و هى inheritnace 
    و انه اكثر من نوع منه Single - Hierarchical - MultiLevel 
    و بعدها خدنا Access Modifer اللى بتكون جوا Class و struct 
    و اى اللي بيحصل مثلا Protected - internal - private و باقي access 
    فى حالة انى خدت child و اتعاملت سواء علي مستوى نفس البروجيت او بروجيكت واحد reference
         */





            #endregion






            #region     Part 2 

            // Design and implement a Class for the employees in a company:
            // Employee is identified by an ID, Name, security level, salary, hire date and Gender.


            // Create an array of Employees with size three a DBA, Guest and the third one is security officer
            // who have full permissions. (Employee [] EmpArr;)

            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee (1,"Ahmed" , SecurityPrivileges.DBA , 3000 , Gender.Male , 08,12,2002);
            EmpArr[1]  = new Employee(2, "Ali", SecurityPrivileges.guest, 5000, Gender.Male, 18,02,2021);
            EmpArr[2]  = new Employee(3, "Mohamed", SecurityPrivileges.SecurityOfficer, 1000, Gender.Male, 10,10,2022);

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i]);
            }








            // Sort the employees based on their hire date then Print the sorted array.
            // While sorting(how many times Boxing and Unboxing process has occurred)











            #endregion




        }
    }
}
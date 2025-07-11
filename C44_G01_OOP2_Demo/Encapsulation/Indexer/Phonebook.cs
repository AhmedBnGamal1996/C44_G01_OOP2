
using System.Collections;

namespace C44_G01_OOP2_Demo.Encapsulation.Indexer
{
    internal struct PhoneBook 

    {
        #region Attributes

        //private string?[] names;
        //private int?[] numbers;
        //private int size;
        //public int Size
        //{
        //    get { return size; }
        //    set { Size = size; }
        //}

        #endregion

        #region Cosntructors

        //public PhoneBook(int size)
        //{
        //    this.size = size;
        //     this.names = new string?[size];
        //    this.numbers = new int?[size];
        //}

        #endregion



        #region Methods

        //public void AddNewPerson(int position , string? name , int? number)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        if (position >= 0 && position < size)
        //        {
        //            names[position] = name;
        //            numbers[position] = number;
        //        }
        //    }
        //}




        //public int? GetNumber (string? name)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (names[i] == name)
        //            {
        //                return numbers[i];
        //            }
        //        }
        //    }
        //    return -1;
        //}




        //public void SetNumber(string? name, int? number)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (names[i] == name)
        //            {
        //                numbers[i] = number;
        //                // break;
        //                return;
        //            }
        //        }
        //    }
        //}



        #endregion


        #region Indexer

       
        
        //public int? this[string? name]
        //{
        //    get 
        //    {
        //        if (names is not null && numbers is not null)
        //        {
        //            for (int i = 0; i < names.Length; i++)
        //            {
        //                if (names[i] == name)
        //                {
        //                    return numbers[i];
        //                }
        //            }
        //        }
        //        return -1;



        //    }

        //    set 
        //    {
        //        if (names is not null && numbers is not null)
        //        {
        //            for (int i = 0; i < names.Length; i++)
        //            {
        //                if (names[i] == name)
        //                {
        //                    numbers[i] = value;
        //                    // break;
        //                    return;
        //                }
        //            }
        //        }
        //    }

        //}




        // Indexer Overloading

        //public string? this[int index]
        //{
        //    get {  return $"Index {index} , Name : {names[index]} , Number : {numbers[index]}"; }


        //}



        #endregion












    }
}

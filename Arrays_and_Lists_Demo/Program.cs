using System.Collections.Generic;
using Arrays_and_Lists_Demo;

//declaring Array  //initializing it with values
int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var myList = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };


//myArray[0] = 15;
//myList[0] = 365;
//Console.WriteLine(myArray[0]);
//Console.WriteLine(myList[0]);

//myArray[myArray.Length - 1] = 9;

//foreach (var item in myArray)
//{
//    Console.WriteLine(item);
//}

//for(int i = 0; i < myArray.Length; i++)
//{
//    Console.WriteLine(myArray[i]);
//}







#region ARRAYS
//1st way of declaring and initializing an integer array
//int[] array = new int[3];

//array[0] = 10;
//array[1] = 20;
//array[2] = 30;



//string[] myStrArray = new string[3];
//myStrArray[0] = "abc";
//myStrArray[1] = "def";
//myStrArray[2] = "ghi";






//2nd way of declaring and initializing an integer array
//int[] array2 = new int[3] { 100, 200, 300 };
//string[] myStr2Array = new string[3] { "a", "b", "c" };








////3rd way of declaring and initializing an integer array
//int[] array3 = new int[] { 1000, 2000, 3000, 4000 };

//Console.WriteLine(array3.Length);









////4th way of declaring and initializing an integer array
//var array4 = new int[] { 10_000, 20_000, 30_000 };


//foreach (var item in array4)
//{
//    Console.WriteLine(item);
//}





////5th way of declaring and initializing an integer array
//int[] array5 = { -1, -2, -3 };




////foreach (var num in array)
////{
////    Console.WriteLine(num);
////}

//var answer = Methods.CreateRandomArrayOfSize10();

//Array.Sort(answer);

//foreach (var item in answer)
//{
//    Console.WriteLine(item);
//}

////will print out same things as above
//for (int i = 0; i < answer.Length; i++)
//{
//    Console.WriteLine(answer[i]);
//}




////WE NEED TO KNOW:
////how to declare and
////initialize an array

////string array example
//string[] myOtherStrArray = { "nbd", "lol", "jk" };

//Array.Sort(myOtherStrArray);

//foreach (var str in myOtherStrArray)
//{
//    Console.WriteLine(str);
//}

//string firstName = "John";

////print out third letter
//Console.WriteLine(firstName[2]);

////print out last letter
//Console.WriteLine(firstName[firstName.Length - 1]);

#endregion

//#region LISTS

//explicit
//List<int> myList = new List<int>() { 23, 28, 42};

////implicit (inferred)
//var mySecondList = new List<int>();




//myList.Add(43);

//foreach (var item in myList)
//{
//    Console.WriteLine(item);
//}



//myThirdList.Add("item 4");
//myThirdList.Add("item 5");
//myThirdList.Add("item 6");
//myThirdList.Add("item 7");

//foreach (var item in myThirdList)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();
//Console.WriteLine();


////declaring and initializing a list of strings
//var myThirdList = new List<string>() { "a", "item 1", "item 2", "item 3", "90" };

//myThirdList.RemoveAll(x => x.StartsWith('a'));

//foreach (var item in myThirdList)
//{
//    Console.WriteLine(item);
//}




int[] example = new();















//for (int i = 0; i < myThirdList.Count; i++)
//{
//    if (myThirdList[i].StartsWith('a'))
//    {
//        myThirdList.RemoveAt(i);
//    }
//    else
//    {
//        Console.WriteLine(myThirdList[i]);
//    }

//}



//#endregion




//var answer = Methods.CreateRandomArrayOfSize10();
//foreach (var number in answer)
//{
//    Console.WriteLine(number);
//}

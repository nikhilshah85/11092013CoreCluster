
using FileIO_demo;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;

Console.WriteLine("Welcome to File System");

#region Demo 1 - Create and write to file
//FileStream myFile = new FileStream("introduction.txt", FileMode.Create, FileAccess.Write);

//StreamWriter pen = new StreamWriter(myFile);

//pen.WriteLine("Hello and Welcome, my name is Nikhil");
//pen.WriteLine("I am from Mumbai");
//pen.WriteLine("I am into the field of IT");
//pen.WriteLine("Thank you for listening and reading");

//pen.Close();
//myFile.Close();
#endregion

#region Demo 2 - Create and Write to file - dynamic nameing
//Console.WriteLine("Please enter your name");
//string guestName = Console.ReadLine();
//FileStream myFile = new FileStream(guestName + ".txt", FileMode.Create, FileAccess.Write);
//StreamWriter pen = new StreamWriter(myFile);
//string content = Console.ReadLine();

//while (content != "Bye")
//{
//    Console.WriteLine("Say Something");
//     content = Console.ReadLine();

//    pen.WriteLine(content);
//}

//pen.Close();
//myFile.Close();
#endregion

#region Demo 3 - Read from file

//FileStream myFile = new FileStream("introduction.txt", FileMode.Open, FileAccess.Read);

//StreamReader readFile = new StreamReader(myFile);

//Console.WriteLine(readFile.ReadToEnd());

//readFile.Close();
//myFile.Close();
#endregion


#region Demo 4 - XML Serialization with FileIO
Employee emp = new Employee() { EmpNo = 101, EmpName = "Kriti", EmpDesigantion = "HR", EmpIsPermenant = true, EmpSalary = 12000 };
FileStream myFile = new FileStream("empObj.xml", FileMode.Create, FileAccess.Write);
XmlSerializer empSerializer = new XmlSerializer(typeof(Employee));

empSerializer.Serialize(myFile,emp);

myFile.Close();

#endregion













using System;

namespace BoxApp{
class Box{
public double length;
public double breadth;
public double height;

public Box(){
Console.WriteLine("Constructor");
}

public void length(double l){
len=l;
}}

class BoxTest{
static void Main(string[] args){
Box B1=new Box;
Box B2=new Box;
double volume=0.0;

Box1.height=5.0;
Box1.length=6.0;
Box1.breadth=7.0;

Box2.height=6.0;
Box2.length=7.0;
Box2.breadth=8.0;
Box2.length(3.0);

volume=Box1.height*Box1.length*Box1.breadth;
Console.WriteLine("volume of Box1:{0}",volume);
volume=Box2.height*Box2.length*Box2.breadth;
Console.WriteLine("volume of Box2:{0}",volume);
Console.WriteLine("len:{0}",len);
}}}


===============================================================

using System;
using System.Text.RegularExpressions;

namespace RegExApplication {
class Program {
static void Main(string[] args) {
string input = "Hello   World   ";
string pattern = "\\s+";
string replacement = " ";
         
Regex rgx = new Regex(pattern);
string result = rgx.Replace(input, replacement);

Console.WriteLine("Original String: {0}", input);
Console.WriteLine("Replacement String: {0}", result);    
Console.ReadKey();
}}}


=========================================================

using System;

namespace ErrorHandlingApplication {
class DivNumbers {
int result;
      
DivNumbers() {
result = 0;
}
public void division(int num1, int num2) {
try {
result = num1 / num2;
}
catch (DivideByZeroException e) {
Console.WriteLine("Exception caught: {0}", e);
} 
finally {
Console.WriteLine("Result: {0}", result);
}}
static void Main(string[] args) {
DivNumbers d = new DivNumbers();
d.division(25, 0);
Console.ReadKey();
}}}

=======================================================

using System;
using System.IO;

namespace FileIOApplication {
class Program {
      
static void Main(string[] args) {
FileStream F = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
         
for (int i = 1; i <= 20; i++) {
F.WriteByte((byte)i);
}
F.Position = 0;
for (int i = 0; i <= 20; i++) {
Console.Write(F.ReadByte() + " ");
}
F.Close();
Console.ReadKey();
}}}

=======================================================

using System;

public class MyClass {
   [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
   
   static void OldMethod() {
      Console.WriteLine("It is the old method");
   }
   static void NewMethod() {
      Console.WriteLine("It is the new method"); 
   }
   public static void Main() {
      OldMethod();
   }
}

*********************
*********************

using System;

public class MyClass {
   [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
   
   static void OldMethod() {
      Console.WriteLine("It is the old method");
   }
   static void NewMethod() {
      Console.WriteLine("It is the new method"); 
   }
   public static void Main() {
      NewMethod();
   }
}

=======================================================

using System;
namespace tutorialspoint {
class Student {
private string code = "N.A";
private string name = "not known";
private int age = 0;
     
public string Code {
get {
return code;
}
set {
code = value;
}}
     
public string Name {
get {
return name;
}
set {
name = value;
}}      
public int Age {
get {
return age;
}
set {
age = value;
}}
public override string ToString() {
return "Code = " + Code +", Name = " + Name + ", Age = " + Age;
}}
   
class ExampleDemo {
public static void Main() {
     
Student s = new Student();
        
s.Code = "001";
s.Name = "Zara";
s.Age = 9;
Console.WriteLine("Student Info: {0}", s);
        
s.Age += 1;
Console.WriteLine("Student Info: {0}", s);
Console.ReadKey();
}}}

========================================================

using System;

namespace IndexerApplication {
   
class IndexedNames {
private string[] namelist = new string[size];
static public int size = 10;
      
public IndexedNames() {
for (int i = 0; i < size; i++)
namelist[i] = "N. A.";
}
     
public string this[int index] {
   
get {
string tmp;
         
if( index >= 0 && index <= size-1 ) {
tmp = namelist[index];
} else {
tmp = "";
}
           
return ( tmp );
}
set {
if( index >= 0 && index <= size-1 ) {
namelist[index] = value;
}}}
      
static void Main(string[] args) {
IndexedNames names = new IndexedNames();
names[0] = "Zara";
names[1] = "Riz";
names[2] = "Nuha";
names[3] = "Asif";
names[4] = "Davinder";
names[5] = "Sunil";
names[6] = "Rubic";
         
for ( int i = 0; i < IndexedNames.size; i++ ) {
Console.WriteLine(names[i]);
}
Console.ReadKey();
}}}

=======================================================

using System;
using System.Collections;

namespace CollectionApplication {
   
class Program {
    
static void Main(string[] args) {
ArrayList al = new ArrayList();
         
Console.WriteLine("Adding some numbers:");
al.Add(45);
al.Add(78);
a1.Add(33);
al.Add(56);
al.Add(12);
al.Add(23);
al.Add(9);
         
Console.WriteLine("Capacity: {0} ", al.Capacity);
Console.WriteLine("Count: {0}", al.Count);
         
Console.Write("Content: ");
foreach (int i in al) {
Console.Write(i + " ");
}
         
Console.WriteLine();
Console.Write("Sorted Content: ");
al.Sort();
foreach (int i in al) {
Console.Write(i + " ");
}
Console.WriteLine();
Console.ReadKey();
}}}

=======================================================

using System;
using System.Collections;

namespace CollectionsApplication{

class Program{
static void Main(string[] args){
Hashtable ht = new Hashtable();

ht.Add("1","a");
ht.Add("2","b");
ht.Add("3","c");
ht.Add("4","d");
ht.Add("5","e");

if (ht.ContainsValue("f")){
Console.WriteLine("it Have");
}else{
ht.Add("6","f");
}
ICollection key=ht.Keys;

foreach(strings k in key){
Console.WriteLine(k+": "+ht[k]);
}}}}

=======================================================


using System;
class MainClass{
private string[] name=new string[n];
static public int n=10;
public MainClass(){
for(int i=0;i<n;i++){
name[i]="Null";
}}
public string this[int index]{
get{
string t;
if(index >= 0 && index <= n-1){
t=name[index];
}else{
t="";
}
return(t);
}
set{
if(index>=0 && index<=n-1){
name[index]=value;
}}}
static void Main(string[] args){
MainClass a=new MainClass();
a[0]="A";
a[1]="B";
a[2]="C";
a[3]="D";
a[4]="E";
for(int i=0;i<MainClass.n;i++){
Console.WriteLine(a[i]);
}
Console.ReadKey();
}}

 using System;
 class mxcalc{
static void Main(string[]args){
Console.WriteLine("Enter total sum:");
var dolar=double.Parse(Console.ReadLine());
Console.WriteLine("Enter %:");
var psent=int.Parse(Console.ReadLine());
Console.WriteLine("Enter period:");
var time=int.Parse(Console.ReadLine());
double total=dolar*(1+(time*psent/100*psent));//za prosta lihva
double total1=dolar*(1+(psent/100));//za slojna lihva
double sloj=Math.Pow(total1,time);
// grafic prosta lihva
double mounth=total/time;
double m1=Math.Round(mounth,2);
double res=m1*time-1;
double last=m1-res;
// grafic slojna lihva
double mounth1=sloj/time;
double m2=Math.Round(mounth1,2);
double res1=m2*time-1;
double last1=m2-res1;
//prosta lihva
Console.WriteLine("Suma za izplashtane pri prosta lihva:"+total);
//za slojna lihva
Console.WriteLine("Suma za izplashtane pri slojna lihva:"+sloj);
}     
}
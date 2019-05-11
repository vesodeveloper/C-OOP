using System;
class Summary
{
public   int Power;
public int pasagers;
public double weight;
}
class Car : Summary
{

}
class Bus : Summary
{

}
class Van : Summary
{

}
class Motor : Summary
{

}
class Vehiles : Car,Bus,Van,Motor
{

}
class Autoparks : Vehiles
{

}
class PublicAutopark : Vehiles, Vehiles.pasagers
{

}
class LogisticAutopark : Vehiles, Vehiles.weight
{

} class Program{
public static void Main(string[] args)
{ int broi=0;
 Console.WriteLine("Enter maximum Autoparks:");
     var num=int.Parse(Console.ReadLine());
     Autoparks auto[]= new Autoparks[num];
     Console.WriteLine("Enter type of Vehile:");
      var type=Console.ReadLine();
     for (int i=0; i<=num; i++) {broi++;
       if (type=="Car") {
         foreach ( object cr in Car) {
           Car c1 = new Car;
           Console.WriteLine("Enter  Power:");
         c1.Power=int.Parse(Console.ReadLine();
         Console.WriteLine("Enter Pasagers: ");
         c1.pasagers=int.Parse(Console.ReadLine());
         Console.WriteLine("Enter weight:");
         c1.weight=double.Parse(Console.ReadLine());

         }
         else if (type=="Bus") {
           foreach ( object bs in Bus) {
             Bus bs = new Bus;
             Console.WriteLine("Enter  Power:");
           bs.Power=int.Parse(Console.ReadLine();
           Console.WriteLine("Enter Pasagers: ");
           bs.pasagers=int.Parse(Console.ReadLine());
           Console.WriteLine("Enter weight:");
           bs.weight=double.Parse(Console.ReadLine());
           }
         }
         else if (type=="Van") {
           foreach ( object vn in Van) {
          Van  vn = new Van;
             Console.WriteLine("Enter  Power:");
           vn.Power=int.Parse(Console.ReadLine();
           Console.WriteLine("Enter Pasagers: ");
           vn.pasagers=int.Parse(Console.ReadLine());
           Console.WriteLine("Enter weight:");
           vn.weight=double.Parse(Console.ReadLine());
           }
         }
         else  (type=="Motor") {
           foreach ( object mt in Motor) {
          Motor mt = new Motor;
             Console.WriteLine("Enter  Power:");
           mt.Power=int.Parse(Console.ReadLine();
           Console.WriteLine("Enter Pasagers: ");
           mt.pasagers=int.Parse(Console.ReadLine());
           Console.WriteLine("Enter weight:");
           mt.weight=double.Parse(Console.ReadLine());
           }
         }
     }
   } Console.WriteLine("Broqt e:"+broi);
   PublicAutopark  p1= new PublicAutopark;
   Console.WriteLine("Pasagers are:");
   foreach ( pub in Vehiles) {
     Console.WriteLine(Vehiles.pasagers);
   }
   LogisticAutopark lp= new LogisticAutopark;
   foreach ( wei in Vehiles) {
     Console.WriteLine(Vehiles.weight);
   }

}}

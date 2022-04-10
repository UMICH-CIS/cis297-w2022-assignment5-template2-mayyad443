using System;
namespace exit_application{
public class GUICalculator
{
  
public static void Main(string[] args)
{

Console.WriteLine("Press 1 to remove blank spaces in String");
Console.WriteLine("Press 2 to reverse string");
Console.WriteLine("Press 3 to find remainder and quotient of a number");
Console.WriteLine("Press 4 to find log of a number base 10");
Console.WriteLine("Press 5 to find log of a number");
Console.WriteLine("Press 6 to find minimum and maximum of two nos.");
Console.WriteLine("Press 7 to find power of number");
Console.WriteLine("Press 8 to find the roots of quadratic equation");
Console.WriteLine("Press 9 to find root of given number");
Console.WriteLine("Press 10 to exit");
Console.WriteLine("Enter your choice = ");
int choice=Convert.ToInt32(Console.ReadLine());
  
switch(choice){
case 1:Console.WriteLine("Enter a String: ");
string text=Console.ReadLine();
Console.WriteLine(text.Replace(" ",string.Empty));
break;
case 2: Console.WriteLine("Enter a String: ");
string text1=Console.ReadLine();
string res="";
for(int i=text1.Length-1;i>=0;i--){
res+=text1[i];
}
Console.WriteLine(res);
break;
case 3: int quotient,remainder;
int dividend=15;
int divisor=2;
quotient=dividend/divisor;
Console.WriteLine("Quotient= "+quotient+"Remainder= "+Math.DivRem(dividend,divisor,out remainder));
break;
case 4: int num=43;
Console.WriteLine(Math.Log10(num));
break;
case 5: int num1=56;
int baseLog=5;
Console.WriteLine(Math.Log(num1,baseLog));
break;
case 6: int num2=34;
int num3=187;
Console.WriteLine("Minimum= "+Math.Min(num2,num3));
Console.WriteLine("Maximum= "+Math.Max(num2,num3));
break;
case 7: int num4=24;
int power=3;
Console.WriteLine(Math.Pow(num4,power));
break;
case 8: //Console.WriteLine("a is the coeff of x^2, b is the coeff of x, c is the constant term");
//eqn. is x^2+2x+1
int a=1;
int b=2;
int c=1;
double d, x1,x2;
d=b*b-4*a*c;
if(d==0)
{
Console.Write("Both roots are equal.\n");
x1=-b/(2.0*a);
x2=x1;
Console.Write("First Root Root1= {0}\n",x1);
Console.Write("Second Root Root2= {0}\n",x2);
}
else if(d>0)
   {
   Console.Write("Both roots are real and diff-2\n");
  
   x1=(-b+Math.Sqrt(d))/(2*a);
   x2=(-b-Math.Sqrt(d))/(2*a);
  
   Console.Write("First Root Root1= {0}\n",x1);
   Console.Write("Second Root root2= {0}\n",x2);
   }
   else
   Console.Write("Root are imeainary;\nNo Solution. \n\n");
   break;
case 9: int num5=25;
Console.WriteLine(Math.Sqrt(num5));
break;
case 10: Environment.Exit(0);
break;
default: Console.WriteLine("Invalid Input");
break;
}
  
}
}}

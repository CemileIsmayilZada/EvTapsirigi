//Task 1: 
int temperature=34;
if(temperature<15){
    Console.WriteLine("Hava Soyuqdur");
}
else if(temperature>15){
    Console.WriteLine("Hava Istidir");
}
else{
    Console.WriteLine("hava ne isti nede soyuqdu");
}
//Task 2

int number=23;

if(number%2==0){
    Console.WriteLine("Number is Even");

}
else{
   Console.WriteLine("Number is Odd");
}

//Task 3

int numb1=42;
int numb2=23;
int numb3=23;

if((numb1<numb2)&&(numb1<numb3))
{
    Console.WriteLine("Minimum number is "+numb1);
}
else if((numb2<numb1)&&(numb2<numb3)){
    Console.WriteLine("Minimum number is "+numb2);
}
else{
    Console.WriteLine("Minimum number is "+numb3);
}


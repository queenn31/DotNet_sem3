int x=1221, y=x, r=0;
while(y>10)
{
r+=y%10;
y/=10;
}
r+=y;
if(x==r) Console.WriteLine("Yes");
else  Console.WriteLine("No");
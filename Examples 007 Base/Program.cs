int a = 7;
int b = 3;
int c = 9;
int d = 1;
int e = 4;

int max = a;

if(max < a) max = a;
if(max < b) max = b;
if(max < c) max = c;
if(max < d) max = d;
if(max < e) max = e;

Console.Write("max = ");
Console.WriteLine(max);

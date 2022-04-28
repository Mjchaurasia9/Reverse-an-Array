// See https://aka.ms/new-console-template for more information
Console.Write("How many Element You Want to Add in Array:\t");
int num = int.Parse(Console.ReadLine());

int [] arr = new int [num];

for (int i = 0; i < arr.Length; i++)
{
Console.Write("Enter the Value Of Element:\t");
int ele = int.Parse(Console.ReadLine());
arr[i] = ele;
}

Array.Reverse(arr);
Console.WriteLine("Reverse Element of Given Array:\t"+ String.Join(',',arr));

/*for (int j = arr.Length-1; j >= 0; j--)
{
Console.Write(arr[j]+" ");
}
Console.WriteLine();
*/

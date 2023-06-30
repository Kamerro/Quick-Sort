
using System.ComponentModel;
using System.Data;

int[] tablica_liczb = new int[] {1000,1,4,3,24124,231231,0,100,15,23,4124};
QuickSort(tablica_liczb, 0, tablica_liczb.Length-1);
foreach(var elem in tablica_liczb)
{
    Console.WriteLine(elem);
}
void QuickSort(int[] tab,int left,int right)
{

    if (right > left)
    {
        //Pivot
        int pivot = calculatePivot(tab, left, right);
        QuickSort(tab, pivot + 1, right);
        QuickSort(tab, left, pivot-1);
    }

}


int calculatePivot(int[] tab,int left, int right)
{
    //pivot ustawia liczbe na prawidłowym miejscu 
    int j = left - 1;
    int piv = tab[right];
    for(int i = left; i < right; i++)
    {
        if (piv < tab[i])
        {
            j++;
            swap(i,j,tab);
        }
    }
    swap(right,++j,tab);
    return j;

}

void swap(int v1, int v2, int[] tab)
{
    int temporary = tab[v1];
    tab[v1] = tab[v2];
    tab[v2] = temporary;
}
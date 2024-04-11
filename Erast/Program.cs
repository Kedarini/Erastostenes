class Zadanie
{
    static void Main(string[] args)
    {
        bool[] liczby = new bool[100];

        WypelnienieTablicy(liczby);
    }
    static void WypelnienieTablicy(bool[] tab)
    {
        for(int i = 0; i < tab.Length; i++)
        {
            tab[i] = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sortowanie2
{
    public partial class Sortowanie : Form
    {
        public Sortowanie()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true
                || checkBox3.Checked == true || checkBox4.Checked == true
                || checkBox5.Checked == true)
            {
                
                    button1.Enabled = true;
            }
            else
            { button1.Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true || checkBox2.Checked == true
                || checkBox3.Checked == true || checkBox4.Checked == true
                || checkBox5.Checked == true)
            {
               
                    button1.Enabled = true;
            }
            else
            { button1.Enabled = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true || checkBox2.Checked == true
                || checkBox3.Checked == true || checkBox4.Checked == true
                || checkBox5.Checked == true)
            {
                
                    button1.Enabled = true;
            }
            else
            { button1.Enabled = false; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true || checkBox2.Checked == true
                || checkBox3.Checked == true || checkBox4.Checked == true
                || checkBox5.Checked == true)
            {
               
                    button1.Enabled = true;
            }
            else
            { button1.Enabled = false; }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true
                || checkBox3.Checked == true || checkBox4.Checked == true
                || checkBox5.Checked == true)
            {
                
                button1.Enabled = true;
            }
            else
            { button1.Enabled = false; }
        }

        

        private void checkBox6_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked == true)
            {
                checkBox7.Checked = false;
            }
            else { checkBox7.Checked = true; }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox6.Checked = false;
            }
            else { checkBox6.Checked = true; }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }
            else if (checkBox9.Checked == false && checkBox10.Checked == false)
            {
                checkBox10.Checked = true;
            }
            
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox8.Checked = false;
                checkBox10.Checked = false;
            }
            else if (checkBox8.Checked == false && checkBox10.Checked == false)
            {
                checkBox10.Checked = true;
            }

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox9.Checked = false;
                checkBox8.Checked = false;
            }
            else if (checkBox9.Checked == false && checkBox8.Checked == false)
            {
                checkBox10.Checked = true;
            }

        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            Wykres.Series.Clear();
            int seria = (int)numericUpDown1.Value;
            int mnoznik = (int)numericUpDown2.Value;
            int ziarno = (int)numericUpDown3.Value;
            Series s = new Series("Bubblesort");
            if (checkBox1.Checked == true)
            {
                for (int i = 1; i <= seria; i++)
                {
                    BubbleSort bubbleSort;
                    if (checkBox8.Checked == true)
                    {
                        bubbleSort = new BubbleSort(BubbleSort.typ.rosnace, ziarno + i * mnoznik);
                    }
                    else if (checkBox9.Checked == true)
                    {
                        bubbleSort = new BubbleSort(BubbleSort.typ.malejace, ziarno + i * mnoznik);
                    }
                    else
                    {
                        bubbleSort = new BubbleSort(BubbleSort.typ.losowe, ziarno + i * mnoznik);
                    }
                    int ilosc;
                    if (checkBox7.Checked == true)
                    {
                        ilosc = bubbleSort.SortujMalejaca();
                    }
                    else
                    {
                        ilosc = bubbleSort.SortujRosnaca();
                    }
                    s.Points.AddXY((double)(ziarno + (i-1) * mnoznik), (double)(ilosc));
                }

                Wykres.Series.Add(s);
                

            }
            s = new Series("QuickSort");
             if (checkBox4.Checked == true)
            {
                for (int i = 1; i <= seria; i++)
                {
                    QuickSort quickSort;
                    if (checkBox8.Checked == true)
                    {
                        quickSort = new QuickSort(QuickSort.typ.rosnace, ziarno + i * mnoznik);
                    }
                    else if (checkBox9.Checked == true)
                    {
                        quickSort = new QuickSort(QuickSort.typ.malejace, ziarno + i * mnoznik);
                    }
                    else
                    {
                        quickSort = new QuickSort(QuickSort.typ.losowe, ziarno + i * mnoznik);
                    }
                    int ilosc;
                    if (checkBox7.Checked == true)
                    {
                        ilosc = quickSort.SortujMalejaca();
                    }
                    else
                    {
                        ilosc = quickSort.SortujRosnaca();
                    }
                    s.Points.AddXY((double)(ziarno + (i - 1) * mnoznik), (double)(ilosc));
                }

                Wykres.Series.Add(s);
                

            }

            s = new Series("MergeSort");

            if (checkBox5.Checked == true)
            {
                for (int i = 1; i <= seria; i++)
                {
                    MergeSort mergeSort;
                    if (checkBox8.Checked == true)
                    {
                        mergeSort = new MergeSort(MergeSort.typ.rosnace, ziarno + i * mnoznik);
                    }
                    else if (checkBox9.Checked == true)
                    {
                        mergeSort = new MergeSort(MergeSort.typ.malejace, ziarno + i * mnoznik);
                    }
                    else
                    {
                        mergeSort = new MergeSort(MergeSort.typ.losowe, ziarno + i * mnoznik);
                    }
                    int ilosc;
                    if (checkBox7.Checked == true)
                    {
                        ilosc = mergeSort.SortujMalejaca();
                    }
                    else
                    {
                        ilosc = mergeSort.SortujRosnaca();
                    }
                    s.Points.AddXY((double)(ziarno + (i - 1) * mnoznik), (double)(ilosc));
                }

                Wykres.Series.Add(s);
                Wykres.Visible = true;

            }

            s = new Series("InsertionSort");

            if (checkBox2.Checked == true)
            {
                for (int i = 1; i <= seria; i++)
                {
                    InsertionSort insertionSort;
                    if (checkBox8.Checked == true)
                    {
                        insertionSort = new InsertionSort(InsertionSort.typ.rosnace, ziarno +i * mnoznik);
                    }
                    else if (checkBox9.Checked == true)
                    {
                        insertionSort = new InsertionSort(InsertionSort.typ.malejace, ziarno + i * mnoznik);
                    }
                    else
                    {
                        insertionSort = new InsertionSort(InsertionSort.typ.losowe, ziarno + i * mnoznik);
                    }
                    int ilosc;
                    if (checkBox7.Checked == true)
                    {
                        ilosc = insertionSort.SortujMalejaca();
                    }
                    else
                    {
                        ilosc = insertionSort.SortujRosnaca();
                    }
                    s.Points.AddXY((double)(ziarno + (i - 1) * mnoznik), (double)(ilosc));
                }

                Wykres.Series.Add(s);
                Wykres.Visible = true;

            }

            s = new Series("SelectionSort");

            if (checkBox3.Checked == true)
            {
                for (int i = 1; i <= seria; i++)
                {
                    SelectionSort selectionSort;
                    if (checkBox8.Checked == true)
                    {
                        selectionSort = new SelectionSort(SelectionSort.typ.rosnace, ziarno + i * mnoznik);
                    }
                    else if (checkBox9.Checked == true)
                    {
                        selectionSort = new SelectionSort(SelectionSort.typ.malejace, ziarno + i * mnoznik);
                    }
                    else
                    {
                        selectionSort = new SelectionSort(SelectionSort.typ.losowe, ziarno + i * mnoznik);
                    }
                    int ilosc;
                    if (checkBox7.Checked == true)
                    {
                        ilosc = selectionSort.SortujMalejaca();
                    }
                    else
                    {
                        ilosc = selectionSort.SortujRosnaca();
                    }
                    s.Points.AddXY((double)(ziarno + (i - 1) * mnoznik), (double)(ilosc));
                }

                Wykres.Series.Add(s);
                Wykres.Visible = true;

            }

            Wykres.ChartAreas[0].RecalculateAxesScale();

        }
        


    }

    abstract public class Dane
    {
        protected int[] tab;
        public enum typ { losowe, malejace, rosnace, wstawione };

        public void losowe(int ilosc)
        {
            GC.Collect();
            tab = new int[ilosc];
            Random rnd = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(1, tab.Length);
            }
        }

        public void rosnace(int ilosc)
        {
            GC.Collect();
            tab = new int[ilosc];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }
        }

        public void malejace(int ilosc)
        {
            GC.Collect();
            tab = new int[ilosc];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = tab.Length - i;
            }
        }

        public void wstaw(int[] tab2)
        {
            this.tab = new int[tab2.Length];
            for (int i = 0; i < tab2.Length; i++)
            {
                this.tab[i] = tab2[i];
            }
            GC.Collect();
        }

        public void wypisz()
        {
            if (tab != null)
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    System.Console.Write(tab[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Tablica pusta!");
            }
        }

        public Dane()
        {
            tab = null;
        }

        public Dane(typ rodzaj, int ilosc)
        {
            if (rodzaj == typ.losowe)
            {
                losowe(ilosc);
            }

            if (rodzaj == typ.malejace)
            {
                malejace(ilosc);
            }

            if (rodzaj == typ.rosnace)
            {
                rosnace(ilosc);
            }

        }

        public int[] zwrocDane()
        {
            int rozmiar = tab.Length;
            int[] kopia = new int[rozmiar];
            for (int i = 0; i < kopia.Length; i++)
            {
                kopia[i] = tab[i];
            }
            return kopia;
        }


        ~Dane()
        {
            tab = null;
            GC.Collect();
        }

        public abstract int SortujRosnaca();
        public abstract int SortujMalejaca();



    };


    public class InsertionSort : Dane
    {
        public InsertionSort() : base()
        {

        }
        public InsertionSort(typ rodzaj, int ilosc) : base(rodzaj, ilosc)
        {

        }

        public override int SortujRosnaca()
        {

            if (tab == null)
            {
                return 0;
            }

            int n = tab.Length;
            int x;
            int j;
            int count = 0;
            for (int i = n - 2; i >= 0; i--)
            {
                x = tab[i];
                j = i + 1;
                while ((j < n) && (x > tab[j]))
                {
                    tab[j - 1] = tab[j];
                    j++;
                    count++;
                }
                tab[j - 1] = x;
            }
            return count;
        }

        public override int SortujMalejaca()
        {
            if (tab == null)
            {
                return 0;
            }

            int n = tab.Length;
            int x;
            int j;
            int count = 0;
            for (int i = n - 2; i >= 0; i--)
            {
                x = tab[i];
                j = i + 1;
                while ((j < n) && (x < tab[j]))
                {
                    tab[j - 1] = tab[j];
                    j++;
                    count++;
                }
                tab[j - 1] = x;
            }
            return count;
        }

    }

    public class BubbleSort : Dane /*jak dziedziczysz z klasy zawierającej konstruktor dopóki nie zadeklarujesz konstruktora
                                       będziesz miał błąd */
    {
        public BubbleSort() : base()
        {

        }
        public BubbleSort(typ rodzaj, int ilosc) : base(rodzaj, ilosc)
        {

        }

        public override int SortujRosnaca()
        {
            int count = 0;
            if (this.tab != null)
            {
                for (int i = tab.Length - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (tab[j] > tab[j + 1])
                        {
                            int var = this.tab[j];
                            this.tab[j] = this.tab[j + 1];
                            this.tab[j + 1] = var;
                        }
                        count++;
                    }
                }
            }
            return count;
        }

        public override int SortujMalejaca()
        {
            int count = 0;
            if (this.tab != null)
            {
                for (int i = tab.Length - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (tab[j] < tab[j + 1])
                        {
                            int var = this.tab[j];
                            this.tab[j] = this.tab[j + 1];
                            this.tab[j + 1] = var;
                        }
                        count++;
                    }
                }
            }
            return count;
        }

    }


    public class QuickSort : Dane
    {
        private int count = 0;

        public QuickSort() : base()
        {

        }
        public QuickSort(typ rodzaj, int ilosc) : base(rodzaj, ilosc)
        {

        }

        private void zamien(int i, int j)
        {
            if (this.tab == null || i >= this.tab.Length || j >= this.tab.Length)
            {
                return;
            }

            int x = this.tab[i];
            this.tab[i] = this.tab[j];
            this.tab[j] = x;
        }

        private void Quick(int p, int k, typ type)
        {
            if (this.tab == null || k >= this.tab.Length || p >= k)
            {
                return;
            }
            int sr = (p + k) / 2;
            zamien(p, sr);

            int j = p + 1;
            int h = p + 1;

            if (type == QuickSort.typ.rosnace)
            {
                while (j <= k)
                {
                    if (this.tab[j] < this.tab[p])
                    {
                        zamien(j, h);
                        h++;
                    }
                    j++;
                    count++;
                }
            }

            if (type == QuickSort.typ.malejace)
            {
                while (j <= k)
                {
                    if (this.tab[j] > this.tab[p])
                    {
                        zamien(j, h);
                        h++;
                    }
                    j++;
                    count++;
                }
            }



            h--;

            zamien(h, p);

            Quick(p, h - 1, type);
            Quick(h + 1, k, type);


        }

        public override int SortujMalejaca()
        {
            int count2 = 0;
            Quick(0, this.tab.Length - 1, QuickSort.typ.malejace);
            count2 = this.count;
            this.count = 0;
            return count2;
        }

        public override int SortujRosnaca()
        {
            int count2 = 0;
            Quick(0, this.tab.Length - 1, QuickSort.typ.rosnace);
            count2 = this.count;
            this.count = 0;
            return count2;
        }


    }

    public class SelectionSort : Dane
    {
        private int count = 0;

        public SelectionSort() : base()
        {

        }
        public SelectionSort(typ type, int ilosc) : base(type, ilosc)
        {

        }

        private void zamien(int i, int j)
        {
            if (this.tab == null || i >= this.tab.Length || j >= this.tab.Length)
            {
                return;
            }

            int x = this.tab[i];
            this.tab[i] = this.tab[j];
            this.tab[j] = x;
        }

        private int znajdzminimum(int index)
        {
            int min = index;
            for (int i = index + 1; i < this.tab.Length; i++)
            {
                if (this.tab[i] < this.tab[min])
                {
                    min = i;
                }
                count++;
            }
            return min;
        }

        private int znajdzmaksimum(int index)
        {
            int min = index;
            for (int i = index + 1; i < this.tab.Length; i++)
            {
                if (this.tab[i] < this.tab[min])
                {
                    min = i;
                }
                count++;
            }
            return min;
        }



        public override int SortujRosnaca()
        {
            for (int i = 0; i < this.tab.Length; i++)
            {
                int min = znajdzminimum(i);
                zamien(i, min);
            }
            int count2 = count;
            count = 0;
            return count2;

        }

        public override int SortujMalejaca()
        {
            for (int i = 0; i < this.tab.Length; i++)
            {
                int min = znajdzmaksimum(i);
                zamien(i, min);
            }
            int count2 = count;
            count = 0;
            return count2;
        }

    }

    public class MergeSort : Dane
    {
        private int[] kopia = null;
        private int count = 0;

        public MergeSort() : base()
        {

        }
        public MergeSort(typ type, int ilosc) : base(type, ilosc)
        {

        }

        private void Scal(int p, int s, int k, typ type)
        {
            int h = 0;
            int i = p;
            int j = s + 1;
            if (type == typ.rosnace)
            {
                while (i <= s && j <= k)
                {
                    if (this.tab[i] < this.tab[j])
                    {
                        kopia[h] = this.tab[i];
                        i++;
                        h++;
                    }
                    else
                    {
                        kopia[h] = this.tab[j];
                        j++;
                        h++;
                    }
                    count++;
                }
            }

            if (type == typ.malejace)
            {
                while (i <= s && j <= k)
                {
                    if (this.tab[i] > this.tab[j])
                    {
                        kopia[h] = this.tab[i];
                        i++;
                        h++;
                    }
                    else
                    {
                        kopia[h] = this.tab[j];
                        j++;
                        h++;
                    }
                    count++;
                }
            }


            while (i <= s)
            {
                kopia[h] = tab[i];
                h++;
                i++;
            }


            while (j <= k)
            {
                kopia[h] = tab[j];
                h++;
                j++;
            }

            h = 0;

            for (int l = p; l <= k; l++)
            {
                this.tab[l] = kopia[h];
                h++;

            }


        }

        private void Merge(int poczatek, int koniec, typ type)
        {

            if (poczatek == koniec || koniec < poczatek || poczatek < 0 || koniec > this.tab.Length)
            {
                return;
            }

            int s = (poczatek + koniec) / 2;

            Merge(poczatek, s, type);
            Merge(s + 1, koniec, type);
            Scal(poczatek, s, koniec, type);



        }



        public override int SortujMalejaca()
        {
            kopia = new int[this.tab.Length];
            Merge(0, this.tab.Length - 1, typ.malejace);
            int count2 = count;
            count = 0;
            kopia = null;
            GC.Collect();
            return count2;

        }

        public override int SortujRosnaca()
        {
            kopia = new int[this.tab.Length];
            Merge(0, this.tab.Length - 1, typ.rosnace);
            int count2 = count;
            count = 0;
            kopia = null;
            GC.Collect();
            return count2;
        }
    }

}

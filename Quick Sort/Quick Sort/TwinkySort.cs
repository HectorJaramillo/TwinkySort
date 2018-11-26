using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    public class TwinkySort
    {
        double raiz = (Math.Sqrt(2) / 2), raiz2 = Math.Sqrt(3);//    NUMEROS QUE REQUIEREN FORMULAS MATEMATICAS
        double[] vector, vector2, vector3, vector4;//VECTORES A ORDENAR
        public void Enviollenar()
        {
            vector = new double[] { 11, 2, 3, 14, 18, 4, 5, -3, -1, 6, 9 };//LLENADO DE LOS VECTORES CON LOS VALORES ESTABLECIDOS EN EL SALON
            vector2 = new double[] { 1, 3, 5, 7, 8, 3, 9, raiz, 1.5664, 12, 0, 10 };
            vector3 = new double[] { 3, 7, 15, 4 / 3, 155, 100, 15, raiz2, 5, -5, 3, 2 };
            vector4 = new double[] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
            QuickSort(vector, 0, vector.Length - 1);//LLAMADA AL METODO QUICKSORT PARA CADA VECTOR
            QuickSort(vector2, 0, vector2.Length - 1);
            QuickSort(vector3, 0, vector3.Length - 1);
            QuickSort(vector4, 0, vector4.Length - 1);
            Mostrar();//IMPRESION DE LOS VECTORES YA ORDENADOS
        }

        public void QuickSort(double[] vector, int primero, int ultimo)//METODO QUICKSORT
        {//PIDE UN ARREGLO, POSICION INICIAL DEL VECTOR Y LA POSICION
            int i, j, central;//SEÑALADORES DEL METODO
            double pivote;
            central = (primero + ultimo) / 2;//CALCULO DE LA POSICION CENTRAL DEL ARREGLO AL SER DE TIPO INT SE REDONDEA
            pivote = vector[central];//VALOR DE LA POSICION CENTRAL DEL VECTOR
            i = primero;
            j = ultimo;

            do//IMPLEMENTACION DEL ORDENAMIENTO
            {
                while (vector[i] < pivote) i++;//MIENTRA EXISTA UN ELEMENTO MENOR QUE EL PIVOTE
                while (vector[j] > pivote) j--;//MIENTRA EXISTA UN ELEMENTO MAYOR QUE EL PIVOTE

                if (i <= j)//SI I ES MENOR O IGUAL QUE J
                {
                    double temporal;//VARIABLE DE ALMACENAMIENTO TEMPORAL
                    temporal = vector[i];//LA POSICION I DEL VECTOR SE GUARDA EN TEMPORAL
                    vector[i] = vector[j];//LA POSICION J DEL VECTOR SE GUARDA EN LA POSICION I
                    vector[j] = temporal;//EL VALOR GUARDADO EN TEMPORAL SE GUARDA EN LA POSICION J DEL VECTOR
                    i++;//CONTADORES +1
                    j--;

                }
            } while (i <= j);//SI I ES MENOR IGUAL QUE J

            if (primero < j)//SI PRIMERO ES MENOR QUE J
            {
                QuickSort(vector, primero, j);//LLAMADA RECURSIVA DEL METODO QUIKSORT
            }
            if (i < ultimo)//SI I ES MENOR QUE ULTIMO
            {
                QuickSort(vector, i, ultimo);//LLAMADA RECURSIVA DEL METODO QUIKSORT
            }
        }

        public void Mostrar()//METODO PARA IMPRIMIR LOS VECTORES YA ORDENADOS
        {
            Console.WriteLine("Vector 1: ");
            for (int i = 0; i < vector.Length; i++)
            {

                Console.Write("{0}, ", vector[i]);
            }
            Console.WriteLine("\nVector 2: ");
            for (int i = 0; i < vector2.Length; i++)
            {

                Console.Write("{0}, ", vector2[i]);
            }
            Console.WriteLine("\nVector 3: ");
            for (int i = 0; i < vector3.Length; i++)
            {

                Console.Write("{0}, ", vector3[i]);
            }
            Console.WriteLine("\nVector 4: ");
            for (int i = 0; i < vector4.Length; i++)
            {

                Console.Write("{0}, ", vector4[i]);
            }
            Console.ReadKey(true);
        }
    }
}

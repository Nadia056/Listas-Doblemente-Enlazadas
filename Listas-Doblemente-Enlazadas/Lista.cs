using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Doblemente_Enlazadas
{
    class Lista
    {


        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        //Lista doble
        public void Insertar()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingresa la palabra: ");
            nuevo.Dato = Console.ReadLine();
            
            if (primero == null)
            {
                primero = nuevo;
                ultimo = primero;
                return;
            }
            if (primero.Dato.CompareTo(nuevo.Dato) > 0)
            {
                nuevo.Siguiente = primero;
                primero.Atras = nuevo;
                primero = nuevo;
                return;
            }

            Nodo actual = new Nodo();
            actual = primero;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Dato.CompareTo(nuevo.Dato) > 0)
                {
                    nuevo.Siguiente = actual.Siguiente;
                    actual.Siguiente.Atras = nuevo;
                    nuevo.Atras = actual;
                    actual.Siguiente = nuevo;
                    return;
                }
                actual = actual.Siguiente;
            }
            ultimo.Siguiente = nuevo;
            nuevo.Atras = ultimo;
            ultimo = nuevo;
        }
        //desplegarListaPrimero
        public void desplegarListaPrimero()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if (actual == null)
            {
                Console.WriteLine("Lista Vacia ");
                Console.ReadLine();
                return;
            }
            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
            Console.ReadLine();
        }
        //desplegarListaUltimo
        public void desplegarListaUltimo()
        {
            Nodo actual = new Nodo();
            actual = ultimo;
            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Atras;
            }
        }
        //buscarPalabra
        public void buscarPalabra()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingresa Palabra: ");
            nuevo.Dato = Console.ReadLine();
            Nodo actual = primero;
            while (actual != null)
            {
                if (actual.Dato == nuevo.Dato)
                {
                    Console.WriteLine("Si se encuentra en la lista: " + nuevo.Dato );
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("Si se encuentra en la lista");
        }
        //vaciarLista
        public void vaciarLista()
        {
            Nodo actual = new Nodo();
            Nodo aux = new Nodo();
            actual = primero;
            try
            {
                while (actual.Atras != null) actual = actual.Atras;

                while(actual != null)
                {
                    aux = actual;
                    actual = actual.Siguiente;
                }
                primero = null;
                Console.WriteLine("Lista vacia");
                Console.ReadLine();
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Lista vacia");
                Console.ReadLine();
            }
        }
        //eliminarPalabra
        public void eliminarPalabra()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingresa la palabra a eliminar: ");
            nuevo.Dato = Console.ReadLine();
            Nodo actual = primero;
            try
            {
                while (actual.Siguiente != null && actual.Dato != nuevo.Dato)
                {
                    actual = actual.Siguiente;
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("La lista esta vacia");
                Console.ReadLine();
                return;
            }
            try
            {
                if (actual.Dato == nuevo.Dato)
                {
                    if (actual == primero && actual == ultimo)
                    {
                        primero = null;
                        ultimo = null;
                        Console.WriteLine("Palabra eliminada");
                        Console.ReadLine();
                        return;
                    }
                    if (actual == primero)
                    {
                        primero = actual.Siguiente;
                        primero.Atras = null;
                        Console.WriteLine("Palabra eliminada ");
                        Console.ReadLine();
                        return;
                    }
                    if (actual == ultimo)
                    {
                        ultimo = actual.Atras;
                        ultimo.Siguiente = null;
                        Console.WriteLine("Palabra eliminada ");
                        Console.ReadLine();
                        return;
                    }
                    Nodo anterior = actual.Atras;
                    Nodo siguiente = actual.Siguiente;
                    anterior.Siguiente = siguiente;
                    siguiente.Atras = anterior;
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("La lista esta vacia");
                Console.ReadLine();
            }
            Console.WriteLine("La palabra no se encuetra en la lista");
            Console.ReadLine();
        }
        public void modificarPalabra()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingresa la palabra para modificar: ");
            nuevo.Dato = Console.ReadLine();
            Nodo actual = primero;
            try
            {
                while (actual.Siguiente != null && actual.Dato != nuevo.Dato)
                {
                    actual = actual.Siguiente;
                }
            }
            catch (System.NullReferenceException)
            {
                Console.ReadLine(); 
                return;
            }
            try
            {
                if (actual.Dato == nuevo.Dato)
                {
                    if (actual == primero && actual == ultimo)
                    {
                        primero = null;
                        ultimo = null;
                        
                    }
                    if (actual == primero)
                    {
                        primero = actual.Siguiente;
                        primero.Atras = null;
                        
                    }
                    if (actual == ultimo)
                    {
                        ultimo = actual.Atras;
                        ultimo.Siguiente = null;
                        
                    }
                    Nodo anterior = actual.Atras;
                    Nodo siguiente = actual.Siguiente;
                    anterior.Siguiente = siguiente;
                    siguiente.Atras = anterior;
                }
            }
            catch (System.NullReferenceException)
            {
            }
            Console.Write("Ingresa una palabra: ");
            nuevo.Dato = Console.ReadLine();

            if (primero == null)
            {
                primero = nuevo;
                ultimo = primero;
                return;
            }
            if (primero.Dato.CompareTo(nuevo.Dato) > 0)
            {
                nuevo.Siguiente = primero;
                primero.Atras = nuevo;
                primero = nuevo;
                return;
            }
            actual = primero;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Dato.CompareTo(nuevo.Dato) > 0)
                {
                    nuevo.Siguiente = actual.Siguiente;
                    actual.Siguiente.Atras = nuevo;
                    nuevo.Atras = actual;
                    actual.Siguiente = nuevo;
                    return;
                }
                actual = actual.Siguiente;
            }
            ultimo.Siguiente = nuevo;
            nuevo.Atras = ultimo;
            ultimo = nuevo;
        }
       
    }
}
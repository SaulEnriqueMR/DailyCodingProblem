/**
 * Stripe
 */


 /**
  * This problem was asked by Stripe.
  *
  * Given an array of integers, find the first missing 
  * positive integer in linear time and constant space. 
  * In other words, find the lowest positive integer that 
  * does not exist in the array. The array can contain 
  * duplicates and negative numbers as well.
  *
  * For example, the input [3, 4, -1, 1] should give 2. 
  * The input [1, 2, 0] should give 3.
  * You can modify the input array in-place
  */

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Stripe {

    public int obtenerProximoEntero() {
        Scanner teclado = new Scanner(System.in);
        System.out.println("Número de elementos: ");
        int numeroDeElementos = Integer.parseInt(teclado.nextLine());
        ArrayList<Integer> listaDeElementos = new ArrayList<>();

        for (int i = 0; i < numeroDeElementos; i++) {
            int elemento = Integer.parseInt(teclado.nextLine());
            listaDeElementos.add(elemento);
        }

        Collections.sort(listaDeElementos);

        teclado.close();
        return (listaDeElementos.get(listaDeElementos.size() - 1)) + 1;

    }

    public static void main(String[] args) {
        Stripe s = new Stripe();
        System.out.println(s.obtenerProximoEntero());
    }
    
}
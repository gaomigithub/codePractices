/**
 * 
 */
package lab2;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

/**
 * 
 * @describing Write a Multithreaded program that calculates various statistical values for a list of numbers.
 *  This program will be passed a series of numbers on the command line and will then create three separate worker threads.
 *   One thread will determine the average of the numbers, the second will determine the maximum value, and the third will determine the minimum value. 
 *   
 * @author Mi Gao
 * @date 20170-05-19
 *
 */
public class Multithread {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
        ArrayList<Integer> numbers = new ArrayList<>();

        // Read an initial data
        System.out.print(
                "Enter an integer (the input ends if it is negative): ");
        int data = input.nextInt();

        // Keep reading data until the input is 0
        int sum = 0;
        while (data >= 0) {
            // Read the next data
            System.out.print(
                    "Enter an integer (the input ends if it is negative): ");
            data = input.nextInt();
            if(data>= 0){
            numbers.add(data);
            }
        }
        
        Thread thread1 = new Average(numbers);
        Thread thread2 = new Minimum(numbers);
        Thread thread3 = new Maximum(numbers);
        thread1.start();
        thread2.start();
        thread3.start();
        }
	}

class Average extends Thread {
	private ArrayList<Integer> number;
	double sum=0 , average;
	
	Average(ArrayList<Integer> number) {
		this.number = number;
		}
   
	public void run() {

		for(int a: number){
			sum+=a;
			}
		average= sum/number.size();
		System.out.println("The average value is "+average);
		}
	}

class Minimum extends Thread  {
	private ArrayList<Integer> number;
	int min;
	
	Minimum(ArrayList<Integer> number) {
		this.number = number;
		}
   
	public void run() {
		min = Collections.min(number);
		System.out.println("The Minimum value is "+min);
		}
	}

class  Maximum extends Thread  {
	private ArrayList<Integer> number;
	int max;
   
	Maximum(ArrayList<Integer> number) {
		this.number = number;
		}
	
	public void run() {
		max = Collections.max(number);
		System.out.println("The Maximum value is "+max);
		}
	}
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
package lab2_2;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;
import java.util.Arrays;

/**
 * 
 * @param
 * @return the value returned from threads in the subclass 
 * 			which calculating average, minimum and maximum of input data.
 *
 */
public class Multithread {

	/**
	 * 
	 * @param args Unused
	 * @throws FileNotFoundException Throw exception when the scanner do not find the input file.
	 */
	public static void main(String[] args) throws FileNotFoundException {
		
        System.out.println(
                "REMINDER: This thread will process INTERGER within the text file only.");
        System.out.println(
                "The result will remove decimal values from a value of type 'double' in Java.");
        System.out.print(
                "What is the name of the text file: "); // src\input.txt
		
        // Read a data file
		Scanner input = new Scanner(System.in);
		File file = new File(input.nextLine());
		input = new Scanner(file);
        ArrayList<Integer> numbers = new ArrayList<>();
        
        int data = 0;	// Initial variable for insert data to the arraylist
        
    	while (input.hasNextLine()) {
    	      data = input.nextInt();
    	      numbers.add(data);
    	}
        
        Thread thread1 = new Average(numbers);
        Thread thread2 = new Minimum(numbers);
        Thread thread3 = new Maximum(numbers);
        
        // Run threads
        thread1.start();
        thread2.start();
        thread3.start();
        
        }
	}

/**
 * 
 * The subclass is responsible for the thread which calculate the average.
 * 	The result is going to be returned by run() method.
 *
 */
class Average extends Thread {
	private ArrayList<Integer> number;
	int sum=0 , average;
	
	/**
	 * 
	 * @param number the value extended from the scanner which in main class above.
	 * 			
	 */
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

/**
 * 
 * The subclass is responsible for the thread which calculate the minimum. 
 * 	The result is going to be returned by run() method.
 *
 */
class Minimum extends Thread  {
	private ArrayList<Integer> number;
	int min;
	
	/**
	 * 
	 * @param number the value extended from the scanner which in main class above.
	 * 			
	 */
	Minimum(ArrayList<Integer> number) {
		this.number = number;
		}
   
	public void run() {
		min = Collections.min(number);
		System.out.println("The Minimum value is "+min);
		}
	}

/**
 * 
 * The subclass is responsible for the thread which calculate the maximum
 *	The result is going to be returned by run() method.
 *
 */
class  Maximum extends Thread  {
	private ArrayList<Integer> number;
	int max;
   
	/**
	 * 
	 * @param number the value extended from the scanner which in main class above.
	 * 			
	 */
	Maximum(ArrayList<Integer> number) {
		this.number = number;
		}
	
	public void run() {
		max = Collections.max(number);
		System.out.println("The Maximum value is "+max);
		}
	}
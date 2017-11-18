/**
 * @author Mi Gao
 * @Date 2017-06-19
 * @Description The mapping of a logical address to its page number and offset within the page.
 */

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.ArrayList;
import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintStream;

public class Main {
	
	/**
	 * 
	 * @param args Unused
	 * @throws FileNotFoundException Throw exception when the scanner do not find the input file.
	 */
	public static void main(String[] args) throws FileNotFoundException {
		// TODO Auto-generated method stub
		
		
		System.out.print("Enter the file name with extension : "); // src\VMData.txt

        // Read a data file
		Scanner input = new Scanner(System.in);
		File file = new File(input.nextLine());
		input = new Scanner(file);
		
        ArrayList<Integer> numbers = new ArrayList<>();
        
        int data = 0;	// Initial variable for insert data to the arraylist
        
    	while (input.hasNext()) {
    	      data = input.nextInt();
    	      numbers.add(data);
    	}
        
		/*
		 * The addresses in the data file assumes  virtual address n = 11, page size m = 6;
		 *  	initialize the address, page number, and offset. 
		 *  	If the address out of the size, then sign as invalid.
		 * */
		int n = 17, m = 4; 
		int address = 0;
		int y = (int) Math.pow(2,m);
		int pageNum = 0;
		int offset = 0;
		String remark = "invalid";		
		
		/*
		 * The function addressAccess that takes an address as parameter and displays its page number and offset
		 * 		in both decimal and hexadecimal formats.
		 * */
		accessAddress(address,pageNum,offset,n,m,remark,numbers);

		
	}
	
	/**
	 * 
	 * @param address	inherit the data from the Arraylist from input files.
	 * @param pageNum	can be calculated by the address / page size, the location on the memory sort by the page
	 * @param offset	can be calculated by the address % page size, the space between the address to next page
	 * @param n			inherit virtual address n = 11
	 * @param m 		inherit page size m = 6
	 * @param remark	the signal from invalid addresses
	 * @param numbers	ArrayList<Integer> inherit from the input file in main class
	 * 
	 * @throw FileNotFoundException Throw exception when the scanner do not find the input file.
	 * 
	 * */
	public static void accessAddress(int address, int pageNum, int offset, int n, int m, String remark, ArrayList<Integer> numbers) throws FileNotFoundException{
		
		PrintStream out = new PrintStream(new FileOutputStream("output.txt"));
		
		out.println("address         page number         offset         remark");
		out.println("----------------------------------------------------------");
		
		for (int i = 0; i < numbers.size(); i++) {
			
			// insert the element from the Arraylist called numbers 
			address = numbers.get(i);
			// right shift the value of the address by page size m = 6 can get the page number
			pageNum = address>>m;
			// then left shift the page number by m and compare as XOR can get the offset
			offset = ((pageNum <<m)^ address );
			
			
			/*
			 * judge by the virtual address space; and the formating
			 * */
			if (address<Math.pow(2,n)) {

				out.printf("%-1d (%#5x) %7d (%#4x) %10d (%#5x)", address, address, pageNum, pageNum, offset, offset);

				out.print("\n");
				
			} else {
			
				out.printf("%-50d %s\n", address, remark);
			}
				
		}
		
		out.close();
		
	}
	
}

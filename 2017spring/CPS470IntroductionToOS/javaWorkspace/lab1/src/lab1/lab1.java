/**
 * 
 */

package lab1;
import java.io.*;
import java.lang.*;
import java.util.*;
/**
 * @author gao2m
 *
 */
public class lab1 {

	/**
	 * @param args
	 * @throws FileNotFoundException 
	 */
	public static void main(String[] args) throws FileNotFoundException {
		// TODO Auto-generated method stub
	
            System.out.print("Enter the file name with extension : ");

            Scanner input = new Scanner(System.in);

            File file = new File(input.nextLine());

            input = new Scanner(file);

//    		Map<String, Integer> wordCounts = new TreeMap<String, Integer>();
//            while (input.hasNext()) {
//                String next = input.next().toLowerCase();
//                if (!wordCounts.containsKey(next)) {
//                    wordCounts.put(next, 1);
//                } else {
//                    wordCounts.put(next, wordCounts.get(next) + 1);
//                }
//            }   

            while (input.hasNextLine()) {
                String line = input.nextLine();
                System.out.println(line);
            }
            input.close();
            
//            int min = console.nextInt();
//            for (String word : wordCounts.keySet()) {
//                int count = wordCounts.get(word);
//                if (count >= min)
//                    System.out.println(count + "\t" + word);
//                }
	      
	}

}

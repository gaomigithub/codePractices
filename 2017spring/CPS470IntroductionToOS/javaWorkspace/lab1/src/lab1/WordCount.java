/**
 * @author Mi Gao
 * @Date 2017-05-18
 * @Description Analyze a textual input file (named input.txt) determining the frequency (word count) and location(s) by trying to use TreeMap
 */
package lab1;

import java.util.*;
import java.io.*;

public class WordCount {
	
	/**
	 * This method is used to split each word in paragraph 
	 * 	and count the amount 
	 * @param args Unused
	 * @throws IOException If an input or output 
	 *                      exception occurred
	 */
    public static void main(String[] args) throws IOException {
    	
    	LineCounter lc = new LineCounter();
    	
    	// set the treeMap for counting words
    	 Map<String, Integer> wordCounts = new TreeMap<String, Integer>();
    	 
        // open the file
        System.out.print("What is the name of the text file? ");

        Scanner input = new Scanner(System.in);
        File file = new File(input.nextLine());
        input = new Scanner(file);
        
        // insert elements into ArrayList
        String str = null;
        
    	List<String> list = new ArrayList<String>();
    	while (input.hasNextLine()) {
    	      str = input.nextLine().toLowerCase();
    	      list.add(str);
    	}
    	
    	
    	//Iterate over each sentence in the array list
    	int lineCounter = 1;
    	
    	for (int i =0; i< list.size(); i++){
    		//Split the current line into an array
    		String[] words = list.get(i).replaceAll("[^a-zA-Z ]", "").toLowerCase().split("\\s+");
    		for (int j = 0; j < words.length; j ++){
    			//Check if word is in tree map. If it is, increment count, else create new entry in tree
    			if (!wordCounts.containsKey(words[j])) {
    				//First time appear
                    wordCounts.put(words[j], 1);
//                    System.out.println(words[j] + wordCounts.get(words[j]));
                } else {
                	//Second time appear
                    wordCounts.put(words[j], wordCounts.get(words[j]) + 1);
//                    System.out.println(words[j] + wordCounts.get(words[j]));
                }
    		}
    		
    		lineCounter++;
//    		System.out.println(lineCounter);
    	}
   
        // report frequencies
        for (String word : wordCounts.keySet()) {
            int count = wordCounts.get(word);
            System.out.print(word + "..." + count + ": ");
            
            for (int i = 0; i < list.size(); i++){
            	
//            	String index_str = lc.toString();
//            	System.out.println(index_str);
            	
            	System.out.print(" ");
            }
            System.out.println();
        }
        
//        // extend test 
//        lc.locationMarks(list);
        
        input.close();
        
    }
    
/**
 *     
 * This 2nd Class for Split the sentences into a hashMap
 * 	then I may be allowed to search the word from the array in each leaf of sentences
 * 	and find out appearing location marks
 * 
 * 	But it still has some problem when printing... (NullPointerException) 
 * 
 * @param input is extended from main class which be scanned from the file
 * @return occurences.toString() should return the map with the location of words in the arrays of sentences 
 *
 */
    public static class LineCounter extends WordCount{
    	
		public void locationMarks(Scanner input) {
			
			occurences = new HashMap<String, ArrayList<Integer>>();

			// check from first line
	        int lineNo = 1;
	        
	            while (input.hasNextLine()) {
	                String line = input.nextLine();
	                String[] words = line.split("\\W+");
	                for (String word : words) {
	                    word = word.toLowerCase();
	                    ArrayList<Integer> list = occurences.get(word);
	                    if (list == null) {
	                        list = new ArrayList<>();
	                        list.add(lineNo);
	                    } else {
	                        list.add(lineNo);
	                    }
	                    occurences.put(word, list);
	                }
	                lineNo++;
	            }
	        }
	    }

	    public String toString() {
	        return occurences.toString();
	    }

	    private static Map<String, ArrayList<Integer>> occurences;
    	
    
    
}
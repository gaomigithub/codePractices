package test;


import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.InputStreamReader;


public class BookIndexer {
    public static void main(String[] args) {
    	
    	File file = new File("src/input.txt");
    	BufferedReader br = null;
        try {
            
        	FileReader fr = new FileReader(file);
            br = new BufferedReader(fr);
            
            String index_str = new Index(br).toString();
            System.out.println(index_str);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }

}
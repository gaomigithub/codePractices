
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStreamWriter;
import java.util.Scanner;



public class User 
{

	// -- Fields
	String userName = "";
	String password = ""; 
	Class listOfRegisteredClasses[] = new Class[100]; 
	
	public User(String newUser, String newPass) 
	{
		userName = newUser;
		password = newPass; 
		
		for(int i = 0; i < listOfRegisteredClasses.length; i++)
			listOfRegisteredClasses[i] = null; 
	}
	
	public void populateClasses(Class listToAdd[])
	{
		if(listToAdd != null)
			listOfRegisteredClasses = listToAdd;
		else
			return; 	
	}
	
	public boolean isUser(String user)
	{
		if(user == null)
			return false;
		else
		{
			if(userName.compareTo(user) == 0)
				return true;
			else
				return false; 
		}
	}
	
	public boolean isPasswordCorrect(String pass)
	{
		if(pass == null)
			return false;
		else
		{
			if(password.compareTo(pass) == 0)
				return true;
			else
				return false; 
		}
	}
	
 	public boolean addRegisteredClass(Class classToAdd)
	{
		if(classToAdd == null)
			return false;
		else
		{
			boolean bIsInList = false; 
			
			for(int i = 0; i < listOfRegisteredClasses.length; i++)
				if(listOfRegisteredClasses[i] == classToAdd)
				{
					bIsInList = true;
					break; 
				}
			
			if(bIsInList)
				return false; 
			else
			{
				for(int x = 0; x < listOfRegisteredClasses.length; x++)
					if(listOfRegisteredClasses[x] == null)
					{
						listOfRegisteredClasses[x] = classToAdd;
						break;
					}
				
				return true; 
			}
		}
	}
	
	public boolean dropRegisteredClass(Class classToDrop)
	{
		if(classToDrop == null)
			return false;
		else
		{
			boolean bFlag = false; 
			
			for(int i = 0; i < listOfRegisteredClasses.length; i++)
				if(listOfRegisteredClasses[i] == classToDrop)
				{
					bFlag = true; 
					listOfRegisteredClasses[i] = null;
					break;
				}
			
			return bFlag; 
		}	
	}
	
	public String getUserName()
	{return userName;}
	
	public String getPassword()
	{return password;}
		
	public Class[] getClasses()
	{ return listOfRegisteredClasses; }
	
	public void setUserName(String name)
	{
		if(name == null)
			return;
		else
			userName = name; 
	}

	public void setPassword(String pass)
	{
		if(pass == null)
			return;
		else
			password = pass; 
		
	}
	
	public String toString()
	{
		String returnString = "Username: " + userName + "\n";
		returnString += "Password: " + password + "\n";
		
		for(int i = 0; i < listOfRegisteredClasses.length; i++)
			if(listOfRegisteredClasses[i] != null)
				returnString += listOfRegisteredClasses[i].toString(); 
			
		return returnString; 
	}
	
	public void writeFile1() throws IOException {
		File fout = new File(System.getProperty("user.dir"), "RegisterList.txt");
		FileOutputStream fos = new FileOutputStream(fout);
		
		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(fos));
		for (int i = 0; i < listOfRegisteredClasses.length; i++) {
			if(listOfRegisteredClasses[i] != null){
                            bw.write(getUserName() + " ");
				bw.write(listOfRegisteredClasses[i].outWrite());
                                bw.newLine();
			}
			
		}
		
		
		bw.close();
	}
        

	
}

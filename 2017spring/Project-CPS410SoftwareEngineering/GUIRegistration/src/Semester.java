


public class Semester 
{

	private String semName = ""; 
	private int semYear = 2016; 
	private Class[] listOfClasses = new Class[10]; 
	private int numOfClasses = 0; 
	
	
	public Semester(String newSemName, int newSemYear) 
	{
		for(int i = 0; i < listOfClasses.length; i++)
			listOfClasses[i] = null;
		
		semName = newSemName;
		semYear = newSemYear; 
		numOfClasses = 0; 
	}
	
	public boolean addClass(Class newClass)
	{
		if(newClass == null)
			return false;
		else
		{
			if(numOfClasses == 0)
			{
				listOfClasses[numOfClasses] = newClass; 
				numOfClasses++;
				return true;
			}
			else
			{
				boolean bFlag = true;  // Check if it is already listed, if false return 
				
				for(int i = 0; i < numOfClasses; i++)
					if(listOfClasses[i] == newClass)
					{
						bFlag = false;
						break; 
					}
				
				if(!bFlag)
					return bFlag; 
				else
				{
					for(int x = 0; x < listOfClasses.length; x++)
						if(listOfClasses[x] == null)
						{
							listOfClasses[x] = newClass;
							numOfClasses++; 
							break;
						}
					
					return true; 
				}
				
			}
			
		}
	}

	public Class[] getClasses()
	{
		return listOfClasses; 
	}
	
	

	public String toString()
	{
		String returnString = "Semester Term: " + semName + "\n";
		returnString += "Semester Year: " + semYear + "\n"; 
		
		for(int i = 0; i < listOfClasses.length; i++)
			if(listOfClasses[i] != null)
			{
				returnString += "//---------------------\n";
				returnString += listOfClasses[i].toString();
			}
				 
		
		return returnString; 
	}
}

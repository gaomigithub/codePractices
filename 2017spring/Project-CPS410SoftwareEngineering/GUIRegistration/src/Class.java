
public class Class {

	// -- Class Fields 
	private String className = ""; 
	private int classNumber = 000;
	private String building = "";
	private int roomNumber = 000;
	private int credits = 0;
	private String days = "M-W-F";
        private String time = "0:00pm-0:00pm";
        private String classType ="";
        private String semester= "";
	
	// -- Class Constructor
        public Class(String newClassType, int newClassNumber, String newClassName, String newBuilding, int newRoomNumber, int newCredits, String newDays, String newTime , String newSemester)        
	{
		className = newClassName;
		classNumber = newClassNumber; 
		building = newBuilding;
		roomNumber = newRoomNumber; 
		credits = newCredits;
		days = newDays;
                time = newTime;
                classType = newClassType;
                semester = newSemester;
	}
        
        
        public String outWrite(){
        String send = semester + " " + classType + " " + classNumber + " " + className + " " + building + " " + roomNumber + " " + credits + " " + days + " " + time;
        return send;
        }
	
	public String toString()
	{
		String returnString = className+" "+"\n";
                returnString += classType+" "+classNumber+" "+"\n";
		returnString += building + " "+roomNumber +" "+ "\n";
		returnString += "credit hours: " +credits + "\n";
		returnString +=  days + "\n";
                returnString += time+ "\n";
		
		return returnString; 
	}

}

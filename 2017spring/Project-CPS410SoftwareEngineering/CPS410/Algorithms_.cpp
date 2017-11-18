// For this application we are going to be testing how a user 
// responds to the a prediciton done for them. For our tests 
// We are going to test to see how the user responsds to a prediciton
// of a couple of simple math problems. For our tests we are going
// to test the user on how they respond to answers that yield to the
// sum of 8. 
// We will be reading in a file and use the numbers in there to display 
// answer to the end user. 

// File Format:
// 6 2 // 6 Will be the X value and 2 will be the Y value. 
// 8 0 // 8 Will be the X value and 0 will be the Y Value 
// We Will be reading in two lines of the file to get an A and 
// B answer. 

// Once the answers are read in, then we will randomly pick on of 
//the answers.  And track if the user has changed their answer. If 
// they do not change it we will not track it. Below is the code for all of it.

#include <iostream.h>

int main(void)
{
	// Create Varaibles
	bool bHasCompletedQuestions = false; // Assume we have not completed the questions
	bool bHasChangedAnswer = false;		 // Assume the user has not changed the answer
	bool bHasSelectedOptionA = true; 	// Assume we choose option A 
	int numberOfChanges  = 0; 
	int numberOfQuestions = 5; 
	File* fileToRead = NULL; // get the file to read from	

	// If the file exists, then cont.. else return error
	if(fileToRead)
	{   // While We have not completed the questions
		while(!(bHasCompletedQuestions))
		{
			// Pull Two Lines From the file 

			// Display them to option A and Option B 
			
			// Pick a Random Button to select
			// And Track the change if any 
			bHasSelectedOptionA = getRandomSelection(); 

			// Get any changes if any 
			
			// If Change, then increment the changes 
			numberOfChanges++; 

		 	// Reset Variables, and check if we have finished the questions.
		}
	}
	// 
	
	// Any Clean Up Needed, close file here ect.... 

	// Display The Results. And Wait to record it 
	fprintf(strerr, "Number of Changes Made By the User: %d\n", numberOfChanges );
	system("pause");

	// Return the application thread. 
	return 0; 
}



 


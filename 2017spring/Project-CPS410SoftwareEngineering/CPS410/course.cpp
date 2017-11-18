
//-----------------------------------------------------------------------------------
// Libraries and Includes                                                           -
//-----------------------------------------------------------------------------------
#include "course.h"

//-----------------------------------------------------------------------------------
// Constructor                                                                      -
//-----------------------------------------------------------------------------------
Course::Course(enum classID className, enum Year classyear, enum Semester classterm)
{
    classTerm = classterm;
    classYear = classyear;
    classIDNum = className;
}

//-----------------------------------------------------------------------------------
// Class Mutators                                                                   -
//-----------------------------------------------------------------------------------
bool Course::setCourseTerm(Semester term)
{
    if(term == Semester::Sem_NULL) // If We do not have a null state
        return false;
    else
    {
        if(term != classTerm)       // If they are not the same...
        {
            classTerm = term;       // Change the semester term
            return true;            // Return true that we modified it
        }
        else                        // Else if they are the same...
            return false;           // Return false that we did not modify it
    }
}

bool Course::setCourseYear(Year yearOfCourse)
{
    if(yearOfCourse == Year::Year_NULL) // Same Methodology as above...
        return false;
    else
    {
        if(yearOfCourse != classYear)
        {
            classYear = yearOfCourse;
            return true;
        }
        else
            return false;
    }
}

bool Course::setCourseClassID(classID courseID)
{
    if(courseID  == classID::id_NULL)   // Same methodology as above
        return false;
    else
    {
        if(courseID != classIDNum)
        {
            classIDNum = courseID;
            return true;
        }
        else
            return false;
    }
}

//-----------------------------------------------------------------------------------
// Class Accessors                                                                  -
//-----------------------------------------------------------------------------------
Semester Course::getCourseTerm()
{
    return classTerm;
}

Year Course::getCourseYear()
{
    return classYear;
}

classID Course::getCourseID()
{
    return classIDNum;
}

#ifndef COURSE_H
#define COURSE_H

// -- Enum for Semesters
enum Semester
{
  Sem_Fall,
  Sem_Spring,
  Sem_Summer_One,
  Sem_Summer_Two,
  Sem_NULL
};

// -- Enum for Year,
// Note: This is not the best way, but the lightest
// for the static system
enum Year
{
  Year_2017,
  Year_2018,
  Year_2019,
  Year_NULL
};

// -- Enum for class ID
// It would be better to use a string,
// but this makes more sense for a small project
enum classID
{
    id_CPS_180,
    id_CPS_181,
    id_ITC_383,
    id_CPS_410,
    id_CPS_450,
    id_CPS_470,
    id_NULL
};

//#define enum Semester Semester;
//#define enum Year Year;
//#define enum classID classID;

// -- Class Information --
class Course
{


    // -- Public Information -- Constructor -- //
public:
    Course(enum classID className, enum Year classyear, enum Semester classterm);

    // -- Public Information -- Accessors and Mutators for Courses -- //
public:
    bool setCourseTerm(enum Semester term =  Semester::Sem_NULL);
    bool setCourseYear(enum Year yearOfCourse = Year::Year_NULL);
    bool setCourseClassID(enum classID courseID = classID::id_NULL);

    enum Semester getCourseTerm();
    enum Year getCourseYear();
    enum classID getCourseID();
    // -- Private Information  -- Class Information -- //
private:
    enum Semester classTerm = Semester::Sem_NULL;
    enum Year classYear = Year::Year_NULL;
    enum classID classIDNum = classID::id_NULL;
};

#endif // COURSE_H

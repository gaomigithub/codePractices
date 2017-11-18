#include "mainwindow.h"
#include "course.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    //  Get the time and date of the Host machine
    time_t currentTime = time(0);

    // Create the courses
    Course* classOne = new Course(classID::id_CPS_180, Year::Year_2017, Semester::Sem_Fall);
    Course* classTwo = new Course(classID::id_CPS_181, Year::Year_2017, Semester::Sem_Fall);
    Course* classThree = new Course(classID::id_CPS_410, Year::Year_2018, Semester::Sem_Spring);
    Course* classFour = new Course(classID::id_CPS_470, Year::Year_2018, Semester::Sem_Spring);


    // Generate the Window and the UI and Show it to the end user
    QApplication a(argc, argv);
    MainWindow w;

    // Show the window
    w.show();

    // Delete the pointers
    delete classOne;
    delete classTwo;
    delete classThree;
    delete classFour;

    // Return this thread..
    return a.exec();
}

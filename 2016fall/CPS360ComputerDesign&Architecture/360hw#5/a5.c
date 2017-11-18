/************************************************************************************
  a5.c
   
  CPS 360
  partial implementation of assignment 5
  author: Dr. Ugur  (You need to put your name here)
  
  version 1.0
  Last updated: Nov. 17, 2016

  This program implements bitwise operations and adders and multiplexers.
  The command line args needs to be given in hexadecimal notation
  (up to 8 characters, since sizeof(int) = 4 bytes = 32 bits,
  arg. is optional (a hex value)

  compile:  gcc a5.c -o a5

  Usage:     /a5
            ./a5 <hexval>
     ex:    ./a5 1
            ./a5 1234
            ./a5

NOTE: set the global variable debug= 0 below (then compile and test) 
      for the final submit version

************************************************************************************/

#include <stdlib.h>
#include <stdio.h>

/* global variables */
int debug = 2;  /* 0: set it to 0 for the final submission;
                   2: add16
                   3: printing SHIFT, MASK */

/* global functions */
void printbits(int var, char* var_name);
int isbigornot();
int isbigornotalt();
int sizeofint();

int main(int argc, char *argv[])
{
  /* a5 variables */
  int i, x, y, arr[2] = {1, 2};
  char *cp1, *cp2;
  
  printf("DEBUG=%d\n", debug);  

  /* print arguments as strings */
  if (debug >= 1) 
  {
    printf("ARGUMENTS: (argc=%d) ", argc);
    for (i=0;  i < argc; i++)
      printf("%s ", argv[i]);

    printf("\n");
  }

  /* get arguments */
  if (argv[1])
    x = (int) strtol(argv[1], NULL, 16);
  else
    x = 0;
  
  if (debug >= 1) 
  {
    printf("x=%d\n", x);
    /* print bits of variable value  */
    printf("\n");
    printbits(x, "x");
    printf("\n");
  }

  /* check isbigornot() */
  printf("isbigornot() results:\n");
  y = isbigornot();
  if (y == 1)
    printf("The computer uses Big-Endian representation.\n");
  else
    printf("The computer DO NOT use Big-Endian representation.\n");
  printf("\n");

  /* check isbigornot() */
  printf("isbigornotalt() results:\n");
  y = isbigornotalt();
  if (y == 1)
    printf("altTest. The computer uses Big-Endian representation.\n");
  else
    printf("altTest: The computer DO NOT use Big-Endian representation.\n");
  printf("\n");

  /* ADD YOUR main program code HERE */
  
  /* check sizeofint() */
  printf("sizeofint() results:\n");
  y = sizeofint();
  printf("The size of an int: %d bytes.\n", y);
  printf("\n");

  /* TURN THE CODE BELOW into the function sizeofintalt() 
     and right here in main, make a call to it and print the result */

  /* test int pointers */
  cp1 = (char *) &arr[0]; cp2 = (char *) &arr[1];
  y = cp2 - cp1;
  printf("Alt. The size of an int: %d bytes.\n\n", y);
  
  exit(0);

} /*end-main */

/* prints bits of variable byte by byte,
   also prints the name of variable if provided */
void printbits(int var, char* var_name)
{
  const int SHIFT = 8 * sizeof( unsigned ) - 1;
  const unsigned int MASK = 1 << SHIFT;
  int i;

  if (debug == 3) 
  {
    printf("MASK=%d, SHIFT=%d\n", MASK, SHIFT);
  }

  if (var_name)
    printf("%s\t", var_name);

  for (i = 1; i <= SHIFT + 1; i++ ) 
  {
    printf("%c", (var & MASK ? '1' : '0' ));
    var <<= 1;

    if ( i % 8 == 0 )
      printf(" ");
  }

  printf("\n");
   
} /* end-printbits */


/* checks if the computer uses big-endian representation 
   via accessing least significant byte and omparing its value 
   against stored fixed value of <0,0,0,1> */
int isbigornot()
{
  int x, byte1Val, big, *xp;
  char *byte1;

  big = 0; /* default */
  x = 1;
  
  byte1 = (char *) &x;

  byte1Val = (int) (*byte1);
 
  if (byte1Val == x)
    big = 1;

  if (debug == 2) {
    printf("&x=%x, &byte1=%x\n", &x, byte1);
    printf("isbigornot: x=%d: byte1Val=%d, big=%d\n", x, byte1Val, big);
    printbits(x, "x");
    printf("\n");
  }

  return big;     

} /* end-isbigornot */

/* checks if the computer uses big-endian representation 
   via accessing least significant two bytes and comparing their value 
   against stored fixed value of <0,0,2,1> */
int isbigornotalt()
{
  int i, x, byte1Val, byte2Val, big, *xp;
  char *byte1, *byte2;

  big = 0; /* default */
  x = 0x0201;

  byte1 = (char *) &x;
  byte2 = byte1 + 1;

  byte1Val = (int) (*byte1);
  byte2Val = (int) (*byte2);

  if (byte1Val < byte2Val)
    big = 1;
 
  if (debug == 2) {
    printf("&x=%x, &byte1=%x, &byte2=%x\n", &x, byte1, byte2);
    printf("isbigornotalt: x=%d: byte1Val=%d, byte2Val=%d, big=%d\n", x, byte1Val, byte2Val, big);
    printbits(x, "altx");
    printf("\n");
  }

  return big; 
    
} /* end-isbigornotalt */

/* ADD YOUR functions code HERE */

/* calculates sizeof an integer (in terms of #bytes) without using sizeof() macro */
int sizeofint()
{
  unsigned int x; /* necessary since 1000 (in 4-bits) is -0 */
  int cnt, size;

  x = 1;
  cnt = 0; /* stores the num. of bits shifts needed to become a zero */

  if (debug == 2) {
    printf("sizeofint(): x=%x, cnt=%d\n", x, cnt);
    printbits(x, "x");
  }
  
  while (x > 0)
  {
    x = x << 1;
    cnt++;
    
    if (debug == 2) {
      printf("sizeofint(): after Left-shift-cnt=%d, x=%x\n", cnt, x);
      printbits(x, "x");
    }
  }

  if (debug == 2)
    printf("end-Left-shift-cnt=%d\n\n", cnt);
  
  size = cnt/8; /* convert to the byte count */

  return size; /* in bytes */

} /* end-intsizeofint */

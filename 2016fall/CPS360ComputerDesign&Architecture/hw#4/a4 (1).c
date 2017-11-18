/************************************************************************************
  a4.c
   
  CPS 360
  partial implementation of assignment 4
  author: Mi Gao
  
  version 1.0
  Last updated: Nov. 03, 2016

  This program implements bitwise operations and adders and multiplexers.
  The command line args needs to be given in hexadecimal notation
  (up to 8 characters, since sizeof(int) = 4 bytes = 32 bits,
   last arg. should be given as single value - either 0 or 1).

  compile:  gcc a4.c -o a4

  Usage:    ./a4 <hex1> <hex2> <hex-cin>
     ex:    ./a4 1b 2f 1
            ./a4 4f 3d 1
            ./a4 4f01 3d02 0   (for 16 bit values)

NOTE: set the global variable debug= 0 below (then compile and test) 
      for the final submit version

************************************************************************************/

/*
long int strtol(const char *nptr, char **endptr, int base);
int atoi(const char *nptr);

The atoi() function converts the initial portion of the string pointed to by nptr to int. 
The behavior is the same as strtol(nptr, NULL, 10);
except that atoi() does not detect errors.
*/

#include <stdlib.h>
#include <stdio.h>

/* global variables */
int debug = 0;  /* 0: set it to 0 for the final submission;
                   2: add16
                   3: printing SHIFT, MASK */

/* global functions */
void printbits(int var, char* var_name);
void halfaddr(int a, int b, int *sumptr, int *carryptr);
void fulladdr(int a, int b, int incarry, int *sumptr, int *carryoutptr);
void add4(int a, int b, int incarry, int *sumptr, int *carryoutptr);
void add16(int a, int b, int incarry, int *sumptr, int *carryoutptr);
void magnitude4(int a, int *rslt);
void parity4(int a, int *outparity); 
void mux2x1(int a, int b, int select, int *out); 
void printresult(char *label, int a); 

int main(int argc, char *argv[])
{
  /* a4 variables */
  int i, x, y, carryin, sum, carry;

  printf("DEBUG=%d\n", debug);  

  /* print arguments as strings */
  if (debug >= 1) 
  {
    printf("ARGUMENTS: (argc=%d) ", argc);
    for (i=0;  i < argc; i++)
      printf("%s ", argv[i]);

    printf("\n");
    printf("sizeof_int=%d bytes\n", sizeof(int));
  }

  if (argc < 4) {
    fprintf(stderr, "Usage: %s <hex1> <hex2> <hex-cin>\n", argv[0]);
    exit(1);
  }

  /* get arguments */
  x =  (int) strtol(argv[1], NULL, 16);
  y =  (int) strtol(argv[2], NULL, 16);
  carryin =  strtol(argv[3], NULL, 16);

  if (debug >= 1) 
  {
    printf("x=%d, y=%d, carryin=%d\n", x, y, carryin);
  }

  /* print bits of variable value  */
  printf("\n");
  printbits(x, "x");
  printbits(y, "y");
  printbits(carryin, "carryin");
  printf("\n");

  /* perform half adder to the LSBs of x and y */
  halfaddr(x, y, &sum, &carry);

  /* print half asdder results */
  printf("HalfAdder(x,y) results:\n");
  printbits(sum, "sum");
  printbits(carry, "carry");
  printf("\n");
  
  /* perform full adder to the LSBs of x and y */
  fulladdr(x, y, carryin, &sum, &carry);

  /* print full asdder results */
  printf("FullAdder(x,y,cin) results:\n");
  printbits(sum, "sum");
  printbits(carry, "carryo");
  printf("\n");

  /* perform 4 bit adder to the LSBs of x and y */
  add4(x, y, carryin, &sum, &carry);

  /* print 4-bit adder results */
  printf("RippleCarry-4bitAdder(x,y,cin) results:\n");
  printbits(sum, "sum");
  printbits(carry, "carryo");
  printf("\n");

  /* perform 16 bit adder to the LSBs of x and y */
  add16(x, y, carryin, &sum, &carry);

  /* print 16-bit adder results */
  printf("16-bitAdder(x,y,cin) results:\n");
  printbits(sum, "sum");
  printbits(carry, "carryo");
  printf("\n");

  /* ADD MORE HERE */
  magnitude4(x, &sum);
  magnitude4(y, &carry);
  printf("magnitude4(x, rslt) results:\n");
  printresult("rslt", sum);
  printf("magnitude4(y, rslt) results:\n");
  printresult("rslt", carry);
  printf("\n");
  
  /* print parity4 results */
  parity4(x, &sum);
  parity4(y, &carry);
  printf("parity4(x, parity) results:\n");
  printresult("parity", sum);
  printf("parity4(y, parity) results:\n");
  printresult("parity", carry);
  printf("\n");
  
  /* print mux2-1 results */
  printbits(x, "x");
  printbits(y, "y");
  printbits(carryin, "select");
  printf("\n");
  
  mux2x1(x, y, carryin, &sum);
 
  printf("mux2x1(x,y,select) results:\n");
  printresult("out", sum);
  printf("\n");

  exit(0);
}

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

/* adds the LSBs of a and b and places the results into *sumptr and *carryptr */
void halfaddr(int a, int b, int *sumptr, int *carryptr)
{
  int x, y, s, c;

  x = a & 1; 
  y = b & 1; /* get the last bit, LSB */
  s = x ^ y;
  c = x & y;

  *sumptr = s; 
  *carryptr = c;
}

/* adds the LSBs of a and b and cin
   and places the results into *sumptr and *carryoutptr */
void fulladdr(int a, int b, int incarry, int *sumptr, int *carryoutptr)
{
  int x, y, s, c, co;

  x = a & 1; 
  y = b & 1; 
  c = incarry & 1; /* get the last bit, LSB */
 
  s = x ^ y ^ c;
  co = (c & (x ^ y)) | (x & y); 

  *sumptr = s; 
  *carryoutptr = co;
}

/* adds the four LSBs of a and b and cin using fulladdr() 
   and places the results into *sumptr and *carryoutptr */
void add4(int a, int b, int incarry, int *sumptr, int *carryoutptr)
{
  int x, y, s, c, co, sum, i;

  sum = 0 ; 
  x = a; 
  y = b; 
  c = incarry; /* initially */

  for (i = 0; i < 4; i++)
  {
     if (debug == 1) 
	 {
       printf("add4: before FA, step %d: x=%d, y=%d, cin%d\n", i, x, y, c);
       printbits(x, "x");
       printbits(y, "y");
     }
     
     /* add LSB of x and y with carryin */
     fulladdr(x, y, c, &s, &co);

     /* update x, y, c, sum */
     x = x >> 1;  /* get the next bit to the left */
     y = y >> 1;  /* get the next bit to the left */

     sum = sum | (s << i); /* move the FA sum to the right by one bit position */
     c = co;

     if (debug == 1) 
	 {
       printf("add4: step %d: s=%d, co=%d\n", i, s, co);
       printbits(sum, "sum");
       printbits(c, "carry");
       printf("\n");
     }
  }

  *sumptr = sum;
  *carryoutptr = c;
}

/* adds the 16 LSBs of a and b and cin using add4() 
   and and places the results into *sumptr and *carryoutptr */
void add16(int a, int b, int incarry, int *sumptr, int *carryoutptr)
{
  int x, y, s, c, co, sum,i;

  sum = 0 ; 
  x = a; y = b; c = incarry; /* initially */

  for (i = 0; i < 4; i++)
  {
     if (debug == 2) 
	 {
       printf("add16: before add4, step %d: x=%d, y=%d, cin%d\n", i, x, y, c);
       printbits(x, "x");
       printbits(y, "y");
     }
     
     /* add LSB of x and y with carryin */
     add4(x, y, c, &s, &co);

     /* update x, y, c, sum */
     x = x >> 4;  /* get the next bit to the left */
     y = y >> 4;  /* get the next bit to the left */

     sum = sum | (s << (i*4)); /* move the FA sum to the right by 4 bit positions */
     c = co;

     if (debug == 2) 
	 {
       printf("add16: step %d: s=%d, co=%d\n", i, s, co);
       printbits(sum, "sum");
       printbits(c, "carry");
       printf("\n");
     }
  }

  *sumptr = sum;
  *carryoutptr = c;
}

/* finds magnitude of a (lower order 4 bits) using an add4 and xors */
void magnitude4(int a, int *rslt)
{
	int x = a & 0xF;
	int i, y = 0, sum, c;
	
	for(i=0; i<4; i++)
		y |= (((x>>3)&1)<<i); // let y = x>>3, where >> is signed right shift
	
	add4(x, y, 0, &sum, &c);
	*rslt = sum ^ y;
}

/* generates odd parity for lower order 3 bits in a */
void parity4(int a, int *outparity)
{
	int i;
	*outparity = a&1;
	for(i=1; i<3; i++)
	{
		a >>= 1;
		*outparity ^= a&1;
	}
}

/* connects one of the 2 inputs (lower order bits in a and b) to out based 
   on 1 selection input (lowest order bit of c) */
void mux2x1(int a, int b, int select, int *out)
{
	int x, y, s, i;

	s = select & 1;
	*out = 0;
	
	/* here lower order 8 bits */
	for(i=0; i<8; i++)
	{
		x = a & 1;
		y = b & 1;
		
		*out |= ((s&x) | ((~s)&y)) << i;
		
		a >>= 1;
		b >>= 1;
	}
}

// prints all bits in groups of 8 bits
void printresult(char *label, int a)
{
  int i;

  // print label if any
  if (label)
    printf("%s:\t", label);

  for (i = sizeof(int)*8-1; i>=0; i--) 
  {
    printf("%c", '0'+((a>>i)&1));
    if ( i % 8 == 0 )
	  printf(" ");
  }
  printf("\n");
}
编译命令：
flex calc.lex
yacc -y -d calc.yacc
gcc -o calc *.c -lfl

gcc编译后会一个warning，不用管它
calc.yacc: In function ‘yyparse’:
calc.yacc:7:5: warning: format ‘%s’ expects argument of type ‘char *’, but argument 2 has type ‘YYSTYPE’ [-Wformat=]
 statement: NAME '=' expression { printf("pretending to assign %s the value %d\n", $1, $3); }
     ^
运行示例
./calc
3 4 - 5 *
scanned the number 3
Recognized a number.
skipped whitespace
scanned the number 4
skipped whitespace
found other data "-"
Recognized '-' expression.
skipped whitespace
scanned the number 5
skipped whitespace
found other data "*"
Recognized '-' expression.
reached end of line
= -5

./calc
-5
found other data "-"
scanned the number 5
Recognized a number.
reached end of line
= -5

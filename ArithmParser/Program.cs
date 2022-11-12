using Antlr4.Runtime;
using ArithmParser;


string input = "5*6+9*3-1";

Console.WriteLine($"INPUT: {input}\n");

ICharStream stream = CharStreams.fromString(input);

aritmeticaLexer lexer = new aritmeticaLexer(stream);

CommonTokenStream tokens = new CommonTokenStream(lexer);

aritmeticaParser parser = new aritmeticaParser(tokens);

var tree = parser.aritmetica();

Aritmetica aritmetica = new Aritmetica();

int resultado = aritmetica.Visit(tree);
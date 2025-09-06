*I must save here what I learned
*Ler a documentacao da tecnologia que voce esta usando

Static modifier:
Imagina que você tem uma caixa de ferramentas. Nessa caixa, tem uma **chave de fenda especial** que **todo mundo pode usar direto**, sem precisar montar ou criar nada. Essa chave é como um método `static`.

---

### 🧰 Exemplo com e sem `static`

#### 🔹 Quando algo é `static`:

Você pode usar direto!  
É como se dissesse:  
**"Ei, pode usar essa ferramenta agora mesmo!"**

### 💡 Então, resumindo:

- `static` é quando você **não precisa montar nada** para usar.
    
- Sem `static`, você **precisa criar** o objeto primeiro.
    
- É como ter **uma ferramenta pronta** ou uma que você precisa montar antes de usar.
This nos construtores
### Por que usamos `this`?

No construtor ali em cima, você recebe três valores:

- `nome`
    
- `idade`
    
- `altura`
    

Esses são **parâmetros do construtor**.

Mas a classe também tem variáveis **com o mesmo nome**.

Então se você escreve só:

`nome = nome;`

O C# **não sabe** se você está falando do parâmetro ou da variável da classe. Ele acha que você está dizendo: "o nome é igual ao nome", o que não ajuda em nada.

---

### ✅ O que o `this` faz então?

Quando você escreve:

`this.nome = nome;`

Você está dizendo:

- **`this.nome`** → é o nome da **classe**, o que vai ser guardado.
    
- **`nome`** → é o nome que foi passado no construtor.
    

Ou seja:  
👉 "**Guarda o nome que recebi dentro do nome da classe.**"

---

### 🧠 Em resumo:

|Palavra|Significa|
|---|---|
|`this`|o próprio objeto que está sendo criado|
|`this.nome`|o nome que pertence ao objeto|
|`nome`|o nome que veio como parâmetro|

	Abstract Classes

*the abstract identifier function is to don't let the classes missing components be used*

	Lists
The list is a Array that is more dynamical providing a simplier grammar

Here are all the commands to an Array:
//
songs.Add("Phonk"); //adds a new item to the list

songs.Add("Rock");

songs.Remove("Rock"); //remove a item from the list

songs.Insert(1, "Pop"); // insert a item in a selected position of the list

songs.Add("Phonk");

songs.LastIndexOf("Phonk"); // searches for the last position of the given item

Console.WriteLine(songs.Contains("Rock")); // its gonna return true or false if it contains the solicited item 
//needs a writeline to show the answer

Console.WriteLine(songs.IndexOf("Phonk")); //show the position of the written item

songs.Sort(); // show our list in alphabetical order

songs.Reverse(); //show our list in reverse order

songs.Clear(); // clear our list

Console.WriteLine(songs.Count); // indicate the number of items in the list

string[] songsdiff = songs.ToArray(); // converts the list to a normal array
//

	String Built-in Methods
	
ToUpper make the cases be capital
ToLower make the cases be lower case

.Length provide the number of cases of our string

	ToString() Method

//basically the ToString method returns a string representation of the object
e.g. Car.Namespace

However, If we override the Build-in ToString method we can make it return something different, like the variables from the object or better, the identification from the object

e.g.: return "This is a " + name + " and it costs " + value;

	Random Method
First of all you create a new random with: Random variablenumber = new Random();
okay, it will generate you a random number, but if you want to set a right range of numbers to be random you'll have to use the random.next method e.g.: variablenumber.next( 1, 100) for example

	While Loops
What are while loops?
The while loop is a loop that until a information be false it's not gonna stop running

So the while loop is good for programs that need a true information, so it's gonna run until it becomes false.

syntax: while (variable == false) {
 keep running until it's true
}

	Switches
// the switch is used when you have many different values to write in the code. it can be a really good substitute of the if and else because the syntax is smaller.

syntax:
switch (data) {
case 1:
Console.WriteLine("blahblahblah");
break;
} 

	For Loops
// the for loop you set when it will stop. it's not as the same as the while loop which only stop when the value comes false so it stop

syntax
for (int i = 0; i < 10;  i++) {
Console.WriteLine("something"); it's gonna be ran 10 times
}

	Methods
the methods, they can be used to use less code, because we create a block of code
for example

 static void namedogs(string dogs) //here we create the method
{
    Console.WriteLine("Here's you're dogs: " + dogs);
}

to use it in our main code we have to write the name of the method followed by the variables that are passed as parameters in the methods.

	Arrays
What are arrays? the arrays are like a folder that must have a tipe of document that you will receive. creating a array you'll have to write what kind of variable you'll receive, and how many variables are gonna fit there
syntax:
int[] numbers = new int[10] an array of ten numbers that it's gonna fit 10 numbers
to access a array element you have to type:
nameofthearray[0"The position of the element and it begins with 0"]

Easy ways to show a array:

for (int i = 0; i <numbers.Length"This part changes depending of the type of variable";) {
Console.WriteLine("numbers[i]");
} //the i is gonna pass through the entire array
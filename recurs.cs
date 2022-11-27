
using System;

class Ejercicio{
    static void Main(){
        string[] choices = {"[recurs] Elevar", "[iterable] Elevar", "Parar"};
        string choice;
        do{
            choice = askChoice(choices);

            switch(choice){
                case 0:
                    goto case 13;
                case 1:
                    goto case 13;
                case 13:
                    int elevate_number = askString("Número a elevar: ");
                    int elevate_to = askString("Elevar a: ");
                    displayLine(String.Format("{0}^{1} = {2}", 
                    elevate_number, elevate_to, elevar(elevate_number, elevate_to, mode=choice)));
                    break;
                    
            }
        }while(choice != 2);
    }

    static int fibo(int n, int old = 0, int next = 1){
        if (n == 0) return old+next;
        return fibo(n-1, next, old+next);
    }

    static int elevar(int num, int to, int mode=0){
        if(mode == 0) return elevarNumRecurs(num, to);
        return elevarNumIter(num, to);
    }

    static int elevarNumIter(int num, int to){
        int resultado = 1;
        for(int i = to; i > 0; i--){
            resultado *= num;
        }
        return resultado;
    }

    static int elevarNumRecurs(int num, int to){
        if(to == 0) return 1;
        return num * elevarNum(num, to-1);
    }

    static string askChoice(string[] choices){
        displayEnumeratedLines(choices);
        return askInt("Opción");
    }

    static void displayLines(string[] lines){
        for(int i = 0; i<lines.Length; i++){
            displayLine(lines[i]);
        }
    }

    static void displayEnumeratedLines(string[] lines){
        for(int i = 0; i<lines.Length; i++){
            displayLine("{0}{1}", i+1, lines[i]);
        }
    }

    static int askInt(string text=""){
        int number;
        while(true){
            try{
                number = Convert.ToInt32(askString(text));
                return number;
            }catch(exception){
                displayLine("Error, debe ser un número.");
            }
        }
    }

    static double askDouble(string text=""){
        int number;
        while(true){
            try{
                number = Convert.ToInt64(askString(text));
                return number;
            }catch(exception){
                displayLine("Error, debe ser un número.");
            }
        }
    }

    static string askString(string text=""){
        displayLineNotEmpty(text, end=": ");
        return Console.ReadLine();
    }

    static void displayLineNotEmpty(string text="", string end="\n"){
        if (text != "") displayLine(text, end);
    }

    static void displayLine(string text="", string end="\n"){
        Console.WriteLine("{0}{1}", text, end);
    }
}
namespace AtividadeDesafios;

public class Desafios
{
    public void Desafio01(){
        Console.WriteLine("Insira um valor: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int dobro = num * 2;
        int triplo = num * 3;
        double raiz = Math.Sqrt(num);
        
        Console.WriteLine("Dobro do valor: " + dobro);
        Console.WriteLine("Triplo do valor: " + triplo);
        Console.WriteLine("Raiz do valor: " + raiz);
    }

    public void Desafio02(){
        int nota1, nota2, media;

        Console.WriteLine("Insira a primeira nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira a segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        media = ( nota1 + nota2 ) / 2;
        Console.WriteLine("Média: " + media);
    }

    public void Desafio03(){
        Console.WriteLine("Insira a medida (metros): ");
        double medida = Convert.ToDouble(Console.ReadLine());

        double centimetros = medida * 100;
        double milimetros = medida * 1000;

        Console.WriteLine("Medida em centimetros: " + centimetros + "cm");
        Console.WriteLine("Medida em milimetros: " + milimetros +"mm");
    }

    public void Desafio04(){
        Console.WriteLine("Insira o valor: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= 10; i++){
            Console.WriteLine(num + " X " + i + " = " + num * i);
        }
    }

    public void Desafio05(){
        double reais, dolares;
        Console.WriteLine("Insira o valor em reais que deseja converter: ");
        Console.Write("R$");
        reais = Convert.ToDouble(Console.ReadLine());

        dolares = reais * 5;

        Console.WriteLine("Você tem: US$" + dolares.ToString("0.00"));
    }

    public void Desafio06(){
        Console.WriteLine("Insira a altura (em metros) da parede: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira a largura (em metros) da parede: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        double area = altura * largura;
        double tinta = area / 2;

        Console.WriteLine("Área total para pintura: " + area.ToString("0.00") + "m");
        Console.WriteLine("Você precisa de ao menos " + tinta + " litros de tinta para pintar a parede");
    }

    public void Desafio07(){
        Console.WriteLine("Insira o preço do produto: ");
        Console.Write("R$");
        double preco = Convert.ToDouble(Console.ReadLine());

        preco = preco * 0.95;

        Console.WriteLine("Preço com desconto: R$" + preco.ToString("0.00"));
    }

    public void Desafio08(){
        Console.WriteLine("Insira o valor do salário: ");
        Console.Write("R$");
        double salario = Convert.ToDouble(Console.ReadLine());

        salario = salario * 1.15;

        Console.WriteLine("Novo salário: R$" + salario.ToString("0.00"));
    }

    public void Desafio09(){
        Console.WriteLine("Insira a temperatura em celcius: ");
        double temperatura = Convert.ToDouble(Console.ReadLine());

        temperatura = temperatura * 1.8 + 32;
        Console.WriteLine("Temperatura em fahrenheit: "  + temperatura);
    }

    public void Desafio10(){
        Console.WriteLine("Quantos Km foram rodados com o carro?");
        double distancia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Quantos dias foram alugados? ");
        int dias = Convert.ToInt32(Console.ReadLine());

        double total = dias * 60 + distancia * 0.15;
        Console.WriteLine("Valor total: R$" + total.ToString("0.00"));
    }

    public void Desafio11(){

        Console.WriteLine("Quantos alunos deseja cadastrar?");
        int qtd = Convert.ToInt32(Console.ReadLine());
        string[] nomes = new string[qtd];

        for(int i = 0; i < qtd; i++){
            Console.Write("Insira o nome do aluno ("+ (i+1) +"):");
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine("Lista de alunos: ");
        for (int i = 0; i<qtd; i++){
            Console.WriteLine(nomes[i]);
        }
    }

    public void Desafio12(){
        Console.WriteLine("Quantos alunos deseja cadastrar?");
        int qtd = Convert.ToInt32(Console.ReadLine());

        List<String> nomes = new List<String>();

        for(int i = 0; i < qtd; i++){
            Console.Write("Insira o nome do aluno ("+ (i+1) +"):");
            nomes.Add(Console.ReadLine());
        }

        nomes.Sort();

        Console.WriteLine("Lista de alunos: ");
        for (int i = 0; i<qtd; i++){
            Console.WriteLine(nomes[i]);
        }
    }

    public void Desafio13(){
        Random random = new Random();
        Console.WriteLine("Quantos alunos deseja cadastrar?");
        int qtd = Convert.ToInt32(Console.ReadLine());

        List<String> nomes = new List<String>();

        for(int i = 0; i < qtd; i++){
            Console.Write("Insira o nome do aluno ("+ (i+1) +"):");
            nomes.Add(Console.ReadLine());
        }

        int escolhido = random.Next(qtd);

        Console.WriteLine("Aluno escolhido: " + nomes[escolhido]);
    }

    public void Desafio14(){
        List<String> nomes = new List<String>();
        Random random = new Random();

        Console.WriteLine("Quantos alunos deseja cadastrar?");
        int qtd = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < qtd; i++){
            Console.Write("Insira o nome do aluno ("+ (i+1) +"):");
            nomes.Add(Console.ReadLine());
        }

        var shuffled = nomes.OrderBy(_ => random.Next()).ToList();
        Console.WriteLine(String.Join(", ", shuffled));
    }

    public void Desafio15(){
        List<String> nomes = new List<String>();
        Random random = new Random();

        Console.WriteLine("Quantos alunos deseja cadastrar?");
        int qtd = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < qtd; i++){
            Console.Write("Insira o nome do aluno ("+ (i+1) +"):");
            nomes.Add(Console.ReadLine());
        }

        var shuffled = nomes.OrderBy(_ => random.Next()).ToList();
        int escolhido = random.Next(qtd);

        Console.WriteLine("Aluno escolhido: " + shuffled[escolhido]);
    }

    public void Desafio16(){
        Console.WriteLine("Insira um numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num % 2 == 0){
            Console.WriteLine("O numero " + num + " é par!");
        } else {
            Console.WriteLine("O numero " + num + " é impar!");
        }
    }

    public void Desafio17(){
        Console.WriteLine("Insira o nome do usuário: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Olá meu nome é: " + nome);
        Console.WriteLine("Nome em maiusculo: " + nome.ToUpper());
        Console.WriteLine("Nome em minusculo: " + nome.ToLower());

        string[] nomeSeparado = nome.Split(' ');
        int totalLetras = 0;
        foreach(string palavra in nomeSeparado){
            totalLetras = totalLetras + palavra.Length;
        }
        
        Console.WriteLine("Quantidade de letras: " + totalLetras);

        Console.WriteLine("Letras no primeiro nome: " + nomeSeparado[0].Length);
    }

    public void Desafio18(){
        double total = 0, num1, num2;
        Console.WriteLine("Qual operação deseja realizar? ");
        Console.WriteLine("1 - soma");
        Console.WriteLine("2 - subtração");
        Console.WriteLine("3 - multiplicação");
        Console.WriteLine("4 - divisão");
        int operacao = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o primeiro valor: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira o segundo valor: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        switch(operacao){
            case 1:
                total = num1 + num2;
                break;
            case 2:
                total = num1 - num2;
                break;
            case 3:
                total = num1 * num2;
                break;
            case 4:
                if(num2 == 0){
                    Console.WriteLine("Impossível dividir por zero!");
                    operacao = 0;
                } else {
                    total = num1 / num2;
                }
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        if(operacao>=1 && operacao<=4){
            Console.WriteLine("Total: "+ total);
        }
    }

    public void Desafio19(){
        Console.WriteLine("Insira a idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        if(idade<18){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sem persmissão!", Console.ForegroundColor);
        } else {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Permissão concedida!", Console.ForegroundColor);
        }
    }

    public void Desafio20(){
        Console.WriteLine("Insira uma frase:");
        string frase = Console.ReadLine();

        frase = frase.Replace('A', 'a').Replace('a', '&');

        Console.WriteLine("Frase ajustada: " + frase);
    }

    public void Desafio21(){
        Console.WriteLine("Insira o valor do salário: ");
        Console.Write("R$");
        double salario = Convert.ToDouble(Console.ReadLine());

        if (salario < 1700){
            salario = salario + 300;
        } else {
            salario = salario + 200;
        }

        Console.WriteLine("Novo salário: R$" + salario.ToString("0.00"));
    }

    public void Desafio22(){
        double peso, altura, imc;
        Console.WriteLine("Insira o peso: ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira a altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        imc = peso / Math.Pow(altura, 2);

        Console.WriteLine("Seu IMC é: " + imc.ToString("0.0"));
    }

    public void Desafio23(){
        double altura, largura, profundidade, volume;

        Console.WriteLine("Insira a altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira a largura: ");
        largura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira a profundidade: ");
        profundidade = Convert.ToDouble(Console.ReadLine());

        volume = altura * largura * profundidade;

        Console.WriteLine("O volume total é de " + volume.ToString("0.00") + "m³");
    }

    public void Desafio24(){
        double altura, raio, volume;

        Console.WriteLine("Insira a altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o raio: ");
        raio = Convert.ToDouble(Console.ReadLine());

        volume = 3.14 * Math.Pow(raio, 2) * altura;

        Console.WriteLine("O volume total é de " + volume.ToString("0.00") + "m³");
    }

    public void Desafio25(){
        Console.WriteLine("Insira o primeiro valor: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o segundo valor: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double total = Math.Pow((num1 - num2), 2);
        Console.WriteLine("Quadrado da diferença: " + total);
    }

    public void Desafio26(){
        Console.WriteLine("Insira o valor do raio da esfera: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double total = (4 * 3.14 * Math.Pow(raio, 3)) / 3;
        Console.WriteLine("Área da esfera: " + total.ToString("0.00") + "m³");
    }

    public void Desafio27(){
        Console.WriteLine("Insira o primeiro valor:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o segundo valor: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 + num2;
        Console.WriteLine("Soma = " + soma);

        double sub = num1 - num2;
        Console.WriteLine("Subtração = " + sub);

        double mult = num1 * num2;
        Console.WriteLine("Multiplicação = " + mult);

        if(num2 == 0){
            Console.WriteLine("Impossivel dividir por zero!");
        }else{
            double div = num1 / num2;
            Console.WriteLine("Divisão = "+ div);
        }
    }

    public void Desafio28(){
        Console.WriteLine("Quantos km o carro faz por litro? ");
        double kmPorLitro = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Quantos km o carro percorreu? ");
        double distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

        double resultado = distanciaPercorrida / kmPorLitro;

        Console.WriteLine("O carro consumiu " + resultado.ToString("0.000") + " Litros de gasolina");
    }

    public void Desafio29(){
        Console.WriteLine("Qual o valor original do produto?");
        Console.Write("R$");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual a porcentagem de juros por mês?");
        Console.Write("%");
        double taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A quantos meses está atrasado?");
        double periodo = Convert.ToDouble(Console.ReadLine());

        double total = valor * ((1+( taxaJuros/100 ) * periodo));

        Console.WriteLine("O valor total do débito é de: R$" + total.ToString("0.00"));
    }

    public void Desafio30(){
        List<int> lista = new List<int>();

        for(int i = 0; i <5; i++){
            Console.WriteLine("Insira um numero:");
            lista.Add(Convert.ToInt32(Console.ReadLine()));
        }

        int menor = lista[0];
        int maior = lista[0];

        for (int i = 0; i<5; i++){
            if (lista[i] < menor){
                menor = lista[i];
            }
            if(lista[i] > maior){
                maior = lista[i];
            }
        }

        Console.WriteLine("Maior numero: " + maior);
        Console.WriteLine("Menor numero: " + menor);
    }

    public void Desafio31(){
        Console.WriteLine("Informe um numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num%2==0){
            Console.Write("O numero é par, multiplo de 2");
        } else {
            Console.Write("O numero é impar");
        }

        if (num%3==0){
            Console.Write(", multiplo de 3");
        }

        if (num%5==0){
            Console.Write(", multiplo de 5");
        }

        Console.WriteLine(", e não tenho mais nada a dizer sobre.");

    }
}

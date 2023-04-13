using MonsterDog;


Caixa caixa = new Caixa(100);
Produtos g = new Produtos();
ListaGenerica<String> lista = new ListaGenerica<String>(10);
ListaGenerica<int> codigo = new ListaGenerica<int>(10);
ListaGenerica<double> valuee = new ListaGenerica<double>(10);
Valores<double> valores = new Valores<double>(10);
int tamanhoMax = 100;
string nome = "";
string opcao = "";
string id = "";
double valor = 0;
int cadastra = 0;
Console.Clear();
bool ok = true;
while (ok == true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;    
    Console.WriteLine(@"
███╗░░░███╗░█████╗░███╗░░██╗░██████╗████████╗███████╗██████╗░  ██████╗░░█████╗░░██████╗░
████╗░████║██╔══██╗████╗░██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗  ██╔══██╗██╔══██╗██╔════╝░
██╔████╔██║██║░░██║██╔██╗██║╚█████╗░░░░██║░░░█████╗░░██████╔╝  ██║░░██║██║░░██║██║░░██╗░
██║╚██╔╝██║██║░░██║██║╚████║░╚═══██╗░░░██║░░░██╔══╝░░██╔══██╗  ██║░░██║██║░░██║██║░░╚██╗
██║░╚═╝░██║╚█████╔╝██║░╚███║██████╔╝░░░██║░░░███████╗██║░░██║  ██████╔╝╚█████╔╝╚██████╔╝
╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝  ╚═════╝░░╚════╝░░╚═════╝░");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine(@"
░█████╗░  ░██████╗░██╗░░░██╗███████╗  ██████╗░███████╗░██████╗███████╗░░░░░██╗░█████╗░░█████╗░
██╔══██╗  ██╔═══██╗██║░░░██║██╔════╝  ██╔══██╗██╔════╝██╔════╝██╔════╝░░░░░██║██╔══██╗██╔══██╗
██║░░██║  ██║██╗██║██║░░░██║█████╗░░  ██║░░██║█████╗░░╚█████╗░█████╗░░░░░░░██║███████║╚═╝███╔╝
██║░░██║  ╚██████╔╝██║░░░██║██╔══╝░░  ██║░░██║██╔══╝░░░╚═══██╗██╔══╝░░██╗░░██║██╔══██║░░░╚══╝░
╚█████╔╝  ░╚═██╔═╝░╚██████╔╝███████╗  ██████╔╝███████╗██████╔╝███████╗╚█████╔╝██║░░██║░░░██╗░░
░╚════╝░  ░░░╚═╝░░░░╚═════╝░╚══════╝  ╚═════╝░╚══════╝╚═════╝░╚══════╝░╚════╝░╚═╝░░╚═╝░░░╚═╝░░");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine(@"
▄▀█ ▀▄   █▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ ▄▀█ █▀█   █▀█ █▀█ █▀█ █▀▄ █░█ ▀█▀ █▀█
█▀█ ▄▀   █▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▀█ █▀▄   █▀▀ █▀▄ █▄█ █▄▀ █▄█ ░█░ █▄█");
    Console.WriteLine("");
    Console.WriteLine(@"
█▄▄ ▀▄   █▀▀ █▀█ █▄▄ █▀█ ▄▀█ █▀█
█▄█ ▄▀   █▄▄ █▄█ █▄█ █▀▄ █▀█ █▀▄");
    Console.WriteLine("");
    Console.WriteLine(@"
█▀▀ ▀▄   █▀▀ █▀▀ █▀▀ █░█ ▄▀█ █▀▄▀█ █▀▀ █▄░█ ▀█▀ █▀█   █▀▄ █▀▀   █▀▀ ▄▀█ █ ▀▄▀ ▄▀█
█▄▄ ▄▀   █▀░ ██▄ █▄▄ █▀█ █▀█ █░▀░█ ██▄ █░▀█ ░█░ █▄█   █▄▀ ██▄   █▄▄ █▀█ █ █░█ █▀█");
    Console.WriteLine("");
    Console.WriteLine("");

    opcao = Console.ReadLine();
    opcao = opcao.ToUpper();

    if (opcao == "A")
    {
        Console.Clear();
        Console.WriteLine(@"
█▀█ █░█ ▄▀█ █▄░█ ▀█▀ █▀█ █▀   █▀█ █▀█ █▀█ █▀▄ █░█ ▀█▀ █▀█ █▀   █▀▄ █▀▀ █▀ █▀▀ ░░█ ▄▀█
▀▀█ █▄█ █▀█ █░▀█ ░█░ █▄█ ▄█   █▀▀ █▀▄ █▄█ █▄▀ █▄█ ░█░ █▄█ ▄█   █▄▀ ██▄ ▄█ ██▄ █▄█ █▀█

█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ ▄▀█ █▀█ ▀█
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▀█ █▀▄ ░▄");
        Console.WriteLine("");
        Console.WriteLine("");
        cadastra = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cadastra; i++)
        {
            Console.WriteLine(@"
█▀▄ █ █▀▀ █ ▀█▀ █▀▀   █▀█   █ █▀▄   █▀▄ █▀█   █▀█ █▀█ █▀█ █▀▄ █░█ ▀█▀ █▀█
█▄▀ █ █▄█ █ ░█░ ██▄   █▄█   █ █▄▀   █▄▀ █▄█   █▀▀ █▀▄ █▄█ █▄▀ █▄█ ░█░ █▄█");
            Console.WriteLine("");
            Console.WriteLine("");
            id = Console.ReadLine();
            Console.WriteLine(@"
█▀▄ █ █▀▀ █ ▀█▀ █▀▀   █▀█   █▄░█ █▀█ █▀▄▀█ █▀▀   █▀▄ █▀█   █▀█ █▀█ █▀█ █▀▄ █░█ ▀█▀ █▀█
█▄▀ █ █▄█ █ ░█░ ██▄   █▄█   █░▀█ █▄█ █░▀░█ ██▄   █▄▀ █▄█   █▀▀ █▀▄ █▄█ █▄▀ █▄█ ░█░ █▄█");
            Console.WriteLine("");
            Console.WriteLine("");
            nome = Console.ReadLine();
            Console.WriteLine(@"
█▀▄ █ █▀▀ █ ▀█▀ █▀▀   █▀█   █░█ ▄▀█ █░░ █▀█ █▀█   █▀▄ █▀█   █▀█ █▀█ █▀█ █▀▄ █░█ ▀█▀ █▀█
█▄▀ █ █▄█ █ ░█░ ██▄   █▄█   ▀▄▀ █▀█ █▄▄ █▄█ █▀▄   █▄▀ █▄█   █▀▀ █▀▄ █▄█ █▄▀ █▄█ ░█░ █▄█");
            Console.WriteLine("");
            Console.WriteLine("");
            valor = Convert.ToDouble(Console.ReadLine());            
            lista.inserir(nome, id);
            valores.inserirValor(valor);
            Console.Clear();
        }
    }

    double conta;
    double calcula = 0;

    if (opcao == "B")
    {
        for (int i = 0; i < tamanhoMax; i++)
        {
            Console.Clear();

            g.imprimeprodutos();
            for (int j = 0; j < lista.getTamanho(); j++)
            {                
                Console.WriteLine(lista.getIndex(j) + " R$ " + valores.getIndexValor(j));
            }
            Console.WriteLine("");
            Console.WriteLine(@"
█▀▄ █ █▀▀ █ ▀█▀ █▀▀   █▀█   █ █▀▄   █▀▄ █▀█   █▀█ █▀█ █▀█ █▀▄ █░█ ▀█▀ █▀█   █▀█ █░█ █▀▀
█▄▀ █ █▄█ █ ░█░ ██▄   █▄█   █ █▄▀   █▄▀ █▄█   █▀▀ █▀▄ █▄█ █▄▀ █▄█ ░█░ █▄█   ▀▀█ █▄█ ██▄

█▀▄ █▀▀ █▀ █▀▀ ░░█ ▄▀█ █▀█   █▀ █▀▀ █░░ █▀▀ █▀▀ █ █▀█ █▄░█ ▄▀█ █▀█
█▄▀ ██▄ ▄█ ██▄ █▄█ █▀█ █▀▄   ▄█ ██▄ █▄▄ ██▄ █▄▄ █ █▄█ █░▀█ █▀█ █▀▄");
            Console.WriteLine("");
            Console.WriteLine("");
            conta = Convert.ToDouble(Console.ReadLine());
            Console.Clear();            
            caixa.Conta(conta);
            double value = caixa.Conta(conta);
            caixa.InserirLancamento(value);
            calcula = caixa.Conta(conta);
            caixa.contaprevia(calcula);           
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(@"
▄█   ▄▄   █▀▀ █▀█ █▄░█ ▀█▀ █ █▄░█ █░█ ▄▀█ █▀█
░█   ░░   █▄▄ █▄█ █░▀█ ░█░ █ █░▀█ █▄█ █▀█ █▀▄");
            Console.WriteLine(@"
▀█   ▄▄   █▀ ▄▀█ █ █▀█
█▄   ░░   ▄█ █▀█ █ █▀▄");
            Console.WriteLine("");
            Console.WriteLine("");
            int continua;
            continua = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (continua == 1)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine(@"
█░█ ▄▀█ █░░ █▀█ █▀█   ▀█▀ █▀█ ▀█▀ ▄▀█ █░░ ▀
▀▄▀ █▀█ █▄▄ █▄█ █▀▄   ░█░ █▄█ ░█░ █▀█ █▄▄ ▄  R${0}", caixa.TrazConta());
                caixa.Zerarcontaprevia();
                for (int l = 0; l < 10; l++)
                {
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                }
                Console.Write(".");
                Console.Clear();         
                break;
            }
        }
    }
    int continuar2;
    
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (opcao == "C")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine(@"
█░█ ▄▀█ █░░ █▀█ █▀█   ▀█▀ █▀█ ▀█▀ ▄▀█ █░░   █▀▀ █▀▄▀█   █░█ █▀▀ █▄░█ █▀▄ ▄▀█ █▀ ▀
▀▄▀ █▀█ █▄▄ █▄█ █▀▄   ░█░ █▄█ ░█░ █▀█ █▄▄   ██▄ █░▀░█   ▀▄▀ ██▄ █░▀█ █▄▀ █▀█ ▄█ ▄  {0} ", caixa.Fechamento());
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(@"
▄█   ▄▄   █▀▀ █▀█ █▄░█ ▀█▀ █ █▄░█ █░█ ▄▀█ █▀█
░█   ░░   █▄▄ █▄█ █░▀█ ░█░ █ █░▀█ █▄█ █▀█ █▀▄");
        Console.WriteLine(@"
▀█   ▄▄   █▀ ▄▀█ █ █▀█
█▄   ░░   ▄█ █▀█ █ █▀▄");
        Console.WriteLine("");
        Console.WriteLine("");
        continuar2 = Convert.ToInt32(Console.ReadLine());
        if (continuar2 == 1)
        {
            Console.Clear();            
        }
        else if (continuar2 == 2)
        {
            break;
            
        }

    }
   

}


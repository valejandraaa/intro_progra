using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_dado_proyecto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se inicializa un objeto de tipo Tablero
            Tablero tablero = new Tablero();

            //Se inicia el tablero
            tablero.iniciarTablero();
        }
    }

    class Dado
    {

        //variable para generar los números aleatorios
        private static Random numeroRandom;

        //variable para guardar el resultado del dado
        private int resultado;


        public int Resultado { get => resultado; }


        // Constructor de la clase Dado
        static Dado()
        {
            // Inicializar la instancia de Random           
            numeroRandom = new Random();
        }

        // Método para lanzar el dado y devolver un número entre 1 y 6
        public int LanzarDado()
        {
            // Generar un número aleatorio entre 1 y 6
            resultado = numeroRandom.Next(1, 7);
            return Resultado;
        }

        //Metodo para generar la representación en una cadena del dado con el numero resultado
        public string DibujarDado()
        {
            string[] dados = new string[]
            {
            "+-------+",
            "|       |",
            "|   *   |",
            "|       |",
            "+-------+"
            };

            // Reemplazar el espacio reservado "*" con el número del dado
            dados[2] = dados[2].Replace('*', char.Parse(resultado.ToString()));

            // Unir las líneas del dado en un solo string
            return string.Join("\n", dados);
        }


    }

    class Jugador
    {

        //variable para almacenar el nombre del jugador
        private string nombre;

        //variables para llevar el control del resultado de las partidas y tiros
        private int punteoAcumulado;
        private int punteoTiro;
        private int sumaResultadoDados;

        //varibales para las estadisticas del jugador
        private bool primeraTirada;
        private int cantidadTirosRealizados;
        private int cantidadTirosGanados;
        private double probabilidadGanar;
        private int cantidadTirosPares;
        private int cantidadTirosImpares;
        private int cantidadTirosIguales;


        //Constructor de la clase Jugador
        public Jugador(string NombreJugador)
        {
            Nombre = NombreJugador;

            primeraTirada = true;

        }

        //Se establecen las propiedades de cada atributo (get, set)		
        public string Nombre { get => nombre; set => nombre = value; }
        public int PunteoAcumulado { get => punteoAcumulado; set => punteoAcumulado = value; }
        public int CantidadTirosRealizados { get => cantidadTirosRealizados; }
        public int CantidadTirosGanados { get => cantidadTirosGanados; set => cantidadTirosGanados = value; }
        public int CantidadTirosPares { get => cantidadTirosPares; set => cantidadTirosPares = value; }
        public int CantidadTirosImpares { get => cantidadTirosImpares; set => cantidadTirosImpares = value; }
        public int CantidadTirosIguales { get => cantidadTirosIguales; set => cantidadTirosIguales = value; }
        public bool PrimeraTirada { get => primeraTirada; }
        public int SumaResultadoDados { get => sumaResultadoDados; }
        public double ProbabilidadGanar { get => probabilidadGanar; set => probabilidadGanar = value; }
        public int PunteoTiro { get => punteoTiro; set => punteoTiro = value; }


        //Funcion que realiza el lanzamiento de los dadas (generar los numeros) y devuelve la suma de ambos dados.
        public int TirarDados(Dado dado1, Dado dado2)
        {
            //Se valida si es el primer tiro del jugador
            if (cantidadTirosRealizados == 1)
            {
                primeraTirada = false;
            }

            //Se reinicia el punteo por cada tiro del jugador
            punteoTiro = 0;


            //Se llama al metodo de cada dado para generar los numeros aleatorios
            dado1.LanzarDado();
            dado2.LanzarDado();

            //Se suman los resultados de cada dado,
            sumaResultadoDados = dado1.Resultado + dado2.Resultado;

            //Se incrementa el contador de tiros realizados
            cantidadTirosRealizados += 1;


            return SumaResultadoDados;
        }


    }


    class Tablero
    {

        //objetos de tipo jugador 
        private Jugador jugador1;
        private Jugador jugador2;

        //Objetos de la clase dado
        private Dado dado1;
        private Dado dado2;

        //Objetos para saber el jugador actual y el ganador
        private Jugador jugadorActual;
        private Jugador jugadorGanador;

        private int IdJugadorActual;

        private bool ganador;

        //Configuración del tablero
        private int cantidadPartidas;
        private int cantidadTirosPartida;



        public Tablero()
        {

            // Inicializar las instancias de Dado
            dado1 = new Dado();
            dado2 = new Dado();

            // Inicializar las instancias de Jugador
            jugador1 = new Jugador("");
            jugador2 = new Jugador("");

            //Se establece el jugador actual
            jugadorActual = jugador1;
            IdJugadorActual = 1;

            //Se inicializa la variable ganador
            ganador = false;
        }


        //Metodo que inicializa la configuración de tablero
        public void iniciarTablero()
        {

            Console.WriteLine("++++++++++ JUEGO DE DADOS +++++++++\n");

            //Se solicita el nombre del jugador
            Console.Write("Ingrese su nombre: ");
            jugador1.Nombre = Console.ReadLine();

            jugador2.Nombre = "La Casa";


            //Se ingresa la cantidad de partidas
            Console.Write("Ingrese cantidad de partidas: ");
            cantidadPartidas = int.Parse(Console.ReadLine());

            //Se ingresa la cantidad de tiros por partidas
            Console.Write("Ingrese cantidad de tiros: ");
            cantidadTirosPartida = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            //Se inicializa el juego
            iniciarJuego();

        }

        //metodo que inicia el juego de dados
        private void iniciarJuego()
        {

            //Ciclo para llevar el control de la cantidad de partidas
            for (int contadorPartidas = 1; contadorPartidas <= cantidadPartidas; contadorPartidas++)
            {
                Console.WriteLine(String.Format("---------- PARTIDA NO. {0} ----------\n", contadorPartidas));

                //Ciclo para llevar el control de la cantidad de tiros por partida
                for (int contadorTirosPartida = 1; contadorTirosPartida <= cantidadTirosPartida; contadorTirosPartida++)
                {
                    Console.WriteLine(String.Format("+++++++++++++ TIRO: {0} +++++++++++++\n", contadorTirosPartida));

                    //Ciclo para realizar el tiro por cada jugador
                    for (int turnoJugador = 1; turnoJugador <= 2; turnoJugador++)
                    {

                        //Se llama al metodo para ejecutar el turno del jugador
                        turnoSiguiente();

                        //Se realiza el cambio de jugador
                        cambiaJugador();

                        //Se immprime el punteo de los jugador por cada tiro
                        Console.WriteLine("Punteo {0}: {1}", jugador1.Nombre, jugador1.PunteoTiro);
                        Console.WriteLine("Punteo {0}: {1}", jugador2.Nombre, jugador2.PunteoTiro);

                        //Se reinicia el punteo de tiro a los jugadores
                        jugador1.PunteoTiro = 0;
                        jugador2.PunteoTiro = 0;

                        Console.Write("\n");
                    }

                    //Se imprime el fin del Tiro
                    Console.WriteLine(String.Format("+++++++++++ FIN TIRO: {0} +++++++++++\n", contadorTirosPartida));
                }

                //Se imprimien los punteos acumulados de los jugadores
                Console.WriteLine("Punteo Acumulado {0}: {1}", jugador1.Nombre, jugador1.PunteoAcumulado);
                Console.WriteLine("Punteo Acumulado {0}: {1}", jugador2.Nombre, jugador2.PunteoAcumulado);

                //Se imprime el fin de cada partida
                Console.WriteLine(String.Format("\n-------- FIN PARTIDA NO. {0} --------\n\n", contadorPartidas));
            }

            //Se imprimien los resultados del juego
            MostrarResultadosJuego();

            Console.ReadKey();

        }

        //permite que cada jugador pueda lanzar los dados
        private void turnoSiguiente()
        {
            //Se lanzan los dados del jugador actual
            jugadorActual.TirarDados(dado1, dado2);

            //Se valida el resultado de los dados
            validaResultadoDados();

            //Se valida el punteo obtenido del jugador luego del lanzamiento
            validarPunteoJugador();

            //Se imprime el resultado de los dados a nivel de pantalla
            MostrarResultadoGraficoDados();

        }


        //Se valida el resultado obtenido de los dados en cada lanzamiento
        private void validaResultadoDados()
        {
            //Valida par o impar
            if ((dado1.Resultado + dado2.Resultado) % 2 == 0)
            {
                //Se incrementa el contador
                jugadorActual.CantidadTirosPares += 1;
            }
            else
            {
                //Se incrementa el contador
                jugadorActual.CantidadTirosImpares += 1;
            }

            //valida valores iguales
            if (dado1.Resultado == dado2.Resultado)
            {
                //Se incrementa el contador
                jugadorActual.CantidadTirosIguales += 1;
            }

        }


        //Permite validar las reglas del punteo del jugador
        private void validarPunteoJugador()
        {
            //Si es turno del jugador 1 (humano)
            if (IdJugadorActual == 1)
            {
                if (jugadorActual.PrimeraTirada && (jugadorActual.SumaResultadoDados == 12 || jugadorActual.SumaResultadoDados == 6))
                {
                    //Jugador actual gana puntos
                    jugadorActual.PunteoAcumulado += 12;
                    jugadorActual.PunteoTiro = 12;
                    //Se toma como tiro ganado
                    jugadorActual.CantidadTirosGanados += 1;
                }

                if (jugadorActual.PrimeraTirada &&
                    (jugadorActual.SumaResultadoDados == 4 || jugadorActual.SumaResultadoDados == 6 || jugadorActual.SumaResultadoDados == 10))
                {
                    //La casa gana puntos
                    jugador2.PunteoAcumulado += 12;
                    jugador2.PunteoTiro = 12;
                }

                if (jugadorActual.PunteoAcumulado == 0 && jugadorActual.SumaResultadoDados == 11)
                {
                    //La casa gana puntos
                    jugador2.PunteoAcumulado += 6;
                    jugador2.PunteoTiro = 6;
                }
            }

            //Se valida para cualquier jugador: Humano o La casa
            if (jugadorActual.SumaResultadoDados == 2 || jugadorActual.SumaResultadoDados == 3
                || jugadorActual.SumaResultadoDados == 5 || jugadorActual.SumaResultadoDados == 7
                || jugadorActual.SumaResultadoDados == 8 || jugadorActual.SumaResultadoDados == 9)
            {
                //El jugador gana puntos
                jugadorActual.PunteoAcumulado += jugadorActual.SumaResultadoDados;
                jugadorActual.PunteoTiro = jugadorActual.SumaResultadoDados;
                //Se toma como tiro ganado
                jugadorActual.CantidadTirosGanados += 1;
            }
        }


        //Permite realizar cambio de jugador y establecer el jugador actual
        private void cambiaJugador()
        {
            //Si es jugador 1 se cambia a jugador 2
            if (IdJugadorActual == 1)
            {
                jugador1 = jugadorActual;
                IdJugadorActual = 2;
                jugadorActual = jugador2;
            }
            else
            {
                //Se cambia a jugador 1
                jugador2 = jugadorActual;
                IdJugadorActual = 1;
                jugadorActual = jugador1;
            }
        }



        //Permite imprimir en pantalla la representación de los dados lanzados con su resultado
        private void MostrarResultadoGraficoDados()
        {
            Console.WriteLine(String.Format("Tira: {0} -> Suma de dados: {1}", jugadorActual.Nombre, jugadorActual.SumaResultadoDados));

            // Obtener las representaciones gráficas de los dos dados
            string dibujoDado1 = dado1.DibujarDado();
            string dibujoDado2 = dado2.DibujarDado();

            // Dividir las representaciones gráficas en líneas
            string[] lineasDado1 = dibujoDado1.Split('\n');
            string[] lineasDado2 = dibujoDado2.Split('\n');

            // Asegurarse de que las dos representaciones tengan la misma cantidad de líneas
            int maxLineas = Math.Max(lineasDado1.Length, lineasDado2.Length);

            //recorrer cada linea de los dados y mostrarla en pantalla
            for (int i = 0; i < maxLineas; i++)
            {
                Console.WriteLine(String.Format("{0} {1}", lineasDado1[i], lineasDado2[i]));
            }
            Console.Write("\n");
        }


        //Muestra el resultado del juego, establece si hay un ganador e imprime los resultados en pantalla
        private void MostrarResultadosJuego()
        {
            Console.WriteLine("\n++++++ RESULTADOS DEL JUEGO ++++++\n");

            //Se valida si existe un ganador
            if (jugador1.PunteoAcumulado > jugador2.PunteoAcumulado)
            {
                jugadorGanador = jugador1;
                ganador = true;
            }
            else if (jugador2.PunteoAcumulado > jugador1.PunteoAcumulado)
            {
                jugadorGanador = jugador2;
                ganador = true;
            }
            else
            {
                //En este caso se delcara un empate
                ganador = false;
            }

            //Si hay un ganador se muestran los resultados del jugador que ganó el juego.
            if (ganador)
            {
                Console.WriteLine("------------ GANADOR -------------\n");
                mostrarResultadosJugador(jugadorGanador);
            }
            //de lo contrario el juego se declara en empate y se muestra el resultado de ambos jugadores.
            else
            {
                Console.WriteLine("------------- EMPATE -------------\n");

                mostrarResultadosJugador(jugador1);
                Console.WriteLine("----------------------------------\n");
                mostrarResultadosJugador(jugador2);
            }


            Console.WriteLine("\n\n\nPresione cualquier tecla para salir");

        }

        //Se muestran los resultados del juego en base al Jugador requerido
        private void mostrarResultadosJugador(Jugador jugadorR)
        {
            Console.WriteLine(String.Format("Jugador: {0} \n", jugadorR.Nombre));
            Console.WriteLine(String.Format("Punteo Final: {0} \n", jugadorR.PunteoAcumulado));
            Console.WriteLine(String.Format("Cantidad de Tiros Ganados: {0}", jugadorR.CantidadTirosGanados));
            Console.WriteLine(String.Format("Probabilidad de Ganar: {0}%", jugadorR.ProbabilidadGanar));
            Console.WriteLine(String.Format("Cantidad de Tiros Pares: {0}", jugadorR.CantidadTirosPares));
            Console.WriteLine(String.Format("Cantidad de Tiros Impares: {0}", jugadorR.CantidadTirosImpares));
            Console.WriteLine(String.Format("Cantidad de Tiros Iguales: {0}", jugadorR.CantidadTirosIguales));
        }
    }



}

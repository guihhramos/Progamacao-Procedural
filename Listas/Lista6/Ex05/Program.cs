const int NUMEROS_QUANTIDADE = 10;
        const int NUMERO_MINIMO = 10;
        const int NUMERO_MAXIMO = 50;

        int[] numeros = new int[NUMEROS_QUANTIDADE];

        int contador = 0;

        while(contador < NUMEROS_QUANTIDADE)
        {
            int numero = int.Parse(Console.ReadLine());

            if(numero >= NUMERO_MINIMO && numero <= NUMERO_MAXIMO)
            {
                numeros[contador] = numero;
                contador++;
            }
        }

        for(int contador2 = 0; contador2 < NUMEROS_QUANTIDADE; contador2++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(numeros[contador2]);
            Console.ResetColor();
        }
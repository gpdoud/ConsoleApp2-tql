namespace ConsoleApp2;

internal class Program {

    static void Main(string[] args) {

        /*
         * Use a FOR loop to add up the numbers from 1 to 100 and print
         * out the sum.
         */
        // you need a variable to add up the numbers
        int sum = 0;

        for(var nbr = 1; nbr <= 100; nbr++) {
            if(nbr % 5 == 0 || nbr % 7 == 0) {
                sum = sum + nbr;
            }
        }

        Console.WriteLine(sum);

        //int nbr = 1;
        //while(nbr <= 10) {
        //    // the code goes here
        //    nbr++;
        //}

    }
}

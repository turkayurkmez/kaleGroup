using System.Diagnostics;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> list = new List<int>()  { 3,6,9-6,12 };
            //var totalWithLoop = getTotal(list);
            //var totalWithLinq = getTotalWithLinq(list);

            string choosenWord = getRandomWord();
            string wordPuzzle = changeWordToStars(choosenWord);
            show(wordPuzzle);

            wordPuzzle = foundLetters(wordPuzzle, 'a');
            
            

            
        }

        private static string foundLetters(string wordPuzzle, char letter)
        {
            return convertToLetter(letter);
        }

        private static string convertToLetter(char letter)
        {
            throw new NotImplementedException();
        }

        private static void show(string wordPuzzle)
        {
            throw new NotImplementedException();
        }

        private static string changeWordToStars(string choosenWord)
        {
            throw new NotImplementedException();
        }

        private static string getRandomWord()
        {
            throw new NotImplementedException();
        }

        bool isEven(int number) => number % 2 == 0;
        /*
         * 1. Bir kelime grubundan rastgele kelime seç
         * 2. Seçilen bu kelimenin harfleri kadar * işareti koy
         * 3. Bu * işaretlerini ekranda göster
         * 4. Kullanıcıdan harf iste
         * 5. Eğer harf varsa harfin bulunduğu pozisyondaki * harfe dönüşsün
         * 6. Yoksa bir hak düşsün
         * 7. Kelime tahmini için fırsat verilsin.
         * 8. Bilemezse 4. Adıma dön.
         */
        
       






    }
}
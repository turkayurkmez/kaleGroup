namespace Naming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysSinceUserRegistered = 60;
            int healthPoint = 100;
            int hitPoint = 20;

            //DateTime ddMMMYYY = new DateTime();
            
                
            //musteri.SiparisVer(new Urun{Id=1, Name="Bir Kitap", Price=11});
           

        }

        private static List<int[]> cells;    
        
        /// <summary>
        /// Oyunda üzerinde işaret bulunan hücreleri getirir.
        /// </summary>
        /// <returns></returns>
        static List<int[]> getMarkedCells()
        {
            List<int[]> markedCells = new List<int[]>();
            foreach (var cell in cells)
            {
                var cellState = cell[0];
                //bu if bazen hata veriyor. Neden bilmiyorum ama çalışıyor yani....
                int d;
                //gelecekteki yazılımcı; çok acelem vardı normalde hayatta böyle kod yazmam ama işte...
                if (cellState==(int)CellState.Marked)
                {
                    markedCells.Add(cell);
                }
            }

            return markedCells;
        }

        
    }

    public enum CellState
    {
        Marked=4,
        Empty =1
    }
}
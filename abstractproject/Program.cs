
namespace abstractproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BediiBook BediiBook = new BediiBook(1, 2); 
            BediiBook.OverallPriceOfSehifeler();
            Console.WriteLine(BediiBook.OverallPriceOfSehifeler());
           DedektivBook DedektivBook = new DedektivBook(2, 1);
            DedektivBook.OverallPriceOfSehifeler();
            Console.WriteLine(DedektivBook.OverallPriceOfSehifeler());
            MotivationBook MotivationBook = new MotivationBook(1, 3);
            MotivationBook.OverallPriceOfSehifeler();
            Console.WriteLine(MotivationBook.OverallPriceOfSehifeler());
        }
    }



    public abstract class Book
    {
        protected int pricePerBook;
        protected int countofSehife; public abstract int OverallPriceOfSehifeler();
        public Book(int countOfSehife, int pricePerBook)
        {
            this.countofSehife = countOfSehife; this.pricePerBook = pricePerBook;
        }
    }
    public class BediiBook : Book
    {
        public override int OverallPriceOfSehifeler()
        {
            return countofSehife * pricePerBook;
        }
        public BediiBook(int countOfSehife, int pricePerBook) :base(countOfSehife, pricePerBook)
        {
            this.countofSehife= countOfSehife;
            this.pricePerBook = pricePerBook;
        }
    }

    public class DedektivBook :Book
    {
        public override int OverallPriceOfSehifeler()
        {
            return countofSehife * pricePerBook;
        }
        public DedektivBook(int countOfSehife, int pricePerBook) : base(countOfSehife, pricePerBook)
        {
            this.countofSehife = countOfSehife;
            this.pricePerBook = pricePerBook;
        }
    }
    public class MotivationBook : Book
    {
        public override int OverallPriceOfSehifeler()
        {
            return countofSehife * pricePerBook;
        }
        public MotivationBook(int countOfSehife, int pricePerBook) : base(countOfSehife, pricePerBook)
        {
            this.countofSehife = countOfSehife;
            this.pricePerBook = pricePerBook;
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Girmiş olduğunuz sayi " + sayi);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("Hata " + ex.Message.ToString());
        }
        // finally
        // {
        //     Console.WriteLine("İşlem Tamamlandı");
        // }

        try
        {
            // int a = int.Parse(null);
            // int a = int.Parse("test");
            int a = int.Parse("-20000000000000");
        }
        catch (ArgumentNullException ex)
        {

            Console.WriteLine("Boş değer Girdiniz");
            Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {

            Console.WriteLine("Veri Tipi Uygun Değil");
            Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {

            Console.WriteLine("Cok kücük ya da cok buyuk bir değer girdiniz");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İşlem Başarıyla Tamamlandı");
        }

    }
}
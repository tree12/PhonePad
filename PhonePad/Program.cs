using PhonePad;

internal class Program
{
    private static void Main(string[] args)
    {
        //I don't know what it should happen if user press value more than the posible value. I assume it back to the initial state such as '55555'=>'K' equivalent '55'.
        Console.WriteLine(MainKeyPad.OldPhonePad("33#"));
        Console.WriteLine(MainKeyPad.OldPhonePad("227*#"));
        Console.WriteLine(MainKeyPad.OldPhonePad("4433555 555666#"));
        Console.WriteLine(MainKeyPad.OldPhonePad("8 88777444666*664#"));
    }

   
}
namespace Lesson11_1_Event;

delegate void Notify();


// 1) event keyword - delegate keyword
// 2) event - delegate-in uzerinde abstarction and protection
// 3) event - delegate-in uzerinde qurulub.
// 4) event -ler parameter kimi istifade oluna bilmir.
// 5) event -ler Interface daxilinde istifade oluna bilir.
// 6) event -ler = operator-u ile ishlemir.


// add | remove



class Button
{
    public event Notify MouseEnter = null!;
    public event Notify MouseLeave = null!;
    public event Notify MouseDoubleClick = null!;
    public event Notify TextChanged = null!;
    public event Notify SizeChanged = null!;


    public string? Text { get; set; }
    public string? Location { get; set; }
    public string? BackgroundColor { get; set; }
    public string? ForegroundColor { get; set; }


    public void Start()
    {
        MouseEnter?.Invoke();
        MouseLeave?.Invoke();
        MouseDoubleClick?.Invoke();
        TextChanged?.Invoke();
        SizeChanged?.Invoke();
    }
}


class Program
{
    static void Main()
    {
        Button button = new Button();
        button.MouseEnter += Button_MouseEnter;
        button.MouseEnter += Button_MouseEnter;
        button.MouseLeave += Button_MouseLeave;

        // button.MouseEnter = Button_MouseEnter; error

        button.Start();
    }


    private static void Button_MouseEnter()
    {
        Console.WriteLine("Button_MouseEnter");
    }

    private static void Button_MouseLeave()
    {
        Console.WriteLine("Button_MouseLeave");
    }
}
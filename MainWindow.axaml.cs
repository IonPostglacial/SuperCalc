using System.Globalization;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SuperCalc;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private static decimal Evaluate(string expression)
    {
        return 0m;
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var btn = (sender as Button);
        switch (btn?.Name)
        {
            case "BtnDel":
                Input.Text = "";
                break;
            case "BtnParOpen":
                Input.Text += "(";
                break;
            case "BtnParClose":
                Input.Text += ")";
                break;
            case "BtnMod":
                Input.Text += " mod ";
                break;
            case "BtnPi":
                Input.Text += "π";
                break;
            case "Btn0" or "Btn1" or "Btn2" or "Btn3" or "Btn4" or "Btn5" or "Btn6" or "Btn7" or  "Btn8" or "Btn9":
                Input.Text += btn.Content;
                break;
            case "BtnDiv":
                Input.Text += "÷";
                break;
            case "BtnMul":
                Input.Text += "×";
                break;
            case "BtnSub":
                Input.Text += "-";
                break;
            case "BtnAdd":
                Input.Text += "+";
                break;
            case "BtnSqrt":
                Input.Text += "√";
                break;
            case "BtnSq":
                Input.Text += "²";
                break;
            case "BtnDot":
                Input.Text += ".";
                break;
            case "BtnPercent":
                Input.Text += "%";
                break;
            case "BtnEq":
                var expr = Input.Text;
                var result = Evaluate(expr ?? "");
                Output.Text += $"{expr} = {result}\n";
                Input.Text = result.ToString(CultureInfo.InvariantCulture);
                break;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LFP_PROYECTO1_Simple_IDE;

namespace LFP_PROYECTO1_Simple_IDE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            bool test = false;
        }
    }

    public class myLibraries
    {
        // To see if a string is a word
        public bool isWord(String token)
        {
            return !token.StartsWith("0") && !token.StartsWith("1") && !token.StartsWith("2") && !token.StartsWith("3") && !token.StartsWith("4") && !token.StartsWith("5") && !token.StartsWith("6") && !token.StartsWith("7") && !token.StartsWith("8") && !token.StartsWith("9") && !token.StartsWith("Q");
        }

        // To see if a string is an Integer

        public bool isInteger(String token)
        {
            bool isInteger = false;

            for (int i = 0; i < token.Length; i++)
            {
                if (token[i].Equals('0') || token[i].Equals('1') || token[i].Equals('2') || token[i].Equals('3') || token[i].Equals('4') || token[i].Equals('5') || token[i].Equals('6') || token[i].Equals('7') || token[i].Equals('8') || token[i].Equals('9'))
                {
                    isInteger = true;
                }
                else
                {
                    isInteger = false;
                    break;
                }
            }

            return isInteger;
        }

        // To see if a string is a Decimal
        public bool isDecimal(string token)
        {
            bool isDecimal = false;
            /*String integerPart = "";
            String fractionalPart = "";
            bool fractionalTurn = false;*/
            bool isFirstTime = false;

            if (token.Length > 1)
            {
                for (int i = 0; i < token.Length; i++)
                {

                    if (token[i].Equals('0') || token[i].Equals('1') || token[i].Equals('2') || token[i].Equals('3') || token[i].Equals('4') || token[i].Equals('5') || token[i].Equals('6') || token[i].Equals('7') || token[i].Equals('8') || token[i].Equals('9') || token[i].Equals('.'))
                    {
                        if (token[i].Equals('.'))
                        {
                            //fractionalTurn = true;
                            isFirstTime = !isFirstTime;  // To ensure we have only one point in expression to be decimal
                            if (isFirstTime == false)
                            {
                                isDecimal = false;
                                break;
                            }
                        }
                        else
                        {
                            isDecimal = true;
                        }
                    }
                    else
                    {
                        isDecimal = false;
                        return isDecimal;
                    }
                }
            }

            return isDecimal;
        }

        // To see if a string is a Money Simbol
        public bool isMoneySimbol(string token)
        {
            bool isMoneySimbol = false;

            if (token.Equals("Q") || token.Equals("$") || token.Equals("€"))
            {
                isMoneySimbol = true;
                return isMoneySimbol;
            }

            if (token.Equals("Q.") || token.Equals("$.") || token.Equals("€."))
            {
                isMoneySimbol = true;
                return isMoneySimbol;
            }

            return isMoneySimbol;
        }
    }
}

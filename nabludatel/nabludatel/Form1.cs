using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nabludatel
{
    public partial class Form1 : Form
    {
        //static string health, type, howOften;
        public static int high, weight, ageTime;

        int step = 6, step2 = 1, time = 0, timeTest = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (time - timeTest == 8)
            {
                ageTime += step;
                timeTest = time;
                if (ageTime <= 12)
                {
                    high += 35;
                    weight += 400 * 6;

                    highChange.Text = high.ToString();
                    weightChange.Text = weight.ToString();
                    month.Text = ageTime.ToString();

                }
                else
                {
                    Random rnd = new Random();
                    weight += rnd.Next(-100, 300);

                    highChange.Text = high.ToString();
                    weightChange.Text = weight.ToString();
                    month.Text = ageTime.ToString();
                }

                if (ageTime > 240)
                {
                    highChange.Text = high.ToString();
                    weightChange.Text = weight.ToString();
                    month.Text = ageTime.ToString();

                    timer1.Stop();
                    timer2.Stop();
                }
                (string, string, string) data = kittyData.dataChanged();
                labelHealth.Text = data.Item1;
                labelType.Text = data.Item3;
                labelOften.Text = data.Item2;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time += 1;
            //ageTime -= 6;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            high = int.Parse(textHigh.Text);
            weight = int.Parse(textWeight.Text);
            ageTime = int.Parse(textAge.Text);
            
            highChange.Text = high.ToString();
            weightChange.Text = weight.ToString();
            month.Text = ageTime.ToString();
            
            timer1.Start();
            timer2.Start();

            (string, string, string) data = kittyData.dataChanged();
            labelHealth.Text = data.Item1;
            labelType.Text = data.Item3;
            labelOften.Text = data.Item2;
            
            
        }
    
    }
    public class kittyData
    {
        public static int getHigh()
        {
            return Form1.high;
        }
        public static  int getWeight()
        {
            return Form1.weight;
        }
        public static int getAge()
        {
            return Form1.ageTime;
        }

        public static (string, string, string) dataChanged()
        {
            int high = getHigh();
            int weight = getWeight();
            int age = getAge();

            return (healthKittyDisplay.Update(high, weight, age),
            howOftenKittyEatingDisplay.Update(high, weight, age),
            typeOfKittyDisplay.Update(high, weight, age));
        }

    }

    public class healthKittyDisplay
        {           
            static public string Update(int high, int weight, int age)
                {
                if ((high < 20) & (weight < 2000) & (age < 12))
                {
                    return "Здоровый котёнок";
                }
                else
                    if ((high <= 50) & (weight <= 3000) & (age <= 12))
                {
                    return "Здоровый котёнок-подросток";
                }
                else
                    if ((high >= 50) & (weight <= 6500) & (age > 12))
                {
                    return "Здоровый взрослый котик";
                }
                else
                    if ((high >= 50) & (weight > 6500) & (age > 12))
                {
                    return "Взрослый котик с ожирением";
                }
                else return "ВАШ КОТИК ОЧЕНЬ ХОЧЕТ КУШАТЬ";
            }
        }

        public class howOftenKittyEatingDisplay
        {

            static public string Update(int high, int weight, int age)
            {
                if ((high < 20) & (weight < 2000) & (age < 12))
                {
                    return "Продолжайте кормить 6-7 раз в день суточной нормой";
                }
                else
                    if ((high <= 50) & (weight <= 3000) & (age <= 12))
                {
                    return "Продолжайте кормить 2-3 раза в день суточной нормой";
                }
                else
                    if ((high >= 50) & (weight <= 6500) & (age > 12))
                {
                    return "Продолжайте кормить 2-3 раза в день суточной нормой";
                }
                else
                    if ((high >= 50) & (weight > 6500) & (age > 12))
                {
                    return "Следует кормить маленькими порциями 3 раза в день";
                }
                else return "ВАШ КОТИК ОЧЕНЬ ХОЧЕТ КУШАТЬ";


            }
        }

        public class typeOfKittyDisplay
        {

            static public string Update(int high, int weight, int age)
            {
            if ((high < 20) & (weight < 2000) & (age < 12))
            {
                return "У вас котик маленький картофель";
            }
            else
                if ((high <= 50) & (weight <= 3000) & (age <= 12))
            {
                return "У вас котик продолговатый подросток";
            }
            else
                if ((high >= 50) & (weight <= 6500) & (age > 12))
            {
                return "У вас котик продолговатый взрослый";
            }
            else
                if ((high >= 50) & (weight > 6500) & (age > 12))
            {
                return "У вас котик взрослый картофель";
            }
            else return "ВАШ КОТИК ОЧЕНЬ ХОЧЕТ КУШАТЬ";
            }
        }
}

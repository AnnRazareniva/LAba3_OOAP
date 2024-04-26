using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nabludatel
{
    public partial class Form1 : Form
    {
        //static string health, type, howOften;
        public static int high, weight, ageTime;                
        KittyData dat = new KittyData();

        int step = 6, step2 = 1, time = 0, timeTest = 0;

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            time += 1;
            //ageTime -= 6;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (time - timeTest == 13)
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

                if(weight < 2000)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Ann\\Desktop\\работа\\11.png");
                }
                else
                if (weight <=4000 &&  weight >=2000)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Ann\\Desktop\\работа\\12.png");
                }
                else
                if(weight <=6500 &&  (weight >4000))
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Ann\\Desktop\\работа\\13.png");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Ann\\Desktop\\работа\\14.png");
                }

                if (ageTime > 240)
                {
                    highChange.Text = high.ToString();
                    weightChange.Text = weight.ToString();
                    month.Text = ageTime.ToString();

                    timer1.Stop();
                    timer2.Stop();
                }



                //int run;
                //run = Run.Rrun(dat);
                (string, string, string) data = dat.setData(high, weight, ageTime);


                labelHealth.Text = data.Item1;
                labelType.Text = data.Item3;
                labelOften.Text = data.Item2;

            }
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

            timer1.Start();
            timer2.Start();


            //KittyData dat = new KittyData();

            int run;
            run = Run.Rrun(dat);
            (string, string, string) data = dat.setData(high, weight, ageTime);
            if (weight < 2000 && ageTime < 12)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Ann\\Desktop\\работа\\11.png");
            }
            else
                if (weight <= 4000 && weight >= 2000 && ageTime <=16)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Ann\\Desktop\\работа\\12.png");
            }
            else
                if (weight <= 6500 && (weight > 4000) && ageTime >16)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Ann\\Desktop\\работа\\13.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Ann\\Desktop\\работа\\14.png");
            }
            labelHealth.Text = data.Item1;
            labelType.Text = data.Item3;
            labelOften.Text = data.Item2;
        }
    }

    public abstract class Subject
    {
        public abstract void registerNabludatel(Nabludatel nabludatel);
        public abstract void removeNabludatel(Nabludatel nabludatel);
        public abstract void notifyNabludatel();
    }

    public abstract class Nabludatel
    {
        public abstract string update(int high, int weight, int age);
    }

    public class KittyData : Subject
    {
        List<Nabludatel> nabludatels = new List<Nabludatel>();
        String[] result = new string[3];
        public int high;
        public int weight;
        public int age;

        //public KittyData() 
        //{
        //    nabludatels = new List<Nabludatel>();
        //}
        public int getHigh()
        {
            return high;
        }
        public int getWeight()
        {
            return weight;
        }
        public int getAge()
        {
            return age;
        }
        public (string, string, string) setData(int high, int weight, int ageTime)
        {
            this.high = high;
            this.weight = weight;
            this.age = ageTime;

            notifyNabludatel();
            return (result[0], result[1], result[2]);
        }
        public override void notifyNabludatel()
        {
            for (int i = 0; i < nabludatels.Count; i++)
            {
                result[i] = nabludatels[i].update(high, weight, age);
            }
        }

        public override void registerNabludatel(Nabludatel nabludatel)
        {
            nabludatels.Add(nabludatel);
        }

        public override void removeNabludatel(Nabludatel nabludatel)
        {

        }


    }

    public class Run
    {
        public static int Rrun(KittyData kittyData)
        {
            

            kittyData.high = kittyData.getHigh();
            kittyData.weight = kittyData.getWeight();
            kittyData.age = kittyData.getAge();

            HealthKittyDisplay health = new HealthKittyDisplay(kittyData);
            HowOftenKittyEatingDisplay how = new HowOftenKittyEatingDisplay(kittyData);
            TypeOfKittyDisplay type = new TypeOfKittyDisplay(kittyData);

            //kittyData.registerNabludatel(health);
            //kittyData.registerNabludatel(how);
            //kittyData.registerNabludatel(type);

            return 1;

            //kittyData.setData(high, weight, age);
        }
    }

    public class HealthKittyDisplay : Nabludatel
    {
        Subject kittyData;
        public HealthKittyDisplay(Subject kittyData)
        {
            this.kittyData = kittyData;
            kittyData.registerNabludatel(this);
        }

            public override string update(int high, int weight, int age)
            {
                if ((high < 20) & (weight < 2000) & (age < 12))
                {
                    return "Здоровый котёнок";
                }
                else
                    if ((high <= 50) & (weight <= 4000) & (age <= 16))
                {
                    return "Здоровый котёнок-подросток";
                }
                else
                    if ((high >= 50) & (weight <= 6500) & (age > 16))
                {
                    return "Здоровый взрослый котик";
                }
                else
                    if ((high >= 50) & (weight > 6500) & (age > 16))
                {
                    return "Взрослый котик с ожирением";
                }
                else return "ВАШ КОТИК ОЧЕНЬ ХОЧЕТ КУШАТЬ";
            }
        }

    public class HowOftenKittyEatingDisplay : Nabludatel
    {
        Subject kittyData;
        public HowOftenKittyEatingDisplay(Subject kittyData)
        {
            this.kittyData = kittyData;
            kittyData.registerNabludatel(this);
        }
        public override string update(int high, int weight, int age)
            {
                if ((high < 20) & (weight < 2000) & (age < 12))
                {
                    return "Продолжайте кормить 6-7 раз в день суточной нормой";
                }
                else
                    if ((high <= 50) & (weight <= 4000) & (age <= 16))
                {
                    return "Продолжайте кормить 2-3 раза в день суточной нормой";
                }
                else
                    if ((high >= 50) & (weight <= 6500) & (age > 16))
                {
                    return "Продолжайте кормить 2-3 раза в день суточной нормой";
                }
                else
                    if ((high >= 50) & (weight > 6500) & (age > 16))
                {
                    return "Следует кормить маленькими порциями 3 раза в день";
                }
                else return "ВАШ КОТИК ОЧЕНЬ ХОЧЕТ КУШАТЬ";


            }
        }

    public class TypeOfKittyDisplay : Nabludatel
    {
        Subject kittyData;
        public TypeOfKittyDisplay(Subject kittyData)
        {
            this.kittyData = kittyData;
            kittyData.registerNabludatel(this);
        }
        public override string update(int high, int weight, int age)
            {
            if ((high < 20) & (weight < 2000) & (age < 12))
            {
                return "У вас котик маленький картофель";
            }
            else
                if ((high <= 50) & (weight <= 4000) & (age <= 16))
            {
                return "У вас котик продолговатый подросток";
            }
            else
                if ((high >= 50) & (weight <= 6500) & (age > 16))
            {
                return "У вас котик продолговатый взрослый";
            }
            else
                if ((high >= 50) & (weight > 6500) & (age > 16))
            {
                return "У вас котик взрослый картофель";
            }
            else return "ВАШ КОТИК ОЧЕНЬ ХОЧЕТ КУШАТЬ";
            }
        }
}

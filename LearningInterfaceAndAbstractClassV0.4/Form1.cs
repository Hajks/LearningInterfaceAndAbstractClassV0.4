using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningInterfaceAndAbstractClassV0._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CoffeeMaker misterCoffee = new CoffeeMaker();
            Oven oldToasty = new Oven();
            Appliance[] kitchenWare = new Appliance[2];
            kitchenWare[0] = misterCoffee;
            kitchenWare[1] = oldToasty;
            Oven misterToasty = new Oven();
            misterToasty. // <-------------------------- so we got 3 diffrent references to same object which give us access to diffrent methods and fields.

            ICooksFood cooker;
            if (misterToasty is ICooksFood)
            {
                cooker = misterToasty as ICooksFood;
                cooker. // <-------------------------- so we got 3 diffrent references to same object which give us access to diffrent methods and fields.

            }


            Appliance powerConsumer = new CoffeeMaker();
            powerConsumer.ConsumerPower(); //We can use it as object Appliance but not as CoffeeMaker
            // powerConsumer.MakeCoffee(); <-- it won't compile. 
            if (powerConsumer is CoffeeMaker)
            {
                CoffeeMaker javaJoe = powerConsumer as CoffeeMaker; //We decide to treat our powerConsumer as object CoffeeMaker
                javaJoe.MakeCofee(); // now we are projecting down to let our object CoffeeMaker use her methods.
            }
            if (misterToasty is Appliance)
            {
                powerConsumer = misterToasty;
                powerConsumer. // <-------------------------- so we got 3 diffrent references to same object which give us access to diffrent methods and fields.

            }
        }
    }
}

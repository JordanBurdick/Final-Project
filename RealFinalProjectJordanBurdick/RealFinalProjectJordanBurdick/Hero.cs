using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealFinalProjectJordanBurdick
{
    class Hero
    {
        private string Alterego;
        private string Weakness;
        private bool Antihero;
        private string Gender;
        private string Race;

        public string Power;
        public int PowerLevel;
        public double Health;
        public string Weapons;
        public int Age;
        public string Name;
        public string nemesis;

        public Hero()
        {
        }

        public Hero(string name, string nemesis, string race, string power)
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = race;
            this.Power = power;
        }

        public Hero(string name, string nemesis, string race, string power, bool antihero)
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = race;
            this.Power = power;
            this.Antihero = antihero;
        }
        public Hero(string Name, int Age, int PowerLevel)
        {
            this.Name = Name;
            this.Age = Age;
            this.PowerLevel = PowerLevel;

        }
        // TODO: Problem 1 - add a constructor method with a different number and/or types of parameters
        //done

        public void FightCrime(string address)
        {
            // TODO: Problem 2 - Output "Successfully fought crime at address" if PowerLevel > 49
            //done
            if (PowerLevel > 49)
            {
                Console.WriteLine("{0} has fought crime at {1}",Name,address );
            }
            else
            {
                Console.WriteLine("{0} has lost at {1}", Name, address);
            }
        }

        public bool Investigate()
        {
            // TODO: Problem 3 - output "Investigated Crime" and return true
            Console.WriteLine("{0} has investigated crime", this.Name);
            bool returnValue = true;
            return returnValue;
        }

        public void Fly()
        {
            // TODO: Problem 4 - if Power contains Fly, then output "Name is Flying!" else output "Name can't fly!"
            //done
            if (this.Power.Contains("Fly"))
            {
                Console.WriteLine("{0} is flying",Name);
            }
            else
            {
                Console.WriteLine("{0} Cannot fly!",Name);
            }
        }

        public void Craft(string material, int numMaterials)
        {
            Console.WriteLine("Crafting with " + material);
        }

        public void Climb(int height)
        {
            Console.WriteLine(this.Name + " has climbed " + height + " feet");
        }
       
        public int ChargePower()
        {
            // TODO: Problem 5 - increase this.PowerLevel by 1
            //done
            PowerLevel += 1;
            return PowerLevel;
        }
        int i;
        //done
        //TODO: Problem 6 - Add an overloaded method ChargePower that has a parameter for increaseAmount.  Add increaseAmount to this.PowerLevel and return the new value for this.PowerLevel (try to use a loop calling the other ChargePower)
        public int ChargePower(int increaseAmmount)
        {
            for (int i = 0; i < increaseAmmount; i++)
            {
                this.ChargePower();
               // Console.Write(this.Name + " is Charging up!");
            }
            Console.WriteLine(this.Name + " has charged up " + increaseAmmount + " times!");
            return this.PowerLevel;
        }





        //pls
        }
    }
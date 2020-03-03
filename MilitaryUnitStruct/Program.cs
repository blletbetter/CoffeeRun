using System;

namespace MilitaryUnitStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class Personnel
        {
            public virtual string Command()
            {
                return "";
            }
            public class Officer : Personnel
            {
                Enlisted.NCO nco = new Enlisted.NCO();
                public override string  Command()
                {
                    return "";
                }
                public bool DrinkCoffee()
                {
                    if (nco.CoffeeRun() == true)
                        return true;
                    else
                        return false;
                }
            }
            public class Enlisted : Personnel
            {
                public override string Command()
                {
                    return "";
                }
                public virtual bool CoffeeRun()
                {
                    return true;
                }
                public class SNCO : Enlisted
                {
                    public override string Command()
                    {
                        return "";
                    }
                }
                public class NCO : Enlisted
                {
                    public override string Command()
                    {
                        return "";
                    }
                    public override bool CoffeeRun()
                    {
                        return true;
                    }
                }
                public class JrEnlisted : Enlisted
                {
                    public bool Skate()
                    {
                        return true;
                    }
                    public override bool CoffeeRun()
                    {
                        return false;
                    }
                }
            }
        }
        public class Vehicles
        {
            public virtual string Name { get; set; }
            public virtual bool Drive()
            {
                return true;
            }
            public class Armored : Vehicles
            {
                public override string Name { get => base.Name; set => base.Name = value; }
                public override bool Drive()
                {
                    return true;
                }
                public short ArmorWeight { get; set; }
            }
            public class Unarmored : Vehicles
            {
                public override string Name { get => base.Name; set => base.Name = value; }
                public override bool Drive()
                {
                    return base.Drive();
                }
            }
            public class Tank : Vehicles
            {
                public override string Name { get => base.Name; set => base.Name = value; }
                public override bool Drive()
                {
                    return base.Drive();
                }
            }
        }
        public class Weapons
        {
            public virtual int ammo { get; set; }
            public virtual string name { get; set; }
            public virtual bool Fire()
            {
                return true;
            }
            public class SmallCaliber  : Weapons
            {
                public override int ammo { get => base.ammo; set => base.ammo = value; }
                public override string name { get => base.name; set => base.name = value; }
                public override bool Fire()
                {
                    if (ammo > 0)
                        return true;
                    else
                        return false;
                }
            }
            public class IndirectFire : Weapons
            {
                public override bool Fire()
                {
                    if (ammo > 0 && team == true)
                        return true;
                    else
                        return false;
                }
                public bool team { get; set; }
            }

        }
    }
}

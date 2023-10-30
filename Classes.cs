using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUnits
{
    public class Unit
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int FiringRange { get; set; }
        public int DetectionRange { get; set; }
        public string? MainWeapon { get; set; }
        public string? SecondaryWeapon { get; set; }
    }

    public class Troop : Unit
    {
        private List<Infantry> infantryList = new List<Infantry>();

        public void addUnit(Infantry infantry)
        {
            infantryList.Add(infantry);
        }

        public void removeUnit(Infantry infantry)
        {
            infantryList.Remove(infantry);
        }
    }

    public class Infantry : Unit
    {
        public string? PersonalWeapon { get; set; }
    }

    public class Infantryman : Infantry
    {

    }

    public class MachineGunTeam : Infantry
    {

    }

    public class Vehicle : Unit
    {
        public int PassengerCapacity { get; set; }
        private List<Unit> unitList = new List<Unit>();

        public void AddVehicle(Unit unit)
        {
            unitList.Add(unit);
        }

        public void RemoveVehicle(Unit unit)
        {
            unitList.Remove(unit);
        }
    }

    public class Tank : Vehicle
    {

    }

    public class Aircraft : Vehicle
    {

    }

    public class Helicopter : Vehicle
    {

    }

    public class Howitzer : Vehicle
    {

    }

    class Program
    {
        public static Unit CreateUnit(int health, int damage, int speed, int firingRange, int detectionRange, string? mainWeapon = null, string? secondaryWeapon = null, string unitType = "Infantry", int PassengerCapacity = 0)
        {
            Unit unit;

            switch (unitType)
            {
                case "Infantry":
                    unit = new Infantry();
                    break;
                case "Vehicle":
                    unit = new Vehicle();
                    if (unit is Vehicle vehicle)
                    {
                        vehicle.PassengerCapacity = PassengerCapacity;
                    }
                    break;
                default:
                    unit = new Unit();
                    break;
            }   
            
            return unit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUnits
{
    public abstract class Unit
    {
        
        public int Damage { get; set; }
        public int Speed { get; set; }
        public string? MainWeapon { get; set; }
        public string? SecondaryWeapon { get; set; }
    }

    public class Troop : Infantry
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
        public int Health { get; set; }
        public string? PersonalWeapon { get; set; }
    }

    public class Infantryman : Infantry
    {

    }

    public class MachineGunTeam : Infantry
    {

    }

    public abstract class Vehicle : Unit
    {
        public int FuelCapacity { get; set; }
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

 public class MechTroop : Vehicle
    {
        private List<Vehicle> vehicleList = new List<Vehicle>();

        public void addUnit(Vehicle vehicle)
        {
           vehicleList.Add(Vehicle);
        }

        public void removeUnit(Vehicle vehicle)
        {
           vehicleList.Remove(vehicle);
        }
    }
    public class Tank : Vehicle
    {

    }

    public class Aircraft : Vehicle
    {
        public int DetectionRange { get; set; }
    }

    public class Helicopter : Vehicle
    {
        public byte PassengerCapacity { get; set; }
        public int DetectionRange { get; set; }
    }

    public class Howitzer : Vehicle
    {
        public int FiringRange { get; set; }
    }

    class Program
    {
        
    }
}

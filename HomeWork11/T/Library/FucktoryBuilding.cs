using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWWally;

namespace WWWally
{
    internal class FucktoryBuilding
    {

        private static Hashtable hashtable = new Hashtable();
        private FucktoryBuilding() { }
        public static void CreateBuild(float height, byte numberStoreys, byte numberEntrance, ushort numberFlats)
        {
            Building building = new Building(height, numberStoreys, numberEntrance, numberFlats);
            hashtable[building.GetID()] = building;
        }
        public static void DeleteBuilding(uint id)
        {
            hashtable.Remove(id);
        }
        public static List<Building> GetCreatedBuildingsList()
        {
            List<Building> buildings = new List<Building>();
            foreach (var item in hashtable.Values)
            {
                if (item is Building)
                {
                    buildings.Add((Building)item);
                }
            }
            buildings.Reverse();
            return buildings;
        }

    }
}

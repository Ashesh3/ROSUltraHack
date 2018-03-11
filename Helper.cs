 
using System;
using System.Collections.Generic;

namespace Whynot
{
  internal class Helper
  {
         public static Dictionary<int, string> Items = new Dictionary<int, string>
                    {
                        { 0, "Nothing"},
                        { 1, "Lv 1 helmet"},
                        { 2, "Lv 2 helmet"},
                        { 3, "Lv 3 helmet"},
                        { 5, "Lv 1 Armor"},
                        { 6, "Lv 2 Armor"},
                        { 7, "Lv 3 Armor"},
                        { 8, "Lv 1 Backpack"},
                        { 9, "Lv 2 Backpack"},
                        { 10, "Lv 3 Backpack"},
                        { 19, "Ghillie Suit"},
                        { 50, "Fuel Barrel"},
                        { 101, "Bandage"},
                        { 102, "Med Kit"},
                        { 103, "First Aid Kit"},
                        { 105, "Sports Drink"},
                        { 106, "Cardio Tonic"},
                        { 1001, "M4A1 Rifle"},
                        { 1002, "AKM Rifle"},
                        { 1003, "M870 SG"},
                        { 1004, "M1887 SG"},
                        { 1005, "AA12 SG"},
                        { 1006, "AWM SR"},
                        { 1007, "Barett SR"},
                        { 1008, "M249 MG"},
                        { 1009, "M14EBR Rifle"},
                        { 1010, "AR15 Rifle"},
                        { 1011, "MP7 SMG"},
                        { 1012, "PP19 SMG"},
                        { 1013, "Thompson SMG"},
                        { 1014, "G18C Pistol"},
                        { 1015, "Desert Eagle"},
                        { 1017, "Vector"},
                        { 1018, "P90 SMG"},
                        { 1019, "SAIGA-12 Shotgun"},
                        { 1020, "WRO Hunting Rifle"},
                        { 1021, "SVD SR"},
                        { 1022, "M110 Sniper Rifle"},
                        { 1023, "ACR Rifle"},
                        { 1024, "AN94 Rifle"},
                        { 1025, "MP5 SMG"},
                        { 1026, "AUG Rifle"},
                        { 1027, "QBU Sniper Rifle"},
                        { 1031, "RPG Rocket Tube"},
                        { 1101, "SG Ammo"},
                        { 1102, "Rifle Ammo"},
                        { 1103, "SR Ammo"},
                        { 1104, "SMG Ammo"},
                        { 1105, "Pistol Ammo"},
                        { 1106, "RPG Ammo"},
                        { 1201, "Rifle Silencer"},
                        { 1202, "SR Silence"},
                        { 1204, "SMG Silencer"},
                        { 1211, "Rifle Compensator"},
                        { 1212, "SR Compensator"},
                        { 1213, "SMG Compensator"},
                        { 1221, "Rifle Flash Hider"},
                        { 1222, "SR Flash Hider"},
                        { 1223, "SMG Smoke Hider"},
                        { 1231, "SG Choke"},
                        { 1241, "Triangle Grip"},
                        { 1242, "Vertical Foregrip"},
                        { 1251, "Rifle QD-Mag"},
                        { 1252, "Rifle EX-Mag"},
                        { 1253, "Rifle EX-QD-Mag"},
                        { 1261, "SR Cheek Pad"},
                        { 1262, "Tactical Stock"},
                        { 1263, "SG Bullet Loop"},
                        { 1264, "SR EX-Mag"},
                        { 1265, "SR QD-Mag"},
                        { 1266, "SR EX-QD-Mag"},
                        { 1271, "Red Dot Sight"},
                        { 1272, "Holo-Sight"},
                        { 1273, "2x Scope"},
                        { 1274, "4x Scope"},
                        { 1275, "8x Scope"},
                        { 1276, "SMG QD-Mag"},
                        { 1277, "SMG EX-Mag"},
                        { 1278, "SMG QD-EX-Mag"},
                        { 1279, "Collapsible Stock"},
                        { 1303, "Crowbar"},
                        { 1306, "Frying Pan"},
                        { 1307, "Rubber Chicken"},
                        { 1401, "Grenade"},
                        { 1402, "Stun Grenade"},
                        { 1403, "Smoke Grenade"},
                        { 1404, "Molotov Cocktail"},
                        { 1405, "Chicken Grenade"},
                        { 1406, "Flash Grenade"}
                    };

        public static int GetDistance(Vector3 v1, Vector3 v2, int Divide)
        {
            Vector3 vector3 = new Vector3();
            vector3.X = v1.X - v2.X;
            vector3.Y = v1.Y - v2.Y;
            vector3.Z = v1.Z - v2.Z;
            return (int)Math.Sqrt(Math.Pow((double)vector3.X, 2.0) + Math.Pow((double)vector3.Y, 2.0) + Math.Pow((double)vector3.Z, 2.0)) / Divide;
        }
    }
}

/******************************************************************
*** NAME        : Jessica Morrow, Evan Schwarz, Nathan Crosby   ***
*** CLASS       : CSC 346                                       ***
*** ASSIGNMENT  : 2                                             ***
*** DUE DATE    : 02-23-26                                      ***
*** INSTRUCTOR  : GAMRADT                                       ***
*******************************************************************
*** DESCRIPTION: The assignment uses VSCode to create a user-   ***
*** defined Abstract Data Type using C# Classes named Viking    ***
*** and Global along with an interface named IView and an       ***
*** appropriate set of C# files.                                ***
*** This file defines and implements the Viking class           ***
*** within the VikingNS namespace. The Viking class             ***
*** describes the following: the current state of an individual Viking ***
*** instance through auto-implemented properties: Name,         ***
*** Status, Health, Weapon, and Shield; Fulfills the contract   ***
*** set by the interface "IView"; Declares and defines a deep   **
*** copy constructor                                            ***
*******************************************************************
*/

using System;
using System.Diagnostics;

namespace VikingNS
{
    public class Viking
    {
        public string Name { get; set; }
        public short Health { get; set; }
        public Global.Weapon Weapon { get; set; }
        public bool Shield { get; set;}

        /****************************************************************
        ***  METHOD  Viking (Default/Parameterized Constructor)       ***
        *****************************************************************
        ***  DESCRIPTION : Initializes a Viking object using default  ***
        ***  or provided values.                                      ***
        ***  INPUT ARGS :  name, status, health, weapon, shield       ***
        ***  OUTPUT ARGS :  None                                      ***
        ***  IN/OUT ARGS :  None                                      ***
        ***  RETURN :  None                                           ***
        ****************************************************************/

        public Viking(
            string name = "Olaf", 
            short health = 100,
            Global.Weapon weapon = Global.Weapon.NONE, 
            bool shield = false)
        {
           Name = name;
           Health = health;
           Weapon = weapon;
           Shield = shield; 
        }
     
        /******************************************************************
        ***  METHOD  Viking (Copy Constructor)                          ***
        *******************************************************************
        ***  DESCRIPTION : Copies the values from another Viking object ***
        ***  INPUT ARGS :  Viking other                                 ***
        ***  OUTPUT ARGS :  None                                        ***
        ***  IN/OUT ARGS :  None                                        ***
        ***  RETURN :  Viking instance                                  ***
        ******************************************************************/
        public Viking(Viking viking)
        {
            Name = viking.Name;
            Health = viking.Health;
            Weapon = viking.Weapon;
            Shield = viking.Shield;
        }

        /****************************************************************
        ***  METHOD  ToString()                                       ***      
        *****************************************************************
        ***  DESCRIPTION :                                            *** 
        ***  Displays Viking properties in vertical format.           ***
        ***                                                           ***
        ***  INPUT ARGS :  None                                       ***
        ***  OUTPUT ARGS :  None                                      ***
        ***  IN/OUT ARGS :  None                                      ***
        ***  RETURN :  void                                           ***
        ****************************************************************/
        public override string ToString()
        {

            return $"Name: {Name}{Environment.NewLine}"
                 + $"Health: {Health}{Environment.NewLine}"
                 + $"Weapon: {Weapon}{Environment.NewLine}"
                 + $"Shield: {Shield}{Environment.NewLine}"
            ;
        }
    }
}
/******************************************************************
*** NAME        : Jessica Morrow, Evan Schwarz, Nathan Crosby   ***
*** CLASS       : CSC 346                                       ***
*** ASSIGNMENT  : 3                                             ***
*** DUE DATE    : 03-05-26                                      ***
*** INSTRUCTOR  : GAMRADT                                       ***
*******************************************************************
***  DESCRIPTION: The assignment uses VSCode to create a user-  ***
*** defined Abstract Data Type using C# Classes named Viking,   ***
*** Karl, and Global along with an appropriate                  ***
*** set of C# files.                                            ***
***                                                             ***
***                                                             ***
*** enumerated types "Duty" and "Weapon" within the VikingNS    ***
*** namespace                                                   ***
*******************************************************************
*/


namespace VikingNS
{
    public static class Global
    {
        public enum Duty
        {
            CRAFTSMAN, 
            FARMER, 
            SAILOR, 
            WARRIOR
        }
       public enum Weapon
        {
            AXE, 
            SWORD,
            NONE
        }
    }
}
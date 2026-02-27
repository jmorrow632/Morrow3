/******************************************************************
*** NAME        : Jessica Morrow, Evan Schwarz, Nathan Crosby   ***
*** CLASS       : CSC 346                                       ***
*** ASSIGNMENT  : 3                                             ***
*** DUE DATE    : 03-05-26                                      ***
*** INSTRUCTOR  : GAMRADT                                       ***
*******************************************************************
*** DESCRIPTION: The assignment uses VSCode to create a user-   ***
*** defined Abstract Data Type using C# Classes named Viking    ***
*** and Global along with an interface named IView and an       ***
*** appropriate set of C# files.                                ***
*** This file defines the static class Global containing the    ***
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
            FARMET, 
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
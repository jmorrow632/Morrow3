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
*** This file creates two instances of the Viking class using   ***
*** the VikingNS namespace: One with default and one with       ***
*** default arguments, then implements the abstract methods     ***
*** from the IView interface.                                   ***
*******************************************************************
*/



using VikingNS;

class Program
{
    static void Main()
    {
        Viking vDefault = new Viking();
        vDefault.ViewH();

        Viking vCustom = new Viking("Ragnar", Global.Status.JARL, 250, Global.Weapon.SWORD, true);
        Viking copy = new Viking(vCustom);
        copy.ViewV();
    }
}
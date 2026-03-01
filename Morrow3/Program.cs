/******************************************************************
*** NAME        : Jessica Morrow, Evan Schwarz, Nathan Crosby   ***
*** CLASS       : CSC 346                                       ***
*** ASSIGNMENT  : 3                                             ***
*** DUE DATE    : 03-05-26                                      ***
*** INSTRUCTOR  : GAMRADT                                       ***
*******************************************************************
*** DESCRIPTION: The assignment uses VSCode to create a user-   ***
*** defined Abstract Data Type using C# Classes named Viking,   ***
*** Karl, and Global along with an                              ***
*** appropriate set of C# files.                                ***
*** This file creates three instances of the Viking class;      ***
*** Default, paramaterized, and copy.                           ***
*** and three instances of the Karl class;                      ***
*** Default, paramaterized, and copy.                           ***
*******************************************************************
*/



/* using VikingNS;

class Program
{
    static void Main()
    {
        Viking vDefault = new Viking();

        Viking Karl = new Viking(Vikings.Karl);
        Viking copy = new Viking(Karl);
    }
} */

/// /////////////////////////////////////////////////////////////////////////////
/// File:        Program.cs
/// Description: Driver/test program for the VikingNS namespace. Demonstrates
///              the Viking, Karl, and Global ADT classes. This file will be
///              replaced by the instructor's test program.
/// Author:      [Your Name]
/// Course:      CSC 346
/// Assignment:  Assignment 3
/// Date:        2026-02-27
/// /////////////////////////////////////////////////////////////////////////////

using VikingNS;

// -----------------------------------------------------------------------
// Test Viking default constructor
// -----------------------------------------------------------------------
Viking v1 = new Viking();
Console.WriteLine("--- Viking Default Constructor ---");
Console.WriteLine(v1);

// -----------------------------------------------------------------------
// Test Viking parameterized constructor
// -----------------------------------------------------------------------
Viking v2 = new Viking("Vidar", 350, Global.Weapon.SWORD, true);
Console.WriteLine("--- Viking Parameterized Constructor ---");
Console.WriteLine(v2);

// -----------------------------------------------------------------------
// Test Viking copy constructor
// -----------------------------------------------------------------------
Viking v3 = new Viking(v2);
Console.WriteLine("--- Viking Copy Constructor ---");
Console.WriteLine(v3);

// -----------------------------------------------------------------------
// Test Karl default constructor
// -----------------------------------------------------------------------
Karl k1 = new Karl();
Console.WriteLine("--- Karl Default Constructor ---");
Console.WriteLine(k1);

// -----------------------------------------------------------------------
// Test Karl parameterized constructor
// -----------------------------------------------------------------------
Karl k2 = new Karl("Vidar", 350, Global.Weapon.SWORD, true, Global.Duty.WARRIOR);
Console.WriteLine("--- Karl Parameterized Constructor ---");
Console.WriteLine(k2);

// -----------------------------------------------------------------------
// Test Karl copy constructor
// -----------------------------------------------------------------------
Karl k3 = new Karl(k2);
Console.WriteLine("--- Karl Copy Constructor ---");
Console.WriteLine(k3);


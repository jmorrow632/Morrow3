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
***     ***
***     ***
***                                                    ***
*******************************************************************
*/


using VikingNS;

public class Karl : Viking
{
    public Global.Duty Duty { get; set;}

    /******************************************************************
    ***  METHOD  Karl (Default Constructor)                         ***
    *******************************************************************
    ***  DESCRIPTION : Define the default values for a Karl object  ***
    ***  INPUT ARGS :  None                                         ***
    ***  OUTPUT ARGS :  None                                        ***
    ***  IN/OUT ARGS :  None                                        ***
    ***  RETURN :  None                                             ***
    ******************************************************************/
    public Karl() : base()
    {
        Duty = Global.Duty.FARMER;
    }

    /******************************************************************
    ***  METHOD  Karl (Parameterized Constructor)                   ***
    *******************************************************************
    ***  DESCRIPTION : Define the parameter values for a Karl object***
    ***  INPUT ARGS :  Name, Health, Weapon, Shield, Duty           ***
    ***  OUTPUT ARGS :  None                                        ***
    ***  IN/OUT ARGS :  None                                        ***
    ***  RETURN :  None                                             ***
    ******************************************************************/
    public Karl(
        string name,
        short health, 
        Global.Weapon weapon, 
        bool shield,
        Global.Duty duty = Global.Duty.FARMER) : base(name, health, weapon, shield)
    {
        this.Duty = duty; 
    }

    /******************************************************************
    ***  METHOD  Karl (Copy Constructor)                            ***
    *******************************************************************
    ***  DESCRIPTION : Creates a copy of a Karl object              ***
    ***  INPUT ARGS :  Karl karl                                    ***
    ***  OUTPUT ARGS :  None                                        ***
    ***  IN/OUT ARGS :  None                                        ***
    ***  RETURN :  Karl Instance                                    ***
    ******************************************************************/
    public Karl(Karl karl) : base(karl)
    {
        this.Duty = karl.Duty;
    }

    /******************************************************************
    ***  METHOD  Override ToString()                                ***
    *******************************************************************
    ***  DESCRIPTION : Returns a formatted string representation    ***
    *** of a Karl object                                            *** 
    ***  INPUT ARGS :  None.                                        ***
    ***  OUTPUT ARGS :  None                                        ***
    ***  IN/OUT ARGS :  None                                        ***
    ***  RETURN :  String.                                          ***
    ******************************************************************/
    public override string ToString()
    {
        return base.ToString() + $"Duty: {Duty}";
    }
}

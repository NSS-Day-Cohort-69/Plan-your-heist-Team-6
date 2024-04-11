// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
List<TeamMember> teamMembers = new List<TeamMember>()
{

};
Console.WriteLine("Plan Your Heist!");



// Add a class to store the Team Member
// After choosing to add team member, Prompt user to enter a name(string)
// After that prompt user to enter a skill level 1-5(integer)
// After that prompt the user to enter a Courage Factor(decimal)
// After all that display the information of the team member
int BankLevel = 100;

CreateTeamLoop();
CompareTeamSkillToBankDifficulty(SumOfTeamSkillLevels(), BankLevel);

string AddName()
{
    Console.WriteLine("Enter the name of your Team Member: ");
    string name = Console.ReadLine()!.Trim();
    if (string.IsNullOrWhiteSpace(name))
    {
        return null;

    }
    else
    {
        return name;
    }
};

int AddSkill()
{
    Console.WriteLine("What is their skill level(1-35): ");
    int skillLevel = int.Parse(Console.ReadLine());
    return skillLevel;

};



decimal AddCourage()
{
    Console.WriteLine("How brave are they?(between 0.0-2.0)");
    decimal courageFactor = decimal.Parse(Console.ReadLine());
    return courageFactor;
}

void StoreNewTeamMember(string name, int skillLevel, decimal courageFactor)
{



    TeamMember newMember = new TeamMember()
    {
        Name = name,
        SkillLevel = skillLevel,
        CourageFactor = courageFactor
    };
    teamMembers.Add(newMember);



}

void CreateTeamLoop()
{
    bool isLooping = true;
    while (isLooping)
    {
        string memberName = AddName();
        if (memberName == null)
        {
            break;
        }
        int memberSkill = AddSkill();
        decimal memberCourage = AddCourage();
        StoreNewTeamMember(memberName, memberSkill, memberCourage);

    }

}

void DisplayTeamMemberInfo()
{

    Console.WriteLine($"You have {teamMembers.Count} members on your team!");
    foreach (TeamMember member in teamMembers)
    {
        Console.WriteLine($"{member.Name} has a skill level of {member.SkillLevel} and a courage factor of {member.CourageFactor}");
    }
}

int SumOfTeamSkillLevels()
{
    int sum = 0;
    foreach (TeamMember member in teamMembers)
    {
        sum += member.SkillLevel;
    }
    return sum;
};

void CompareTeamSkillToBankDifficulty(int sum, int bankLevel)
{
    if (sum >= bankLevel)
    {
        Console.WriteLine("Success! You won't get arrested! :)");
    }
    else
    {
        Console.WriteLine("Don't do this mission, you will FAIL :(");
    }
}

// Display Team Member
//  Name = AddName()


/*need to create an empty list to hold the new team members
*/

/* ----PHASE 3----
Stop displaying each team member's info
Store a Bank difficulty level = 100 (will be global?)
function to save sum of team's skill level
{
    add up all skills of members, then store it
}
function to compare team's skill with bank's difficulty
{
    if (team's skill >= bank's difficulty)
    {
        display success
    }
    else
    {
        display fail
    }
}
*/

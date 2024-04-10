// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
List<TeamMember> teamMembers = new List<TeamMember>()
{

};
Console.WriteLine("Plan Your Heist!");
// Create an option menu
// First option is to exit app,
// Second is to add Team Member
// Add a class to store the Team Member
// After choosing to add team member, Prompt user to enter a name(string)
// After that prompt user to enter a skill level 1-5(integer)
// After that prompt the user to enter a Courage Factor(decimal)
// After all that diplay the information of the team member


StoreNewTeamMember(AddName(), AddSkill(), AddCourage());

string AddName()
{
    Console.WriteLine("Enter the name of your Team Member: ");
    string name = Console.ReadLine()!.Trim();
    return name;
};

int AddSkill()
{
    Console.WriteLine("What is their skill level(1-5): ");
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

void DisplayTeamMemberInfo()
{

    Console.WriteLine($"You have {teamMembers.Count} members on your team!");
    foreach (TeamMember member in teamMembers)
    {
        Console.WriteLine($"{member.Name} has a skill level of {member.SkillLevel} and a courage factor of {member.CourageFactor}");
    }
}

// Display Team Member
//  Name = AddName()

/*need to create an empty list to hold the new team members
*/
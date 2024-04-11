// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
List<TeamMember> teamMembers = new List<TeamMember>()
{

};



// Add a class to store the Team Member
// After choosing to add team member, Prompt user to enter a name(string)
// After that prompt user to enter a skill level 1-5(integer)
// After that prompt the user to enter a Courage Factor(decimal)
// After all that display the information of the team member
// Create a random number bewtween -10 and 10 for heist luck value
// Create a function that adds luck value to bank difficulty
// Before display success/fail message, show the team combined skill level and bank difficulty.
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
/*int trialruns = 0
 while(chosentrilruns < trailruns )
    {
        difficulty/skill level
        trialruns++
        loop stops once trialruns = chosentrialruns
    }*/

/*
Phase 6
prompt user to enter bank diffuclty level
readline
display report showing number of successes and number of fails
*/


Console.WriteLine("Plan Your Heist!");
Console.WriteLine("What is the bank's difficulty level?");
int BankLevel = int.Parse(Console.ReadLine().Trim());
int success = 0;
int failure = 0;
int LuckValue = RandomLuckValue();
int BankLevelWithLuck = BankLevelLuck(BankLevel, LuckValue);
// Console.WriteLine(LuckValue);
// Console.WriteLine(BankLevelWithLuck);
CreateTeamLoop();
int ChosenTrialRuns = ChooseNumberOfTrialRuns();

// loops thru for each ChosenTrailRuns and displays the report for each run and chooses a new random luck number each time
// line 80: setting a new random luck value (-10 ,10)
// line 81: setting the new banklevel with the random luck value
// line 82: displays the report
// line 83: displaying the success/failed messages
for (int trialRuns = 0; trialRuns < ChosenTrialRuns; trialRuns++)
{
    int newLuckValue = RandomLuckValue(); 
    BankLevelWithLuck = BankLevelLuck(BankLevel, newLuckValue); 
    Report(BankLevelWithLuck, SumOfTeamSkillLevels());
    CompareTeamSkillToBankDifficulty(SumOfTeamSkillLevels(), BankLevelWithLuck);
};
Console.WriteLine($@"Heist Report:
You had {success} successes :)
You had {failure} failures :(");
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

void Report(int BankLevel, int TotalTeamSkill)
{
    Console.WriteLine($"The total skill level of the team is : {TotalTeamSkill}");
    Console.WriteLine($"The bank difficulty level is: {BankLevel}");
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
        success ++;
    }
    else
    {
        Console.WriteLine("Don't do this mission, you will FAIL :(");
        failure++;
    }
}

int BankLevelLuck(int BankLevel, int LuckValue)
{
    int Luck = BankLevel + LuckValue;
    return Luck;
}

int ChooseNumberOfTrialRuns()
{
    Console.WriteLine("Please enter the amount of trial runs you would like to attempt");
    int ChosenNumberOfTrialRuns = int.Parse(Console.ReadLine()!.Trim());
    return ChosenNumberOfTrialRuns;
}

int RandomLuckValue()
{
    Random random = new Random();
    int RandomLuck = random.Next(-10, 11);
    return RandomLuck;
}
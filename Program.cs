string permission = "Admin|Manager";
int level = 87;

/*
string permission = "Admin|Manager";
int level = 54;

string permission = "Manager";
int level = 20;

string permission = "Manager";
int level = 19;

string permission = "Dwarf";
int level = 99999999;
*/

if ( permission.Contains("Admin") && level > 55 )
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if ( permission.Contains("Admin") && level <= 55 )
{
    Console.WriteLine("Welcome, Admin user.");
}
else if ( permission.Contains("Manager") && level >= 20 )
{
    Console.WriteLine("Contact an Admin for access.");
}
else if ( permission.Contains("Manager") && level < 20 )
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else if ( !permission.Contains("Admin") && !permission.Contains("Manager"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}
using EntityFrameworkTesting;

// // Create a new instance of the Testdb context
// using (var dbContext = new Testdb())
// {
//     // Create a new User object
//     var newUser = new User
//     {
//         FirstName = "Seth",
//         LastName = "Bowman"
//     };

//     // Add the new User to the Users DbSet
//     dbContext.Users.Add(newUser);

//     // Save changes to the database
//     dbContext.SaveChanges();

//     Console.WriteLine("User added successfully!");
// }

// Create a new instance of the Testdb context
using (var dbContext = new Testdb())
{
    // Retrieve the user with ID 2 from the database
    var userToUpdate = dbContext.Users.FirstOrDefault(u => u.Id == 2);

    // Check if the user exists
    if (userToUpdate != null)
    {
        // Update the properties of the user object
        userToUpdate.FirstName = "Cruz";
        userToUpdate.LastName = "Sanchez";

        // Save changes to the database
        dbContext.SaveChanges();

        Console.WriteLine("User updated successfully!");
    }
    else
    {
        Console.WriteLine("User with ID 2 not found!");
    }
}
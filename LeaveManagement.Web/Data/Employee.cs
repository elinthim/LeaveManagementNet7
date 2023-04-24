using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; }   //? questionmark can be nullable type string in the database because of the ? ? FirstName
        public string? Lastname { get; set; }
        public string? TaxId { get; set; }
            
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }

    }
}
//

//protected override void Up(MigrationBuilder migrationBuilder)
//{
  //  migrationBuilder.AddColumn<DateTime>(
    //    name: "DateJoined",
      //  table: "AspNetUsers",
  //      type: "datetime2",
    //    nullable: false, //Because i did not have  a questionmark in employee cs after string? before FirstName? it can not be nullable it can not have a null value now. so it is falseeee
      //  defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
      //remove-migration
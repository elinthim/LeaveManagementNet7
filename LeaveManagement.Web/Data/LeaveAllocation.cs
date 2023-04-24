using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }

        //Append dataannotation 
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }    
        public int LeaveTypeId { get; set; } //naming forreign key after the table property LeaveType

        public string EmployeeId { get; set; }  
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }  
            
        ///forreign key is refference to another primary key on another table
    }
}

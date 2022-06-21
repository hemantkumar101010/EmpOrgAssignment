using EmployeeOrg;
using EmployeeOrg.Data;
using EmployeeOrg.Data.Entities;

public class Program
{
   public static  CRUDManager crud = new CRUDManager();
    public static void Main()
    {


        //One to many: An employee id can have more then one organization values
        //Insert crud-operation
        #region First-approach
        //Employee employee = new Employee { Name = "Hemant", Address = "Srinagar" };

        //List<Organization> orgList = new List<Organization>();
        //orgList.Add(new Organization
        //{ OrgName = "Kellton",
        //    //passing the employee object also when we try to save data in Organizations Table
        //    Employee = employee
        //});
        //orgList.Add(new Organization
        //{
        //    OrgName = "TCS",
        //    Employee = employee
        //});

        //crud.InsertInOrgs(orgList);
        #endregion

        #region 2ed-approach
        List<Organization> orgList2 = new List<Organization>();
        orgList2.Add(new Organization { OrgName = "Google" });
        orgList2.Add(new Organization { OrgName = "Microsoft" });
       // passing orflist and employee obj together
        crud.InsertInOrgs(new Employee { Name = "Mayank", Address = "UP" }, orgList2);
        #endregion

        //Read Employee and Organization table crud-operation
        //ShowAllEmpOrgsDetails();



        //update employee with organizationslist

        List<Organization> OrgList = new List<Organization>();
       // OrgList.Add(new Organization { OrgName="Accenture"});
        OrgList.Add(new Organization { OrgName = "Citymall" });
        OrgList.Add(new Organization { OrgName = "Spacex" });

       // crud.UpdateEmpOrgs(6, new Employee{Name = "Hemant",Address = "Mumbai"}, OrgList);
       // Console.ReadKey();


        //delete crud
        //crud.DeleteImpOrg(6);


    }

    public static void ShowAllEmpOrgsDetails()
    {
        foreach(Employee item in crud.ReadEmployeeWithOrgs())
        {
            Console.Write($"EId: {item.ID}\tEName: {item.Name}\tEAddress: {item.Address}\t");
            foreach(Organization Oitem in item.OrganizationList)
            {
                Console.WriteLine($"OId: {Oitem.ID}\tOName: {Oitem.OrgName}");
            }
        }
    }
}
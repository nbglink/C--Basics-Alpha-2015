using System;


namespace S2PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter company phone: ");
            string companyPhone = Console.ReadLine();
            string companyFax = "(no fax)"; // just string
            Console.Write("Enter company website: ");
            string companyWeb = Console.ReadLine();
            Console.Write("Enter company manager first name: ");
            string companyManagerFName = Console.ReadLine();
            Console.Write("Enter company manager last name: ");
            string companyManagerLName = Console.ReadLine();
            Console.Write("Enter company manager age: ");
            int companyManagerAge = int.Parse(Console.ReadLine());
            Console.Write("Enter company manager phone: ");
            string companyManagerPhone = Console.ReadLine();



            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}",companyAddress);
            Console.WriteLine("Tel: {0:### ### ## ##}", companyPhone);
            Console.WriteLine("Company fax: {0}",companyFax);
            Console.WriteLine("Web site: {0}", companyWeb);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3:### ### ## ##})", companyManagerFName, companyManagerLName, companyManagerAge, companyManagerPhone);
           
            
        }
    }
}

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerLoanManager customerLoanManager = new CustomerLoanManager();
            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();

           

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(vehicleLoanManager,  dataBaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { { customerLoanManager}, {vehicleLoanManager }, { mortgageLoanManager} };

           // applicationManager.GiveCreditPreliminaryInformation(credits);



        }
    }
}

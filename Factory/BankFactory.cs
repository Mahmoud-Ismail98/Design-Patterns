namespace DesignPatterns.Factory
{
    public class BankFactory:IBankFactory
    {
        public IBank GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "123456" : return new BankA();
                case "111222" : return new BankB(); 
            }
            return null;
        }
    }
}
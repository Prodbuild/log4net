using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Log4NetDemoApplication
{
    class Program
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("Log4NetDemoApplication");

        static void Main(string[] args)
        {
            try
            {
                logger.Debug("Hello");

                logger.Error("Exceptino occurred", new Exception("Serious Exception"));

                logger.Info("Hello nothing happened.");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

            Console.ReadLine();

        }
    }
}

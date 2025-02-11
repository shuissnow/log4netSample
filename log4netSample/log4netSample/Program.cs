using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netSample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

			try
			{
				logger.Debug("デバッグ");
				logger.Info("情報");
				logger.Warn("警告");
				logger.Error("障害");
				logger.Fatal("致命的障害");
				throw new Exception("Fatal Errorですやん");
			}
			catch (Exception ex)
			{
				logger.Fatal(ex.ToString(), ex);
			}


			Console.ReadLine();
		}
	}
}

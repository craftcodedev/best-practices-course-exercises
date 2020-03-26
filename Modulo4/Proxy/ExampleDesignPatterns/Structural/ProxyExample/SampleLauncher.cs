using System;
using System.IO;
using Proxy.Impl;
using Proxy.Interfaces;

namespace Proxy
{
	public class SampleLauncher
	{
		static void Main(string[] args)
		{
		    Console.WriteLine("Client: Executing the client code with a real Internet:");

		    IInternet internet = new RealInternet();

		    try
		    {
		        internet.ConnectTo("craftcode.com");
		        internet.ConnectTo("abc.com");
            }
		    catch (Exception e)
		    {
		        Console.WriteLine(e.Message);
            }

            internet = new ProxyInternet(new RealInternet());

            try
            {
                internet.ConnectTo("craftcode.com");
                internet.ConnectTo("abc.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
	}
}

﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigurationSectionsLibrary;
using InterfacesLibrary;

namespace DemoCustomConfigSections
{
    class Program
    {
        static void Main(string[] args)
        {
            var environmentsConfig = ConfigurationService.Environments;

            if (environmentsConfig != null)
            {
                foreach (EnvironmentElement env in environmentsConfig.Environments)
                {
                    Console.WriteLine("{0}",env.Name);

                    foreach (ComputerElement computerConfig in env.Computers)
                    {
                        Console.WriteLine("\t{0}", computerConfig.Name);

                        foreach (DriveElement drive in computerConfig.Drives)
                        {
                            Console.WriteLine("\t\t{0} ({1})", drive.Name, drive.MinimumSpaceRequired);
                        }
                    }
                }
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

    }
}

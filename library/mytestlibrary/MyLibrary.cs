using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace mytestlibrary
{
    [ComVisible(true), Guid("BF0489DB-1A00-4D7B-A33A-15B7DB09DFC7")]
    public class MyLibrary
    {
        public string MyMethod(string argument1, int argument2, object[] argument3)
        {
            List<Object> arguments = new List<Object>() { argument1, argument2 };

            if (argument3 != null)
            {
                foreach (var arg in argument3) {
                    arguments.Add(arg);
                }
            }

            List<string> argument_types = new List<string>();

            foreach (var arg in arguments)
            {
                if (arg != null)
                {
                    argument_types.Add(arg.GetType().FullName);
                }
            }

            return String.Join("@", argument_types);
        }
    }
}

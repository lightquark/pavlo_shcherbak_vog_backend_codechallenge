using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API
{
    public static class TESTModule
    {
        public static object Module(object testObject)
        {
            switch (testObject)
            {
                case 1:
                    // there is no sense to double 1, so it's better to return it as is
                    return 1;
                case 2:
                    return doubler((int)testObject);
                case int value when value >= 3:
                    return tripler(value);
                // We must compare floating values in this way.
                // Another incomprehensibility is that we can return 9.0f instead of calculations because we want to always use 'leveler(1.0f)'
                //OLD: case float floatValue when floatValue == 1.0f:
                case float floatValue when Math.Abs(floatValue - 1.0f) <= float.Epsilon:
                    return leveler(floatValue);
                default:
                    return testObject;
            }


            int doubler(int amount) => amount * 2;
            int tripler(int amount) => amount * 3;
            // I changed type of parameter from double to float to be consistent with switch
            //OLD: double leveler(double amount) => amount - 0.1f * 10f;
            double leveler(float amount) => amount - 0.1f * 10f;
        }

    }

}

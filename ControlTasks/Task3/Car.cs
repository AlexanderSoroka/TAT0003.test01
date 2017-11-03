using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Car
    {
        private Params parameters;

        Car(Params parameters)
        {
            this.parameters = parameters;
        }

        public Params GetParams()
        {
            return parameters;
        }

        public Car[] Sort(Car[] cars)
        {
            for (var i = 0; i < cars.Length - 1; i++)
            {
                if (cars[i].GetParams().Prise - cars[i+1].GetParams().Prise > Double.Epsilon)
                {
                    Car buff = cars[i];
                    cars[i] = cars[i + 1];
                    cars[i + 1] = buff;
                }
            }

            return cars;
        }
    }
}

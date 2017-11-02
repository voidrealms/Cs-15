using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Wizzard
    {
        private int mAge = 0;


        /// <summary>
        /// Gets or sets the age
        /// </summary>
        public int Age
        {
            get
            {
                
                return mAge;
            }
            set
            {
                if (value > 200)
                {
                    mAge = 200;
                }
                else
                {
                    mAge = value;
                }
            }
        }


        public int BunnySlipper
        {
            get
            {
                return mAge;
            }
        }
    }
}

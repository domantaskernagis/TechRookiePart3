using System;
using System.Collections.Generic;
using System.Text;

namespace domantas.kernagis
{
    class egg
    {
        private bool isBroken; //tells if an egg is broken

        public egg(bool _isBroken)
        {
            IsBroken = _isBroken;
        }

        public bool IsBroken
        {
            get { return isBroken; }
            set
            {
                isBroken = value;
            }
        }
    }
}

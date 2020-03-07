using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ThirdPartyFilterAdapter : IFilter
    {
        private ThirdPartyFilter _thirdPartyFilter;

        public ThirdPartyFilterAdapter(ThirdPartyFilter thirdPartyFilter)
        {
            _thirdPartyFilter = thirdPartyFilter;
        }

        public void Apply()
        {
            _thirdPartyFilter.Filter();
        }
    }
}

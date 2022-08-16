using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uno.Extensions.Configuration;
using Uno.Extensions.Reactive;

namespace IWO_immutablelist_bug
{
    [ReactiveBindable]
    public partial class ViewModel
    {
        private IWritableOptions<Options> _hosConfig;

        public async ValueTask ModifyConfig()
        {

            return;
        }
    }
}

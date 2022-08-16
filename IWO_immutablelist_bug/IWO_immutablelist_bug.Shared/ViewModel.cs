using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;
using Uno.Extensions.Configuration;
using Uno.Extensions.Reactive;

namespace IWO_immutablelist_bug
{
    [ReactiveBindable]
    public partial class ViewModel
    {
        private IWritableOptions<Options> _config;
        public string testString = "test text2";

        public ViewModel(IWritableOptions<Options> config)
        {
            _config = config;
        }

        public async ValueTask UpdateString()
        {
            await _config.UpdateAsync(config =>
            {
                if (config._list.Contains("item1")) config._list.Remove("item1");
                else config._list.Add("item1");
            });
            await _config.UpdateAsync(config =>
            {
                var newList = config._immutableList.Contains("item1") ? config._immutableList.Remove("item1") : config._immutableList.Add("item1");
                return config with { _immutableList = newList };
            });
        }
    }
}

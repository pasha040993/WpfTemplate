using System;
using System.Collections.Generic;
using System.Text;
using WpfTemplate.Models;

namespace WpfTemplate.ViewModel
{
    public class RiskViewModel : ITag
    {
        private readonly Risk _risk;
        private readonly int _index;

        public RiskViewModel(Risk risk, int index)
        {
            _risk = risk;
            _index = index;
        }

        public string Message => $"Р-{_index}";

        public StateModes State => StateModes.Warning;
    }
}

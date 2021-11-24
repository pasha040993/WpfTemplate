using System;
using System.Collections.Generic;
using System.Text;
using WpfTemplate.Models;

namespace WpfTemplate.ViewModel
{
    public class EquipmentViewModel
    {
        private readonly Equipment _equipment;

        public EquipmentViewModel(Equipment equipment)
        {
            _equipment = equipment;
        }

        public string Name => _equipment.Name;

        public StateModes State => _equipment.State ? StateModes.Info : StateModes.Error;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfTemplate.Models;

namespace WpfTemplate.ViewModel
{
    class EventViewModel
    {
        private readonly Event _event;

        public List<ITag> Tags { get; } = new List<ITag>();

        public List<EquipmentViewModel> Equipments { get; } = new List<EquipmentViewModel>();

        public string DateTime => _event.DateTime.ToString("dd MMM yyyy HH:mm:ss");

        public string Source => _event.Source;

        public StateModes State => _event.State;

        public EventViewModel(Event @event)
        {
            _event = @event;

            foreach (var equipment in _event.Equipment)
            {
                Equipments.Add(new EquipmentViewModel(equipment));
            }

            Tags.Add(new MessageTextViewModel($"Ген. в работе {_event.Generators.Count(g => g.State)} из {_event.Generators.Count}:"));
            foreach (var generator in _event.Generators)
            {
                Tags.Add(new GeneratorViewModel(generator));
            }
            Tags.Add(new MessageTextViewModel("Риски:"));
            var index = 1;
            foreach (var risk in _event.Risks)
            {
                Tags.Add(new RiskViewModel(risk, index++));
            }
        }
    }
}

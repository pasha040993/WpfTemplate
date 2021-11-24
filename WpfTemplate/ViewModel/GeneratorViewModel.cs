using System;
using System.Collections.Generic;
using System.Text;
using WpfTemplate.Models;

namespace WpfTemplate.ViewModel
{
    public class GeneratorViewModel: ITag
    {
        private readonly Generator _generator;

        public GeneratorViewModel(Generator generator)
        {
            _generator = generator;
        }

        public string Message => _generator.Name;

        public StateModes State => _generator.State ? StateModes.Info : StateModes.Error;
    }
}

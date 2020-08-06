using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public abstract class OutputDecorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void ProduceOutput()
        {
            if (component != null)
                component.ProduceOutput();
        }
    }
}

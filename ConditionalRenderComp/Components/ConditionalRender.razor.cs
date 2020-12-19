using Microsoft.AspNetCore.Components;
using System;


namespace ConditionalRenderComp.Components
{
    public partial class ConditionalRender
    {
        [Parameter]
        public Func<bool> Condition { get; set; }

        private bool ConditionValue
        {
            get
            {
                return Condition != null && Condition.Invoke();
            }
        }

        [Parameter]
        public RenderFragment TrueCondition { get; set; }
        [Parameter]
        public RenderFragment FalseCondition { get; set; }

        public ConditionalRender()
        {
        }
    }
}

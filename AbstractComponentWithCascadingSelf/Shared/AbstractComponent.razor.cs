using Microsoft.AspNetCore.Components;

namespace AbstractComponentWithCascadingSelf.Shared {
    public abstract partial class AbstractComponent : IAbstractComponent {
        public abstract string Name { get; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }

    public interface IAbstractComponent { }
}
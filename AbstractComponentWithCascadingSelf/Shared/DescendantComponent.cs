namespace AbstractComponentWithCascadingSelf.Shared {
    public class DescendantComponent : AbstractComponent, IDescendantComponent {
        public override string Name  => "Descendant";
    }

    public interface IDescendantComponent { }
}

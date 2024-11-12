namespace Nova.Core.Plugins
{
    public abstract class ExtensionPoint
    {
        public abstract Type InterfaceType { get; }


    }

    public abstract class ExtensionPoint<TInterface> : ExtensionPoint
    {
        public override Type InterfaceType
        {
            get { return typeof(TInterface); }
        }
    }
}

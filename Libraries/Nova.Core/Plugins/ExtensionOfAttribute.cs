namespace Nova.Core.Plugins
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ExtensionOfAttribute : Attribute
    {
        #region Private fields

        private Type _extensionPointClass;

        #endregion Private fields

        #region Constructors

        public ExtensionOfAttribute(Type extensionPointClass)
        {
            _extensionPointClass = extensionPointClass;
        }

        #endregion Constructors

        #region Public Properties

        public Type ExtensionPointClass
        {
            get
            {
                return _extensionPointClass;
            }
        }

        #endregion Public Properties
    }
}

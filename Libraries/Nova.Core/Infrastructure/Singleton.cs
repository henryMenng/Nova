using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.Core.Infrastructure
{
    public partial class Singleton<T> : BaseSingleton
    {
        private static T? _instance;

        /// <summary>
        /// The singleton instance for the specified type T. Only one instance (at the time) of this object for each type of T.
        /// </summary>
        public static T Instance
        {
            get => _instance ?? throw new InvalidOperationException("Instance is not set.");
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Instance cannot be set to null.");
                }
                _instance = value;
                AllSingletons[typeof(T)] = value;
            }
        }
    }
}

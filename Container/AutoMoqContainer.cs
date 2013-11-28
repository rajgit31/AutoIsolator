using System.Diagnostics;
using Microsoft.Practices.Unity;
using Moq;

namespace AutoMocking.UnityMoq
{
    public enum DefaultBehavior
    {
        Empty = 0,
        AutoMock = 1,
    }

    /// <summary>
    /// Define members for auto mocking functionality
    /// with configured contains and the isolation object framework.
    /// </summary>
    public class AutoMockContainer : UnityContainer
    {
        private readonly DefaultBehavior _defaultBehavior;
        
        /// <summary>
        /// 
        /// </summary>
        public AutoMockContainer()
            : this(DefaultBehavior.AutoMock)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultBehavior"></param>
        public AutoMockContainer(DefaultBehavior defaultBehavior)
        {
            _defaultBehavior = defaultBehavior;
        }

        /// <summary>
        /// 
        /// </summary>
        public DefaultBehavior DefaultBehavior {
            get
            {
                return _defaultBehavior;
            }
        }

    }
}
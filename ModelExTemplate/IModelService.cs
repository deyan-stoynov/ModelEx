using System.Collections.Generic;
using System.Threading.Tasks;
using $DomainNamespace$;

namespace $CoreServiceNamespace$
{
    /// <summary>
    /// The $basename$ service interface.
    /// </summary>
    public interface I$basename$Service
	{        
        /// <summary>
        /// Gets the element by identifier asynchronously.
        /// </summary>
        /// <param name="id">The identifier.</param>
        Task<$basename$> GetAsync(long id);

        /// <summary>
        /// Gets the all elements asynchronously.
        /// </summary>
        Task<IEnumerable<$basename$>> GetAllAsync();
    }
}
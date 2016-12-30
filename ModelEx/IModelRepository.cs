using System.Collections.Generic;
using System.Threading.Tasks;
using $DomainNamespace$;

namespace $CoreRepoNamespace$
{
    /// <summary>
    /// The $itemname$ repository interface.
    /// </summary>
    public interface I$basename$Repository
	{    
        /// <summary>
        /// Gets the element by identifier asynchronously.
        /// </summary>
        /// <param name="id">The identifier.</param>
        Task<$basename$> GetAsync(int id);

        /// <summary>
        /// Gets the all elements asynchronously.
        /// </summary>
        Task<IEnumerable<$basename$>> GetAllAsync();
     }
}
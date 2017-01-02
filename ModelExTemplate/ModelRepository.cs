using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using $DomainNamespace$;
using $CoreRepoNamespace$;

namespace $DataNamespace$
{
    /// <summary>
    /// The default <see cref="I$basename$Repository"/> implementation.
    /// </summary>
    public class $basename$Repository : I$basename$Repository
	{
        /// See <see cref="I$basename$Repository" /> for more.
        public Task<$basename$> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        /// See <see cref="I$basename$Repository" /> for more.
        public Task<IEnumerable<$basename$>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
     }
}
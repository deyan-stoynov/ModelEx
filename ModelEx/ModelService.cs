using System.Collections.Generic;
using System.Threading.Tasks;
using $DomainNamespace$;
using $CoreRepoNamespace$;
using $CoreServiceNamespace$;

namespace $BuisnessNamespace$
{
    /// <summary>
    /// The default <see cref="I$basename$Service"/> implementation.
    /// </summary>
    public class $basename$Service : I$basename$Service
	{
        #region Fields

        private readonly I$basename$Repository $propname$;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="$basename$Service"/> class.
        /// </summary>
        public $basename$Service(I$basename$Repository $basename$Repository)
        {   
            $propname$ = $basename$Repository;
        }

        #endregion

        #region Public Methods

        /// See <see cref="I$basename$Service" /> for more.
        public Task<$basename$> GetAsync(int id)
        {
            return $propname$.GetAsync(id);
        }

        /// See <see cref="I$basename$Service" /> for more.
        public Task<IEnumerable<$basename$>> GetAllAsync()
        {
            return $propname$.GetAllAsync();
        }

        #endregion
    }
}
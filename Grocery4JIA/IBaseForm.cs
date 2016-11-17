using BLL;
using System.Collections.Generic;

namespace UI
{
    interface IBaseForm
    {
        List<IBaseManager> getManagers();
    }
}

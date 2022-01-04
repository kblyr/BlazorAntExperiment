using System.Collections.Generic;
using FromAntDesignTemplate.Models;
using Microsoft.AspNetCore.Components;
using AntDesign;

namespace FromAntDesignTemplate.Pages.Account.Center
{
    public partial class Applications
    {
        private readonly ListGridType _listGridType = new ListGridType
        {
            Gutter = 24,
            Column = 4
        };

        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}
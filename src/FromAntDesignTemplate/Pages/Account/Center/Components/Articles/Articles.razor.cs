using System.Collections.Generic;
using FromAntDesignTemplate.Models;
using Microsoft.AspNetCore.Components;

namespace FromAntDesignTemplate.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}
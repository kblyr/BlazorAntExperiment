using System.Collections.Generic;
using FromAntDesignTemplateWithLess.Models;
using Microsoft.AspNetCore.Components;

namespace FromAntDesignTemplateWithLess.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}
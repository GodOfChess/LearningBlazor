using GodOfChessSite.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodOfChessSite.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }

        private int currentCount = 0;

        [CascadingParameter] AppStyle styles { get; set; }

        private void IncrementCount()
        {
            currentCount++;

            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}

using Microsoft.AspNetCore.Components;
using NoBullshitBlazor.Data;

namespace NoBullshitBlazor.Shared
{
    public partial class PersonDisplay
    {
        [Parameter] 
        public Person Person { get; set; }
    }
}

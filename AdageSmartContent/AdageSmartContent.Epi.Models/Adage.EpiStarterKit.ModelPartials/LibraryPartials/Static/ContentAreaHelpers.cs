using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Static
{
    public static partial class ContentAreaHelpers
    {
        // src: https://krzysztofmorcinek.wordpress.com/2013/10/24/empty-contentarea-avoid-null/
        public static IEnumerable<ContentAreaItem> ItemsOrEmpty(this ContentArea contentArea)
        {
            return contentArea != null ? contentArea.Items : Enumerable.Empty<ContentAreaItem>();
        }

        public static IEnumerable<T> ItemsOfTypeOrEmpty<T>(this ContentArea contentArea)
        {
            if (contentArea == null)
                return Enumerable.Empty<T>();
            else
                return contentArea.Items.Select(i => i.GetContent()).OfType<T>();
        }

        public static IEnumerable<T> FilteredItemsOfTypeOrEmpty<T>(this ContentArea contentArea)
        {
            if (contentArea == null)
                return Enumerable.Empty<T>();
            else
                return contentArea.FilteredItems.Select(i => i.GetContent()).OfType<T>();
        }

        // src: https://krzysztofmorcinek.wordpress.com/2013/10/24/empty-contentarea-avoid-null/
        public static IEnumerable<ContentAreaItem> FilteredItemsOrEmpty(this ContentArea contentArea)
        {
            return contentArea != null ? contentArea.FilteredItems : Enumerable.Empty<ContentAreaItem>();
        }
    }
}

using Navigations.MVVM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigations.Utilities
{
    public class NavigationUtilities
    {
        public static void Examine(INavigation navigation)
        {
            StringBuilder stringBuilder = new();

            foreach (var page in navigation.NavigationStack)
            {
                stringBuilder.AppendLine(page.GetType().Name);
            }

            /* to separate each page when we call the method */

            stringBuilder.AppendLine("-----------------");

            Debug.WriteLine(stringBuilder.ToString());
        }


        /* Method to insert a new page, before another page, but from here, the NavigatioinStack */

        public static void InsertPage(INavigation navigation)
        {
            //var page = navigation.NavigationStack[navigation.NavigationStack.Count - 1];

            /* the second page, the one we want to replace */
            var pageToReplace = navigation.NavigationStack.ElementAtOrDefault(1);


            if (pageToReplace is not null)
            {
                navigation.InsertPageBefore(new AddedPage(), pageToReplace); //insert this page (AddedPage) before it..
            }
        }

        /* method to remove a page from the NavigationStack, from here. This can come in handy in removing the login page after the login so that the user won't find it after login */
        public static void RemovePage(INavigation navigation, string pageName)
        {
            var pageToDelete = navigation.NavigationStack.FirstOrDefault(x => x.GetType().Name == pageName); /* Get the page here .. */

            if (pageToDelete is not null)
            {
                navigation.RemovePage(pageToDelete);
            }
        }
    }
}

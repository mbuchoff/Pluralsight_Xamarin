using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using BethanysPieShopMobile.Core.Model;

namespace BethanysPieShopMobile.Fragments
{
    public class PieCategoryFragment : Android.Support.V4.App.Fragment
    {
        private readonly Category _category;

        public PieCategoryFragment(Category category)
        {
            _category = category;
        }
    }
}
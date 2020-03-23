﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Auth0.Xamarin.Droid.Model
{
    class UserProfile
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string ProfilePictureUrl { get; set; }

    }
}
﻿using Calendar.Abstract;
using Calendar.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Entities
{
    internal class Meeting : Event , INotification
    {
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
                Console.WriteLine($"Inviting: {guest}");
        }
    }
}

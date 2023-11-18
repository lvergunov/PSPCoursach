using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


    public class Room
    {
        public BoundsInt Bounds { get; }
        public Room(BoundsInt bounds) {
            Bounds = bounds; 
        }
    private List<StaticItem> _items = new List<StaticItem>();
    }


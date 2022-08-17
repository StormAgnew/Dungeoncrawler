﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoncrawler
{
    public class MonsterLibrary
    {
        private string _name;
        private int _attack;
        private int _defense;
        private int _health;
        private int _magic;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Attack { get { return _attack; } set { _attack = value; } }
        public int Defense { get { return _defense; } set { _defense = value; } }
        public int Health { get { return _health; } set { _health = value; } }
        public int Magic { get { return _magic; } set { _magic = value; } }
                
    }
}

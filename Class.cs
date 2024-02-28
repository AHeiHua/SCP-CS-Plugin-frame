using UnityEngine;
using Akequ;
using Akequ.Base;
using System.Reflection;
using System.Collections.Generic;
using System;

namespace HeiHua
{
    public class Class
    {
        public List<Type> GetAllClass()
        {
            List<Type> playerClasses = new List<Type>();
            foreach(var item in Assembly.GetExecutingAssembly().GetTypes())
            {
                if(item.FullName != typeof(PlayerClass).FullName)
                {
                    playerClasses.Add((Type)item);
                }
            }
            return playerClasses;
        }
    }
}
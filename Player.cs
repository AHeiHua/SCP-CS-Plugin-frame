using Akequ;
using Akequ.Base;
using System.Collections.Generic;
using UnityEngine;

namespace HeiHua
{
    public class Players
    {
        /// <summary>
        /// 通过名字获取玩家
        /// </summary>
        /// <param name="玩家名字"></param>
        /// <returns>玩家列表</returns>
        public Player[] GetPlayerOfName(string name)
        {
            List<Player> plys = new List<Player>();
            foreach (Player ply in GameObject.FindObjectsOfType<Player>())
            {
                if (ply.name == name)
                {
                    plys.Add(ply);
                }
            }
            return plys.ToArray();
        }
        /// <summary>
        /// 通过连接获取玩家
        /// </summary>
        /// <param name="conn">连接</param>
        /// <returns>玩家列表</returns>
        public Player GetPlayerOfConnection(Mirror.NetworkConnectionToClient conn)
        {
            return PlayerUtilities.GetServerPlayer(conn);
        }

        /// <summary>
        /// 通过职业类型获取玩家
        /// </summary>
        /// <param name="playerClass">职业类型</param>
        /// <returns>玩家列表</returns>
        public Player[] GetPlayerOfType(PlayerClass playerClass)
        {
            List<Player> plys = new List<Player>();
            foreach (Player ply in GameObject.FindObjectsOfType<Player>())
            {
                PlayerClassProxy proxy = ply.playerClass as PlayerClassProxy;
                if (proxy == playerClass as PlayerClassProxy)
                {
                    plys.Add(ply);
                }
            }
            return plys.ToArray();
        }

        /// <summary>
        /// 设置玩家职业
        /// </summary>
        /// <param name="ply">要设置的玩家</param>
        /// <param name="className">职业名称</param>
        public void SetClass(Player ply,string className)
        {
            ply.SetClass(className);
        }

        /// <summary>
        /// 更改玩家名称
        /// </summary>
        /// <param name="ply"></param>
        /// <param name="name"></param>
        public void SetName(Player ply,string name)
        {
            ply.accountName = name;
        }

        /// <summary>
        /// 获取玩家名字
        /// </summary>
        /// <param name="ply"></param>
        /// <returns>玩家名字</returns>
        public string GetPlayerName(Player ply)
        {
            return ply.accountName;
        }

        /// <summary>
        /// 获取玩家账号UID
        /// </summary>
        /// <param name="ply"></param>
        /// <returns>玩家ID</returns>
        public long GetPlayerLongID(Player ply)
        {
            return ply.accountUID;
        }

        /// <summary>
        /// 获取玩家在服务器中的ID
        /// </summary>
        /// <param name="ply"></param>
        /// <returns>连接创建的ID</returns>
        public short GetPlayerShortID(Player ply)
        {
            return ply.playerId;
        }
    }
}
using Akequ.Classes;
using HeiHua;

public class Test
{
    public void example()
    {
        //实例一个Players类
        Players plys = new Players();
        //获取玩家通过名字
        plys.GetPlayerOfName("PlayerName");
        //获取玩家通过职业
        plys.GetPlayerOfType(new Akequ.Base.PlayerClass());
        //或者plys.GetPlayerOfType(player.playerClass);
        //获取玩家通过
        plys.GetPlayerOfConnection(new Mirror.NetworkConnectionToClient(123));
        //获取玩家名字
        Player ply = new Player();
        plys.GetPlayerName(ply);
        //获取玩家账号UID
        plys.GetPlayerLongID(ply);
        //获取玩家临时UID
        plys.GetPlayerShortID(ply);
        //设置玩家职业
        plys.SetClass(ply, "ClassD");
        //设置玩家名字
        plys.SetName(ply, "NewName");
    }
}
// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestPrepareSceneChanger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003247")]
  public static class QuestPrepareSceneChanger
  {
    [Token(Token = "0x6013995")]
    [Address(RVA = "0x4611B88", Offset = "0x4611B88", VA = "0x4611B88")]
    public static void ChangeToBattle(
      string battleUuid,
      QuestInfo questInfo,
      OrganizationTeam team,
      List<PlayerUnitLevelUpType> unitLvUps,
      List<PlayerBattleChestDropType> chestDropList,
      List<PlayerBattleEnemyDrop> enemyDropsList,
      int rollbackCnt,
      int lap = 0,
      int initDamage = 0,
      bool isMock = false,
      string sceneName = "PvEBattleMain")
    {
    }
  }
}

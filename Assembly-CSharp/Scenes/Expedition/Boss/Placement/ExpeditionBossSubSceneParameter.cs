// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Boss.Placement.ExpeditionBossSubSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Expedition.Boss.Placement
{
  [Token(Token = "0x2002D4E")]
  public sealed class ExpeditionBossSubSceneParameter : ChangeSceneParameter
  {
    [Token(Token = "0x17003C91")]
    public ExpeditionStageData StageData
    {
      [Token(Token = "0x6011B58"), Address(RVA = "0x42B5E38", Offset = "0x42B5E38", VA = "0x42B5E38")] get
      {
        return (ExpeditionStageData) null;
      }
      [Token(Token = "0x6011B59"), Address(RVA = "0x42B5E40", Offset = "0x42B5E40", VA = "0x42B5E40")] private set
      {
      }
    }

    [Token(Token = "0x17003C92")]
    public ExpeditionBossDescriptionData BossData
    {
      [Token(Token = "0x6011B5A"), Address(RVA = "0x42B5E48", Offset = "0x42B5E48", VA = "0x42B5E48")] get
      {
        return (ExpeditionBossDescriptionData) null;
      }
      [Token(Token = "0x6011B5B"), Address(RVA = "0x42B5E50", Offset = "0x42B5E50", VA = "0x42B5E50")] private set
      {
      }
    }

    [Token(Token = "0x6011B5C")]
    [Address(RVA = "0x42ABBA8", Offset = "0x42ABBA8", VA = "0x42ABBA8")]
    public ExpeditionBossSubSceneParameter(
      ExpeditionStageData stageData,
      ExpeditionBossDescriptionData bossData)
    {
    }
  }
}

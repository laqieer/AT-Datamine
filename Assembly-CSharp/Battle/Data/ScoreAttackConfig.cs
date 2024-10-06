// Decompiled with JetBrains decompiler
// Type: Battle.Data.ScoreAttackConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.ScoreAttack;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002712")]
  public class ScoreAttackConfig : StoryBattleConfig
  {
    [Token(Token = "0x17003391")]
    public AllocatePoint AllocatePoint
    {
      [Token(Token = "0x600F26B"), Address(RVA = "0x41B6930", Offset = "0x41B6930", VA = "0x41B6930")] get
      {
        return (AllocatePoint) null;
      }
      [Token(Token = "0x600F26C"), Address(RVA = "0x41B6938", Offset = "0x41B6938", VA = "0x41B6938")] private set
      {
      }
    }

    [Token(Token = "0x600F26D")]
    [Address(RVA = "0x41B6940", Offset = "0x41B6940", VA = "0x41B6940")]
    public ScoreAttackConfig(PvEBattle.QuestBattleSceneParameter parameter)
    {
    }

    [Token(Token = "0x600F26E")]
    [Address(RVA = "0x41B6968", Offset = "0x41B6968", VA = "0x41B6968")]
    private void SetupAllocatePoint(PvEBattle.QuestBattleSceneParameter parameter)
    {
    }
  }
}

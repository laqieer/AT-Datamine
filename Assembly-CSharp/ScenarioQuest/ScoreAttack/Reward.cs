// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.Reward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200085F")]
  internal struct Reward
  {
    [Token(Token = "0x40027B3")]
    [FieldOffset(Offset = "0x0")]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40027B4")]
    [FieldOffset(Offset = "0x4")]
    public int rewardId;
    [Token(Token = "0x40027B5")]
    [FieldOffset(Offset = "0x8")]
    public int amount;

    [Token(Token = "0x6003023")]
    [Address(RVA = "0x3E75F3C", Offset = "0x3E75F3C", VA = "0x3E75F3C")]
    public Reward(RewardTypeEnum type, int id, int amount)
    {
    }
  }
}

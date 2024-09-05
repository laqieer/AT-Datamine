// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.RewardConditionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x200298E")]
  public class RewardConditionData
  {
    [Token(Token = "0x400B101")]
    [FieldOffset(Offset = "0x10")]
    public int ProgressId;
    [Token(Token = "0x400B102")]
    [FieldOffset(Offset = "0x14")]
    public int Num;
    [Token(Token = "0x400B103")]
    [FieldOffset(Offset = "0x18")]
    public int RewardPoint;
    [Token(Token = "0x400B104")]
    [FieldOffset(Offset = "0x1C")]
    public TreasureType Type;

    [Token(Token = "0x601054D")]
    [Address(RVA = "0x475FBF4", Offset = "0x475FBF4", VA = "0x475FBF4")]
    public RewardConditionData(int progressId, int num, int rewardPoint, TreasureType type)
    {
    }
  }
}

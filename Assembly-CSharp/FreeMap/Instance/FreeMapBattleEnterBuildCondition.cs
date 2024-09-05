// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapBattleEnterBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018C5")]
  public class FreeMapBattleEnterBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B8C")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;

    [Token(Token = "0x6008CE6")]
    [Address(RVA = "0x451FC10", Offset = "0x451FC10", VA = "0x451FC10")]
    public FreeMapBattleEnterBuildCondition(
      int battleenterLayoutID,
      StoryFreeActionLayoutData layout = null)
    {
    }

    [Token(Token = "0x6008CE7")]
    [Address(RVA = "0x4530A24", Offset = "0x4530A24", VA = "0x4530A24", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}

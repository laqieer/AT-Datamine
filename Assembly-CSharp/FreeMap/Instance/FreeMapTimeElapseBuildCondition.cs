// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapTimeElapseBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018DB")]
  public class FreeMapTimeElapseBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006BC1")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;

    [Token(Token = "0x6008D26")]
    [Address(RVA = "0x4522CB0", Offset = "0x4522CB0", VA = "0x4522CB0")]
    public FreeMapTimeElapseBuildCondition(int timeElapseLayoutID, StoryFreeActionLayoutData layout = null)
    {
    }

    [Token(Token = "0x6008D27")]
    [Address(RVA = "0x4532F3C", Offset = "0x4532F3C", VA = "0x4532F3C", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}

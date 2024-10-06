// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapObliviaeBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018CF")]
  public class FreeMapObliviaeBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B9C")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;

    [Token(Token = "0x6008D05")]
    [Address(RVA = "0x4531C94", Offset = "0x4531C94", VA = "0x4531C94")]
    public FreeMapObliviaeBuildCondition(
      int sequenceID,
      int obliviaeLayoutID,
      StoryFreeActionLayoutData layout = null)
    {
    }

    [Token(Token = "0x6008D06")]
    [Address(RVA = "0x4531DB0", Offset = "0x4531DB0", VA = "0x4531DB0", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}

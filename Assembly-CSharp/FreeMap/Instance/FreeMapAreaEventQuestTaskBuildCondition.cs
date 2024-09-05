// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapAreaEventQuestTaskBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018C4")]
  public class FreeMapAreaEventQuestTaskBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B8A")]
    [FieldOffset(Offset = "0x10")]
    protected readonly FreeMapLayoutBuildCondition conditionLayout;
    [Token(Token = "0x4006B8B")]
    [FieldOffset(Offset = "0x18")]
    protected readonly StoryAreaEventQuestTaskData taskMaster;

    [Token(Token = "0x6008CE2")]
    [Address(RVA = "0x4530714", Offset = "0x4530714", VA = "0x4530714")]
    public FreeMapAreaEventQuestTaskBuildCondition(int taskID, int sequenceID)
    {
    }

    [Token(Token = "0x6008CE3")]
    [Address(RVA = "0x45307D0", Offset = "0x45307D0", VA = "0x45307D0")]
    public FreeMapAreaEventQuestTaskBuildCondition(StoryAreaEventQuestTaskData task, int sequenceID)
    {
    }

    [Token(Token = "0x6008CE4")]
    [Address(RVA = "0x4530870", Offset = "0x4530870", VA = "0x4530870", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}

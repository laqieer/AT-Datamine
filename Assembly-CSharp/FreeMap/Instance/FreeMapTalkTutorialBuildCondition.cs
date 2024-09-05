// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapTalkTutorialBuildCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.ModeState;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018CB")]
  public class FreeMapTalkTutorialBuildCondition : IFreeMapBuildCondition
  {
    [Token(Token = "0x4006B96")]
    [FieldOffset(Offset = "0x10")]
    private TutorialModaState stateRef;

    [Token(Token = "0x6008CF6")]
    [Address(RVA = "0x45312F8", Offset = "0x45312F8", VA = "0x45312F8")]
    public FreeMapTalkTutorialBuildCondition(TutorialModaState state)
    {
    }

    [Token(Token = "0x6008CF7")]
    [Address(RVA = "0x4531320", Offset = "0x4531320", VA = "0x4531320", Slot = "4")]
    public bool CanCreate(int sequenceID) => new bool();
  }
}

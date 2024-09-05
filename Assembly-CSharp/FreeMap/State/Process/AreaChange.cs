// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AreaChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017A3")]
  public class AreaChange : FreeMapProcess
  {
    [Token(Token = "0x1700154C")]
    public ITransitionEvent TransitionEvent
    {
      [Token(Token = "0x6008626"), Address(RVA = "0x406F2C0", Offset = "0x406F2C0", VA = "0x406F2C0")] set
      {
      }
      [Token(Token = "0x6008627"), Address(RVA = "0x406F2C8", Offset = "0x406F2C8", VA = "0x406F2C8")] get
      {
        return (ITransitionEvent) null;
      }
    }

    [Token(Token = "0x6008628")]
    [Address(RVA = "0x406F2D0", Offset = "0x406F2D0", VA = "0x406F2D0")]
    public AreaChange(FreeMapStateManager entity, ITransitionEvent transitionEvent)
    {
    }

    [Token(Token = "0x6008629")]
    [Address(RVA = "0x406F2F8", Offset = "0x406F2F8", VA = "0x406F2F8", Slot = "4")]
    public override void Begin()
    {
    }
  }
}

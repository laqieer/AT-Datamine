// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AreaRelease
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017AE")]
  public class AreaRelease : FreeMapProcess
  {
    [Token(Token = "0x4006897")]
    [FieldOffset(Offset = "0x38")]
    protected MovableMobManager movableMobManager;

    [Token(Token = "0x600865C")]
    [Address(RVA = "0x406FDC0", Offset = "0x406FDC0", VA = "0x406FDC0")]
    public AreaRelease(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x600865D")]
    [Address(RVA = "0x406FE58", Offset = "0x406FE58", VA = "0x406FE58", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600865E")]
    [Address(RVA = "0x406F6E8", Offset = "0x406F6E8", VA = "0x406F6E8")]
    public static void Release(FreeMapStateManager entity, MovableMobManager movableMobManager)
    {
    }
  }
}

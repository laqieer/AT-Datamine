// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.NpcLookAtBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Instance.Element;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x200171C")]
  public abstract class NpcLookAtBase : IFreeMapButtonEventTask
  {
    [Token(Token = "0x40066F7")]
    [FieldOffset(Offset = "0x18")]
    protected FreeMapCharacterLookAt lookAt;
    [Token(Token = "0x40066F8")]
    [FieldOffset(Offset = "0x20")]
    protected FreeMapCharacter npcInstance;
    [Token(Token = "0x40066F9")]
    [FieldOffset(Offset = "0x28")]
    protected InstanceID npcInstanceID;

    [Token(Token = "0x17001478")]
    protected FreeMapInstanceHolder InstanceHolder
    {
      [Token(Token = "0x60082C9"), Address(RVA = "0x420227C", Offset = "0x420227C", VA = "0x420227C")] get
      {
        return (FreeMapInstanceHolder) null;
      }
    }

    [Token(Token = "0x60082CA")]
    [Address(RVA = "0x4202284", Offset = "0x4202284", VA = "0x4202284")]
    protected NpcLookAtBase(FreeMapInstanceHolder instanceHolder, InstanceID instanceID)
    {
    }

    [Token(Token = "0x60082CB")]
    [Address(RVA = "0x42022B4", Offset = "0x42022B4", VA = "0x42022B4", Slot = "7")]
    public virtual void Execute()
    {
    }

    [Token(Token = "0x60082CC")]
    [Address(RVA = "0x4202488", Offset = "0x4202488", VA = "0x4202488", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x60082CD")]
    [Address(RVA = "0x420248C", Offset = "0x420248C", VA = "0x420248C", Slot = "8")]
    public virtual bool IsBusy() => new bool();
  }
}

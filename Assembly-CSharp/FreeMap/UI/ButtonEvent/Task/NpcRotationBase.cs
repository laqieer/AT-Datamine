// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.NpcRotationBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x200171F")]
  public abstract class NpcRotationBase : IFreeMapButtonEventTask
  {
    [Token(Token = "0x40066FC")]
    [FieldOffset(Offset = "0x10")]
    protected float rotationSpeed;
    [Token(Token = "0x40066FD")]
    [FieldOffset(Offset = "0x14")]
    protected float rotationLimit;
    [Token(Token = "0x40066FE")]
    [FieldOffset(Offset = "0x18")]
    private bool enable;
    [Token(Token = "0x4006700")]
    [FieldOffset(Offset = "0x28")]
    protected FreeMapInstance npcInstance;
    [Token(Token = "0x4006701")]
    [FieldOffset(Offset = "0x30")]
    protected InstanceID npcInstanceID;
    [Token(Token = "0x4006702")]
    [FieldOffset(Offset = "0x38")]
    protected Quaternion targetRotation;

    [Token(Token = "0x17001479")]
    protected FreeMapInstanceHolder InstanceHolder
    {
      [Token(Token = "0x60082D4"), Address(RVA = "0x4202780", Offset = "0x4202780", VA = "0x4202780")] get
      {
        return (FreeMapInstanceHolder) null;
      }
    }

    [Token(Token = "0x60082D5")]
    [Address(RVA = "0x4202788", Offset = "0x4202788", VA = "0x4202788")]
    protected NpcRotationBase(FreeMapInstanceHolder instanceHolder, InstanceID instanceID)
    {
    }

    [Token(Token = "0x60082D6")]
    [Address(RVA = "0x42027C4", Offset = "0x42027C4", VA = "0x42027C4", Slot = "7")]
    public virtual void Execute()
    {
    }

    [Token(Token = "0x60082D7")]
    [Address(RVA = "0x42027EC", Offset = "0x42027EC", VA = "0x42027EC", Slot = "8")]
    public virtual bool IsBusy() => new bool();

    [Token(Token = "0x60082D8")]
    [Address(RVA = "0x4202868", Offset = "0x4202868", VA = "0x4202868", Slot = "9")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x60082D9")]
    [Address(RVA = "0x4202A90", Offset = "0x4202A90", VA = "0x4202A90")]
    protected void StartRotation(Quaternion targetRotation)
    {
    }
  }
}

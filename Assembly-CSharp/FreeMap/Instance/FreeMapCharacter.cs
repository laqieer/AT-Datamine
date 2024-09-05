// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapCharacter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using Story.Prop;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018BD")]
  public class FreeMapCharacter : 
    FreeMapInstance,
    IFreeMapVisibleObject,
    IFreeMapObjectOutsideModelControll,
    IPropEventSubject
  {
    [Token(Token = "0x4006B54")]
    [FieldOffset(Offset = "0x58")]
    private ResourceCacheHandle modelHandle;
    [Token(Token = "0x4006B55")]
    [FieldOffset(Offset = "0x68")]
    protected GameObject modelObject;
    [Token(Token = "0x4006B56")]
    [FieldOffset(Offset = "0x70")]
    protected PropEventSender propEventSender;
    [Token(Token = "0x4006B57")]
    [FieldOffset(Offset = "0x78")]
    private List<GameObject> propObjs;

    [Token(Token = "0x1700168C")]
    public Animator TargetAnimator
    {
      [Token(Token = "0x6008C75"), Address(RVA = "0x452CE34", Offset = "0x452CE34", VA = "0x452CE34")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x1700168D")]
    public FreeMapCharacterAction MyAction
    {
      [Token(Token = "0x6008C76"), Address(RVA = "0x452CE50", Offset = "0x452CE50", VA = "0x452CE50")] protected set
      {
      }
      [Token(Token = "0x6008C77"), Address(RVA = "0x452CE58", Offset = "0x452CE58", VA = "0x452CE58")] get
      {
        return (FreeMapCharacterAction) null;
      }
    }

    [Token(Token = "0x1700168E")]
    public GameObject ModelObject
    {
      [Token(Token = "0x6008C78"), Address(RVA = "0x452CE60", Offset = "0x452CE60", VA = "0x452CE60")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6008C79")]
    [Address(RVA = "0x452CE68", Offset = "0x452CE68", VA = "0x452CE68")]
    protected void Awake()
    {
    }

    [Token(Token = "0x6008C7A")]
    [Address(RVA = "0x452CEC8", Offset = "0x452CEC8", VA = "0x452CEC8")]
    public void Setup(ResourceCacheHandle modelHandle, GameObject model, Animator animator)
    {
    }

    [Token(Token = "0x6008C7B")]
    [Address(RVA = "0x452D05C", Offset = "0x452D05C", VA = "0x452D05C", Slot = "8")]
    public override void InstanceUpdate()
    {
    }

    [Token(Token = "0x6008C7C")]
    [Address(RVA = "0x452D074", Offset = "0x452D074", VA = "0x452D074", Slot = "10")]
    public override void ReleaseInstance()
    {
    }

    [Token(Token = "0x6008C7D")]
    [Address(RVA = "0x452D2F0", Offset = "0x452D2F0", VA = "0x452D2F0", Slot = "15")]
    public virtual Transform GetLookAtPoint() => (Transform) null;

    [Token(Token = "0x6008C7E")]
    [Address(RVA = "0x452D318", Offset = "0x452D318", VA = "0x452D318", Slot = "11")]
    public void Show()
    {
    }

    [Token(Token = "0x6008C7F")]
    [Address(RVA = "0x452D338", Offset = "0x452D338", VA = "0x452D338", Slot = "12")]
    public void Hide()
    {
    }

    [Token(Token = "0x6008C80")]
    [Address(RVA = "0x452D358", Offset = "0x452D358", VA = "0x452D358", Slot = "13")]
    public GameObject Get3DModelRef() => (GameObject) null;

    [Token(Token = "0x6008C81")]
    [Address(RVA = "0x452D3CC", Offset = "0x452D3CC", VA = "0x452D3CC", Slot = "14")]
    public void Subscribe(IPropEventObserver observer)
    {
    }

    [Token(Token = "0x6008C82")]
    [Address(RVA = "0x452D464", Offset = "0x452D464", VA = "0x452D464")]
    public void AddPropObject(GameObject prop)
    {
    }

    [Token(Token = "0x6008C83")]
    [Address(RVA = "0x452D50C", Offset = "0x452D50C", VA = "0x452D50C")]
    public FreeMapCharacter()
    {
    }
  }
}

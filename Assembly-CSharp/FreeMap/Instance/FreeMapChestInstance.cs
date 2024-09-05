// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapChestInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Prop;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018FF")]
  public class FreeMapChestInstance : FreeMapRewardInstance, IPropEventSubject, IFreeMapVisibleObject
  {
    [Token(Token = "0x4006C04")]
    private const string OpenEventName = "chest_open";
    [Token(Token = "0x4006C05")]
    private const string OpendAnimationName = "AfterAction";
    [Token(Token = "0x4006C07")]
    [FieldOffset(Offset = "0x58")]
    private FreeMapInstancePlaySESubscribeHelper seEventSubscriber;
    [Token(Token = "0x4006C09")]
    [FieldOffset(Offset = "0x68")]
    private bool isOpened;

    [Token(Token = "0x14000124")]
    private event UnityAction<AnimationEvent> SendEvent
    {
      [Token(Token = "0x6008DF2"), Address(RVA = "0x4AFC6D4", Offset = "0x4AFC6D4", VA = "0x4AFC6D4")] add
      {
      }
      [Token(Token = "0x6008DF3"), Address(RVA = "0x4AFC784", Offset = "0x4AFC784", VA = "0x4AFC784")] remove
      {
      }
    }

    [Token(Token = "0x170016BD")]
    private GameObject ModelObject
    {
      [Token(Token = "0x6008DF4"), Address(RVA = "0x4AFC834", Offset = "0x4AFC834", VA = "0x4AFC834")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6008DF5"), Address(RVA = "0x4AFC83C", Offset = "0x4AFC83C", VA = "0x4AFC83C")] set
      {
      }
    }

    [Token(Token = "0x6008DF6")]
    [Address(RVA = "0x4AFC844", Offset = "0x4AFC844", VA = "0x4AFC844", Slot = "8")]
    public override void InstanceUpdate()
    {
    }

    [Token(Token = "0x6008DF7")]
    [Address(RVA = "0x4AFC848", Offset = "0x4AFC848", VA = "0x4AFC848")]
    public void SubScribeSE(int chestID)
    {
    }

    [Token(Token = "0x6008DF8")]
    [Address(RVA = "0x4AFCAE8", Offset = "0x4AFCAE8", VA = "0x4AFCAE8", Slot = "10")]
    public override void ReleaseInstance()
    {
    }

    [Token(Token = "0x6008DF9")]
    [Address(RVA = "0x4AFCB9C", Offset = "0x4AFCB9C", VA = "0x4AFCB9C")]
    public void Open()
    {
    }

    [Token(Token = "0x6008DFA")]
    [Address(RVA = "0x4AFCC54", Offset = "0x4AFCC54", VA = "0x4AFCC54")]
    public void Opened()
    {
    }

    [Token(Token = "0x6008DFB")]
    [Address(RVA = "0x4AFCCDC", Offset = "0x4AFCCDC", VA = "0x4AFCCDC", Slot = "11")]
    public void Subscribe(IPropEventObserver observer)
    {
    }

    [Token(Token = "0x6008DFC")]
    [Address(RVA = "0x4AFCDBC", Offset = "0x4AFCDBC", VA = "0x4AFCDBC")]
    public void OnEnable()
    {
    }

    [Token(Token = "0x6008DFD")]
    [Address(RVA = "0x4AFCDCC", Offset = "0x4AFCDCC", VA = "0x4AFCDCC")]
    public void BindModel(GameObject model)
    {
    }

    [Token(Token = "0x6008DFE")]
    [Address(RVA = "0x4AFCDD4", Offset = "0x4AFCDD4", VA = "0x4AFCDD4", Slot = "12")]
    public void Show()
    {
    }

    [Token(Token = "0x6008DFF")]
    [Address(RVA = "0x4AFCDEC", Offset = "0x4AFCDEC", VA = "0x4AFCDEC", Slot = "13")]
    public void Hide()
    {
    }

    [Token(Token = "0x6008E00")]
    [Address(RVA = "0x4AFCE04", Offset = "0x4AFCE04", VA = "0x4AFCE04")]
    public FreeMapChestInstance()
    {
    }
  }
}

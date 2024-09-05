// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapBreakableInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.FadeContent;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018F9")]
  public class FreeMapBreakableInstance : FreeMapRewardInstance, IFreeMapVisibleObject
  {
    [Token(Token = "0x4006BF6")]
    [FieldOffset(Offset = "0x58")]
    private AreaObjectFadeContent fadeContent;
    [Token(Token = "0x4006BF7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private float fadeOutWaitTime;
    [Token(Token = "0x4006BF8")]
    [FieldOffset(Offset = "0x68")]
    private Coroutine fadeCoroutine;
    [Token(Token = "0x4006BF9")]
    [FieldOffset(Offset = "0x70")]
    private bool isDelayFadeWait;

    [Token(Token = "0x170016B5")]
    private GameObject ModelObject
    {
      [Token(Token = "0x6008DCD"), Address(RVA = "0x4AFBD94", Offset = "0x4AFBD94", VA = "0x4AFBD94")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6008DCE"), Address(RVA = "0x4AFBD9C", Offset = "0x4AFBD9C", VA = "0x4AFBD9C")] set
      {
      }
    }

    [Token(Token = "0x6008DCF")]
    [Address(RVA = "0x4AFBDA4", Offset = "0x4AFBDA4", VA = "0x4AFBDA4")]
    public void BindModel(GameObject model)
    {
    }

    [Token(Token = "0x6008DD0")]
    [Address(RVA = "0x4AFBE10", Offset = "0x4AFBE10", VA = "0x4AFBE10", Slot = "8")]
    public override void InstanceUpdate()
    {
    }

    [Token(Token = "0x6008DD1")]
    [Address(RVA = "0x4AFBE14", Offset = "0x4AFBE14", VA = "0x4AFBE14")]
    public void BreakObject(Vector3 addForce)
    {
    }

    [Token(Token = "0x6008DD2")]
    [Address(RVA = "0x4AFC114", Offset = "0x4AFC114", VA = "0x4AFC114", Slot = "10")]
    public override void ReleaseInstance()
    {
    }

    [Token(Token = "0x6008DD3")]
    [Address(RVA = "0x4AFC1C0", Offset = "0x4AFC1C0", VA = "0x4AFC1C0")]
    private IEnumerator DelayReleaseInstance() => (IEnumerator) null;

    [Token(Token = "0x6008DD4")]
    [Address(RVA = "0x4AFC0AC", Offset = "0x4AFC0AC", VA = "0x4AFC0AC")]
    protected IEnumerator FadeOutWaitCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6008DD5")]
    [Address(RVA = "0x4AFC278", Offset = "0x4AFC278", VA = "0x4AFC278", Slot = "11")]
    public void Show()
    {
    }

    [Token(Token = "0x6008DD6")]
    [Address(RVA = "0x4AFC290", Offset = "0x4AFC290", VA = "0x4AFC290", Slot = "12")]
    public void Hide()
    {
    }

    [Token(Token = "0x6008DD7")]
    [Address(RVA = "0x4AFC2A8", Offset = "0x4AFC2A8", VA = "0x4AFC2A8")]
    public FreeMapBreakableInstance()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Battle.UI.TweenWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002364")]
  [RequireComponent(typeof (UITweenGroup))]
  public abstract class TweenWrapper : MonoBehaviour
  {
    [Token(Token = "0x400966A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    protected UITweenGroup tweenGroup;

    [Token(Token = "0x17002E6E")]
    public virtual bool IsPlaying
    {
      [Token(Token = "0x600D80D"), Address(RVA = "0x1B8FB78", Offset = "0x1B8FB78", VA = "0x1B8FB78", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D80E")]
    [Address(RVA = "0x1B8FB8C", Offset = "0x1B8FB8C", VA = "0x1B8FB8C", Slot = "5")]
    protected virtual void Play(bool skipPrev = true, bool asap = false, params string[] names)
    {
    }

    [Token(Token = "0x600D80F")]
    [Address(RVA = "0x1B8FC08", Offset = "0x1B8FC08", VA = "0x1B8FC08", Slot = "6")]
    public virtual void Stop()
    {
    }

    [Token(Token = "0x600D810")]
    [Address(RVA = "0x1B8FC24", Offset = "0x1B8FC24", VA = "0x1B8FC24")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D811")]
    [Address(RVA = "0x1B8FC40", Offset = "0x1B8FC40", VA = "0x1B8FC40")]
    public void AddFinishedCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x600D812")]
    [Address(RVA = "0x1B8FC5C", Offset = "0x1B8FC5C", VA = "0x1B8FC5C")]
    public void RemoveFinishedCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x600D813")]
    [Address(RVA = "0x1B8FC78", Offset = "0x1B8FC78", VA = "0x1B8FC78", Slot = "7")]
    protected virtual void LateUpdate()
    {
    }

    [Token(Token = "0x600D814")]
    [Address(RVA = "0x1B8B018", Offset = "0x1B8B018", VA = "0x1B8B018")]
    protected TweenWrapper()
    {
    }
  }
}

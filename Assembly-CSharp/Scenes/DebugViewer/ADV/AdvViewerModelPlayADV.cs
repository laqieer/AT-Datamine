// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerModelPlayADV
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField;
using Il2CppDummyDll;
using Story.Adv;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x200300B")]
  public class AdvViewerModelPlayADV : IAdvViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CCED")]
    [FieldOffset(Offset = "0x10")]
    private Func<IEnumerator, Coroutine> StartCoroutine;

    [Token(Token = "0x17003F65")]
    private AdvViewerModel Parent
    {
      [Token(Token = "0x6012C90"), Address(RVA = "0x3FB2380", Offset = "0x3FB2380", VA = "0x3FB2380")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x140001BE")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6012C91"), Address(RVA = "0x3FB2388", Offset = "0x3FB2388", VA = "0x3FB2388")] add
      {
      }
      [Token(Token = "0x6012C92"), Address(RVA = "0x3FB2424", Offset = "0x3FB2424", VA = "0x3FB2424")] remove
      {
      }
    }

    [Token(Token = "0x140001BF")]
    public event Action OnEndADV
    {
      [Token(Token = "0x6012C93"), Address(RVA = "0x3FB24C0", Offset = "0x3FB24C0", VA = "0x3FB24C0")] add
      {
      }
      [Token(Token = "0x6012C94"), Address(RVA = "0x3FB255C", Offset = "0x3FB255C", VA = "0x3FB255C")] remove
      {
      }
    }

    [Token(Token = "0x6012C95")]
    [Address(RVA = "0x3FB25F8", Offset = "0x3FB25F8", VA = "0x3FB25F8")]
    public AdvViewerModelPlayADV(AdvViewerModel parent, Func<IEnumerator, Coroutine> StartCoroutine)
    {
    }

    [Token(Token = "0x6012C96")]
    [Address(RVA = "0x3FB2624", Offset = "0x3FB2624", VA = "0x3FB2624", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x6012C97")]
    [Address(RVA = "0x3FB2628", Offset = "0x3FB2628", VA = "0x3FB2628", Slot = "5")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012C98")]
    [Address(RVA = "0x3FB0024", Offset = "0x3FB0024", VA = "0x3FB0024")]
    public void Play(AdvStage advStage, Action<AdvStageBase> onBegin, Action<AdvStageBase> onEnd)
    {
    }

    [Token(Token = "0x6012C99")]
    [Address(RVA = "0x3FB262C", Offset = "0x3FB262C", VA = "0x3FB262C")]
    private IEnumerator PlayInternal(
      AdvStageBase advStage,
      Action<AdvStageBase> onBegin,
      Action<AdvStageBase> onEnd)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012C9A")]
    [Address(RVA = "0x3FAFCE4", Offset = "0x3FAFCE4", VA = "0x3FAFCE4")]
    public void PlayInFreeMap(IEnumerator onBeginEvent, Action onEndEvent)
    {
    }

    [Token(Token = "0x6012C9B")]
    [Address(RVA = "0x3FB26DC", Offset = "0x3FB26DC", VA = "0x3FB26DC")]
    private IEnumerator PlayInFreeMapInternal(
      OverrideCameraBase overrideParameter,
      IEnumerator onBeginEvent,
      Action onEndEvent)
    {
      return (IEnumerator) null;
    }
  }
}

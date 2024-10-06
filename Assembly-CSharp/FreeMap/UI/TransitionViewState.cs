// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.TransitionViewState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x2001611")]
  public abstract class TransitionViewState
  {
    [Token(Token = "0x6007CEB")]
    [Address(RVA = "0x21A4F88", Offset = "0x21A4F88", VA = "0x21A4F88", Slot = "4")]
    public virtual void LoadUI(FreeMapResourceLoader loader, Transform parent)
    {
    }

    [Token(Token = "0x6007CEC")]
    [Address(RVA = "0x21A4F8C", Offset = "0x21A4F8C", VA = "0x21A4F8C", Slot = "5")]
    public virtual void OnInitialize(GameObject obj)
    {
    }

    [Token(Token = "0x6007CED")]
    public abstract IFreeMapTransitionView GetView();

    [Token(Token = "0x6007CEE")]
    [Address(RVA = "0x21A4E0C", Offset = "0x21A4E0C", VA = "0x21A4E0C")]
    protected void Initialize(GameObject obj, Transform parent)
    {
    }

    [Token(Token = "0x6007CEF")]
    [Address(RVA = "0x21A4DE4", Offset = "0x21A4DE4", VA = "0x21A4DE4")]
    protected TransitionViewState()
    {
    }
  }
}

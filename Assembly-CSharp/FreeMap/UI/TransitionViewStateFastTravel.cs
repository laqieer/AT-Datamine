// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.TransitionViewStateFastTravel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x200160D")]
  public class TransitionViewStateFastTravel : TransitionViewState
  {
    [Token(Token = "0x400646A")]
    private const string AssetBundleName = "ui_page_adv_fasttravel_prefab";
    [Token(Token = "0x400646B")]
    private const string AssetName = "Container_FastTravel";
    [Token(Token = "0x400646C")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapFastTravelTransitionTitleView view;

    [Token(Token = "0x6007CE0")]
    [Address(RVA = "0x21A4B80", Offset = "0x21A4B80", VA = "0x21A4B80", Slot = "4")]
    public override void LoadUI(FreeMapResourceLoader loader, Transform parent)
    {
    }

    [Token(Token = "0x6007CE1")]
    [Address(RVA = "0x21A4D0C", Offset = "0x21A4D0C", VA = "0x21A4D0C", Slot = "5")]
    public override void OnInitialize(GameObject obj)
    {
    }

    [Token(Token = "0x6007CE2")]
    [Address(RVA = "0x21A4DD4", Offset = "0x21A4DD4", VA = "0x21A4DD4", Slot = "6")]
    public override IFreeMapTransitionView GetView() => (IFreeMapTransitionView) null;

    [Token(Token = "0x6007CE3")]
    [Address(RVA = "0x21A4DDC", Offset = "0x21A4DDC", VA = "0x21A4DDC")]
    public TransitionViewStateFastTravel()
    {
    }
  }
}

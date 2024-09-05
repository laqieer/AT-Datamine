// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.TransitionViewStateTitle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x2001612")]
  public class TransitionViewStateTitle : TransitionViewState
  {
    [Token(Token = "0x4006474")]
    private const string AssetBundleName = "2dassets_ui_story_common";
    [Token(Token = "0x4006475")]
    private const string AssetName = "Container_AreaMove_Title";
    [Token(Token = "0x4006476")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapTransitionTitleView view;

    [Token(Token = "0x6007CF0")]
    [Address(RVA = "0x21A4F90", Offset = "0x21A4F90", VA = "0x21A4F90", Slot = "4")]
    public override void LoadUI(FreeMapResourceLoader loader, Transform parent)
    {
    }

    [Token(Token = "0x6007CF1")]
    [Address(RVA = "0x21A511C", Offset = "0x21A511C", VA = "0x21A511C", Slot = "5")]
    public override void OnInitialize(GameObject obj)
    {
    }

    [Token(Token = "0x6007CF2")]
    [Address(RVA = "0x21A51E4", Offset = "0x21A51E4", VA = "0x21A51E4", Slot = "6")]
    public override IFreeMapTransitionView GetView() => (IFreeMapTransitionView) null;

    [Token(Token = "0x6007CF3")]
    [Address(RVA = "0x21A4F80", Offset = "0x21A4F80", VA = "0x21A4F80")]
    public TransitionViewStateTitle()
    {
    }
  }
}

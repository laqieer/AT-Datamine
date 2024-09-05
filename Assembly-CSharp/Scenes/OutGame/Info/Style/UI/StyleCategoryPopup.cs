// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.UI.StyleCategoryPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using StaqData;
using System.Collections;
using UI.Common;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Style.UI
{
  [Token(Token = "0x2003561")]
  [AddComponentMenu("Scenes/OutGame/Info/Style/UI/StyleCategoryPopup")]
  public class StyleCategoryPopup : PopupBase
  {
    [Token(Token = "0x400E81F")]
    [FieldOffset(Offset = "0x88")]
    [Tooltip("スタイルのカテゴリ表示")]
    [SerializeField]
    private StyleCategoryUI styleCategoryUI;
    [Token(Token = "0x400E820")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private BtnFullScreen btnFullScreen;
    [Token(Token = "0x400E821")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400E822")]
    [FieldOffset(Offset = "0xA0")]
    private StyleCategoryViewModel viewModel;
    [Token(Token = "0x400E823")]
    [FieldOffset(Offset = "0xA8")]
    private IAssetProvider assetLoader;
    [Token(Token = "0x400E824")]
    [FieldOffset(Offset = "0xB0")]
    private UniqueID styleUnique;
    [Token(Token = "0x400E825")]
    [FieldOffset(Offset = "0xB8")]
    private bool isInitialized;
    [Token(Token = "0x400E826")]
    [FieldOffset(Offset = "0xC0")]
    private readonly string animationOpen;
    [Token(Token = "0x400E827")]
    [FieldOffset(Offset = "0xC8")]
    private readonly string animationClose;

    [Token(Token = "0x6014F4A")]
    [Address(RVA = "0x4A9EAF0", Offset = "0x4A9EAF0", VA = "0x4A9EAF0")]
    public void Initialize(UniqueID uniqueID, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6014F4B")]
    [Address(RVA = "0x4A9EC18", Offset = "0x4A9EC18", VA = "0x4A9EC18")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6014F4C")]
    [Address(RVA = "0x4A9ECA8", Offset = "0x4A9ECA8", VA = "0x4A9ECA8", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6014F4D")]
    [Address(RVA = "0x4A9ECB4", Offset = "0x4A9ECB4", VA = "0x4A9ECB4", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6014F4E")]
    [Address(RVA = "0x4A9ED9C", Offset = "0x4A9ED9C", VA = "0x4A9ED9C", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6014F4F")]
    [Address(RVA = "0x4A9EE1C", Offset = "0x4A9EE1C", VA = "0x4A9EE1C")]
    public StyleCategoryPopup()
    {
    }

    [Token(Token = "0x2003562")]
    public class LoadedPopup : LoadedSingleAssetGetter<StyleCategoryPopup>
    {
      [Token(Token = "0x6014F51")]
      [Address(RVA = "0x4A9EEA0", Offset = "0x4A9EEA0", VA = "0x4A9EEA0")]
      public LoadedPopup()
      {
      }

      [Token(Token = "0x6014F52")]
      [Address(RVA = "0x4A9EF20", Offset = "0x4A9EF20", VA = "0x4A9EF20")]
      public StyleCategoryPopup ShowPopup(UniqueID uniqueID, IAssetProvider assetProvider)
      {
        return (StyleCategoryPopup) null;
      }
    }
  }
}

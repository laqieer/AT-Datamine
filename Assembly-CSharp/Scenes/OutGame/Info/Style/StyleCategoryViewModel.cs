// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.StyleCategoryViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Style.UI;
using StaqData;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Info.Style
{
  [Token(Token = "0x2003556")]
  public class StyleCategoryViewModel
  {
    [Token(Token = "0x400E7FD")]
    [FieldOffset(Offset = "0x10")]
    private StyleCategoryUI styleCategoryUI;
    [Token(Token = "0x400E7FE")]
    [FieldOffset(Offset = "0x18")]
    private IAssetProvider assetProvider;

    [Token(Token = "0x6014F09")]
    [Address(RVA = "0x1B4C11C", Offset = "0x1B4C11C", VA = "0x1B4C11C")]
    public StyleCategoryViewModel(StyleCategoryUI styleCategoryUI, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6014F0A")]
    [Address(RVA = "0x1B4C148", Offset = "0x1B4C148", VA = "0x1B4C148")]
    public IEnumerator Set(UniqueID uniqueID) => (IEnumerator) null;
  }
}

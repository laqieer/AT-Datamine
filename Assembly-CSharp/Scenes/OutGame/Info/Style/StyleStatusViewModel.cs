// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.StyleStatusViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;

#nullable disable
namespace Scenes.OutGame.Info.Style
{
  [Token(Token = "0x200355B")]
  public class StyleStatusViewModel
  {
    [Token(Token = "0x400E80B")]
    [FieldOffset(Offset = "0x10")]
    private StyleModelBase model;
    [Token(Token = "0x400E80C")]
    [FieldOffset(Offset = "0x18")]
    private StyleStatusView view;
    [Token(Token = "0x400E80D")]
    private const int SpeciesTypeMaxNum = 3;

    [Token(Token = "0x17004588")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x6014F1D"), Address(RVA = "0x4A9C9B8", Offset = "0x4A9C9B8", VA = "0x4A9C9B8")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x6014F1E"), Address(RVA = "0x4A9C9C0", Offset = "0x4A9C9C0", VA = "0x4A9C9C0")] set
      {
      }
    }

    [Token(Token = "0x6014F1F")]
    [Address(RVA = "0x4A9C9C8", Offset = "0x4A9C9C8", VA = "0x4A9C9C8")]
    public void SetModel(StyleModelBase model)
    {
    }

    [Token(Token = "0x6014F20")]
    [Address(RVA = "0x4A9C9D0", Offset = "0x4A9C9D0", VA = "0x4A9C9D0")]
    public void SetView(StyleStatusView view)
    {
    }

    [Token(Token = "0x6014F21")]
    [Address(RVA = "0x4A9C9D8", Offset = "0x4A9C9D8", VA = "0x4A9C9D8")]
    public void OnChange()
    {
    }

    [Token(Token = "0x6014F22")]
    [Address(RVA = "0x4A9D364", Offset = "0x4A9D364", VA = "0x4A9D364")]
    public StyleStatusViewModel()
    {
    }
  }
}

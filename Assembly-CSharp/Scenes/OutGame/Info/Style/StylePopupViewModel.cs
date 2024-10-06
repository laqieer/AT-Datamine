// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.StylePopupViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;

#nullable disable
namespace Scenes.OutGame.Info.Style
{
  [Token(Token = "0x2003559")]
  public class StylePopupViewModel
  {
    [Token(Token = "0x400E806")]
    [FieldOffset(Offset = "0x10")]
    private StyleModelBase model;
    [Token(Token = "0x400E807")]
    [FieldOffset(Offset = "0x18")]
    private StylePopupView view;

    [Token(Token = "0x17004587")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x6014F14"), Address(RVA = "0x1B4CB18", Offset = "0x1B4CB18", VA = "0x1B4CB18")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x6014F15"), Address(RVA = "0x1B4CB20", Offset = "0x1B4CB20", VA = "0x1B4CB20")] set
      {
      }
    }

    [Token(Token = "0x6014F16")]
    [Address(RVA = "0x1B4CB28", Offset = "0x1B4CB28", VA = "0x1B4CB28")]
    public void SetModel(StyleModelBase model)
    {
    }

    [Token(Token = "0x6014F17")]
    [Address(RVA = "0x1B4CB30", Offset = "0x1B4CB30", VA = "0x1B4CB30")]
    public void SetView(StylePopupView view)
    {
    }

    [Token(Token = "0x6014F18")]
    [Address(RVA = "0x1B4CB38", Offset = "0x1B4CB38", VA = "0x1B4CB38")]
    public void OnChange()
    {
    }

    [Token(Token = "0x6014F19")]
    [Address(RVA = "0x1B4CE24", Offset = "0x1B4CE24", VA = "0x1B4CE24")]
    private void SetSkills()
    {
    }

    [Token(Token = "0x6014F1A")]
    [Address(RVA = "0x1B44658", Offset = "0x1B44658", VA = "0x1B44658")]
    public StylePopupViewModel()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Unit.UnitPopupViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;

#nullable disable
namespace Scenes.OutGame.Info.Unit
{
  [Token(Token = "0x2003542")]
  public class UnitPopupViewModel
  {
    [Token(Token = "0x400E7A6")]
    [FieldOffset(Offset = "0x10")]
    private UnitModelBase model;
    [Token(Token = "0x400E7A7")]
    [FieldOffset(Offset = "0x18")]
    private UnitInfoView view;
    [Token(Token = "0x400E7A9")]
    private const int MaxTypeIconNum = 3;

    [Token(Token = "0x17004556")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x6014E57"), Address(RVA = "0x1B47EE0", Offset = "0x1B47EE0", VA = "0x1B47EE0")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x6014E58"), Address(RVA = "0x1B47EE8", Offset = "0x1B47EE8", VA = "0x1B47EE8")] set
      {
      }
    }

    [Token(Token = "0x6014E59")]
    [Address(RVA = "0x1B47EF0", Offset = "0x1B47EF0", VA = "0x1B47EF0")]
    public void SetModel(UnitModelBase model)
    {
    }

    [Token(Token = "0x6014E5A")]
    [Address(RVA = "0x1B47EF8", Offset = "0x1B47EF8", VA = "0x1B47EF8")]
    public void SetView(UnitInfoView view)
    {
    }

    [Token(Token = "0x6014E5B")]
    [Address(RVA = "0x1B47F00", Offset = "0x1B47F00", VA = "0x1B47F00")]
    public void OnChange()
    {
    }

    [Token(Token = "0x6014E5C")]
    [Address(RVA = "0x1B486D0", Offset = "0x1B486D0", VA = "0x1B486D0")]
    private void SetAdditionalPararameter()
    {
    }

    [Token(Token = "0x6014E5D")]
    [Address(RVA = "0x1B487E8", Offset = "0x1B487E8", VA = "0x1B487E8")]
    private void SetSkills()
    {
    }

    [Token(Token = "0x6014E5E")]
    [Address(RVA = "0x1B42C70", Offset = "0x1B42C70", VA = "0x1B42C70")]
    public UnitPopupViewModel()
    {
    }
  }
}

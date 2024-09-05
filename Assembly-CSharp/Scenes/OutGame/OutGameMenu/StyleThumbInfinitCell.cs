// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleThumbInfinitCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AE8")]
  public class StyleThumbInfinitCell : InfiniteCellBase
  {
    [Token(Token = "0x4010377")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb styleThumb;

    [Token(Token = "0x17004BAD")]
    private StyleThumbResource Resource
    {
      [Token(Token = "0x60172D8"), Address(RVA = "0x3012320", Offset = "0x3012320", VA = "0x3012320")] get
      {
        return (StyleThumbResource) null;
      }
    }

    [Token(Token = "0x60172D9")]
    [Address(RVA = "0x30123A8", Offset = "0x30123A8", VA = "0x30123A8", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60172DA")]
    [Address(RVA = "0x3012514", Offset = "0x3012514", VA = "0x3012514")]
    private void PossessionSet(StyleThumbResource resource, Style style)
    {
    }

    [Token(Token = "0x60172DB")]
    [Address(RVA = "0x3012494", Offset = "0x3012494", VA = "0x3012494")]
    private void NotPossessionSet()
    {
    }

    [Token(Token = "0x60172DC")]
    [Address(RVA = "0x30127E4", Offset = "0x30127E4", VA = "0x30127E4")]
    public StyleThumbInfinitCell()
    {
    }
  }
}

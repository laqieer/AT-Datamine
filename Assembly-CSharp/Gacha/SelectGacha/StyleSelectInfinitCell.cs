// Decompiled with JetBrains decompiler
// Type: Gacha.SelectGacha.StyleSelectInfinitCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using UnityEngine;

#nullable disable
namespace Gacha.SelectGacha
{
  [Token(Token = "0x20015A0")]
  public class StyleSelectInfinitCell : InfiniteCellBase
  {
    [Token(Token = "0x4006321")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb styleThumb;

    [Token(Token = "0x170012CC")]
    private StyleSelectThumbResource Resource
    {
      [Token(Token = "0x6007A88"), Address(RVA = "0x229D770", Offset = "0x229D770", VA = "0x229D770")] get
      {
        return (StyleSelectThumbResource) null;
      }
    }

    [Token(Token = "0x6007A89")]
    [Address(RVA = "0x229D7F8", Offset = "0x229D7F8", VA = "0x229D7F8", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6007A8A")]
    [Address(RVA = "0x229D984", Offset = "0x229D984", VA = "0x229D984")]
    public StyleSelectInfinitCell()
    {
    }
  }
}

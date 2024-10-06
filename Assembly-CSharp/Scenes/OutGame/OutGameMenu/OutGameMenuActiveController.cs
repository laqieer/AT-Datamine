// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.OutGameMenuActiveController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A20")]
  public class OutGameMenuActiveController : MonoBehaviour
  {
    [Token(Token = "0x400FE78")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject objMenuTitle;
    [Token(Token = "0x400FE79")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject objHeaderMenu;
    [Token(Token = "0x400FE7A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject objSideMenu;
    [Token(Token = "0x400FE7B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject objFooterMenu;
    [Token(Token = "0x400FE7C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject objBGImage;

    [Token(Token = "0x6016D7D")]
    [Address(RVA = "0x2C59D20", Offset = "0x2C59D20", VA = "0x2C59D20")]
    public void SetActiveAll(bool isActive)
    {
    }

    [Token(Token = "0x6016D7E")]
    [Address(RVA = "0x2C59DA8", Offset = "0x2C59DA8", VA = "0x2C59DA8")]
    public void SetActiveForGachaResult(bool isActive)
    {
    }

    [Token(Token = "0x6016D7F")]
    [Address(RVA = "0x2C59E1C", Offset = "0x2C59E1C", VA = "0x2C59E1C")]
    public OutGameMenuActiveController()
    {
    }
  }
}

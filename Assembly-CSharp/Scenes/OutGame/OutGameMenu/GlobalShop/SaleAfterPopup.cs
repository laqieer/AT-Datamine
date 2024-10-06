// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.SaleAfterPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.GlobalShop.SalePopupContent;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BC6")]
  public class SaleAfterPopup : PopupBase
  {
    [Token(Token = "0x401088B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x401088C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x401088D")]
    [FieldOffset(Offset = "0x98")]
    private SaleCheckContainer createdSaleCheckContainer;

    [Token(Token = "0x6017806")]
    [Address(RVA = "0x265A9D0", Offset = "0x265A9D0", VA = "0x265A9D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6017807")]
    [Address(RVA = "0x265AA74", Offset = "0x265AA74", VA = "0x265AA74")]
    public void SetData(SaleCheckContainer saleCheckContainer, int prevZeny, int getZeny)
    {
    }

    [Token(Token = "0x6017808")]
    [Address(RVA = "0x265AC4C", Offset = "0x265AC4C", VA = "0x265AC4C")]
    public SaleAfterPopup()
    {
    }
  }
}

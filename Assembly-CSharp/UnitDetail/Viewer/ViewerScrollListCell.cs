// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.ViewerScrollListCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004C5")]
  public class ViewerScrollListCell : UIScrollGridItem
  {
    [Token(Token = "0x4001940")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text label;
    [Token(Token = "0x4001941")]
    [FieldOffset(Offset = "0x20")]
    private Action onClickButton;

    [Token(Token = "0x6001B07")]
    [Address(RVA = "0x2C259E0", Offset = "0x2C259E0", VA = "0x2C259E0")]
    public void UpdateItem(string label, Action onClickButton)
    {
    }

    [Token(Token = "0x6001B08")]
    [Address(RVA = "0x2C2B504", Offset = "0x2C2B504", VA = "0x2C2B504")]
    public void OnClickButton()
    {
    }

    [Token(Token = "0x6001B09")]
    [Address(RVA = "0x2C2B520", Offset = "0x2C2B520", VA = "0x2C2B520")]
    public ViewerScrollListCell()
    {
    }
  }
}

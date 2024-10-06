// Decompiled with JetBrains decompiler
// Type: UnitView.UI.AbilityBoardView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitView.UI
{
  [Token(Token = "0x2000401")]
  [Serializable]
  public class AbilityBoardView
  {
    [Token(Token = "0x40016CA")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AnimationNameInSphereBoard;
    [Token(Token = "0x40016CB")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string AnimationNameOutSphereBoard;
    [Token(Token = "0x40016CC")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string AnimationNameInDetail;
    [Token(Token = "0x40016CD")]
    [FieldOffset(Offset = "0x18")]
    private static readonly string AnimationNameOutDetail;
    [Token(Token = "0x40016CE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40016CF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button backButton;
    [Token(Token = "0x40016D0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button detailButton;
    [Token(Token = "0x40016D1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button detailCloseButton;

    [Token(Token = "0x1700028A")]
    public Button BackButton
    {
      [Token(Token = "0x60016EB"), Address(RVA = "0x24899B4", Offset = "0x24899B4", VA = "0x24899B4")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x1700028B")]
    public Button Detailbutton
    {
      [Token(Token = "0x60016EC"), Address(RVA = "0x24899BC", Offset = "0x24899BC", VA = "0x24899BC")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x1700028C")]
    public Button DetaiCloseButton
    {
      [Token(Token = "0x60016ED"), Address(RVA = "0x24899C4", Offset = "0x24899C4", VA = "0x24899C4")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x60016EE")]
    [Address(RVA = "0x24899CC", Offset = "0x24899CC", VA = "0x24899CC")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x60016EF")]
    [Address(RVA = "0x2489A40", Offset = "0x2489A40", VA = "0x2489A40")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x60016F0")]
    [Address(RVA = "0x2489AB4", Offset = "0x2489AB4", VA = "0x2489AB4")]
    public void PlayDetailIn()
    {
    }

    [Token(Token = "0x60016F1")]
    [Address(RVA = "0x2489B28", Offset = "0x2489B28", VA = "0x2489B28")]
    public void PlayDetailOut()
    {
    }

    [Token(Token = "0x60016F2")]
    [Address(RVA = "0x2489B9C", Offset = "0x2489B9C", VA = "0x2489B9C")]
    public AbilityBoardView()
    {
    }

    [Token(Token = "0x60016F3")]
    [Address(RVA = "0x2489BA4", Offset = "0x2489BA4", VA = "0x2489BA4")]
    static AbilityBoardView()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.MasterBonusPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x200351D")]
  public class MasterBonusPopup : PopupBase
  {
    [Token(Token = "0x400E715")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform contentRoot;
    [Token(Token = "0x400E716")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RectTransform headerTransform;
    [Token(Token = "0x400E717")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Button buttonClose;
    [Token(Token = "0x400E718")]
    [FieldOffset(Offset = "0xA0")]
    public Action<MasterBonusPopup> OnClickCloseEvent;
    [Token(Token = "0x400E719")]
    [FieldOffset(Offset = "0xA8")]
    private GameObject Img_Dark;
    [Token(Token = "0x400E71A")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Image baseImage;
    [Token(Token = "0x400E71B")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private float styleBaseScale;
    [Token(Token = "0x400E71C")]
    [FieldOffset(Offset = "0xBC")]
    private float baseImageHeight;
    [Token(Token = "0x400E71D")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private BtnFullScreen btnFullScreen;
    [Token(Token = "0x400E71E")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x1700450B")]
    public Transform ContentRoot
    {
      [Token(Token = "0x6014D44"), Address(RVA = "0x1B3E2C4", Offset = "0x1B3E2C4", VA = "0x1B3E2C4")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x6014D45")]
    [Address(RVA = "0x1B3E2CC", Offset = "0x1B3E2CC", VA = "0x1B3E2CC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6014D46")]
    [Address(RVA = "0x1B3E45C", Offset = "0x1B3E45C", VA = "0x1B3E45C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6014D47")]
    [Address(RVA = "0x1B3E470", Offset = "0x1B3E470", VA = "0x1B3E470")]
    private void SyncTransformPosition(RectTransform src, RectTransform dst)
    {
    }

    [Token(Token = "0x6014D48")]
    [Address(RVA = "0x1B3E574", Offset = "0x1B3E574", VA = "0x1B3E574")]
    public void SyncHeaderPosition(RectTransform srcTransform)
    {
    }

    [Token(Token = "0x6014D49")]
    [Address(RVA = "0x1B3E57C", Offset = "0x1B3E57C", VA = "0x1B3E57C", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6014D4A")]
    [Address(RVA = "0x1B3E59C", Offset = "0x1B3E59C", VA = "0x1B3E59C", Slot = "6")]
    public override void OnBackClosed()
    {
    }

    [Token(Token = "0x6014D4B")]
    [Address(RVA = "0x1B3E5A8", Offset = "0x1B3E5A8", VA = "0x1B3E5A8", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6014D4C")]
    [Address(RVA = "0x1B3E64C", Offset = "0x1B3E64C", VA = "0x1B3E64C", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6014D4D")]
    [Address(RVA = "0x1B3E6E8", Offset = "0x1B3E6E8", VA = "0x1B3E6E8")]
    public MasterBonusPopup()
    {
    }
  }
}

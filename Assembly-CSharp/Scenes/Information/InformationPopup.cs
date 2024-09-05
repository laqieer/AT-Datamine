// Decompiled with JetBrains decompiler
// Type: Scenes.Information.InformationPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using HTMLViewer;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Information
{
  [Token(Token = "0x2002AB8")]
  public class InformationPopup : PopupBase
  {
    [Token(Token = "0x400B5C3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400B5C4")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text closeButtonText;
    [Token(Token = "0x400B5C5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject linkButtonRoot;
    [Token(Token = "0x400B5C6")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton linkButton;
    [Token(Token = "0x400B5C7")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text linkButtonText;
    [Token(Token = "0x400B5C8")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject checkButtonRoot;
    [Token(Token = "0x400B5C9")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject checkMark;
    [Token(Token = "0x400B5CA")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonButton checkButton;
    [Token(Token = "0x400B5CB")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject pagerRoot;
    [Token(Token = "0x400B5CC")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text pagerValue;
    [Token(Token = "0x400B5CD")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text pagerMax;
    [Token(Token = "0x400B5CE")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CommonButton pagerNextButton;
    [Token(Token = "0x400B5CF")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CommonButton pagerPrevButton;
    [Token(Token = "0x400B5D0")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private HTMLView htmlView;
    [Token(Token = "0x400B5D1")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private CommonGesturePanel commonGesturePanel;
    [Token(Token = "0x400B5D2")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private GameObject checkMarkTodayText;
    [Token(Token = "0x400B5D3")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private GameObject checkMarkConfirmMessageText;
    [Token(Token = "0x400B5D4")]
    [FieldOffset(Offset = "0x110")]
    private Action<string> onClickLink;
    [Token(Token = "0x400B5D5")]
    [FieldOffset(Offset = "0x118")]
    private Action<int, int> onCloseButton;
    [Token(Token = "0x400B5D6")]
    [FieldOffset(Offset = "0x120")]
    private Action onGachaButton;
    [Token(Token = "0x400B5D7")]
    [FieldOffset(Offset = "0x128")]
    private int currentMessageId;
    [Token(Token = "0x400B5D8")]
    [FieldOffset(Offset = "0x12C")]
    private int currentIndex;
    [Token(Token = "0x400B5D9")]
    [FieldOffset(Offset = "0x130")]
    private bool isLinkButtonDisable;
    [Token(Token = "0x400B5DB")]
    [FieldOffset(Offset = "0x132")]
    private bool isImportantMessage;

    [Token(Token = "0x170039D6")]
    public bool IsCheckMark
    {
      [Token(Token = "0x6010B36"), Address(RVA = "0x4BD38E4", Offset = "0x4BD38E4", VA = "0x4BD38E4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6010B37"), Address(RVA = "0x4BD38EC", Offset = "0x4BD38EC", VA = "0x4BD38EC")] private set
      {
      }
    }

    [Token(Token = "0x6010B38")]
    [Address(RVA = "0x4BD38F8", Offset = "0x4BD38F8", VA = "0x4BD38F8")]
    public void InitializeInformation()
    {
    }

    [Token(Token = "0x6010B39")]
    [Address(RVA = "0x4BD39A4", Offset = "0x4BD39A4", VA = "0x4BD39A4")]
    private void SetCheckBox(bool isCheck)
    {
    }

    [Token(Token = "0x6010B3A")]
    [Address(RVA = "0x4BD3A6C", Offset = "0x4BD3A6C", VA = "0x4BD3A6C")]
    private void SaveCheckButton()
    {
    }

    [Token(Token = "0x6010B3B")]
    [Address(RVA = "0x4BD3C20", Offset = "0x4BD3C20", VA = "0x4BD3C20")]
    public void SetActiveCheckButton(bool isEnabled, bool isDefaultCheck)
    {
    }

    [Token(Token = "0x6010B3C")]
    [Address(RVA = "0x4BD3C58", Offset = "0x4BD3C58", VA = "0x4BD3C58")]
    public void SetCloseButton(Action<int, int> onCloseButton)
    {
    }

    [Token(Token = "0x6010B3D")]
    [Address(RVA = "0x4BD3C60", Offset = "0x4BD3C60", VA = "0x4BD3C60")]
    public void CloseOnSceneTransition()
    {
    }

    [Token(Token = "0x6010B3E")]
    [Address(RVA = "0x4BD3D4C", Offset = "0x4BD3D4C", VA = "0x4BD3D4C")]
    public void SetClickLink(Action<string> onClickLink)
    {
    }

    [Token(Token = "0x6010B3F")]
    [Address(RVA = "0x4BD3D54", Offset = "0x4BD3D54", VA = "0x4BD3D54")]
    public void SetLinkButtonDisable(bool value)
    {
    }

    [Token(Token = "0x6010B40")]
    [Address(RVA = "0x4BD3D60", Offset = "0x4BD3D60", VA = "0x4BD3D60")]
    public void SetGachaButton(Action onGachaButton)
    {
    }

    [Token(Token = "0x6010B41")]
    [Address(RVA = "0x4BD3D68", Offset = "0x4BD3D68", VA = "0x4BD3D68")]
    public void UpdateArticle(
      List<OfficialInformationArticleType> articles,
      int index,
      Action<int> callback)
    {
    }

    [Token(Token = "0x6010B42")]
    [Address(RVA = "0x4BD4874", Offset = "0x4BD4874", VA = "0x4BD4874")]
    public void UpdateNewArticle(
      List<OfficialInformationArticleType> articles,
      int index,
      Action<int> callback)
    {
    }

    [Token(Token = "0x6010B43")]
    [Address(RVA = "0x4BD4D0C", Offset = "0x4BD4D0C", VA = "0x4BD4D0C")]
    public void ShowDesignatedArticle(OfficialInformationArticleType article, Action callback)
    {
    }

    [Token(Token = "0x6010B44")]
    [Address(RVA = "0x4BD41D8", Offset = "0x4BD41D8", VA = "0x4BD41D8")]
    private void UpdateLinkButton(Category category)
    {
    }

    [Token(Token = "0x6010B45")]
    [Address(RVA = "0x4BD4FA0", Offset = "0x4BD4FA0", VA = "0x4BD4FA0")]
    public void UpdateArticle(
      List<OfficialMessageArticleType> articles,
      int index,
      Action callback)
    {
    }

    [Token(Token = "0x6010B46")]
    [Address(RVA = "0x4BD4340", Offset = "0x4BD4340", VA = "0x4BD4340")]
    private void UpdateArticlePager(
      int index,
      int maxPage,
      Action onNext,
      Action onPrev,
      bool enablePagerRoot)
    {
    }

    [Token(Token = "0x6010B47")]
    [Address(RVA = "0x4BD4640", Offset = "0x4BD4640", VA = "0x4BD4640")]
    private void UpdateInformationObjects(bool isNew, bool isMessage)
    {
    }

    [Token(Token = "0x6010B48")]
    [Address(RVA = "0x4BD4CC4", Offset = "0x4BD4CC4", VA = "0x4BD4CC4")]
    private void SetCheckBoxText(bool isNewInformation)
    {
    }

    [Token(Token = "0x6010B49")]
    [Address(RVA = "0x4BD47D0", Offset = "0x4BD47D0", VA = "0x4BD47D0")]
    private void ResetScrollPosition()
    {
    }

    [Token(Token = "0x6010B4A")]
    [Address(RVA = "0x4BD53A4", Offset = "0x4BD53A4", VA = "0x4BD53A4")]
    public InformationPopup()
    {
    }
  }
}

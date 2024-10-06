// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeQuestStageThumbnail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.Utility;
using System;
using System.Collections.Generic;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E70")]
  public class ObliviaeQuestStageThumbnail : MonoBehaviour
  {
    [Token(Token = "0x400C739")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400C73A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400C73B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton selectButton;
    [Token(Token = "0x400C73C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UIGraphicLaycastCollider selectButtonCollider;
    [Token(Token = "0x400C73D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image questStageThumbnail;
    [Token(Token = "0x400C73E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextContainer stageNameText;
    [Token(Token = "0x400C73F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject missionRootObject;
    [Token(Token = "0x400C740")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject grayOutObject;
    [Token(Token = "0x400C741")]
    [FieldOffset(Offset = "0x58")]
    private Action<int> onClickStageButton;
    [Token(Token = "0x400C742")]
    [FieldOffset(Offset = "0x60")]
    private List<string> tweenPlayList;
    [Token(Token = "0x400C743")]
    [FieldOffset(Offset = "0x68")]
    private int questId;

    [Token(Token = "0x601224D")]
    [Address(RVA = "0x45882C4", Offset = "0x45882C4", VA = "0x45882C4")]
    public void SetUp(
      StoryObliviaeQuestData quest,
      Action<int> onClickStageButton,
      AssetCachedSpawner assetCachedSpawner,
      NewBadgeProxy newBadgeProxy)
    {
    }

    [Token(Token = "0x601224E")]
    [Address(RVA = "0x458D98C", Offset = "0x458D98C", VA = "0x458D98C")]
    public void SetUp(
      int questId,
      int stageId,
      string stageName,
      bool[] missionClears,
      bool isOpen,
      bool isNew,
      bool isBoss,
      Action<int> onClickStageButton,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601224F")]
    [Address(RVA = "0x458E0EC", Offset = "0x458E0EC", VA = "0x458E0EC")]
    public void NewBadgeOff()
    {
    }

    [Token(Token = "0x6012250")]
    [Address(RVA = "0x458E13C", Offset = "0x458E13C", VA = "0x458E13C")]
    public void Show()
    {
    }

    [Token(Token = "0x6012251")]
    [Address(RVA = "0x458E188", Offset = "0x458E188", VA = "0x458E188")]
    public void Hide()
    {
    }

    [Token(Token = "0x6012252")]
    [Address(RVA = "0x458E1D4", Offset = "0x458E1D4", VA = "0x458E1D4")]
    private void OnClickStageButton()
    {
    }

    [Token(Token = "0x6012253")]
    [Address(RVA = "0x458DFB8", Offset = "0x458DFB8", VA = "0x458DFB8")]
    public void AddTweenPlayList(string groupId)
    {
    }

    [Token(Token = "0x6012254")]
    [Address(RVA = "0x458E060", Offset = "0x458E060", VA = "0x458E060")]
    public void PlayTweenPlayList()
    {
    }

    [Token(Token = "0x6012255")]
    [Address(RVA = "0x458DD30", Offset = "0x458DD30", VA = "0x458DD30")]
    public void ResetTweenPlayList(bool isRollback)
    {
    }

    [Token(Token = "0x6012256")]
    [Address(RVA = "0x458DEC0", Offset = "0x458DEC0", VA = "0x458DEC0")]
    private void SetThumbnail(AssetCachedSpawner assetCachedSpawner, int questStageId)
    {
    }

    [Token(Token = "0x6012257")]
    [Address(RVA = "0x458E1F4", Offset = "0x458E1F4", VA = "0x458E1F4")]
    public ObliviaeQuestStageThumbnail()
    {
    }
  }
}

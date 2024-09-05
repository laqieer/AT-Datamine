// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003341")]
  public class AbilityBoardView : MonoBehaviour
  {
    [Token(Token = "0x400DDFA")]
    private const int ARROW_START_NODE_NUMBER = 1;
    [Token(Token = "0x400DDFB")]
    private const int ARROW_LEFT_NODE_NUMBER = 9;
    [Token(Token = "0x400DDFC")]
    private const int ARROW_RIGHT_NODE_NUMBER = 15;
    [Token(Token = "0x400DDFD")]
    private const int ARROW_CENTER_NODE_NUMBER = 17;
    [Token(Token = "0x400DDFE")]
    private const string PLAY_VOICE_FILE_NAME = "VO_{0}_unit_{1}";
    [Token(Token = "0x400DDFF")]
    private const string PLAY_VOICE_UNLOCK_NODE_COMPLETE = "0011";
    [Token(Token = "0x400DE00")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400DE01")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AbilityBoardIcon[] icons;
    [Token(Token = "0x400DE02")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AbilityBoardEffectController[] iconReleaseEffects;
    [Token(Token = "0x400DE03")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject arrowBoardSettingNumber1;
    [Token(Token = "0x400DE04")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject arrowBoardSettingNumber9;
    [Token(Token = "0x400DE05")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject arrowBoardSettingNumber15;
    [Token(Token = "0x400DE06")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject arrowBoardSettingNumber17;
    [Token(Token = "0x400DE07")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text ReleaseNodeNumText;
    [Token(Token = "0x400DE08")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text ReleaseNodeMaxNumText;
    [Token(Token = "0x400DE09")]
    [FieldOffset(Offset = "0x60")]
    private Style style;
    [Token(Token = "0x400DE0A")]
    [FieldOffset(Offset = "0x68")]
    private int boardId;
    [Token(Token = "0x400DE0B")]
    [FieldOffset(Offset = "0x6C")]
    private int boardListId;
    [Token(Token = "0x400DE0C")]
    [FieldOffset(Offset = "0x70")]
    private int unlockedNodeCount;
    [Token(Token = "0x400DE0D")]
    [FieldOffset(Offset = "0x74")]
    private int maxNodeCount;
    [Token(Token = "0x400DE0E")]
    [FieldOffset(Offset = "0x78")]
    private bool isComplete;
    [Token(Token = "0x400DE0F")]
    [FieldOffset(Offset = "0x80")]
    private AbilityBoardConfirmNodeComplete confirmNodeComplete;
    [Token(Token = "0x400DE10")]
    [FieldOffset(Offset = "0x88")]
    private bool isOpen;
    [Token(Token = "0x400DE11")]
    [FieldOffset(Offset = "0x90")]
    public IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DE12")]
    [FieldOffset(Offset = "0x98")]
    public Action<int> OnNodeButtonAction;
    [Token(Token = "0x400DE13")]
    [FieldOffset(Offset = "0xA0")]
    public Action<string> OnPlayAlertUI;
    [Token(Token = "0x400DE14")]
    [FieldOffset(Offset = "0xA8")]
    private Action finishNodeReleaseAction;
    [Token(Token = "0x400DE15")]
    [FieldOffset(Offset = "0xB0")]
    private IReadOnlyList<AbilityBoardBoardListSettingData> boardListSettingDatas;
    [Token(Token = "0x400DE16")]
    [FieldOffset(Offset = "0xB8")]
    private IReadOnlyList<AbilityBoardBoardSettingData> boardSettingDatas;
    [Token(Token = "0x400DE17")]
    [FieldOffset(Offset = "0xC0")]
    private bool animeWait;
    [Token(Token = "0x400DE18")]
    [FieldOffset(Offset = "0xC8")]
    private List<string> waitAnimeNames;
    [Token(Token = "0x400DE19")]
    [FieldOffset(Offset = "0xD0")]
    private Dictionary<int, string> listAnimeDatas;

    [Token(Token = "0x601423B")]
    [Address(RVA = "0x20CFEA4", Offset = "0x20CFEA4", VA = "0x20CFEA4")]
    public IEnumerator InitializeTimelineAsync() => (IEnumerator) null;

    [Token(Token = "0x601423C")]
    [Address(RVA = "0x20CFF0C", Offset = "0x20CFF0C", VA = "0x20CFF0C")]
    public void SetData(
      Style style,
      int boardListId,
      int boardId,
      List<PlayerUnitAbilityBoardType> unlockNodeData,
      bool isPlayBoardLineAnime = true)
    {
    }

    [Token(Token = "0x601423D")]
    [Address(RVA = "0x20CA470", Offset = "0x20CA470", VA = "0x20CA470")]
    public void SelectNode(int nodeId)
    {
    }

    [Token(Token = "0x601423E")]
    [Address(RVA = "0x20C9E00", Offset = "0x20C9E00", VA = "0x20C9E00")]
    public void SelectNodes(HashSet<int> nodeIds)
    {
    }

    [Token(Token = "0x601423F")]
    [Address(RVA = "0x20D2320", Offset = "0x20D2320", VA = "0x20D2320")]
    public void PlayNodeReleaseEffect(int nodeId, Action finishAction = null)
    {
    }

    [Token(Token = "0x6014240")]
    [Address(RVA = "0x20D0C64", Offset = "0x20D0C64", VA = "0x20D0C64")]
    private void SetIcons(List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
    }

    [Token(Token = "0x6014241")]
    [Address(RVA = "0x20C9A58", Offset = "0x20C9A58", VA = "0x20C9A58")]
    public void SetIconState(
      AbilityBoardCacheNodeData cacheData,
      List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
    }

    [Token(Token = "0x6014242")]
    [Address(RVA = "0x20D22E4", Offset = "0x20D22E4", VA = "0x20D22E4")]
    public AbilityBoardIcon GetIcon(AbilityBoardBoardSettingData data) => (AbilityBoardIcon) null;

    [Token(Token = "0x6014243")]
    [Address(RVA = "0x20D2450", Offset = "0x20D2450", VA = "0x20D2450")]
    private AbilityBoardEffectController GetIconReleaseEffect(AbilityBoardBoardSettingData data)
    {
      return (AbilityBoardEffectController) null;
    }

    [Token(Token = "0x6014244")]
    [Address(RVA = "0x20D248C", Offset = "0x20D248C", VA = "0x20D248C")]
    private static int GetIconIndex(AbilityBoardBoardSettingData data) => new int();

    [Token(Token = "0x6014245")]
    [Address(RVA = "0x20D1BC0", Offset = "0x20D1BC0", VA = "0x20D1BC0")]
    private bool IsEnabledArrow(int arrowNodeNumber) => new bool();

    [Token(Token = "0x6014246")]
    [Address(RVA = "0x20D1FD4", Offset = "0x20D1FD4", VA = "0x20D1FD4")]
    private int GetMasterNodeId(int localNum) => new int();

    [Token(Token = "0x6014247")]
    [Address(RVA = "0x20D24A8", Offset = "0x20D24A8", VA = "0x20D24A8")]
    public void OpenConfirmNodeCompletePopup()
    {
    }

    [Token(Token = "0x6014248")]
    [Address(RVA = "0x20D26A0", Offset = "0x20D26A0", VA = "0x20D26A0")]
    public void OpenItemRewardNodeCompletePopup(Action finishAction)
    {
    }

    [Token(Token = "0x6014249")]
    [Address(RVA = "0x20D29A8", Offset = "0x20D29A8", VA = "0x20D29A8")]
    private IEnumerator OpenCompletePopup(
      List<DisplayItemRewardInfoData> rewardDataList,
      string rewardText,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601424A")]
    [Address(RVA = "0x20D2A30", Offset = "0x20D2A30", VA = "0x20D2A30")]
    private void PlayVoice(string voiceId)
    {
    }

    [Token(Token = "0x601424B")]
    [Address(RVA = "0x20D1244", Offset = "0x20D1244", VA = "0x20D1244")]
    private void SetListLine(
      int boardId,
      List<PlayerUnitAbilityBoardType> unlockNodeData,
      bool isPlayBoardLineAnime)
    {
    }

    [Token(Token = "0x601424C")]
    [Address(RVA = "0x20D2B0C", Offset = "0x20D2B0C", VA = "0x20D2B0C")]
    private void Update()
    {
    }

    [Token(Token = "0x601424D")]
    [Address(RVA = "0x20D2BD8", Offset = "0x20D2BD8", VA = "0x20D2BD8")]
    public AbilityBoardView()
    {
    }
  }
}

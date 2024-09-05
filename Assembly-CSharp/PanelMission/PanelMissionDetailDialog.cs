// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionDetailDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.Story;
using System;
using System.Collections;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A02")]
  public class PanelMissionDetailDialog : MonoBehaviour
  {
    [Token(Token = "0x4002E50")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button _cancelButton;
    [Token(Token = "0x4002E51")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _missionTimeLimit;
    [Token(Token = "0x4002E52")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject _missionTimeLimitDay;
    [Token(Token = "0x4002E53")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _missionText;
    [Token(Token = "0x4002E54")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text _missionInfo;
    [Token(Token = "0x4002E55")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text _progressText;
    [Token(Token = "0x4002E56")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text _rewardName;
    [Token(Token = "0x4002E57")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ItemIcon _rewardIcon;
    [Token(Token = "0x4002E58")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ToasterUI toaster;
    [Token(Token = "0x4002E59")]
    [FieldOffset(Offset = "0x60")]
    private CanvasGroup _canvasGroup;
    [Token(Token = "0x4002E5A")]
    [FieldOffset(Offset = "0x68")]
    private UITimelineController _uiTimelineController;
    [Token(Token = "0x4002E5B")]
    [FieldOffset(Offset = "0x70")]
    private PlayableDirector _playableDirector;
    [Token(Token = "0x4002E5C")]
    [FieldOffset(Offset = "0x78")]
    private PanelMissionViewModelFactory _panelMissionViewModelFactory;
    [Token(Token = "0x4002E5D")]
    [FieldOffset(Offset = "0x80")]
    public Action OnClickCancel;
    [Token(Token = "0x4002E5E")]
    [FieldOffset(Offset = "0x88")]
    public Action<int, int> OnClickChallenge;
    [Token(Token = "0x4002E5F")]
    [FieldOffset(Offset = "0x90")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x4002E60")]
    [FieldOffset(Offset = "0x98")]
    private PanelMissionViewModelFactory.MissionDetailDialogViewModel _viewModel;
    [Token(Token = "0x4002E61")]
    [FieldOffset(Offset = "0xA0")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x17000819")]
    private int PanelMissionGroupId
    {
      [Token(Token = "0x6003908"), Address(RVA = "0x3111C50", Offset = "0x3111C50", VA = "0x3111C50")] get
      {
        return new int();
      }
      [Token(Token = "0x6003909"), Address(RVA = "0x3111C58", Offset = "0x3111C58", VA = "0x3111C58")] set
      {
      }
    }

    [Token(Token = "0x1700081A")]
    private int PanelId
    {
      [Token(Token = "0x600390A"), Address(RVA = "0x3111C60", Offset = "0x3111C60", VA = "0x3111C60")] get
      {
        return new int();
      }
      [Token(Token = "0x600390B"), Address(RVA = "0x3111C68", Offset = "0x3111C68", VA = "0x3111C68")] set
      {
      }
    }

    [Token(Token = "0x600390C")]
    [Address(RVA = "0x3111C70", Offset = "0x3111C70", VA = "0x3111C70")]
    public IEnumerator InitializeAsync(int panelMissionGroupId, int panelId) => (IEnumerator) null;

    [Token(Token = "0x600390D")]
    [Address(RVA = "0x3111D14", Offset = "0x3111D14", VA = "0x3111D14")]
    private void PlayCannotChallengeToaster()
    {
    }

    [Token(Token = "0x600390E")]
    [Address(RVA = "0x3111E58", Offset = "0x3111E58", VA = "0x3111E58")]
    private void OnClickItem(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x600390F")]
    [Address(RVA = "0x3111E80", Offset = "0x3111E80", VA = "0x3111E80")]
    public IEnumerator PlayInTimeline() => (IEnumerator) null;

    [Token(Token = "0x6003910")]
    [Address(RVA = "0x3111F10", Offset = "0x3111F10", VA = "0x3111F10")]
    private void OnClickChallengeImpl()
    {
    }

    [Token(Token = "0x6003911")]
    [Address(RVA = "0x3111F50", Offset = "0x3111F50", VA = "0x3111F50")]
    public IEnumerator PlayOutTimeline() => (IEnumerator) null;

    [Token(Token = "0x6003912")]
    [Address(RVA = "0x3111FE0", Offset = "0x3111FE0", VA = "0x3111FE0")]
    private IEnumerator WaitTimelineEnd() => (IEnumerator) null;

    [Token(Token = "0x6003913")]
    [Address(RVA = "0x3112070", Offset = "0x3112070", VA = "0x3112070")]
    public PanelMissionDetailDialog()
    {
    }
  }
}

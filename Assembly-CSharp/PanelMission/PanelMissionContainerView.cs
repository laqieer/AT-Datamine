// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionContainerView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x20009F0")]
  public class PanelMissionContainerView : MonoBehaviour
  {
    [Token(Token = "0x4002DF8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text _panelMissionTitle;
    [Token(Token = "0x4002DF9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PanelMissionPanelList _panelMissionPanelList;
    [Token(Token = "0x4002DFA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PanelMissionLineRewardContainer _panelMissionLineRewardContainer;
    [Token(Token = "0x4002DFB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PanelMissionSideBannerContainer _panelMissionSideBannerContainer;
    [Token(Token = "0x4002DFC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject _lockView;
    [Token(Token = "0x4002DFD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject _receivedView;
    [Token(Token = "0x4002DFE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PanelMissionUnreceivedToster _unreceivedView;
    [Token(Token = "0x4002DFF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton _backButton;
    [Token(Token = "0x4002E00")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RawImage _lineProgressBanner;
    [Token(Token = "0x4002E01")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text _lineCountDone;
    [Token(Token = "0x4002E02")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private PanelMissionLineRewardEffect _lineRewardEffect;
    [Token(Token = "0x4002E03")]
    [FieldOffset(Offset = "0x70")]
    public Action OnBack;
    [Token(Token = "0x4002E04")]
    [FieldOffset(Offset = "0x78")]
    private Action<int> OnPressReceiveAll;
    [Token(Token = "0x4002E05")]
    [FieldOffset(Offset = "0x80")]
    private CanvasGroup _canvasGroup;
    [Token(Token = "0x4002E06")]
    [FieldOffset(Offset = "0x88")]
    private UITimelineController _uiTimelineController;
    [Token(Token = "0x4002E07")]
    [FieldOffset(Offset = "0x90")]
    private PlayableDirector _playableDirector;
    [Token(Token = "0x4002E08")]
    [FieldOffset(Offset = "0x98")]
    private PanelMissionViewModelFactory _panelMissionViewModelFactory;
    [Token(Token = "0x4002E09")]
    [FieldOffset(Offset = "0xA0")]
    private PanelMissionSubScene _sequenceControl;
    [Token(Token = "0x4002E0A")]
    [FieldOffset(Offset = "0xA8")]
    private bool _isInSequence;
    [Token(Token = "0x4002E0B")]
    private const string BANNER_FORMAT = "Image/PanelMission/{0}/PanelMIssionBanner/{0}_PanelMissionBanner.png";

    [Token(Token = "0x17000800")]
    public bool IsInSequence
    {
      [Token(Token = "0x6003891"), Address(RVA = "0x310DEAC", Offset = "0x310DEAC", VA = "0x310DEAC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003892")]
    [Address(RVA = "0x310DEE0", Offset = "0x310DEE0", VA = "0x310DEE0")]
    public IEnumerator InitializeAsync(
      Action<int, int> onPressPanelRewardGet,
      Action<int, int> onPressChallenge,
      Action<int> onPressReceiveAll,
      PanelMissionSubScene panelMissionSubScene)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003893")]
    [Address(RVA = "0x310DF98", Offset = "0x310DF98", VA = "0x310DF98")]
    public void OnPressPanelLeft()
    {
    }

    [Token(Token = "0x6003894")]
    [Address(RVA = "0x310DFB8", Offset = "0x310DFB8", VA = "0x310DFB8")]
    private IEnumerator OnPressPanelLeftAsync() => (IEnumerator) null;

    [Token(Token = "0x6003895")]
    [Address(RVA = "0x310E048", Offset = "0x310E048", VA = "0x310E048")]
    public void OnPressPanelRight()
    {
    }

    [Token(Token = "0x6003896")]
    [Address(RVA = "0x310E068", Offset = "0x310E068", VA = "0x310E068")]
    private IEnumerator OnPressPanelRightAsync() => (IEnumerator) null;

    [Token(Token = "0x6003897")]
    [Address(RVA = "0x310E0F8", Offset = "0x310E0F8", VA = "0x310E0F8")]
    public void ActivateLineRewardFlashEffect(int lineNum)
    {
    }

    [Token(Token = "0x6003898")]
    [Address(RVA = "0x310E25C", Offset = "0x310E25C", VA = "0x310E25C")]
    public void DeactivateLineRewardFlashEffect(int lineNum)
    {
    }

    [Token(Token = "0x6003899")]
    [Address(RVA = "0x310E278", Offset = "0x310E278", VA = "0x310E278")]
    public void MakeLineRewardReceived(int lineNum)
    {
    }

    [Token(Token = "0x600389A")]
    [Address(RVA = "0x310E3C4", Offset = "0x310E3C4", VA = "0x310E3C4")]
    public void SetLineRewardGauge(int lineNum)
    {
    }

    [Token(Token = "0x600389B")]
    [Address(RVA = "0x310E41C", Offset = "0x310E41C", VA = "0x310E41C")]
    public void MakePanelClicked(int panelId)
    {
    }

    [Token(Token = "0x600389C")]
    [Address(RVA = "0x310E518", Offset = "0x310E518", VA = "0x310E518")]
    public void MakePanelReceived(int panelId)
    {
    }

    [Token(Token = "0x600389D")]
    [Address(RVA = "0x310E620", Offset = "0x310E620", VA = "0x310E620")]
    public IEnumerator UnlockNextPage() => (IEnumerator) null;

    [Token(Token = "0x600389E")]
    [Address(RVA = "0x310E6B0", Offset = "0x310E6B0", VA = "0x310E6B0")]
    private void OnClickBack()
    {
    }

    [Token(Token = "0x600389F")]
    [Address(RVA = "0x310E6CC", Offset = "0x310E6CC", VA = "0x310E6CC")]
    private void OnPressSideSelectButton(int missionId)
    {
    }

    [Token(Token = "0x60038A0")]
    [Address(RVA = "0x310E764", Offset = "0x310E764", VA = "0x310E764")]
    public IEnumerator ReloadProgress() => (IEnumerator) null;

    [Token(Token = "0x60038A1")]
    [Address(RVA = "0x310E6EC", Offset = "0x310E6EC", VA = "0x310E6EC")]
    public IEnumerator ShowPanel(int missionId) => (IEnumerator) null;

    [Token(Token = "0x60038A2")]
    [Address(RVA = "0x310E81C", Offset = "0x310E81C", VA = "0x310E81C")]
    private IEnumerator RefreshMissionPanelList(
      List<PanelMissionViewModelFactory.PanelViewModel> panelViewModels,
      PanelMissionViewModelFactory.PanelViewModel latestPage,
      Action onFinish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60038A3")]
    [Address(RVA = "0x310E8CC", Offset = "0x310E8CC", VA = "0x310E8CC")]
    private IEnumerator UpdateLineProgressBanner(
      PanelMissionViewModelFactory.LineProgressViewModel viewModel)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60038A4")]
    [Address(RVA = "0x310E968", Offset = "0x310E968", VA = "0x310E968")]
    public void UpdateLineCountDone(int count)
    {
    }

    [Token(Token = "0x60038A5")]
    [Address(RVA = "0x310E9B0", Offset = "0x310E9B0", VA = "0x310E9B0")]
    public IEnumerator PlayInTimeline() => (IEnumerator) null;

    [Token(Token = "0x60038A6")]
    [Address(RVA = "0x310EA40", Offset = "0x310EA40", VA = "0x310EA40")]
    public IEnumerator PlayOutTimeline() => (IEnumerator) null;

    [Token(Token = "0x60038A7")]
    [Address(RVA = "0x310EAD0", Offset = "0x310EAD0", VA = "0x310EAD0")]
    private IEnumerator WaitTimelineEnd() => (IEnumerator) null;

    [Token(Token = "0x60038A8")]
    [Address(RVA = "0x310EB60", Offset = "0x310EB60", VA = "0x310EB60")]
    public void SetActiveSideBannerBadge(int panelMissionId, bool active)
    {
    }

    [Token(Token = "0x60038A9")]
    [Address(RVA = "0x310ECF4", Offset = "0x310ECF4", VA = "0x310ECF4")]
    public void PlayLineRewardEffect(PanelMissionLineRewardEffect.LineEffectId effectId)
    {
    }

    [Token(Token = "0x60038AA")]
    [Address(RVA = "0x310EDB0", Offset = "0x310EDB0", VA = "0x310EDB0")]
    public void PlayLineRewardEffectOut(PanelMissionLineRewardEffect.LineEffectId effectId)
    {
    }

    [Token(Token = "0x60038AB")]
    [Address(RVA = "0x310EDCC", Offset = "0x310EDCC", VA = "0x310EDCC")]
    public IEnumerator WaitLineRewardEffectAnimationEnd() => (IEnumerator) null;

    [Token(Token = "0x60038AC")]
    [Address(RVA = "0x310EE5C", Offset = "0x310EE5C", VA = "0x310EE5C")]
    public PanelMissionContainerView()
    {
    }
  }
}

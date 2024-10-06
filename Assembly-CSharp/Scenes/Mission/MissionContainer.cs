// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002A7A")]
  public class MissionContainer : MonoBehaviour
  {
    [Token(Token = "0x400B4CE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _title;
    [Token(Token = "0x400B4CF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton _allReceiveBtn;
    [Token(Token = "0x400B4D0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MissionListContainer _listContainer;
    [Token(Token = "0x400B4D1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ProgressPointView _progressPoint;
    [Token(Token = "0x400B4D2")]
    [FieldOffset(Offset = "0x38")]
    private bool IsClicked;
    [Token(Token = "0x400B4D3")]
    [FieldOffset(Offset = "0x39")]
    private bool _isInitialized;
    [Token(Token = "0x400B4D4")]
    [FieldOffset(Offset = "0x40")]
    private MissionSubScene _subScene;
    [Token(Token = "0x400B4D5")]
    [FieldOffset(Offset = "0x48")]
    private MissionContentsModel _contentsModel;
    [Token(Token = "0x400B4D6")]
    [FieldOffset(Offset = "0x50")]
    private List<PlayerMissionProgressType> _visibleMissionList;

    [Token(Token = "0x60109FD")]
    [Address(RVA = "0x4C3492C", Offset = "0x4C3492C", VA = "0x4C3492C")]
    private void Update()
    {
    }

    [Token(Token = "0x60109FE")]
    [Address(RVA = "0x4C349C0", Offset = "0x4C349C0", VA = "0x4C349C0")]
    public IEnumerator InitializeAsync(MissionSubScene subScene) => (IEnumerator) null;

    [Token(Token = "0x60109FF")]
    [Address(RVA = "0x4C34A5C", Offset = "0x4C34A5C", VA = "0x4C34A5C")]
    public IEnumerator Show(MissionContentsModel contentsModel) => (IEnumerator) null;

    [Token(Token = "0x6010A00")]
    [Address(RVA = "0x4C34AD0", Offset = "0x4C34AD0", VA = "0x4C34AD0")]
    public bool GetHasProgressReward() => new bool();

    [Token(Token = "0x6010A01")]
    [Address(RVA = "0x4C34BB4", Offset = "0x4C34BB4", VA = "0x4C34BB4")]
    private void OnReceiveMissionReward(int missionId)
    {
    }

    [Token(Token = "0x6010A02")]
    [Address(RVA = "0x4C34CB8", Offset = "0x4C34CB8", VA = "0x4C34CB8")]
    private void OnReceiveMissionReward(List<int> missionIds)
    {
    }

    [Token(Token = "0x6010A03")]
    [Address(RVA = "0x4C34D4C", Offset = "0x4C34D4C", VA = "0x4C34D4C")]
    private List<int> NotAcceptedMissionIds() => (List<int>) null;

    [Token(Token = "0x6010A04")]
    [Address(RVA = "0x4C34F20", Offset = "0x4C34F20", VA = "0x4C34F20")]
    private void OnReceiveAllMissionReward()
    {
    }

    [Token(Token = "0x6010A05")]
    [Address(RVA = "0x4C34CD8", Offset = "0x4C34CD8", VA = "0x4C34CD8")]
    private IEnumerator RequestReceiveMissionReward(List<int> ids) => (IEnumerator) null;

    [Token(Token = "0x6010A06")]
    [Address(RVA = "0x4C34F98", Offset = "0x4C34F98", VA = "0x4C34F98")]
    private void SetReceivedList(
      List<Reward> receivedItems,
      List<Reward> unreceivedRewards,
      bool hasNotAccepted)
    {
    }

    [Token(Token = "0x6010A07")]
    [Address(RVA = "0x4C35084", Offset = "0x4C35084", VA = "0x4C35084")]
    private IEnumerator EnableClickAfterOneFrame() => (IEnumerator) null;

    [Token(Token = "0x6010A08")]
    [Address(RVA = "0x4C35114", Offset = "0x4C35114", VA = "0x4C35114")]
    private void OpenHasNotAcceptedPopup(bool hasNotAccepted, Action callback = null)
    {
    }

    [Token(Token = "0x6010A09")]
    [Address(RVA = "0x4C35394", Offset = "0x4C35394", VA = "0x4C35394")]
    private void RefreshMissionList()
    {
    }

    [Token(Token = "0x6010A0A")]
    [Address(RVA = "0x4C35398", Offset = "0x4C35398", VA = "0x4C35398")]
    private void SetMissionList()
    {
    }

    [Token(Token = "0x6010A0B")]
    [Address(RVA = "0x4C35450", Offset = "0x4C35450", VA = "0x4C35450")]
    private void UpdateProgressPoint()
    {
    }

    [Token(Token = "0x6010A0C")]
    [Address(RVA = "0x4C35570", Offset = "0x4C35570", VA = "0x4C35570")]
    private void OnReceiveProgressReward(int treasureIndex)
    {
    }

    [Token(Token = "0x6010A0D")]
    [Address(RVA = "0x4C35590", Offset = "0x4C35590", VA = "0x4C35590")]
    private IEnumerator RequestReceiveProgressReward(int treasureIndex) => (IEnumerator) null;

    [Token(Token = "0x6010A0E")]
    [Address(RVA = "0x4C35608", Offset = "0x4C35608", VA = "0x4C35608")]
    private IEnumerator OnUpdateMissionList(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010A0F")]
    [Address(RVA = "0x4C35670", Offset = "0x4C35670", VA = "0x4C35670")]
    public MissionContainer()
    {
    }
  }
}

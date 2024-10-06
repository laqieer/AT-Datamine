// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionSideBannerContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A29")]
  public class PanelMissionSideBannerContainer : MonoBehaviour
  {
    [Token(Token = "0x4002F12")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform _contentRoot;
    [Token(Token = "0x4002F13")]
    private const string SideBannerAssetBundleName = "ui_page_panelmission_prefab";
    [Token(Token = "0x4002F14")]
    private const string SideBannerAssetName = "PanelMission_PanelSelectButton";
    [Token(Token = "0x4002F15")]
    [FieldOffset(Offset = "0x20")]
    private List<PanelMissionViewModelFactory.SideBannerViewModel> _sideBannerViewModels;
    [Token(Token = "0x4002F16")]
    [FieldOffset(Offset = "0x28")]
    private List<PanelMissionPanelSelectButton> _panelSelectButtons;

    [Token(Token = "0x60039FC")]
    [Address(RVA = "0x310EB7C", Offset = "0x310EB7C", VA = "0x310EB7C")]
    public void RefreshBadge(int panelMissionId, bool active)
    {
    }

    [Token(Token = "0x60039FD")]
    [Address(RVA = "0x3111134", Offset = "0x3111134", VA = "0x3111134")]
    public void SetActivePanel(int panelMissionId)
    {
    }

    [Token(Token = "0x60039FE")]
    [Address(RVA = "0x310FB34", Offset = "0x310FB34", VA = "0x310FB34")]
    public IEnumerator InitializeAsync(
      List<PanelMissionViewModelFactory.SideBannerViewModel> sideBannerViewModels,
      Action<int> onPressSelectButton)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60039FF")]
    [Address(RVA = "0x3116558", Offset = "0x3116558", VA = "0x3116558")]
    public PanelMissionSideBannerContainer()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A2C")]
  public class PanelMissionSubScene : SubScene
  {
    [Token(Token = "0x4002F1E")]
    private const string ContainerAssetBundleName = "ui_page_panelmission_prefab";
    [Token(Token = "0x4002F1F")]
    private const string ContainerAssetName = "Container_PanelMission";
    [Token(Token = "0x4002F20")]
    [FieldOffset(Offset = "0x58")]
    private PanelMissionContainerView _container;
    [Token(Token = "0x4002F21")]
    [FieldOffset(Offset = "0x60")]
    private PanelMissionDetailDialog _detailDialog;
    [Token(Token = "0x4002F22")]
    [FieldOffset(Offset = "0x68")]
    private bool _isInSequence;
    [Token(Token = "0x4002F23")]
    private const string MissionLineRewardDialogAssetBundleName = "ui_page_panelmission_prefab";
    [Token(Token = "0x4002F24")]
    private const string MissionLineRewardDialogAssetName = "Container_Popup_PanelMissionClear";
    [Token(Token = "0x4002F25")]
    private const string MissionDetailDialogAssetBundleName = "ui_page_panelmission_prefab";
    [Token(Token = "0x4002F26")]
    private const string MissionDetailDialogAssetName = "Com_Popup_PanelmissionDetail";
    [Token(Token = "0x4002F27")]
    private const string MissionClearDialogAssetBundleName = "ui_page_panelmission_prefab";
    [Token(Token = "0x4002F28")]
    private const string MissionClearDialogAssetName = "Container_Popup_PanelMissionClear";
    [Token(Token = "0x4002F29")]
    private const string MissionLineCompleteDialogAssetBundleName = "ui_page_panelmission_prefab";
    [Token(Token = "0x4002F2A")]
    private const string MissionLineCompleteDialogAssetName = "Container_MissionComplete_Performance";

    [Token(Token = "0x6003A08")]
    [Address(RVA = "0x330F70C", Offset = "0x330F70C", VA = "0x330F70C")]
    public bool CanAnimationOrExecution() => new bool();

    [Token(Token = "0x6003A09")]
    [Address(RVA = "0x330F728", Offset = "0x330F728", VA = "0x330F728", Slot = "6")]
    public override void Initialize(ChangeSceneParameter parameter)
    {
    }

    [Token(Token = "0x6003A0A")]
    [Address(RVA = "0x330F7A0", Offset = "0x330F7A0", VA = "0x330F7A0", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x1700084F")]
    public bool IsInSequence
    {
      [Token(Token = "0x6003A0B"), Address(RVA = "0x330F830", Offset = "0x330F830", VA = "0x330F830")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003A0C")]
    [Address(RVA = "0x330F838", Offset = "0x330F838", VA = "0x330F838")]
    private void ActivateLineRewardFlashEffect(int lineNum)
    {
    }

    [Token(Token = "0x6003A0D")]
    [Address(RVA = "0x330F854", Offset = "0x330F854", VA = "0x330F854")]
    private void DeactivateLineRewardFlashEffect(int lineNum)
    {
    }

    [Token(Token = "0x6003A0E")]
    [Address(RVA = "0x330F870", Offset = "0x330F870", VA = "0x330F870")]
    private IEnumerator GetPressLineRewardAsync(
      int panelMissionId,
      int panelMissionGroupId,
      int lineNum)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003A0F")]
    [Address(RVA = "0x330F924", Offset = "0x330F924", VA = "0x330F924")]
    private void OnPressChallenge(int panelMissionGroupId, int panelId)
    {
    }

    [Token(Token = "0x6003A10")]
    [Address(RVA = "0x330F944", Offset = "0x330F944", VA = "0x330F944")]
    private IEnumerator OnPressChallengeAsync(int panelMissionGroupId, int panelId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003A11")]
    [Address(RVA = "0x330F9E8", Offset = "0x330F9E8", VA = "0x330F9E8")]
    private void OnClickCancelAtDetailDialog()
    {
    }

    [Token(Token = "0x6003A12")]
    [Address(RVA = "0x330FA08", Offset = "0x330FA08", VA = "0x330FA08")]
    private IEnumerator OnClickCancelAtDetailDialogAsync() => (IEnumerator) null;

    [Token(Token = "0x6003A13")]
    [Address(RVA = "0x330FA98", Offset = "0x330FA98", VA = "0x330FA98")]
    private void OnClickChallengeAtDetailDialog(int panelMissionGroupId, int panelId)
    {
    }

    [Token(Token = "0x6003A14")]
    [Address(RVA = "0x330FA9C", Offset = "0x330FA9C", VA = "0x330FA9C")]
    private void OnPressPanelRewardGet(int panelMissionGroupId, int panelId)
    {
    }

    [Token(Token = "0x6003A15")]
    [Address(RVA = "0x330FB38", Offset = "0x330FB38", VA = "0x330FB38")]
    private void OnPressAllPanelRewardGet(int panelMissionId)
    {
    }

    [Token(Token = "0x6003A16")]
    [Address(RVA = "0x330FB58", Offset = "0x330FB58", VA = "0x330FB58")]
    private IEnumerator OnPressAllPanelRewardGetAsync(int panelMissionId) => (IEnumerator) null;

    [Token(Token = "0x6003A17")]
    [Address(RVA = "0x330FBF8", Offset = "0x330FBF8", VA = "0x330FBF8")]
    private IEnumerator UpdatePanelMissionProgressList(
      PanelMissionViewModelFactory factory,
      Action onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003A18")]
    [Address(RVA = "0x330FC94", Offset = "0x330FC94", VA = "0x330FC94")]
    private IEnumerator ReceiveMissionRewardAPIConnection(
      PanelMissionViewModelFactory factory,
      int panelMissionGroupId,
      int missionId,
      Action<int, int> onFinish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003A19")]
    [Address(RVA = "0x330FABC", Offset = "0x330FABC", VA = "0x330FABC")]
    private IEnumerator OnPressPanelRewardGetAsync(int panelMissionGroupId, int panelId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003A1A")]
    [Address(RVA = "0x330FD70", Offset = "0x330FD70", VA = "0x330FD70")]
    private IEnumerator ShowCompleteEffect() => (IEnumerator) null;

    [Token(Token = "0x6003A1B")]
    [Address(RVA = "0x330FE00", Offset = "0x330FE00", VA = "0x330FE00")]
    private void OnBack()
    {
    }

    [Token(Token = "0x6003A1C")]
    [Address(RVA = "0x330FED0", Offset = "0x330FED0", VA = "0x330FED0", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6003A1D")]
    [Address(RVA = "0x330FF60", Offset = "0x330FF60", VA = "0x330FF60")]
    public PanelMissionSubScene()
    {
    }
  }
}

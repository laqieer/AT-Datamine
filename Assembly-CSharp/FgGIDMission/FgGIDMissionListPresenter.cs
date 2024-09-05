// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionListPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x200199B")]
  public class FgGIDMissionListPresenter : IFgGIDMissionListPresenter
  {
    [Token(Token = "0x4006DE7")]
    [FieldOffset(Offset = "0x10")]
    private FgGIDMissionListView view;
    [Token(Token = "0x4006DE8")]
    [FieldOffset(Offset = "0x18")]
    private FgGIDAppData appData;
    [Token(Token = "0x4006DE9")]
    [FieldOffset(Offset = "0x20")]
    private FgGIDMissionDataManager manager;
    [Token(Token = "0x4006DEA")]
    [FieldOffset(Offset = "0x28")]
    private FgGIDMissionLoader loader;

    [Token(Token = "0x6009215")]
    [Address(RVA = "0x4D0C518", Offset = "0x4D0C518", VA = "0x4D0C518")]
    public FgGIDMissionListPresenter(
      FgGIDMissionListView view,
      FgGIDMissionDataManager manager,
      FgGIDMissionLoader loader)
    {
    }

    [Token(Token = "0x6009216")]
    [Address(RVA = "0x4D0ECA0", Offset = "0x4D0ECA0", VA = "0x4D0ECA0", Slot = "5")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6009217")]
    [Address(RVA = "0x4D0EDC4", Offset = "0x4D0EDC4", VA = "0x4D0EDC4", Slot = "4")]
    public void AssignListItemPresenter(FgGIDMissionListItemView view, int index)
    {
    }

    [Token(Token = "0x6009218")]
    [Address(RVA = "0x4D0EFB0", Offset = "0x4D0EFB0", VA = "0x4D0EFB0")]
    public void OnSelectedAppChanged(FgGIDAppData appData)
    {
    }

    [Token(Token = "0x6009219")]
    [Address(RVA = "0x4D0F2CC", Offset = "0x4D0F2CC", VA = "0x4D0F2CC")]
    public void OnMissionListChanged(FgGIDAppData appData)
    {
    }

    [Token(Token = "0x600921A")]
    [Address(RVA = "0x4D0F350", Offset = "0x4D0F350", VA = "0x4D0F350", Slot = "6")]
    public void BalkReceiveButtonClicked()
    {
    }

    [Token(Token = "0x600921B")]
    [Address(RVA = "0x4D0F374", Offset = "0x4D0F374", VA = "0x4D0F374")]
    public void OnReceiveButtonClicked(FgGIDMissionData missionData)
    {
    }

    [Token(Token = "0x600921C")]
    [Address(RVA = "0x4D0F38C", Offset = "0x4D0F38C", VA = "0x4D0F38C")]
    public void OnChallengeButtonClicked(FgGIDMissionData missionData)
    {
    }
  }
}

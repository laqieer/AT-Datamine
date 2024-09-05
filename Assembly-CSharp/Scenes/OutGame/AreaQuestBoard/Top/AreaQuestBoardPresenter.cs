// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaQuestBoardPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038D0")]
  internal class AreaQuestBoardPresenter : IAreaQuestTopPresenter
  {
    [Token(Token = "0x400F87E")]
    [FieldOffset(Offset = "0x10")]
    private readonly AreaQuestBoardSubScene subScene;
    [Token(Token = "0x400F87F")]
    [FieldOffset(Offset = "0x18")]
    private readonly AreaQuestBoardTopView view;
    [Token(Token = "0x400F880")]
    [FieldOffset(Offset = "0x20")]
    private readonly AreaQuestBoardTopModel model;

    [Token(Token = "0x6016550")]
    [Address(RVA = "0x207324C", Offset = "0x207324C", VA = "0x207324C")]
    public AreaQuestBoardPresenter(
      AreaQuestBoardSubScene subScene,
      AreaQuestBoardTopView view,
      AreaQuestBoardTopModel model,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6016551")]
    [Address(RVA = "0x207A3F8", Offset = "0x207A3F8", VA = "0x207A3F8", Slot = "4")]
    public IEnumerator Init() => (IEnumerator) null;

    [Token(Token = "0x6016552")]
    [Address(RVA = "0x207A488", Offset = "0x207A488", VA = "0x207A488", Slot = "5")]
    public void Setup()
    {
    }

    [Token(Token = "0x6016553")]
    [Address(RVA = "0x207AD48", Offset = "0x207AD48", VA = "0x207AD48", Slot = "6")]
    public void Execute()
    {
    }

    [Token(Token = "0x6016554")]
    [Address(RVA = "0x207AF0C", Offset = "0x207AF0C", VA = "0x207AF0C", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x6016555")]
    [Address(RVA = "0x207A6F4", Offset = "0x207A6F4", VA = "0x207A6F4")]
    private void SetupAreaChangeButtons()
    {
    }

    [Token(Token = "0x6016556")]
    [Address(RVA = "0x207A8FC", Offset = "0x207A8FC", VA = "0x207A8FC")]
    private void SetupDifficultyButton()
    {
    }

    [Token(Token = "0x6016557")]
    [Address(RVA = "0x207A9C0", Offset = "0x207A9C0", VA = "0x207A9C0")]
    private void SetupScenarioSkipButton()
    {
    }

    [Token(Token = "0x6016558")]
    [Address(RVA = "0x207AAB0", Offset = "0x207AAB0", VA = "0x207AAB0")]
    private void SetupJumpNodeButtons()
    {
    }

    [Token(Token = "0x6016559")]
    [Address(RVA = "0x207BDAC", Offset = "0x207BDAC", VA = "0x207BDAC")]
    private void OnChangeArea(int nextAreaId)
    {
    }

    [Token(Token = "0x601655A")]
    [Address(RVA = "0x207BEB8", Offset = "0x207BEB8", VA = "0x207BEB8")]
    private void OnChangeDifficulty(int difficultyId)
    {
    }

    [Token(Token = "0x601655B")]
    [Address(RVA = "0x207C054", Offset = "0x207C054", VA = "0x207C054")]
    private void OnJumpNodeButton(int nodeId)
    {
    }

    [Token(Token = "0x601655C")]
    [Address(RVA = "0x207C108", Offset = "0x207C108", VA = "0x207C108")]
    private void OnChangePlayableArea(int areaId, bool isPlayable, bool isRequestAnim)
    {
    }
  }
}

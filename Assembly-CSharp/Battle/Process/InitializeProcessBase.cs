// Decompiled with JetBrains decompiler
// Type: Battle.Process.InitializeProcessBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Stage;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002644")]
  public class InitializeProcessBase : BattleProcessBase
  {
    [Token(Token = "0x400A45B")]
    private const string SceneNameBattleStage = "PvEBattleStage";
    [Token(Token = "0x400A45C")]
    [FieldOffset(Offset = "0x21")]
    protected bool bgOccludeDotDisplay;
    [Token(Token = "0x400A45D")]
    [FieldOffset(Offset = "0x28")]
    public Action OnFinishedProcess;
    [Token(Token = "0x400A45E")]
    [FieldOffset(Offset = "0x30")]
    private InitializeProcessBase.State state;

    [Token(Token = "0x600ECFC")]
    [Address(RVA = "0x4493074", Offset = "0x4493074", VA = "0x4493074", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600ECFD")]
    [Address(RVA = "0x449314C", Offset = "0x449314C", VA = "0x449314C", Slot = "16")]
    protected virtual IEnumerator InitializeBattle() => (IEnumerator) null;

    [Token(Token = "0x600ECFE")]
    [Address(RVA = "0x44931DC", Offset = "0x44931DC", VA = "0x44931DC")]
    protected IEnumerator InAdvanceLoadDuelSceneAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x600ECFF")]
    [Address(RVA = "0x449326C", Offset = "0x449326C", VA = "0x449326C")]
    protected void SetDotShaderParameter(bool bgOccludeDotDisplay)
    {
    }

    [Token(Token = "0x600ED00")]
    [Address(RVA = "0x4493344", Offset = "0x4493344", VA = "0x4493344")]
    protected void LoadSoundPacks()
    {
    }

    [Token(Token = "0x600ED01")]
    [Address(RVA = "0x4493510", Offset = "0x4493510", VA = "0x4493510", Slot = "17")]
    protected virtual IEnumerator LoadBasicAssets() => (IEnumerator) null;

    [Token(Token = "0x600ED02")]
    [Address(RVA = "0x44935A0", Offset = "0x44935A0", VA = "0x44935A0", Slot = "18")]
    protected virtual void InitializeBoard()
    {
    }

    [Token(Token = "0x600ED03")]
    [Address(RVA = "0x4490478", Offset = "0x4490478", VA = "0x4490478")]
    protected CharacterSupportData CreateNpcCharacterSupportData(
      IEnumerable<UnitParameterData> units,
      IEnumerable<IUnitPlacementData> placements)
    {
      return (CharacterSupportData) null;
    }

    [Token(Token = "0x600ED04")]
    [Address(RVA = "0x44935B4", Offset = "0x44935B4", VA = "0x44935B4")]
    protected void SetFieldBgColor()
    {
    }

    [Token(Token = "0x600ED05")]
    [Address(RVA = "0x44936D4", Offset = "0x44936D4", VA = "0x44936D4", Slot = "19")]
    protected virtual void CreateMapGrids(BattleStage stage, MapEditorData mapEditorData)
    {
    }

    [Token(Token = "0x600ED06")]
    [Address(RVA = "0x449387C", Offset = "0x449387C", VA = "0x449387C", Slot = "20")]
    protected virtual IEnumerator LoadItemIcon() => (IEnumerator) null;

    [Token(Token = "0x600ED07")]
    [Address(RVA = "0x4493904", Offset = "0x4493904", VA = "0x4493904")]
    protected void SetupMapCamera(BattleStage stage)
    {
    }

    [Token(Token = "0x600ED08")]
    [Address(RVA = "0x44946F4", Offset = "0x44946F4", VA = "0x44946F4")]
    protected IEnumerator LoadFacilityAssets() => (IEnumerator) null;

    [Token(Token = "0x600ED09")]
    [Address(RVA = "0x4494784", Offset = "0x4494784", VA = "0x4494784")]
    private void CreateFacilityView()
    {
    }

    [Token(Token = "0x600ED0A")]
    [Address(RVA = "0x4494DC8", Offset = "0x4494DC8", VA = "0x4494DC8")]
    private IEnumerator LoadUnitAssets() => (IEnumerator) null;

    [Token(Token = "0x600ED0B")]
    [Address(RVA = "0x4494E58", Offset = "0x4494E58", VA = "0x4494E58")]
    private IEnumerator LoadSkillAssets() => (IEnumerator) null;

    [Token(Token = "0x600ED0C")]
    [Address(RVA = "0x4494EE8", Offset = "0x4494EE8", VA = "0x4494EE8")]
    private List<string> GetUnitAssetBundleNames(UnitParameterData unit) => (List<string>) null;

    [Token(Token = "0x600ED0D")]
    [Address(RVA = "0x4495110", Offset = "0x4495110", VA = "0x4495110", Slot = "21")]
    protected virtual void CreateUnitView()
    {
    }

    [Token(Token = "0x600ED0E")]
    [Address(RVA = "0x449566C", Offset = "0x449566C", VA = "0x449566C")]
    private void DestinationEffectSetting()
    {
    }

    [Token(Token = "0x600ED0F")]
    [Address(RVA = "0x4495B08", Offset = "0x4495B08", VA = "0x4495B08")]
    private void ClearConditionEffect(
      IEnumerable<BattleClearConditionData> clearCondition)
    {
    }

    [Token(Token = "0x600ED10")]
    [Address(RVA = "0x449602C", Offset = "0x449602C", VA = "0x449602C")]
    private void FailedConditionEffect(
      IEnumerable<BattleFailedConditionData> failCondition)
    {
    }

    [Token(Token = "0x600ED11")]
    [Address(RVA = "0x4496550", Offset = "0x4496550", VA = "0x4496550")]
    protected IEnumerator LoadUIAssets() => (IEnumerator) null;

    [Token(Token = "0x600ED12")]
    [Address(RVA = "0x44965E0", Offset = "0x44965E0", VA = "0x44965E0")]
    protected void LoadRequestAssetBundleLabelsForUnitThumbnail(
      BattlePlayerData playerData,
      ref List<string> loadRequestList)
    {
    }

    [Token(Token = "0x600ED13")]
    [Address(RVA = "0x449670C", Offset = "0x449670C", VA = "0x449670C")]
    protected void LoadRequestAssetBundleLabelsForItemThumbnail(
      BattlePlayerData playerData,
      ref List<string> loadRequestList)
    {
    }

    [Token(Token = "0x600ED14")]
    [Address(RVA = "0x4496920", Offset = "0x4496920", VA = "0x4496920")]
    protected void LoadRequestAssetBundleLabelsForEquipmentThumbnail(
      BattlePlayerData playerData,
      ref List<string> loadRequestList)
    {
    }

    [Token(Token = "0x600ED15")]
    [Address(RVA = "0x44973D8", Offset = "0x44973D8", VA = "0x44973D8")]
    protected void AddUnitThumbnailAsset(BattlePlayerData playerData)
    {
    }

    [Token(Token = "0x600ED16")]
    [Address(RVA = "0x4491754", Offset = "0x4491754", VA = "0x4491754", Slot = "22")]
    protected virtual IEnumerator InitializeUI() => (IEnumerator) null;

    [Token(Token = "0x600ED17")]
    [Address(RVA = "0x44977C4", Offset = "0x44977C4", VA = "0x44977C4", Slot = "11")]
    protected override void Finish(ProcessCode nextProcess)
    {
    }

    [Token(Token = "0x600ED18")]
    [Address(RVA = "0x4491740", Offset = "0x4491740", VA = "0x4491740")]
    public InitializeProcessBase()
    {
    }

    [Token(Token = "0x2002645")]
    protected enum State
    {
      [Token(Token = "0x400A460")] Initialize,
      [Token(Token = "0x400A461")] WaitForInitialized,
      [Token(Token = "0x400A462")] Exit,
    }
  }
}

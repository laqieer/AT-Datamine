// Decompiled with JetBrains decompiler
// Type: Battle.Process.ManualActionSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data;
using Battle.Data.Board;
using Battle.Logic.Prediction;
using Battle.Particle;
using Battle.RouteSearch;
using Battle.UI;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002624")]
  public class ManualActionSelector : UnitActionSelectorBase
  {
    [Token(Token = "0x400A3CD")]
    [FieldOffset(Offset = "0x70")]
    private UsableWeaponSkillMap skillMap;
    [Token(Token = "0x400A3CE")]
    [FieldOffset(Offset = "0x78")]
    private bool isSwitched;
    [Token(Token = "0x400A3D0")]
    [FieldOffset(Offset = "0x7A")]
    private bool cancelable;
    [Token(Token = "0x400A3D1")]
    [FieldOffset(Offset = "0x7B")]
    private bool isReleaseDoublePlaying;
    [Token(Token = "0x400A3D2")]
    [FieldOffset(Offset = "0x80")]
    private BattlePlayerData itemUser;
    [Token(Token = "0x400A3D3")]
    [FieldOffset(Offset = "0x88")]
    private ItemParameterData[] itemList;
    [Token(Token = "0x400A3D4")]
    [FieldOffset(Offset = "0x90")]
    private int selectedItemIdx;
    [Token(Token = "0x400A3D5")]
    [FieldOffset(Offset = "0x98")]
    private List<UnitParameterData> itemTargettableUnit;
    [Token(Token = "0x400A3D6")]
    [FieldOffset(Offset = "0xA0")]
    private List<TargetPair> itemTargetUnits;
    [Token(Token = "0x400A3D7")]
    [FieldOffset(Offset = "0xA8")]
    private Queue<ManualActionLuaCommandData> luaList;
    [Token(Token = "0x400A3D8")]
    [FieldOffset(Offset = "0xB0")]
    private LuaCommandState luaCommandState;
    [Token(Token = "0x400A3D9")]
    [FieldOffset(Offset = "0xB8")]
    private ParticleEmitter.Handle gridParticle;
    [Token(Token = "0x400A3DA")]
    [FieldOffset(Offset = "0xC8")]
    private Image grayMask;
    [Token(Token = "0x400A3DB")]
    [FieldOffset(Offset = "0xD0")]
    private AttackableAreaSearcher doubleAreaSeacher;
    [Token(Token = "0x400A3DC")]
    [FieldOffset(Offset = "0xD8")]
    private InteractableAreaSearcher interactAreaSeacher;
    [Token(Token = "0x400A3DD")]
    [FieldOffset(Offset = "0xE0")]
    private Action onSimMoveFinish;
    [Token(Token = "0x400A3DE")]
    [FieldOffset(Offset = "0xE8")]
    private bool onSimMoveFinishIStatusPanelShow;

    [Token(Token = "0x17003249")]
    private IDirector director
    {
      [Token(Token = "0x600EBB6"), Address(RVA = "0x4BA0124", Offset = "0x4BA0124", VA = "0x4BA0124")] get
      {
        return (IDirector) null;
      }
    }

    [Token(Token = "0x1700324A")]
    public IDirector Director
    {
      [Token(Token = "0x600EBB7"), Address(RVA = "0x4BA0140", Offset = "0x4BA0140", VA = "0x4BA0140")] get
      {
        return (IDirector) null;
      }
    }

    [Token(Token = "0x1700324B")]
    private SkillParameterData selectedSkillParam
    {
      [Token(Token = "0x600EBB8"), Address(RVA = "0x4BA015C", Offset = "0x4BA015C", VA = "0x4BA015C")] get
      {
        return (SkillParameterData) null;
      }
    }

    [Token(Token = "0x1700324C")]
    public bool TargetSelecting
    {
      [Token(Token = "0x600EBB9"), Address(RVA = "0x4BA022C", Offset = "0x4BA022C", VA = "0x4BA022C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EBBA"), Address(RVA = "0x4BA0234", Offset = "0x4BA0234", VA = "0x4BA0234")] private set
      {
      }
    }

    [Token(Token = "0x1700324D")]
    public bool Cancelable
    {
      [Token(Token = "0x600EBBB"), Address(RVA = "0x4BA0240", Offset = "0x4BA0240", VA = "0x4BA0240")] set
      {
      }
    }

    [Token(Token = "0x600EBBC")]
    [Address(RVA = "0x4B991B4", Offset = "0x4B991B4", VA = "0x4B991B4")]
    public ManualActionSelector(BattleCore core)
    {
    }

    [Token(Token = "0x600EBBD")]
    [Address(RVA = "0x4BA024C", Offset = "0x4BA024C", VA = "0x4BA024C")]
    protected void SwitchBoard(BoardData targetBoard, bool resetWeapon)
    {
    }

    [Token(Token = "0x600EBBE")]
    [Address(RVA = "0x4BA048C", Offset = "0x4BA048C", VA = "0x4BA048C")]
    public bool StartSelectAction(UnitParameterData unit, bool cancelable, Action<bool> onSelected)
    {
      return new bool();
    }

    [Token(Token = "0x600EBBF")]
    [Address(RVA = "0x4BA19B8", Offset = "0x4BA19B8", VA = "0x4BA19B8")]
    public bool StartActionableView(
      UnitParameterData unit,
      GridData selectGrid,
      Action<bool> onSelected)
    {
      return new bool();
    }

    [Token(Token = "0x600EBC0")]
    [Address(RVA = "0x4BA24D0", Offset = "0x4BA24D0", VA = "0x4BA24D0", Slot = "11")]
    public override void Finish()
    {
    }

    [Token(Token = "0x600EBC1")]
    [Address(RVA = "0x4BA1FCC", Offset = "0x4BA1FCC", VA = "0x4BA1FCC")]
    private bool IsUpdateSkillSearchAreaView(UnitParameterData noActionUnit) => new bool();

    [Token(Token = "0x600EBC2")]
    [Address(RVA = "0x4BA2D4C", Offset = "0x4BA2D4C", VA = "0x4BA2D4C")]
    public void HideTargetIcon()
    {
    }

    [Token(Token = "0x600EBC3")]
    [Address(RVA = "0x4BA3240", Offset = "0x4BA3240", VA = "0x4BA3240", Slot = "15")]
    public override void CancelSelection()
    {
    }

    [Token(Token = "0x600EBC4")]
    [Address(RVA = "0x4BA3264", Offset = "0x4BA3264", VA = "0x4BA3264")]
    public void OnSelectCommand(CommandType selectedCommand)
    {
    }

    [Token(Token = "0x600EBC5")]
    [Address(RVA = "0x4BA4130", Offset = "0x4BA4130", VA = "0x4BA4130", Slot = "16")]
    public override void OnSelectUnit(UnitParameterData unit, GridData grid)
    {
    }

    [Token(Token = "0x600EBC6")]
    [Address(RVA = "0x4BA5304", Offset = "0x4BA5304", VA = "0x4BA5304")]
    private void OnSelectUnitDefault(UnitParameterData unit, GridData targetGrid)
    {
    }

    [Token(Token = "0x600EBC7")]
    [Address(RVA = "0x4BA61B0", Offset = "0x4BA61B0", VA = "0x4BA61B0")]
    private Battle.RouteSearch.Node GetMoveTargetNode(GridData grid) => (Battle.RouteSearch.Node) null;

    [Token(Token = "0x600EBC8")]
    [Address(RVA = "0x4BA6454", Offset = "0x4BA6454", VA = "0x4BA6454", Slot = "17")]
    public override void OnSelectGrid(GridData grid)
    {
    }

    [Token(Token = "0x600EBC9")]
    [Address(RVA = "0x4BA70A0", Offset = "0x4BA70A0", VA = "0x4BA70A0")]
    private void OpenInteractCommand()
    {
    }

    [Token(Token = "0x600EBCA")]
    [Address(RVA = "0x4BA6D64", Offset = "0x4BA6D64", VA = "0x4BA6D64")]
    private bool IsControlFacility(FacilityData facility) => new bool();

    [Token(Token = "0x600EBCB")]
    [Address(RVA = "0x4BA7338", Offset = "0x4BA7338", VA = "0x4BA7338")]
    private bool SameFacility(Vector2Int coordinate, FacilityData facility) => new bool();

    [Token(Token = "0x600EBCC")]
    [Address(RVA = "0x4BA7368", Offset = "0x4BA7368", VA = "0x4BA7368")]
    private bool AdjacentFacility(Vector2Int coordinate, FacilityData facility) => new bool();

    [Token(Token = "0x600EBCD")]
    [Address(RVA = "0x4BA16BC", Offset = "0x4BA16BC", VA = "0x4BA16BC")]
    private void OpenCommandPanel(bool isStatusPanelShow)
    {
    }

    [Token(Token = "0x600EBCE")]
    [Address(RVA = "0x4BA5F74", Offset = "0x4BA5F74", VA = "0x4BA5F74")]
    private void OpenSkillCommandPanel(GridData targetGrid)
    {
    }

    [Token(Token = "0x600EBCF")]
    [Address(RVA = "0x4BA4710", Offset = "0x4BA4710", VA = "0x4BA4710")]
    private void OpenDoublePanel(UnitParameterData unit, GridData grid, CommandType commandType)
    {
    }

    [Token(Token = "0x600EBD0")]
    [Address(RVA = "0x4BA74E8", Offset = "0x4BA74E8", VA = "0x4BA74E8")]
    private void ConfirmDoubleButtonEvent(bool isConfirm)
    {
    }

    [Token(Token = "0x600EBD1")]
    [Address(RVA = "0x4BA7C28", Offset = "0x4BA7C28", VA = "0x4BA7C28")]
    private void SwitchToNextWeapon()
    {
    }

    [Token(Token = "0x600EBD2")]
    [Address(RVA = "0x4BA5608", Offset = "0x4BA5608", VA = "0x4BA5608")]
    public void OnConfirmUseSkill()
    {
    }

    [Token(Token = "0x600EBD3")]
    [Address(RVA = "0x4BA77AC", Offset = "0x4BA77AC", VA = "0x4BA77AC")]
    public void OnConfirmDouble()
    {
    }

    [Token(Token = "0x600EBD4")]
    [Address(RVA = "0x4BA841C", Offset = "0x4BA841C", VA = "0x4BA841C")]
    public void OnCancelDoubleActionCommand(bool isResetActionTargetGrid)
    {
    }

    [Token(Token = "0x600EBD5")]
    [Address(RVA = "0x4BA8594", Offset = "0x4BA8594", VA = "0x4BA8594")]
    public bool OnCancelSelectSkillToTarget(bool showSimpleStatus = true) => new bool();

    [Token(Token = "0x600EBD6")]
    [Address(RVA = "0x4BA8A88", Offset = "0x4BA8A88", VA = "0x4BA8A88")]
    public void OnSwitchWeaponTo(int idx)
    {
    }

    [Token(Token = "0x600EBD7")]
    [Address(RVA = "0x4BA6E78", Offset = "0x4BA6E78", VA = "0x4BA6E78")]
    public CommandType GetSelectableCommand() => new CommandType();

    [Token(Token = "0x600EBD8")]
    [Address(RVA = "0x4BA8D04", Offset = "0x4BA8D04", VA = "0x4BA8D04")]
    private void ShowUnitDetail(UnitParameterData unit, int barrierIndex)
    {
    }

    [Token(Token = "0x600EBD9")]
    [Address(RVA = "0x4BA8FD4", Offset = "0x4BA8FD4", VA = "0x4BA8FD4")]
    public void AwakeUseItem(BattlePlayerData activePlayer, Action<bool> onSelected)
    {
    }

    [Token(Token = "0x600EBDA")]
    [Address(RVA = "0x4BA2B2C", Offset = "0x4BA2B2C", VA = "0x4BA2B2C")]
    private void CleanupUseItem()
    {
    }

    [Token(Token = "0x600EBDB")]
    [Address(RVA = "0x4BA92CC", Offset = "0x4BA92CC", VA = "0x4BA92CC")]
    private void OnSelectUseItem(int idx)
    {
    }

    [Token(Token = "0x600EBDC")]
    [Address(RVA = "0x4BA5168", Offset = "0x4BA5168", VA = "0x4BA5168")]
    private void OpenUseItemConfirm()
    {
    }

    [Token(Token = "0x600EBDD")]
    [Address(RVA = "0x4BA9DE8", Offset = "0x4BA9DE8", VA = "0x4BA9DE8")]
    private void OnConfirmUseItem()
    {
    }

    [Token(Token = "0x600EBDE")]
    [Address(RVA = "0x4BA9A5C", Offset = "0x4BA9A5C", VA = "0x4BA9A5C")]
    private void UpdateCurrentItemInfo()
    {
    }

    [Token(Token = "0x600EBDF")]
    [Address(RVA = "0x4BAA068", Offset = "0x4BAA068", VA = "0x4BAA068")]
    private void UpdateItemSearchAreaAndTarget(SkillParameterData skill)
    {
    }

    [Token(Token = "0x600EBE0")]
    [Address(RVA = "0x4BAA648", Offset = "0x4BAA648", VA = "0x4BAA648")]
    private void UpdateItemEffectiveAreaAndTarget(SkillParameterData skill, GridData targetGrid)
    {
    }

    [Token(Token = "0x600EBE1")]
    [Address(RVA = "0x4BAAAC8", Offset = "0x4BAAAC8", VA = "0x4BAAAC8")]
    private void UpdateItemPrediction(
      SkillParameterData skill,
      UnitParameterData target,
      PredictionUnitResult result)
    {
    }

    [Token(Token = "0x1700324E")]
    public bool IsLuaCommand
    {
      [Token(Token = "0x600EBE2"), Address(RVA = "0x4BA0B40", Offset = "0x4BA0B40", VA = "0x4BA0B40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600EBE3")]
    [Address(RVA = "0x4BAAC04", Offset = "0x4BAAC04", VA = "0x4BAAC04")]
    public void AddLuaCommand(
      UnitParameterData unit,
      LuaActionCommandEnum command,
      int x = 0,
      int y = 0,
      int targetX = 0,
      int targetY = 0,
      int skillIdx = 0,
      int weaponIndex = 0)
    {
    }

    [Token(Token = "0x600EBE4")]
    [Address(RVA = "0x4BA2C68", Offset = "0x4BA2C68", VA = "0x4BA2C68")]
    private void CleanupLuaCommand()
    {
    }

    [Token(Token = "0x600EBE5")]
    [Address(RVA = "0x4BAAEE4", Offset = "0x4BAAEE4", VA = "0x4BAAEE4")]
    public void NextTutorialState(LuaCommandState state)
    {
    }

    [Token(Token = "0x600EBE6")]
    [Address(RVA = "0x4BAAD14", Offset = "0x4BAAD14", VA = "0x4BAAD14")]
    private void EndLuaCommandQueue()
    {
    }

    [Token(Token = "0x600EBE7")]
    [Address(RVA = "0x4BA0B88", Offset = "0x4BA0B88", VA = "0x4BA0B88")]
    private bool CheckLuaSelectUnit(UnitParameterData selectUnit) => new bool();

    [Token(Token = "0x600EBE8")]
    [Address(RVA = "0x4BA6C74", Offset = "0x4BA6C74", VA = "0x4BA6C74")]
    private bool IsMatchGrid(GridData grid) => new bool();

    [Token(Token = "0x600EBE9")]
    [Address(RVA = "0x4BAB7A8", Offset = "0x4BAB7A8", VA = "0x4BAB7A8")]
    public void OnOpenMainCommandPanelByLua()
    {
    }

    [Token(Token = "0x600EBEA")]
    [Address(RVA = "0x4BABA7C", Offset = "0x4BABA7C", VA = "0x4BABA7C")]
    public void OnOpenNormalAttackCommandPanelByLua()
    {
    }

    [Token(Token = "0x600EBEB")]
    [Address(RVA = "0x4BABB64", Offset = "0x4BABB64", VA = "0x4BABB64")]
    public void OnOpenSkillCommandPanelByLua()
    {
    }

    [Token(Token = "0x600EBEC")]
    [Address(RVA = "0x4BABD00", Offset = "0x4BABD00", VA = "0x4BABD00")]
    public void OnSelectSkillCommandByLua()
    {
    }

    [Token(Token = "0x600EBED")]
    [Address(RVA = "0x4BABD34", Offset = "0x4BABD34", VA = "0x4BABD34")]
    public void OnOpenDoubleCommandPanelByLua()
    {
    }

    [Token(Token = "0x600EBEE")]
    [Address(RVA = "0x4BABF60", Offset = "0x4BABF60", VA = "0x4BABF60")]
    public void OnSelectDoubleCommandByLua()
    {
    }

    [Token(Token = "0x600EBEF")]
    [Address(RVA = "0x4BA45D4", Offset = "0x4BA45D4", VA = "0x4BA45D4")]
    private bool IsMatchTarget(GridData grid) => new bool();

    [Token(Token = "0x600EBF0")]
    [Address(RVA = "0x4BA835C", Offset = "0x4BA835C", VA = "0x4BA835C")]
    private void DisActiveCommandPanelByLua()
    {
    }

    [Token(Token = "0x600EBF1")]
    [Address(RVA = "0x4BAB2D8", Offset = "0x4BAB2D8", VA = "0x4BAB2D8")]
    private void SetCommandUI(LuaActionCommandEnum action)
    {
    }

    [Token(Token = "0x600EBF2")]
    [Address(RVA = "0x4BABF88", Offset = "0x4BABF88", VA = "0x4BABF88")]
    public void SetSkillCommandUIByLua()
    {
    }

    [Token(Token = "0x600EBF3")]
    [Address(RVA = "0x4BA7FA0", Offset = "0x4BA7FA0", VA = "0x4BA7FA0")]
    private void CheckLuaCommandSwapWeapon(int weaponIndex)
    {
    }

    [Token(Token = "0x600EBF4")]
    [Address(RVA = "0x4BAAF58", Offset = "0x4BAAF58", VA = "0x4BAAF58")]
    private void SetupTutorialView()
    {
    }

    [Token(Token = "0x600EBF5")]
    [Address(RVA = "0x4BAC090", Offset = "0x4BAC090", VA = "0x4BAC090")]
    private void ShowInstructGrid(GridData grid)
    {
    }

    [Token(Token = "0x600EBF6")]
    [Address(RVA = "0x4BA81DC", Offset = "0x4BA81DC", VA = "0x4BA81DC")]
    private void HideIntructGrid()
    {
    }

    [Token(Token = "0x600EBF7")]
    [Address(RVA = "0x4BAAD7C", Offset = "0x4BAAD7C", VA = "0x4BAAD7C")]
    private void SetImageObj(bool isActive)
    {
    }

    [Token(Token = "0x600EBF8")]
    [Address(RVA = "0x4BAC3FC", Offset = "0x4BAC3FC", VA = "0x4BAC3FC", Slot = "13")]
    protected override void ResetPathSearcher()
    {
    }

    [Token(Token = "0x600EBF9")]
    [Address(RVA = "0x4BA0E64", Offset = "0x4BA0E64", VA = "0x4BA0E64")]
    public bool UpdateCurrentSkillView() => new bool();

    [Token(Token = "0x600EBFA")]
    [Address(RVA = "0x4BAD8FC", Offset = "0x4BAD8FC", VA = "0x4BAD8FC")]
    public void UpdateInteractTargetIcon()
    {
    }

    [Token(Token = "0x600EBFB")]
    [Address(RVA = "0x4BA8ABC", Offset = "0x4BA8ABC", VA = "0x4BA8ABC")]
    private bool IsControllableFacility() => new bool();

    [Token(Token = "0x600EBFC")]
    [Address(RVA = "0x4BA5520", Offset = "0x4BA5520", VA = "0x4BA5520")]
    public bool CanTargetSkillFromCurrentGrid(SkillParameterData skill, GridData targetGrid)
    {
      return new bool();
    }

    [Token(Token = "0x600EBFD")]
    [Address(RVA = "0x4BA4688", Offset = "0x4BA4688", VA = "0x4BA4688")]
    private bool CanTargetDoubleFromCurrentGrid(UnitParameterData targetUnit) => new bool();

    [Token(Token = "0x600EBFE")]
    [Address(RVA = "0x4BA0CB8", Offset = "0x4BA0CB8", VA = "0x4BA0CB8")]
    private void UpdateMovableSearchArea(bool isCalcMoveAmount = false)
    {
    }

    [Token(Token = "0x600EBFF")]
    [Address(RVA = "0x4BAC5C0", Offset = "0x4BAC5C0", VA = "0x4BAC5C0")]
    private void UpdateSkillSearchAreaView(SkillParameterData skill)
    {
    }

    [Token(Token = "0x600EC00")]
    [Address(RVA = "0x4BA2024", Offset = "0x4BA2024", VA = "0x4BA2024")]
    private void UpdateSkillSearchAreaView(List<SkillParameterData> skillParameters, bool isForce = false)
    {
    }

    [Token(Token = "0x600EC01")]
    [Address(RVA = "0x4BAC7C8", Offset = "0x4BAC7C8", VA = "0x4BAC7C8")]
    private void UpdateEffectiveAreaView(
      SkillParameterData skill,
      GridData targetGrid,
      out List<TargetPair> targetsInRange,
      out Dictionary<int, List<TargetPair>> targetsInRangeDictionary,
      out List<UnitParameterData> supportUnits)
    {
    }

    [Token(Token = "0x600EC02")]
    [Address(RVA = "0x4BAD5D0", Offset = "0x4BAD5D0", VA = "0x4BAD5D0")]
    private void UpdateSkillTargetableUnit(List<SkillParameterData> skills)
    {
    }

    [Token(Token = "0x600EC03")]
    [Address(RVA = "0x4BADB48", Offset = "0x4BADB48", VA = "0x4BADB48")]
    private void UpdateSkillTargetableUnitInternal(GridData grid, SkillParameterData skill)
    {
    }

    [Token(Token = "0x600EC04")]
    [Address(RVA = "0x4BACB64", Offset = "0x4BACB64", VA = "0x4BACB64")]
    private void UpdatePredictionOnTargetSelecting(
      SkillParameterData skillParam,
      List<TargetPair> targetsInRange,
      Dictionary<int, List<TargetPair>> targetsInRangeDictionary,
      List<UnitParameterData> supportUnits)
    {
    }

    [Token(Token = "0x600EC05")]
    [Address(RVA = "0x4BAE620", Offset = "0x4BAE620", VA = "0x4BAE620")]
    private void UpdatePrediction(
      UnitParameterData owner,
      SkillParameterData skill,
      PredictionUnitResult targetResult)
    {
    }

    [Token(Token = "0x600EC06")]
    [Address(RVA = "0x4BA3620", Offset = "0x4BA3620", VA = "0x4BA3620")]
    private void UpdateDoubleView()
    {
    }

    [Token(Token = "0x600EC07")]
    [Address(RVA = "0x4BA4D28", Offset = "0x4BA4D28", VA = "0x4BA4D28")]
    private void SimulateMove(
      GridData moveFrom,
      GridData moveTo,
      Action finishCallback = null,
      bool noMoveAnime = false,
      bool isStatusPanelShow = true)
    {
    }

    [Token(Token = "0x600EC08")]
    [Address(RVA = "0x4BAE8E0", Offset = "0x4BAE8E0", VA = "0x4BAE8E0")]
    private void OnSimulateMoveFinish(CommandBase command, bool canceled)
    {
    }

    [Token(Token = "0x600EC09")]
    [Address(RVA = "0x4BA3BD0", Offset = "0x4BA3BD0", VA = "0x4BA3BD0")]
    private void SimulateSwitch()
    {
    }

    [Token(Token = "0x600EC0A")]
    [Address(RVA = "0x4BAEF6C", Offset = "0x4BAEF6C", VA = "0x4BAEF6C")]
    private void OnSimulateSwitchFinish(CommandBase command, bool canceled)
    {
    }

    [Token(Token = "0x600EC0B")]
    [Address(RVA = "0x4BAEB08", Offset = "0x4BAEB08", VA = "0x4BAEB08")]
    private void UpdateActionUnitOnSwitch()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Battle.MapDirectorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Grid;
using Battle.RouteSearch;
using Battle.Stage;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200227B")]
  public abstract class MapDirectorBase : MonoBehaviour
  {
    [Token(Token = "0x4009155")]
    [FieldOffset(Offset = "0x0")]
    protected static string MapSideCoverNameSuffix;
    [Token(Token = "0x4009156")]
    [FieldOffset(Offset = "0x8")]
    protected static readonly Vector3 MapModelPosition;
    [Token(Token = "0x4009157")]
    [FieldOffset(Offset = "0x14")]
    protected static readonly Vector3 MapModelAngles;
    [Token(Token = "0x4009158")]
    protected const float MapModelScale = 1f;
    [Token(Token = "0x4009159")]
    [FieldOffset(Offset = "0x20")]
    protected static readonly Vector3 StageGridPosition;
    [Token(Token = "0x400915A")]
    [FieldOffset(Offset = "0x2C")]
    protected static readonly Vector3 GridPanelPosition;
    [Token(Token = "0x400915B")]
    public const int MapGridSize = 1;
    [Token(Token = "0x400915C")]
    protected const int DefaultLandformId = 1;
    [Token(Token = "0x400915D")]
    [FieldOffset(Offset = "0x18")]
    protected IDirector mainDirector;
    [Token(Token = "0x400915E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected float gridPositionOffsetY;
    [Token(Token = "0x400915F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected StageEventManager stageEventManager;
    [Token(Token = "0x4009160")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected BGParameters bgParameterController;
    [Token(Token = "0x4009161")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected Material gridMaterial;
    [Token(Token = "0x4009162")]
    [FieldOffset(Offset = "0x40")]
    protected GameObject mapSideCoverObject;
    [Token(Token = "0x4009163")]
    [FieldOffset(Offset = "0x48")]
    protected GameObject stageFader;
    [Token(Token = "0x4009164")]
    [FieldOffset(Offset = "0x50")]
    protected Scene mapScene;
    [Token(Token = "0x4009165")]
    [FieldOffset(Offset = "0x58")]
    protected GameObject mapCursor;
    [Token(Token = "0x4009166")]
    [FieldOffset(Offset = "0x60")]
    protected GridBehaviour mapGridPrefab;
    [Token(Token = "0x4009167")]
    [FieldOffset(Offset = "0x68")]
    protected Transform gridRoot;
    [Token(Token = "0x4009168")]
    [FieldOffset(Offset = "0x70")]
    protected GridPanelMesh stageGridMesh;
    [Token(Token = "0x4009169")]
    [FieldOffset(Offset = "0x78")]
    protected GridPanelMesh gridPanelsMesh;
    [Token(Token = "0x400916A")]
    [FieldOffset(Offset = "0x80")]
    protected GridObject[,] grids;
    [Token(Token = "0x400916E")]
    [FieldOffset(Offset = "0x98")]
    protected bool isShowingDangerArea;
    [Token(Token = "0x400916F")]
    [FieldOffset(Offset = "0xA0")]
    private BGSceneEffectController backGroundSceneEffectController;

    [Token(Token = "0x17002D99")]
    public IStageEventHandler StageEventHandler
    {
      [Token(Token = "0x600D200"), Address(RVA = "0x19598BC", Offset = "0x19598BC", VA = "0x19598BC")] get
      {
        return (IStageEventHandler) null;
      }
      [Token(Token = "0x600D201"), Address(RVA = "0x195D0E0", Offset = "0x195D0E0", VA = "0x195D0E0")] set
      {
      }
    }

    [Token(Token = "0x17002D9A")]
    public bool StageInputEventEnabled
    {
      [Token(Token = "0x600D202"), Address(RVA = "0x195D164", Offset = "0x195D164", VA = "0x195D164")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D203"), Address(RVA = "0x19589C8", Offset = "0x19589C8", VA = "0x19589C8")] set
      {
      }
    }

    [Token(Token = "0x17002D9B")]
    public bool MapSideCoverObjectVisible
    {
      [Token(Token = "0x600D204"), Address(RVA = "0x195D180", Offset = "0x195D180", VA = "0x195D180")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D205"), Address(RVA = "0x195A2D4", Offset = "0x195A2D4", VA = "0x195A2D4")] set
      {
      }
    }

    [Token(Token = "0x17002D9C")]
    public bool StageFaderVisible
    {
      [Token(Token = "0x600D206"), Address(RVA = "0x195D208", Offset = "0x195D208", VA = "0x195D208")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D207"), Address(RVA = "0x195D224", Offset = "0x195D224", VA = "0x195D224")] set
      {
      }
    }

    [Token(Token = "0x17002D9D")]
    public bool IsValidMapScene
    {
      [Token(Token = "0x600D208"), Address(RVA = "0x195D244", Offset = "0x195D244", VA = "0x195D244")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002D9E")]
    public string MapSceneName
    {
      [Token(Token = "0x600D209"), Address(RVA = "0x195D250", Offset = "0x195D250", VA = "0x195D250")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002D9F")]
    public bool AcriveSelectCursor
    {
      [Token(Token = "0x600D20A"), Address(RVA = "0x195D2C4", Offset = "0x195D2C4", VA = "0x195D2C4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002DA0")]
    public bool StageGridsVisible
    {
      [Token(Token = "0x600D20B"), Address(RVA = "0x1959BAC", Offset = "0x1959BAC", VA = "0x1959BAC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D20C"), Address(RVA = "0x1958578", Offset = "0x1958578", VA = "0x1958578")] set
      {
      }
    }

    [Token(Token = "0x17002DA1")]
    public GridObject UpLeftGrid
    {
      [Token(Token = "0x600D20D"), Address(RVA = "0x195D2E0", Offset = "0x195D2E0", VA = "0x195D2E0")] get
      {
        return (GridObject) null;
      }
    }

    [Token(Token = "0x17002DA2")]
    public GridObject UpRightGrid
    {
      [Token(Token = "0x600D20E"), Address(RVA = "0x195D318", Offset = "0x195D318", VA = "0x195D318")] get
      {
        return (GridObject) null;
      }
    }

    [Token(Token = "0x17002DA3")]
    public GridObject DownLeftGrid
    {
      [Token(Token = "0x600D20F"), Address(RVA = "0x195D368", Offset = "0x195D368", VA = "0x195D368")] get
      {
        return (GridObject) null;
      }
    }

    [Token(Token = "0x17002DA4")]
    public GridObject DownRightGrid
    {
      [Token(Token = "0x600D210"), Address(RVA = "0x195D3B4", Offset = "0x195D3B4", VA = "0x195D3B4")] get
      {
        return (GridObject) null;
      }
    }

    [Token(Token = "0x17002DA5")]
    public GridObject CenterGrid
    {
      [Token(Token = "0x600D211"), Address(RVA = "0x195D414", Offset = "0x195D414", VA = "0x195D414")] get
      {
        return (GridObject) null;
      }
      [Token(Token = "0x600D212"), Address(RVA = "0x195D41C", Offset = "0x195D41C", VA = "0x195D41C")] protected set
      {
      }
    }

    [Token(Token = "0x17002DA6")]
    public int MapSizeX
    {
      [Token(Token = "0x600D213"), Address(RVA = "0x195D424", Offset = "0x195D424", VA = "0x195D424")] get
      {
        return new int();
      }
      [Token(Token = "0x600D214"), Address(RVA = "0x195D42C", Offset = "0x195D42C", VA = "0x195D42C")] protected set
      {
      }
    }

    [Token(Token = "0x17002DA7")]
    public int MapSizeY
    {
      [Token(Token = "0x600D215"), Address(RVA = "0x195D434", Offset = "0x195D434", VA = "0x195D434")] get
      {
        return new int();
      }
      [Token(Token = "0x600D216"), Address(RVA = "0x195D43C", Offset = "0x195D43C", VA = "0x195D43C")] protected set
      {
      }
    }

    [Token(Token = "0x17002DA8")]
    public BGSceneEffectController BackGroundSceneEffectController
    {
      [Token(Token = "0x600D217"), Address(RVA = "0x195D444", Offset = "0x195D444", VA = "0x195D444")] get
      {
        return (BGSceneEffectController) null;
      }
    }

    [Token(Token = "0x600D218")]
    [Address(RVA = "0x195D44C", Offset = "0x195D44C", VA = "0x195D44C")]
    public void ActivateMapScene()
    {
    }

    [Token(Token = "0x600D219")]
    [Address(RVA = "0x195D4C4", Offset = "0x195D4C4", VA = "0x195D4C4")]
    public void SetActivateMapRoot(bool isActive)
    {
    }

    [Token(Token = "0x600D21A")]
    [Address(RVA = "0x195D650", Offset = "0x195D650", VA = "0x195D650")]
    public IEnumerator LoadMapAsync(
      string mapAssetName,
      int sceneDepth,
      MapDirectorBase.OnLoadMapScene callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D21B")]
    [Address(RVA = "0x195D6F4", Offset = "0x195D6F4", VA = "0x195D6F4")]
    private GameObject SearchMapSideCoverObject(Transform parent) => (GameObject) null;

    [Token(Token = "0x600D21C")]
    [Address(RVA = "0x195D85C", Offset = "0x195D85C", VA = "0x195D85C", Slot = "4")]
    public virtual void CreateGrid(
      ISystemFlags sys,
      Transform gridRoot,
      MapEditorData mapEditorData,
      Vector2Int areaSize,
      Vector2Int offset)
    {
    }

    [Token(Token = "0x600D21D")]
    [Address(RVA = "0x195E450", Offset = "0x195E450", VA = "0x195E450", Slot = "5")]
    public virtual void CreateGrid(
      ISystemFlags sys,
      Transform gridRoot,
      MapEditorData mapEditorData)
    {
    }

    [Token(Token = "0x600D21E")]
    [Address(RVA = "0x195E208", Offset = "0x195E208", VA = "0x195E208")]
    protected void GenerateMapGridBehaviour()
    {
    }

    [Token(Token = "0x600D21F")]
    [Address(RVA = "0x195E4E4", Offset = "0x195E4E4", VA = "0x195E4E4")]
    public void UpdateGridPanelMeshHeight()
    {
    }

    [Token(Token = "0x600D220")]
    [Address(RVA = "0x195E64C", Offset = "0x195E64C", VA = "0x195E64C")]
    public void ShowCursorAt(IGridData grid)
    {
    }

    [Token(Token = "0x600D221")]
    [Address(RVA = "0x195E760", Offset = "0x195E760", VA = "0x195E760", Slot = "6")]
    public virtual void ShowCursorAt(int x, int y)
    {
    }

    [Token(Token = "0x600D222")]
    [Address(RVA = "0x195E864", Offset = "0x195E864", VA = "0x195E864")]
    public void ShowCursor()
    {
    }

    [Token(Token = "0x600D223")]
    [Address(RVA = "0x195E884", Offset = "0x195E884", VA = "0x195E884")]
    public void HideCursor()
    {
    }

    [Token(Token = "0x600D224")]
    [Address(RVA = "0x195E8A4", Offset = "0x195E8A4", VA = "0x195E8A4")]
    public void ShowGridPanel()
    {
    }

    [Token(Token = "0x600D225")]
    [Address(RVA = "0x195E8C0", Offset = "0x195E8C0", VA = "0x195E8C0")]
    public void HideGridPanel()
    {
    }

    [Token(Token = "0x600D226")]
    [Address(RVA = "0x195E8DC", Offset = "0x195E8DC", VA = "0x195E8DC")]
    public void ActivateBGParameterController(float blendStrength = 0.5f)
    {
    }

    [Token(Token = "0x600D227")]
    [Address(RVA = "0x195E8F4", Offset = "0x195E8F4", VA = "0x195E8F4")]
    public void ActivateBGParameterController(Color blendColor, float blendStrength = 0.5f)
    {
    }

    [Token(Token = "0x600D228")]
    [Address(RVA = "0x195CFDC", Offset = "0x195CFDC", VA = "0x195CFDC")]
    public void DeactivateBGParameterController()
    {
    }

    [Token(Token = "0x600D229")]
    [Address(RVA = "0x195E9C8", Offset = "0x195E9C8", VA = "0x195E9C8")]
    public void HideAllUnitActionAreas()
    {
    }

    [Token(Token = "0x600D22A")]
    [Address(RVA = "0x195EB5C", Offset = "0x195EB5C", VA = "0x195EB5C")]
    public void HideAllUnitMoveAttackAreas()
    {
    }

    [Token(Token = "0x600D22B")]
    [Address(RVA = "0x195EC78", Offset = "0x195EC78", VA = "0x195EC78")]
    public void HidePlayerStayAreas()
    {
    }

    [Token(Token = "0x600D22C")]
    [Address(RVA = "0x195ED68", Offset = "0x195ED68", VA = "0x195ED68")]
    public void ShowAreaFromPos(List<Vector2Int> pos, GridViewType type)
    {
    }

    [Token(Token = "0x600D22D")]
    [Address(RVA = "0x195EEDC", Offset = "0x195EEDC", VA = "0x195EEDC", Slot = "7")]
    public virtual void ShowMovableAndAttackableAreaFromSearchResult(
      MovableAreaSearcher movable,
      int gridShapeSize,
      AttackableAreaSearcher attackable,
      bool isAttack)
    {
    }

    [Token(Token = "0x600D22E")]
    [Address(RVA = "0x195F0EC", Offset = "0x195F0EC", VA = "0x195F0EC", Slot = "8")]
    public virtual void AddMovableAndAttackableArea(
      MovableAreaSearcher movable,
      int gridShapeSize,
      AttackableAreaSearcher attackable,
      bool isAttack)
    {
    }

    [Token(Token = "0x600D22F")]
    [Address(RVA = "0x195F200", Offset = "0x195F200", VA = "0x195F200", Slot = "9")]
    public virtual void ShowMovableAreaFromResult(MovableAreaSearcher movable, int gridShapeSize)
    {
    }

    [Token(Token = "0x600D230")]
    [Address(RVA = "0x195F218", Offset = "0x195F218", VA = "0x195F218", Slot = "10")]
    public virtual void ShowAttackableAreaFromResult(
      AttackableAreaSearcher attackable,
      bool isAttack)
    {
    }

    [Token(Token = "0x600D231")]
    [Address(RVA = "0x195EFF4", Offset = "0x195EFF4", VA = "0x195EFF4")]
    private void AddMovableGridView(MovableAreaSearcher movable, int gridShapeSize)
    {
    }

    [Token(Token = "0x600D232")]
    [Address(RVA = "0x195F2E0", Offset = "0x195F2E0", VA = "0x195F2E0", Slot = "11")]
    public virtual void ShowEffectiveAreaFromResult(AttackableAreaSearcher effective)
    {
    }

    [Token(Token = "0x600D233")]
    [Address(RVA = "0x195F394", Offset = "0x195F394", VA = "0x195F394")]
    public void HideEffectiveAreaFromResult(AttackableAreaSearcher effective)
    {
    }

    [Token(Token = "0x600D234")]
    [Address(RVA = "0x195F448", Offset = "0x195F448", VA = "0x195F448")]
    public void MarkDangerAreaFromResult(AttackableAreaSearcher attackable)
    {
    }

    [Token(Token = "0x600D235")]
    [Address(RVA = "0x195F6D4", Offset = "0x195F6D4", VA = "0x195F6D4")]
    public void UnmarkAllDangerAreas(bool updateGridView)
    {
    }

    [Token(Token = "0x600D236")]
    [Address(RVA = "0x195F824", Offset = "0x195F824", VA = "0x195F824")]
    public void MarkFierceDangerAreaFromResult(AttackableAreaSearcher attackable)
    {
    }

    [Token(Token = "0x600D237")]
    [Address(RVA = "0x195F9D0", Offset = "0x195F9D0", VA = "0x195F9D0")]
    public void MarkFierceTargetUnitAreaFromResult(AttackableAreaSearcher attackable)
    {
    }

    [Token(Token = "0x600D238")]
    [Address(RVA = "0x195F910", Offset = "0x195F910", VA = "0x195F910")]
    private void MarkFierceAreaFromResult(
      AttackableAreaSearcher attackable,
      Action<GridObject> markAsFierce)
    {
    }

    [Token(Token = "0x600D239")]
    [Address(RVA = "0x195FABC", Offset = "0x195FABC", VA = "0x195FABC")]
    public void UnmarkAllFierceAreas(bool updateGridView)
    {
    }

    [Token(Token = "0x600D23A")]
    [Address(RVA = "0x19590FC", Offset = "0x19590FC", VA = "0x19590FC")]
    public void ToggleShowingDangerArea()
    {
    }

    [Token(Token = "0x600D23B")]
    [Address(RVA = "0x195FB64", Offset = "0x195FB64", VA = "0x195FB64")]
    public void ToggleShowingDangerArea(bool isActive)
    {
    }

    [Token(Token = "0x600D23C")]
    [Address(RVA = "0x195EAF4", Offset = "0x195EAF4", VA = "0x195EAF4")]
    public void UpdateAreaView()
    {
    }

    [Token(Token = "0x600D23D")]
    [Address(RVA = "0x195FC24", Offset = "0x195FC24", VA = "0x195FC24")]
    private void UpdateAreaView(int x, int y)
    {
    }

    [Token(Token = "0x600D23E")]
    [Address(RVA = "0x1960010", Offset = "0x1960010", VA = "0x1960010")]
    private int GetSubOverrideGridViewTypeExt(GridObject grid) => new int();

    [Token(Token = "0x600D23F")]
    [Address(RVA = "0x19600DC", Offset = "0x19600DC", VA = "0x19600DC")]
    public void ShowPredictionMove(PathSearcher2D searcher, Vector2Int coord)
    {
    }

    [Token(Token = "0x600D240")]
    [Address(RVA = "0x19602CC", Offset = "0x19602CC", VA = "0x19602CC")]
    public void ClearAdjoiningPredictionMove(bool updateGridView)
    {
    }

    [Token(Token = "0x600D241")]
    [Address(RVA = "0x1960250", Offset = "0x1960250", VA = "0x1960250")]
    private AdjoiningDirection GetAdjoiningFromNodes(Battle.RouteSearch.Node node1, Battle.RouteSearch.Node node2)
    {
      return new AdjoiningDirection();
    }

    [Token(Token = "0x600D242")]
    [Address(RVA = "0x196041C", Offset = "0x196041C", VA = "0x196041C")]
    public GridObject GetMapGrid(Vector2Int pos) => (GridObject) null;

    [Token(Token = "0x600D243")]
    [Address(RVA = "0x195E7E8", Offset = "0x195E7E8", VA = "0x195E7E8")]
    public GridObject GetMapGrid(int x, int y) => (GridObject) null;

    [Token(Token = "0x600D244")]
    [Address(RVA = "0x1952014", Offset = "0x1952014", VA = "0x1952014")]
    public GridObject GetMapGrid(GridData gridData) => (GridObject) null;

    [Token(Token = "0x600D245")]
    [Address(RVA = "0x1960424", Offset = "0x1960424", VA = "0x1960424")]
    public GridObject[] GetGrids(
      GridObject from,
      int size,
      MapDirectorBase.GetGridsMethod method,
      bool addFromGrid)
    {
      return (GridObject[]) null;
    }

    [Token(Token = "0x600D246")]
    [Address(RVA = "0x195FFF8", Offset = "0x195FFF8", VA = "0x195FFF8")]
    private int ToIndexX_OnGridPanelMesh(int x) => new int();

    [Token(Token = "0x600D247")]
    [Address(RVA = "0x1960000", Offset = "0x1960000", VA = "0x1960000")]
    private int ToIndexY_OnGridPanelMesh(int y) => new int();

    [Token(Token = "0x600D248")]
    [Address(RVA = "0x195D0CC", Offset = "0x195D0CC", VA = "0x195D0CC")]
    protected MapDirectorBase()
    {
    }

    [Token(Token = "0x600D249")]
    [Address(RVA = "0x19606B4", Offset = "0x19606B4", VA = "0x19606B4")]
    static MapDirectorBase()
    {
    }

    [Token(Token = "0x200227C")]
    public enum GetGridsMethod
    {
      [Token(Token = "0x4009171")] Square,
    }

    [Token(Token = "0x200227D")]
    public delegate void OnLoadMapScene();
  }
}

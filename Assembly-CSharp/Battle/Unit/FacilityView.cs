// Decompiled with JetBrains decompiler
// Type: Battle.Unit.FacilityView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Facility;
using Battle.Grid;
using Battle.Stage;
using Battle.UI;
using Battle.ViewCamera;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022ED")]
  public class FacilityView : MonoBehaviour
  {
    [Token(Token = "0x40093B5")]
    [FieldOffset(Offset = "0x18")]
    private Animator animator;
    [Token(Token = "0x40093B6")]
    [FieldOffset(Offset = "0x20")]
    private Actor.Direction currentDirection;
    [Token(Token = "0x40093B7")]
    [FieldOffset(Offset = "0x28")]
    private BattleFacilityStatusViewPanel statusViewPanel;
    [Token(Token = "0x40093B9")]
    [FieldOffset(Offset = "0x38")]
    public AutoTurretLocator autoTurretLocator;

    [Token(Token = "0x17002E30")]
    public float Height
    {
      [Token(Token = "0x600D595"), Address(RVA = "0x1D1588C", Offset = "0x1D1588C", VA = "0x1D1588C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002E31")]
    public bool IsPlayingAnime
    {
      [Token(Token = "0x600D596"), Address(RVA = "0x1D158FC", Offset = "0x1D158FC", VA = "0x1D158FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002E32")]
    public Vector2Int Coordinate
    {
      [Token(Token = "0x600D597"), Address(RVA = "0x1D159C8", Offset = "0x1D159C8", VA = "0x1D159C8")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600D598"), Address(RVA = "0x1D159D0", Offset = "0x1D159D0", VA = "0x1D159D0")] private set
      {
      }
    }

    [Token(Token = "0x600D599")]
    [Address(RVA = "0x1D159D8", Offset = "0x1D159D8", VA = "0x1D159D8")]
    public static FacilityView Create(
      BattleStage battleStage,
      FacilityData facility,
      WorldSpaceCanvasManager worldSpaceCanvasManager,
      IMapViewCamera camera,
      BattleConfigAsset battleConfig)
    {
      return (FacilityView) null;
    }

    [Token(Token = "0x600D59A")]
    [Address(RVA = "0x1D15E80", Offset = "0x1D15E80", VA = "0x1D15E80")]
    public void RegisterMapViewCamera(IMapViewCamera camera)
    {
    }

    [Token(Token = "0x600D59B")]
    [Address(RVA = "0x1D15F78", Offset = "0x1D15F78", VA = "0x1D15F78")]
    public void OnUpdateMapViewCameraRotation(Quaternion quaternion)
    {
    }

    [Token(Token = "0x600D59C")]
    [Address(RVA = "0x1D16030", Offset = "0x1D16030", VA = "0x1D16030")]
    public void StatusView()
    {
    }

    [Token(Token = "0x600D59D")]
    [Address(RVA = "0x1D16060", Offset = "0x1D16060", VA = "0x1D16060")]
    public void StatusHide()
    {
    }

    [Token(Token = "0x600D59E")]
    [Address(RVA = "0x1D16090", Offset = "0x1D16090", VA = "0x1D16090")]
    public void SetAutoTurretLocator()
    {
    }

    [Token(Token = "0x600D59F")]
    [Address(RVA = "0x1D160F8", Offset = "0x1D160F8", VA = "0x1D160F8")]
    public void UpdateSubPartsPositions(Vector3 position)
    {
    }

    [Token(Token = "0x600D5A0")]
    [Address(RVA = "0x1D16150", Offset = "0x1D16150", VA = "0x1D16150")]
    public void Show(bool switchState)
    {
    }

    [Token(Token = "0x600D5A1")]
    [Address(RVA = "0x1D15E5C", Offset = "0x1D15E5C", VA = "0x1D15E5C")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D5A2")]
    [Address(RVA = "0x1D16390", Offset = "0x1D16390", VA = "0x1D16390")]
    public void Place(
      GridObject grid,
      Actor.Direction direction,
      bool switchState,
      WorldSpaceCanvasManager worldSpaceCanvasManager)
    {
    }

    [Token(Token = "0x600D5A3")]
    [Address(RVA = "0x1D161A0", Offset = "0x1D161A0", VA = "0x1D161A0")]
    public void PlayActivateAnime(bool immediate = false)
    {
    }

    [Token(Token = "0x600D5A4")]
    [Address(RVA = "0x1D16298", Offset = "0x1D16298", VA = "0x1D16298")]
    public void PlayDeactivateAnime(bool immediate = false)
    {
    }

    [Token(Token = "0x600D5A5")]
    [Address(RVA = "0x1D165D4", Offset = "0x1D165D4", VA = "0x1D165D4")]
    public FacilityView()
    {
    }
  }
}

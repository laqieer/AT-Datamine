// Decompiled with JetBrains decompiler
// Type: Battle.Grid.GridParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x2002535")]
  public sealed class GridParameter : IGridView, IGridData
  {
    [Token(Token = "0x1700315C")]
    public BattleLandCorrectData LandCorrect
    {
      [Token(Token = "0x600E5DD"), Address(RVA = "0x486B1FC", Offset = "0x486B1FC", VA = "0x486B1FC", Slot = "14")] get
      {
        return (BattleLandCorrectData) null;
      }
    }

    [Token(Token = "0x1700315D")]
    public string PrimaryDuelSceneName
    {
      [Token(Token = "0x600E5DE"), Address(RVA = "0x486B204", Offset = "0x486B204", VA = "0x486B204", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700315E")]
    public GridViewType ViewType
    {
      [Token(Token = "0x600E5DF"), Address(RVA = "0x486B20C", Offset = "0x486B20C", VA = "0x486B20C", Slot = "4")] get
      {
        return new GridViewType();
      }
      [Token(Token = "0x600E5E0"), Address(RVA = "0x486B214", Offset = "0x486B214", VA = "0x486B214")] set
      {
      }
    }

    [Token(Token = "0x1700315F")]
    public Vector2Int Coordinate
    {
      [Token(Token = "0x600E5E1"), Address(RVA = "0x486B21C", Offset = "0x486B21C", VA = "0x486B21C", Slot = "11")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600E5E2"), Address(RVA = "0x486B224", Offset = "0x486B224", VA = "0x486B224")] private set
      {
      }
    }

    [Token(Token = "0x17003160")]
    public float[] Heights
    {
      [Token(Token = "0x600E5E3"), Address(RVA = "0x486B22C", Offset = "0x486B22C", VA = "0x486B22C", Slot = "12")] get
      {
        return (float[]) null;
      }
    }

    [Token(Token = "0x17003161")]
    public float MaxGridHeight
    {
      [Token(Token = "0x600E5E4"), Address(RVA = "0x486B234", Offset = "0x486B234", VA = "0x486B234", Slot = "13")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17003162")]
    public bool IsDanger
    {
      [Token(Token = "0x600E5E5"), Address(RVA = "0x486B23C", Offset = "0x486B23C", VA = "0x486B23C", Slot = "6")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E5E6"), Address(RVA = "0x486B244", Offset = "0x486B244", VA = "0x486B244")] set
      {
      }
    }

    [Token(Token = "0x17003163")]
    public bool IsFierce
    {
      [Token(Token = "0x600E5E7"), Address(RVA = "0x486B250", Offset = "0x486B250", VA = "0x486B250", Slot = "7")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E5E8"), Address(RVA = "0x486B258", Offset = "0x486B258", VA = "0x486B258")] set
      {
      }
    }

    [Token(Token = "0x17003164")]
    public GridFierceType FierceType
    {
      [Token(Token = "0x600E5E9"), Address(RVA = "0x486B264", Offset = "0x486B264", VA = "0x486B264", Slot = "8")] get
      {
        return new GridFierceType();
      }
      [Token(Token = "0x600E5EA"), Address(RVA = "0x486B26C", Offset = "0x486B26C", VA = "0x486B26C")] set
      {
      }
    }

    [Token(Token = "0x17003165")]
    public bool IsSlope
    {
      [Token(Token = "0x600E5EB"), Address(RVA = "0x486B274", Offset = "0x486B274", VA = "0x486B274", Slot = "15")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E5EC"), Address(RVA = "0x486B27C", Offset = "0x486B27C", VA = "0x486B27C")] private set
      {
      }
    }

    [Token(Token = "0x17003166")]
    public AdjoiningDirection DangerAreaAdjoining
    {
      [Token(Token = "0x600E5ED"), Address(RVA = "0x486B288", Offset = "0x486B288", VA = "0x486B288", Slot = "9")] get
      {
        return new AdjoiningDirection();
      }
      [Token(Token = "0x600E5EE"), Address(RVA = "0x486B290", Offset = "0x486B290", VA = "0x486B290")] set
      {
      }
    }

    [Token(Token = "0x17003167")]
    public PredictionMoveParameter PredictionMoveParameter
    {
      [Token(Token = "0x600E5EF"), Address(RVA = "0x486B298", Offset = "0x486B298", VA = "0x486B298", Slot = "10")] get
      {
        return (PredictionMoveParameter) null;
      }
      [Token(Token = "0x600E5F0"), Address(RVA = "0x486B2A0", Offset = "0x486B2A0", VA = "0x486B2A0")] private set
      {
      }
    }

    [Token(Token = "0x600E5F1")]
    [Address(RVA = "0x486B2A8", Offset = "0x486B2A8", VA = "0x486B2A8")]
    public GridParameter(
      int x,
      int y,
      float[] heights,
      BattleLandCorrectData landCorrect,
      string primaryDuelSceneName)
    {
    }
  }
}

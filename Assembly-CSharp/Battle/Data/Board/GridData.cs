// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.GridData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027E8")]
  public class GridData : IGridData
  {
    [Token(Token = "0x400A9D7")]
    [FieldOffset(Offset = "0x38")]
    private BattleLandCorrectData landCorrect;
    [Token(Token = "0x400A9D8")]
    [FieldOffset(Offset = "0x40")]
    private LandTagEnum[] tags;
    [Token(Token = "0x400A9D9")]
    [FieldOffset(Offset = "0x48")]
    private EffectData landEffect;
    [Token(Token = "0x400A9DA")]
    [FieldOffset(Offset = "0x50")]
    private EffectData statusCorrect;
    [Token(Token = "0x400A9DB")]
    [FieldOffset(Offset = "0x58")]
    private EffectData elementCorrect;

    [Token(Token = "0x170035DD")]
    public Vector2Int Coordinate
    {
      [Token(Token = "0x600F923"), Address(RVA = "0x44BFAF0", Offset = "0x44BFAF0", VA = "0x44BFAF0", Slot = "4")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600F924"), Address(RVA = "0x44BFAF8", Offset = "0x44BFAF8", VA = "0x44BFAF8")] private set
      {
      }
    }

    [Token(Token = "0x170035DE")]
    public float[] Heights
    {
      [Token(Token = "0x600F925"), Address(RVA = "0x44BFB00", Offset = "0x44BFB00", VA = "0x44BFB00", Slot = "5")] get
      {
        return (float[]) null;
      }
      [Token(Token = "0x600F926"), Address(RVA = "0x44BFB08", Offset = "0x44BFB08", VA = "0x44BFB08")] private set
      {
      }
    }

    [Token(Token = "0x170035DF")]
    public FacilityData Facility
    {
      [Token(Token = "0x600F927"), Address(RVA = "0x44BFB10", Offset = "0x44BFB10", VA = "0x44BFB10")] get
      {
        return (FacilityData) null;
      }
      [Token(Token = "0x600F928"), Address(RVA = "0x44BFB18", Offset = "0x44BFB18", VA = "0x44BFB18")] private set
      {
      }
    }

    [Token(Token = "0x170035E0")]
    public UnitParameterData MainUnit
    {
      [Token(Token = "0x600F929"), Address(RVA = "0x44BFB20", Offset = "0x44BFB20", VA = "0x44BFB20")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600F92A"), Address(RVA = "0x44BFB28", Offset = "0x44BFB28", VA = "0x44BFB28")] private set
      {
      }
    }

    [Token(Token = "0x170035E1")]
    public UnitParameterData SubUnit
    {
      [Token(Token = "0x600F92B"), Address(RVA = "0x44BFB30", Offset = "0x44BFB30", VA = "0x44BFB30")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600F92C"), Address(RVA = "0x44BFB38", Offset = "0x44BFB38", VA = "0x44BFB38")] private set
      {
      }
    }

    [Token(Token = "0x170035E2")]
    public UnitParameterData Unit
    {
      [Token(Token = "0x600F92D"), Address(RVA = "0x44BFB40", Offset = "0x44BFB40", VA = "0x44BFB40")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x170035E3")]
    public int X
    {
      [Token(Token = "0x600F92E"), Address(RVA = "0x44BFB58", Offset = "0x44BFB58", VA = "0x44BFB58")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170035E4")]
    public int Y
    {
      [Token(Token = "0x600F92F"), Address(RVA = "0x44BFB60", Offset = "0x44BFB60", VA = "0x44BFB60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170035E5")]
    public BattleLandCorrectData LandCorrect
    {
      [Token(Token = "0x600F930"), Address(RVA = "0x44BFB68", Offset = "0x44BFB68", VA = "0x44BFB68", Slot = "7")] get
      {
        return (BattleLandCorrectData) null;
      }
    }

    [Token(Token = "0x170035E6")]
    public LandTagEnum[] Tags
    {
      [Token(Token = "0x600F931"), Address(RVA = "0x44BFB98", Offset = "0x44BFB98", VA = "0x44BFB98")] get
      {
        return (LandTagEnum[]) null;
      }
    }

    [Token(Token = "0x170035E7")]
    public EffectData LandEffect
    {
      [Token(Token = "0x600F932"), Address(RVA = "0x44BFBC8", Offset = "0x44BFBC8", VA = "0x44BFBC8")] get
      {
        return (EffectData) null;
      }
    }

    [Token(Token = "0x170035E8")]
    public EffectData StatusCorrect
    {
      [Token(Token = "0x600F933"), Address(RVA = "0x44BFBF8", Offset = "0x44BFBF8", VA = "0x44BFBF8")] get
      {
        return (EffectData) null;
      }
    }

    [Token(Token = "0x170035E9")]
    public EffectData ElementCorrect
    {
      [Token(Token = "0x600F934"), Address(RVA = "0x44BFC3C", Offset = "0x44BFC3C", VA = "0x44BFC3C")] get
      {
        return (EffectData) null;
      }
    }

    [Token(Token = "0x170035EA")]
    public float MaxGridHeight
    {
      [Token(Token = "0x600F935"), Address(RVA = "0x44BFC80", Offset = "0x44BFC80", VA = "0x44BFC80", Slot = "6")] get
      {
        return new float();
      }
      [Token(Token = "0x600F936"), Address(RVA = "0x44BFC88", Offset = "0x44BFC88", VA = "0x44BFC88")] private set
      {
      }
    }

    [Token(Token = "0x170035EB")]
    public bool IsSlope
    {
      [Token(Token = "0x600F937"), Address(RVA = "0x44BFC90", Offset = "0x44BFC90", VA = "0x44BFC90", Slot = "8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F938"), Address(RVA = "0x44BFC98", Offset = "0x44BFC98", VA = "0x44BFC98")] private set
      {
      }
    }

    [Token(Token = "0x600F939")]
    public static GridData Create<THandler>(GridSource source, THandler handler) where THandler : IEffectHandler
    {
      return (GridData) null;
    }

    [Token(Token = "0x600F93A")]
    [Address(RVA = "0x44BFCA4", Offset = "0x44BFCA4", VA = "0x44BFCA4")]
    public void CleanAllPlaces()
    {
    }

    [Token(Token = "0x600F93B")]
    [Address(RVA = "0x44BFCB0", Offset = "0x44BFCB0", VA = "0x44BFCB0")]
    public void SetFacility(FacilityData facility)
    {
    }

    [Token(Token = "0x600F93C")]
    [Address(RVA = "0x44BFCB8", Offset = "0x44BFCB8", VA = "0x44BFCB8")]
    public void AddMainUnit(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600F93D")]
    [Address(RVA = "0x44BFCE8", Offset = "0x44BFCE8", VA = "0x44BFCE8")]
    public void AddSubUnit(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600F93E")]
    [Address(RVA = "0x44BFD18", Offset = "0x44BFD18", VA = "0x44BFD18")]
    public void RemoveUnit(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600F93F")]
    [Address(RVA = "0x44BDE38", Offset = "0x44BDE38", VA = "0x44BDE38")]
    public bool IsPlacedAny() => new bool();

    [Token(Token = "0x600F940")]
    [Address(RVA = "0x44BFD40", Offset = "0x44BFD40", VA = "0x44BFD40", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F941")]
    [Address(RVA = "0x44BFE10", Offset = "0x44BFE10", VA = "0x44BFE10")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600F942")]
    [Address(RVA = "0x44BFEB0", Offset = "0x44BFEB0", VA = "0x44BFEB0")]
    public GridData()
    {
    }
  }
}

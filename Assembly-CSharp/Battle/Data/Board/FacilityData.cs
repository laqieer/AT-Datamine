// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.FacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.RouteSearch;
using Battle.Unit;
using FlatBuffers;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027E0")]
  public class FacilityData
  {
    [Token(Token = "0x400A9B3")]
    [FieldOffset(Offset = "0x28")]
    private FacilityData.SwitchTypeEnum switchType;
    [Token(Token = "0x400A9B4")]
    [FieldOffset(Offset = "0x2C")]
    private bool defaultSwitch;
    [Token(Token = "0x400A9B6")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, bool> controlableForce;
    [Token(Token = "0x400A9B7")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<MoveTypeEnum, bool> controlableMoveType;
    [Token(Token = "0x400A9B8")]
    [FieldOffset(Offset = "0x48")]
    private BattleLandCorrectData landCorrectOff;
    [Token(Token = "0x400A9B9")]
    [FieldOffset(Offset = "0x50")]
    private BattleLandCorrectData landCorrectOn;
    [Token(Token = "0x400A9BA")]
    [FieldOffset(Offset = "0x58")]
    private EffectData landEffectOff;
    [Token(Token = "0x400A9BB")]
    [FieldOffset(Offset = "0x60")]
    private EffectData landEffectOn;
    [Token(Token = "0x400A9BC")]
    [FieldOffset(Offset = "0x68")]
    private EffectData statusCorrectOff;
    [Token(Token = "0x400A9BD")]
    [FieldOffset(Offset = "0x70")]
    private EffectData statusCorrectOn;
    [Token(Token = "0x400A9BE")]
    [FieldOffset(Offset = "0x78")]
    private EffectData elementCorrectOff;
    [Token(Token = "0x400A9BF")]
    [FieldOffset(Offset = "0x80")]
    private EffectData elementCorrectOn;
    [Token(Token = "0x400A9C0")]
    [FieldOffset(Offset = "0x88")]
    private LandTagEnum[] landTagsOff;
    [Token(Token = "0x400A9C1")]
    [FieldOffset(Offset = "0x90")]
    private LandTagEnum[] landTagsOn;
    [Token(Token = "0x400A9C7")]
    [FieldOffset(Offset = "0xB8")]
    private SkillDetailData skillDetail;
    [Token(Token = "0x400A9C9")]
    [FieldOffset(Offset = "0xC8")]
    private IFacilityPlacementData placementMaster;

    [Token(Token = "0x170035C4")]
    public int PlacementId
    {
      [Token(Token = "0x600F8E7"), Address(RVA = "0x44BE23C", Offset = "0x44BE23C", VA = "0x44BE23C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F8E8"), Address(RVA = "0x44BE244", Offset = "0x44BE244", VA = "0x44BE244")] private set
      {
      }
    }

    [Token(Token = "0x170035C5")]
    public bool SwitchState
    {
      [Token(Token = "0x600F8E9"), Address(RVA = "0x44BE24C", Offset = "0x44BE24C", VA = "0x44BE24C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F8EA"), Address(RVA = "0x44BE254", Offset = "0x44BE254", VA = "0x44BE254")] private set
      {
      }
    }

    [Token(Token = "0x170035C6")]
    public int FacilityId
    {
      [Token(Token = "0x600F8EB"), Address(RVA = "0x44BE260", Offset = "0x44BE260", VA = "0x44BE260")] get
      {
        return new int();
      }
      [Token(Token = "0x600F8EC"), Address(RVA = "0x44BE268", Offset = "0x44BE268", VA = "0x44BE268")] private set
      {
      }
    }

    [Token(Token = "0x170035C7")]
    public int Id
    {
      [Token(Token = "0x600F8ED"), Address(RVA = "0x44BE270", Offset = "0x44BE270", VA = "0x44BE270")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170035C8")]
    public int GroupId
    {
      [Token(Token = "0x600F8EE"), Address(RVA = "0x44BE278", Offset = "0x44BE278", VA = "0x44BE278")] get
      {
        return new int();
      }
      [Token(Token = "0x600F8EF"), Address(RVA = "0x44BE280", Offset = "0x44BE280", VA = "0x44BE280")] private set
      {
      }
    }

    [Token(Token = "0x170035C9")]
    public BattleFacilityTypeEnum Type
    {
      [Token(Token = "0x600F8F0"), Address(RVA = "0x44BE288", Offset = "0x44BE288", VA = "0x44BE288")] get
      {
        return new BattleFacilityTypeEnum();
      }
      [Token(Token = "0x600F8F1"), Address(RVA = "0x44BE290", Offset = "0x44BE290", VA = "0x44BE290")] private set
      {
      }
    }

    [Token(Token = "0x170035CA")]
    public FacilityData.ControlTypeEnum ControlType
    {
      [Token(Token = "0x600F8F2"), Address(RVA = "0x44BE298", Offset = "0x44BE298", VA = "0x44BE298")] get
      {
        return new FacilityData.ControlTypeEnum();
      }
      [Token(Token = "0x600F8F3"), Address(RVA = "0x44BE2A0", Offset = "0x44BE2A0", VA = "0x44BE2A0")] private set
      {
      }
    }

    [Token(Token = "0x170035CB")]
    public int ForceID
    {
      [Token(Token = "0x600F8F4"), Address(RVA = "0x44BE2A8", Offset = "0x44BE2A8", VA = "0x44BE2A8")] get
      {
        return new int();
      }
      [Token(Token = "0x600F8F5"), Address(RVA = "0x44BE2B0", Offset = "0x44BE2B0", VA = "0x44BE2B0")] private set
      {
      }
    }

    [Token(Token = "0x170035CC")]
    public BattleLandCorrectData LandCorrect
    {
      [Token(Token = "0x600F8F6"), Address(RVA = "0x44BE2B8", Offset = "0x44BE2B8", VA = "0x44BE2B8")] get
      {
        return (BattleLandCorrectData) null;
      }
    }

    [Token(Token = "0x170035CD")]
    public EffectData LandEffect
    {
      [Token(Token = "0x600F8F7"), Address(RVA = "0x44BE2D4", Offset = "0x44BE2D4", VA = "0x44BE2D4")] get
      {
        return (EffectData) null;
      }
    }

    [Token(Token = "0x170035CE")]
    public EffectData StatusCorrect
    {
      [Token(Token = "0x600F8F8"), Address(RVA = "0x44BE2F0", Offset = "0x44BE2F0", VA = "0x44BE2F0")] get
      {
        return (EffectData) null;
      }
    }

    [Token(Token = "0x170035CF")]
    public EffectData ElementCorrect
    {
      [Token(Token = "0x600F8F9"), Address(RVA = "0x44BE30C", Offset = "0x44BE30C", VA = "0x44BE30C")] get
      {
        return (EffectData) null;
      }
    }

    [Token(Token = "0x170035D0")]
    public LandTagEnum[] LandTags
    {
      [Token(Token = "0x600F8FA"), Address(RVA = "0x44BE328", Offset = "0x44BE328", VA = "0x44BE328")] get
      {
        return (LandTagEnum[]) null;
      }
    }

    [Token(Token = "0x170035D1")]
    public Vector2Int Coordinate
    {
      [Token(Token = "0x600F8FB"), Address(RVA = "0x44BE344", Offset = "0x44BE344", VA = "0x44BE344")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600F8FC"), Address(RVA = "0x44BE34C", Offset = "0x44BE34C", VA = "0x44BE34C")] private set
      {
      }
    }

    [Token(Token = "0x170035D2")]
    public Actor.Direction Direct
    {
      [Token(Token = "0x600F8FD"), Address(RVA = "0x44BE354", Offset = "0x44BE354", VA = "0x44BE354")] get
      {
        return new Actor.Direction();
      }
      [Token(Token = "0x600F8FE"), Address(RVA = "0x44BE35C", Offset = "0x44BE35C", VA = "0x44BE35C")] private set
      {
      }
    }

    [Token(Token = "0x170035D3")]
    public int RequiredExpedablesId
    {
      [Token(Token = "0x600F8FF"), Address(RVA = "0x44BE364", Offset = "0x44BE364", VA = "0x44BE364")] get
      {
        return new int();
      }
      [Token(Token = "0x600F900"), Address(RVA = "0x44BE36C", Offset = "0x44BE36C", VA = "0x44BE36C")] private set
      {
      }
    }

    [Token(Token = "0x170035D4")]
    public int RequiredAmount
    {
      [Token(Token = "0x600F901"), Address(RVA = "0x44BE374", Offset = "0x44BE374", VA = "0x44BE374")] get
      {
        return new int();
      }
      [Token(Token = "0x600F902"), Address(RVA = "0x44BE37C", Offset = "0x44BE37C", VA = "0x44BE37C")] private set
      {
      }
    }

    [Token(Token = "0x170035D5")]
    public string OverrideDescription
    {
      [Token(Token = "0x600F903"), Address(RVA = "0x44BE384", Offset = "0x44BE384", VA = "0x44BE384")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F904"), Address(RVA = "0x44BE38C", Offset = "0x44BE38C", VA = "0x44BE38C")] private set
      {
      }
    }

    [Token(Token = "0x170035D6")]
    public bool IsOverrideDescription
    {
      [Token(Token = "0x600F905"), Address(RVA = "0x44BE394", Offset = "0x44BE394", VA = "0x44BE394")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170035D7")]
    public SkillParameterData Skill
    {
      [Token(Token = "0x600F906"), Address(RVA = "0x44BE3C8", Offset = "0x44BE3C8", VA = "0x44BE3C8")] get
      {
        return (SkillParameterData) null;
      }
      [Token(Token = "0x600F907"), Address(RVA = "0x44BE3D0", Offset = "0x44BE3D0", VA = "0x44BE3D0")] private set
      {
      }
    }

    [Token(Token = "0x600F908")]
    [Address(RVA = "0x44BE3D8", Offset = "0x44BE3D8", VA = "0x44BE3D8")]
    private static FacilityData Create(
      BattleFacilityData facility,
      IFacilityPlacementData placement,
      IBattleDataHandler dataHandler)
    {
      return (FacilityData) null;
    }

    [Token(Token = "0x600F909")]
    [Address(RVA = "0x44BE864", Offset = "0x44BE864", VA = "0x44BE864")]
    public static FacilityData Create(
      BattleFacilityData facility,
      IFacilityPlacementData placement,
      IBattleDataHandler dataHandler,
      IBoardDataHandler paramHandler)
    {
      return (FacilityData) null;
    }

    [Token(Token = "0x600F90A")]
    [Address(RVA = "0x44BEB10", Offset = "0x44BEB10", VA = "0x44BEB10")]
    public static FacilityData CreateFromSchema(
      staq.SaveSchema.FacilityData schema,
      IBattleDataHandler dataHandler,
      IBoardDataHandler paramHandler)
    {
      return (FacilityData) null;
    }

    [Token(Token = "0x600F90B")]
    [Address(RVA = "0x44BED20", Offset = "0x44BED20", VA = "0x44BED20")]
    public static FacilityData Clone(
      FacilityData src,
      IBattleDataHandler dataHandler,
      IBoardDataHandler paramHandler)
    {
      return (FacilityData) null;
    }

    [Token(Token = "0x600F90C")]
    [Address(RVA = "0x44BD2E4", Offset = "0x44BD2E4", VA = "0x44BD2E4")]
    public FacilityData(BattleFacilityData facilityMaster, IFacilityPlacementData placementMaster)
    {
    }

    [Token(Token = "0x600F90D")]
    [Address(RVA = "0x44BEF84", Offset = "0x44BEF84", VA = "0x44BEF84")]
    public Offset<staq.SaveSchema.FacilityData> Serialize(FlatBufferBuilder fbb)
    {
      return new Offset<staq.SaveSchema.FacilityData>();
    }

    [Token(Token = "0x600F90E")]
    [Address(RVA = "0x44BEFC8", Offset = "0x44BEFC8", VA = "0x44BEFC8", Slot = "4")]
    public virtual bool IsEffectable(BoardData board, bool isLink, bool isMovable = false)
    {
      return new bool();
    }

    [Token(Token = "0x600F90F")]
    [Address(RVA = "0x44BDB64", Offset = "0x44BDB64", VA = "0x44BDB64", Slot = "5")]
    public virtual void ExecEffect(
      BoardData board,
      UnitParameterData unit,
      bool isLink,
      ref List<FacilityData> activates)
    {
    }

    [Token(Token = "0x600F910")]
    [Address(RVA = "0x44BEFFC", Offset = "0x44BEFFC", VA = "0x44BEFFC", Slot = "6")]
    public virtual bool IsControllable(
      BoardData board,
      UnitParameterData unit,
      MovableAreaSearcher movableAreaSearcher = null)
    {
      return new bool();
    }

    [Token(Token = "0x600F911")]
    [Address(RVA = "0x44BF3D8", Offset = "0x44BF3D8", VA = "0x44BF3D8", Slot = "7")]
    public virtual bool IsPermitted(UnitParameterData unit) => new bool();

    [Token(Token = "0x600F912")]
    [Address(RVA = "0x44BEFD0", Offset = "0x44BEFD0", VA = "0x44BEFD0")]
    public void SwitchNextState()
    {
    }

    [Token(Token = "0x20027E1")]
    public enum ControlTypeEnum
    {
      [Token(Token = "0x400A9CB")] NONE,
      [Token(Token = "0x400A9CC")] BOARDING,
      [Token(Token = "0x400A9CD")] ADJACENT,
    }

    [Token(Token = "0x20027E2")]
    private enum SwitchTypeEnum
    {
      [Token(Token = "0x400A9CF")] NONE,
      [Token(Token = "0x400A9D0")] ONECE,
      [Token(Token = "0x400A9D1")] LOOP,
    }
  }
}

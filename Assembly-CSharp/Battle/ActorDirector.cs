// Decompiled with JetBrains decompiler
// Type: Battle.ActorDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Unit;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002264")]
  public class ActorDirector : MonoBehaviour, ISubDirector<IDirector>
  {
    [Token(Token = "0x40090AF")]
    [FieldOffset(Offset = "0x20")]
    private IDirector mainDirector;
    [Token(Token = "0x40090B0")]
    [FieldOffset(Offset = "0x28")]
    private List<CharacterActor> actors;
    [Token(Token = "0x40090B1")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<int, CharacterActor> actorDic;
    [Token(Token = "0x40090B2")]
    [FieldOffset(Offset = "0x38")]
    private List<FacilityView> facilitys;
    [Token(Token = "0x40090B3")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<int, FacilityView> facilityDic;
    [Token(Token = "0x40090B4")]
    [FieldOffset(Offset = "0x48")]
    private IActorViewData _characterActorViewData;

    [Token(Token = "0x17002D5E")]
    public bool Initialized
    {
      [Token(Token = "0x600D0F6"), Address(RVA = "0x1950AE4", Offset = "0x1950AE4", VA = "0x1950AE4", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D0F7"), Address(RVA = "0x1950AEC", Offset = "0x1950AEC", VA = "0x1950AEC")] protected set
      {
      }
    }

    [Token(Token = "0x17002D5F")]
    public IReadOnlyList<CharacterActor> Actors
    {
      [Token(Token = "0x600D0F8"), Address(RVA = "0x1950AF8", Offset = "0x1950AF8", VA = "0x1950AF8")] get
      {
        return (IReadOnlyList<CharacterActor>) null;
      }
    }

    [Token(Token = "0x17002D60")]
    public List<FacilityView> Facilitys
    {
      [Token(Token = "0x600D0F9"), Address(RVA = "0x1950B00", Offset = "0x1950B00", VA = "0x1950B00")] get
      {
        return (List<FacilityView>) null;
      }
    }

    [Token(Token = "0x17002D61")]
    public IActorViewData characterActorViewData
    {
      [Token(Token = "0x600D0FA"), Address(RVA = "0x1950B08", Offset = "0x1950B08", VA = "0x1950B08")] get
      {
        return (IActorViewData) null;
      }
    }

    [Token(Token = "0x600D0FB")]
    [Address(RVA = "0x1950B10", Offset = "0x1950B10", VA = "0x1950B10", Slot = "5")]
    public void Initialize(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600D0FC")]
    [Address(RVA = "0x1950CAC", Offset = "0x1950CAC", VA = "0x1950CAC", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600D0FD")]
    [Address(RVA = "0x1950CB0", Offset = "0x1950CB0", VA = "0x1950CB0", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600D0FE")]
    [Address(RVA = "0x1950ECC", Offset = "0x1950ECC", VA = "0x1950ECC")]
    public void AddActor(int unitId, CharacterActor actor)
    {
    }

    [Token(Token = "0x600D0FF")]
    [Address(RVA = "0x1951070", Offset = "0x1951070", VA = "0x1951070")]
    public void RemoveActor(int unitId)
    {
    }

    [Token(Token = "0x600D100")]
    [Address(RVA = "0x1951000", Offset = "0x1951000", VA = "0x1951000")]
    private CharacterActor GetActor(int unitId) => (CharacterActor) null;

    [Token(Token = "0x600D101")]
    [Address(RVA = "0x1951154", Offset = "0x1951154", VA = "0x1951154")]
    public CharacterActor GetActor(UnitParameterData unit) => (CharacterActor) null;

    [Token(Token = "0x600D102")]
    [Address(RVA = "0x1951180", Offset = "0x1951180", VA = "0x1951180")]
    public bool TryGetControllActor(
      UnitParameterData unitParam,
      out CharacterActor leader,
      out CharacterActor doubled)
    {
      return new bool();
    }

    [Token(Token = "0x600D103")]
    [Address(RVA = "0x1951314", Offset = "0x1951314", VA = "0x1951314")]
    public void ResetUnitPrediction(IReadOnlyList<UnitParameterData> unitParams)
    {
    }

    [Token(Token = "0x600D104")]
    [Address(RVA = "0x19516D0", Offset = "0x19516D0", VA = "0x19516D0")]
    public void UpdateUnitSkillEffectVfx(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D105")]
    [Address(RVA = "0x1952030", Offset = "0x1952030", VA = "0x1952030")]
    public void UpdateUnitSkillChargingVfx(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D106")]
    [Address(RVA = "0x1952300", Offset = "0x1952300", VA = "0x1952300")]
    public void AddFacility(int dataId, FacilityView view)
    {
    }

    [Token(Token = "0x600D107")]
    [Address(RVA = "0x1952410", Offset = "0x1952410", VA = "0x1952410")]
    public FacilityView GetFacility(int id) => (FacilityView) null;

    [Token(Token = "0x600D108")]
    [Address(RVA = "0x1952480", Offset = "0x1952480", VA = "0x1952480")]
    public FacilityView GetFacility(Vector2Int coordinate) => (FacilityView) null;

    [Token(Token = "0x600D109")]
    [Address(RVA = "0x19525F4", Offset = "0x19525F4", VA = "0x19525F4")]
    public ActorDirector()
    {
    }
  }
}

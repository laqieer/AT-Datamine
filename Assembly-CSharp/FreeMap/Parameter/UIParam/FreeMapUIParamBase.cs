// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapUIParamBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001878")]
  public abstract class FreeMapUIParamBase
  {
    [Token(Token = "0x17001619")]
    public virtual string SpriteName
    {
      [Token(Token = "0x6008AB8"), Address(RVA = "0x4523218", Offset = "0x4523218", VA = "0x4523218", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700161A")]
    public virtual string SpriteAssetName
    {
      [Token(Token = "0x6008AB9"), Address(RVA = "0x4523234", Offset = "0x4523234", VA = "0x4523234", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700161B")]
    public abstract ActionIconTypeEnum ActionIconType { [Token(Token = "0x6008ABA")] get; }

    [Token(Token = "0x1700161C")]
    public InstanceID InstanceID
    {
      [Token(Token = "0x6008ABB"), Address(RVA = "0x4523294", Offset = "0x4523294", VA = "0x4523294")] get
      {
        return new InstanceID();
      }
      [Token(Token = "0x6008ABC"), Address(RVA = "0x452329C", Offset = "0x452329C", VA = "0x452329C")] private set
      {
      }
    }

    [Token(Token = "0x1700161D")]
    public Vector3 IconOffset
    {
      [Token(Token = "0x6008ABD"), Address(RVA = "0x45232A4", Offset = "0x45232A4", VA = "0x45232A4")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6008ABE"), Address(RVA = "0x45232B0", Offset = "0x45232B0", VA = "0x45232B0")] private set
      {
      }
    }

    [Token(Token = "0x1700161E")]
    public int PlayerMovePositionID
    {
      [Token(Token = "0x6008ABF"), Address(RVA = "0x45232BC", Offset = "0x45232BC", VA = "0x45232BC")] get
      {
        return new int();
      }
      [Token(Token = "0x6008AC0"), Address(RVA = "0x45232C4", Offset = "0x45232C4", VA = "0x45232C4")] private set
      {
      }
    }

    [Token(Token = "0x1700161F")]
    public int CameraMovePositionID
    {
      [Token(Token = "0x6008AC1"), Address(RVA = "0x45232CC", Offset = "0x45232CC", VA = "0x45232CC")] get
      {
        return new int();
      }
      [Token(Token = "0x6008AC2"), Address(RVA = "0x45232D4", Offset = "0x45232D4", VA = "0x45232D4")] private set
      {
      }
    }

    [Token(Token = "0x17001620")]
    public EventNpcActEnum EventNpcAct
    {
      [Token(Token = "0x6008AC3"), Address(RVA = "0x45232DC", Offset = "0x45232DC", VA = "0x45232DC")] get
      {
        return new EventNpcActEnum();
      }
      [Token(Token = "0x6008AC4"), Address(RVA = "0x45232E4", Offset = "0x45232E4", VA = "0x45232E4")] private set
      {
      }
    }

    [Token(Token = "0x17001621")]
    public int AreaID
    {
      [Token(Token = "0x6008AC5"), Address(RVA = "0x45232EC", Offset = "0x45232EC", VA = "0x45232EC")] get
      {
        return new int();
      }
      [Token(Token = "0x6008AC6"), Address(RVA = "0x45232F4", Offset = "0x45232F4", VA = "0x45232F4")] protected set
      {
      }
    }

    [Token(Token = "0x17001622")]
    public virtual bool IsActionIcon
    {
      [Token(Token = "0x6008AC7"), Address(RVA = "0x45232FC", Offset = "0x45232FC", VA = "0x45232FC", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001623")]
    public virtual bool IsShowMap
    {
      [Token(Token = "0x6008AC8"), Address(RVA = "0x4523304", Offset = "0x4523304", VA = "0x4523304", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001624")]
    protected IFreeMapBuildCondition BuildCondition
    {
      [Token(Token = "0x6008AC9"), Address(RVA = "0x452330C", Offset = "0x452330C", VA = "0x452330C")] get
      {
        return (IFreeMapBuildCondition) null;
      }
      [Token(Token = "0x6008ACA"), Address(RVA = "0x4523314", Offset = "0x4523314", VA = "0x4523314")] private set
      {
      }
    }

    [Token(Token = "0x17001625")]
    protected float IconClipDistance
    {
      [Token(Token = "0x6008ACB"), Address(RVA = "0x451F660", Offset = "0x451F660", VA = "0x451F660")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001626")]
    public FreeMapUICircleParam CircleParam
    {
      [Token(Token = "0x6008ACC"), Address(RVA = "0x452331C", Offset = "0x452331C", VA = "0x452331C")] get
      {
        return (FreeMapUICircleParam) null;
      }
      [Token(Token = "0x6008ACD"), Address(RVA = "0x4523324", Offset = "0x4523324", VA = "0x4523324")] private set
      {
      }
    }

    [Token(Token = "0x6008ACE")]
    [Address(RVA = "0x452332C", Offset = "0x452332C", VA = "0x452332C", Slot = "9")]
    public virtual bool AlwaysPurposeMark() => new bool();

    [Token(Token = "0x6008ACF")]
    [Address(RVA = "0x451F3B8", Offset = "0x451F3B8", VA = "0x451F3B8")]
    public FreeMapUIParamBase(
      InstanceID instanceID,
      Vector3 iconOffset,
      int cameraMoveID,
      int playerMoveID,
      EventNpcActEnum npcAct = EventNpcActEnum.None)
    {
    }

    [Token(Token = "0x6008AD0")]
    [Address(RVA = "0x4523334", Offset = "0x4523334", VA = "0x4523334")]
    public void SetInstanceID(InstanceID instanceID)
    {
    }

    [Token(Token = "0x6008AD1")]
    [Address(RVA = "0x451FC08", Offset = "0x451FC08", VA = "0x451FC08")]
    public void SetLocationID(int areaID)
    {
    }

    [Token(Token = "0x6008AD2")]
    [Address(RVA = "0x452333C", Offset = "0x452333C", VA = "0x452333C")]
    public void SetCircleParameter(FreeMapUICircleParam circleParameter)
    {
    }

    [Token(Token = "0x6008AD3")]
    [Address(RVA = "0x4523344", Offset = "0x4523344", VA = "0x4523344")]
    public bool CanCreate() => new bool();

    [Token(Token = "0x6008AD4")]
    [Address(RVA = "0x45233B4", Offset = "0x45233B4", VA = "0x45233B4")]
    public bool CanCreate(int sequenceID) => new bool();

    [Token(Token = "0x6008AD5")]
    [Address(RVA = "0x451FD18", Offset = "0x451FD18", VA = "0x451FD18")]
    public void SetBuildCondition(IFreeMapBuildCondition buildCondition)
    {
    }

    [Token(Token = "0x6008AD6")]
    [Address(RVA = "0x4523468", Offset = "0x4523468", VA = "0x4523468", Slot = "10")]
    public virtual string GetTitle() => (string) null;

    [Token(Token = "0x6008AD7")]
    public abstract UIParameterType GetParamType();

    [Token(Token = "0x6008AD8")]
    [Address(RVA = "0x451F4E8", Offset = "0x451F4E8", VA = "0x451F4E8", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008AD9")]
    [Address(RVA = "0x451F5B8", Offset = "0x451F5B8", VA = "0x451F5B8", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008ADA")]
    public abstract IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder);

    [Token(Token = "0x6008ADB")]
    public abstract IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement);

    [Token(Token = "0x6008ADC")]
    [Address(RVA = "0x45234B0", Offset = "0x45234B0", VA = "0x45234B0", Slot = "14")]
    public virtual void OnRefresh()
    {
    }
  }
}

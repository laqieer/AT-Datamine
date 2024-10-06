// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaFacilityPlacementData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DDB")]
  [Serializable]
  public sealed class ArenaFacilityPlacementData : IMasterDataEntity, IFacilityPlacementData
  {
    [Token(Token = "0x4004257")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004258")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placementGroup;
    [Token(Token = "0x4004259")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int battleFacility;
    [Token(Token = "0x400425A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x400425B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int x;
    [Token(Token = "0x400425C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int y;
    [Token(Token = "0x400425D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int direct;
    [Token(Token = "0x400425E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool defaultSwitch;
    [Token(Token = "0x400425F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int forceId;
    [Token(Token = "0x4004260")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public bool controllableAlly;
    [Token(Token = "0x4004261")]
    [FieldOffset(Offset = "0x35")]
    [SerializeField]
    public bool controllableEnemy;
    [Token(Token = "0x4004262")]
    [FieldOffset(Offset = "0x36")]
    [SerializeField]
    public bool controllableFriend;
    [Token(Token = "0x4004263")]
    [FieldOffset(Offset = "0x37")]
    [SerializeField]
    public bool controllableThird;

    [Token(Token = "0x17000C1F")]
    public int Key
    {
      [Token(Token = "0x600549E"), Address(RVA = "0x3AA6AF4", Offset = "0x3AA6AF4", VA = "0x3AA6AF4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600549F")]
    [Address(RVA = "0x3AA6AFC", Offset = "0x3AA6AFC", VA = "0x3AA6AFC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054A0")]
    [Address(RVA = "0x3AA703C", Offset = "0x3AA703C", VA = "0x3AA703C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C20")]
    public int Id
    {
      [Token(Token = "0x60054A1"), Address(RVA = "0x3AA7170", Offset = "0x3AA7170", VA = "0x3AA7170", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C21")]
    public int BattleFacility
    {
      [Token(Token = "0x60054A2"), Address(RVA = "0x3AA7178", Offset = "0x3AA7178", VA = "0x3AA7178", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C22")]
    public int GroupId
    {
      [Token(Token = "0x60054A3"), Address(RVA = "0x3AA7180", Offset = "0x3AA7180", VA = "0x3AA7180", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C23")]
    public Vector2Int Coordinate
    {
      [Token(Token = "0x60054A4"), Address(RVA = "0x3AA7188", Offset = "0x3AA7188", VA = "0x3AA7188", Slot = "10")] get
      {
        return new Vector2Int();
      }
    }

    [Token(Token = "0x17000C24")]
    public int Direct
    {
      [Token(Token = "0x60054A5"), Address(RVA = "0x3AA7190", Offset = "0x3AA7190", VA = "0x3AA7190", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C25")]
    public bool DefaultSwitch
    {
      [Token(Token = "0x60054A6"), Address(RVA = "0x3AA7198", Offset = "0x3AA7198", VA = "0x3AA7198", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000C26")]
    public int ForceId
    {
      [Token(Token = "0x60054A7"), Address(RVA = "0x3AA71A0", Offset = "0x3AA71A0", VA = "0x3AA71A0", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C27")]
    public bool ControllableAlly
    {
      [Token(Token = "0x60054A8"), Address(RVA = "0x3AA71A8", Offset = "0x3AA71A8", VA = "0x3AA71A8", Slot = "14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000C28")]
    public bool ControllableEnemy
    {
      [Token(Token = "0x60054A9"), Address(RVA = "0x3AA71B0", Offset = "0x3AA71B0", VA = "0x3AA71B0", Slot = "15")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000C29")]
    public bool ControllableFriend
    {
      [Token(Token = "0x60054AA"), Address(RVA = "0x3AA71B8", Offset = "0x3AA71B8", VA = "0x3AA71B8", Slot = "16")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000C2A")]
    public bool ControllableThird
    {
      [Token(Token = "0x60054AB"), Address(RVA = "0x3AA71C0", Offset = "0x3AA71C0", VA = "0x3AA71C0", Slot = "17")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000C2B")]
    public int RequiredExpendables
    {
      [Token(Token = "0x60054AC"), Address(RVA = "0x3AA71C8", Offset = "0x3AA71C8", VA = "0x3AA71C8", Slot = "18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C2C")]
    public int RequiredAmount
    {
      [Token(Token = "0x60054AD"), Address(RVA = "0x3AA71D0", Offset = "0x3AA71D0", VA = "0x3AA71D0", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C2D")]
    public string OverrideDescription
    {
      [Token(Token = "0x60054AE"), Address(RVA = "0x3AA71D8", Offset = "0x3AA71D8", VA = "0x3AA71D8", Slot = "20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60054AF")]
    [Address(RVA = "0x3AA7220", Offset = "0x3AA7220", VA = "0x3AA7220")]
    public ArenaFacilityPlacementData()
    {
    }
  }
}

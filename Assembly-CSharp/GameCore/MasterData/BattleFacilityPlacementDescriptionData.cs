// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFacilityPlacementDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E5D")]
  [Serializable]
  public sealed class BattleFacilityPlacementDescriptionData : 
    IMasterDataEntity,
    IFacilityPlacementData
  {
    [Token(Token = "0x400457D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400457E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x400457F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int battleFacility;
    [Token(Token = "0x4004580")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x4004581")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int x;
    [Token(Token = "0x4004582")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int y;
    [Token(Token = "0x4004583")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int direct;
    [Token(Token = "0x4004584")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool defaultSwitch;
    [Token(Token = "0x4004585")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int forceId;
    [Token(Token = "0x4004586")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public bool controllableAlly;
    [Token(Token = "0x4004587")]
    [FieldOffset(Offset = "0x35")]
    [SerializeField]
    public bool controllableEnemy;
    [Token(Token = "0x4004588")]
    [FieldOffset(Offset = "0x36")]
    [SerializeField]
    public bool controllableFriend;
    [Token(Token = "0x4004589")]
    [FieldOffset(Offset = "0x37")]
    [SerializeField]
    public bool controllableThird;
    [Token(Token = "0x400458A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int requiredExpendables;
    [Token(Token = "0x400458B")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int requiredAmount;

    [Token(Token = "0x17000CE1")]
    public int Key
    {
      [Token(Token = "0x600578C"), Address(RVA = "0x3E41658", Offset = "0x3E41658", VA = "0x3E41658", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600578D")]
    [Address(RVA = "0x3E41660", Offset = "0x3E41660", VA = "0x3E41660", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600578E")]
    [Address(RVA = "0x3E41C60", Offset = "0x3E41C60", VA = "0x3E41C60", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000CE2")]
    public int Id
    {
      [Token(Token = "0x600578F"), Address(RVA = "0x3E41DB4", Offset = "0x3E41DB4", VA = "0x3E41DB4", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CE3")]
    public int BattleFacility
    {
      [Token(Token = "0x6005790"), Address(RVA = "0x3E41DBC", Offset = "0x3E41DBC", VA = "0x3E41DBC", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CE4")]
    public int GroupId
    {
      [Token(Token = "0x6005791"), Address(RVA = "0x3E41DC4", Offset = "0x3E41DC4", VA = "0x3E41DC4", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CE5")]
    public Vector2Int Coordinate
    {
      [Token(Token = "0x6005792"), Address(RVA = "0x3E41DCC", Offset = "0x3E41DCC", VA = "0x3E41DCC", Slot = "10")] get
      {
        return new Vector2Int();
      }
    }

    [Token(Token = "0x17000CE6")]
    public int Direct
    {
      [Token(Token = "0x6005793"), Address(RVA = "0x3E41DD4", Offset = "0x3E41DD4", VA = "0x3E41DD4", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CE7")]
    public bool DefaultSwitch
    {
      [Token(Token = "0x6005794"), Address(RVA = "0x3E41DDC", Offset = "0x3E41DDC", VA = "0x3E41DDC", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CE8")]
    public int ForceId
    {
      [Token(Token = "0x6005795"), Address(RVA = "0x3E41DE4", Offset = "0x3E41DE4", VA = "0x3E41DE4", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CE9")]
    public bool ControllableAlly
    {
      [Token(Token = "0x6005796"), Address(RVA = "0x3E41DEC", Offset = "0x3E41DEC", VA = "0x3E41DEC", Slot = "14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CEA")]
    public bool ControllableEnemy
    {
      [Token(Token = "0x6005797"), Address(RVA = "0x3E41DF4", Offset = "0x3E41DF4", VA = "0x3E41DF4", Slot = "15")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CEB")]
    public bool ControllableFriend
    {
      [Token(Token = "0x6005798"), Address(RVA = "0x3E41DFC", Offset = "0x3E41DFC", VA = "0x3E41DFC", Slot = "16")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CEC")]
    public bool ControllableThird
    {
      [Token(Token = "0x6005799"), Address(RVA = "0x3E41E04", Offset = "0x3E41E04", VA = "0x3E41E04", Slot = "17")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CED")]
    public int RequiredExpendables
    {
      [Token(Token = "0x600579A"), Address(RVA = "0x3E41E0C", Offset = "0x3E41E0C", VA = "0x3E41E0C", Slot = "18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CEE")]
    public int RequiredAmount
    {
      [Token(Token = "0x600579B"), Address(RVA = "0x3E41E14", Offset = "0x3E41E14", VA = "0x3E41E14", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CEF")]
    public string OverrideDescription
    {
      [Token(Token = "0x600579C"), Address(RVA = "0x3E41E1C", Offset = "0x3E41E1C", VA = "0x3E41E1C", Slot = "20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600579D")]
    [Address(RVA = "0x3E41EF8", Offset = "0x3E41EF8", VA = "0x3E41EF8")]
    public BattleFacilityPlacementDescriptionData()
    {
    }
  }
}

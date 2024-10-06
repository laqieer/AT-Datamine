// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleMissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E58")]
  [Serializable]
  public sealed class BattleMissionData : IMasterDataEntity, IMissionData
  {
    [Token(Token = "0x400451D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400451E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int missionSet;
    [Token(Token = "0x400451F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardGroupId;
    [Token(Token = "0x4004520")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public BattleMissionTypeEnum missionType1;
    [Token(Token = "0x4004521")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int value1;
    [Token(Token = "0x4004522")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int value2;
    [Token(Token = "0x4004523")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public BattleMissionTypeEnum missionType2;
    [Token(Token = "0x4004524")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int value3;
    [Token(Token = "0x4004525")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int value4;
    [Token(Token = "0x4004526")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public BattleMissionTypeEnum missionType3;
    [Token(Token = "0x4004527")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int value5;
    [Token(Token = "0x4004528")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int value6;

    [Token(Token = "0x17000CCC")]
    public int Key
    {
      [Token(Token = "0x600575E"), Address(RVA = "0x3E3D874", Offset = "0x3E3D874", VA = "0x3E3D874", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600575F")]
    [Address(RVA = "0x3E3D87C", Offset = "0x3E3D87C", VA = "0x3E3D87C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005760")]
    [Address(RVA = "0x3E3DD48", Offset = "0x3E3DD48", VA = "0x3E3DD48", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000CCD")]
    private int Battle\u002EData\u002EIMissionData\u002EID
    {
      [Token(Token = "0x6005761"), Address(RVA = "0x3E3DE6C", Offset = "0x3E3DE6C", VA = "0x3E3DE6C", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CCE")]
    private int Battle\u002EData\u002EIMissionData\u002ErewardGroupId
    {
      [Token(Token = "0x6005762"), Address(RVA = "0x3E3DE74", Offset = "0x3E3DE74", VA = "0x3E3DE74", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CCF")]
    private string Battle\u002EData\u002EIMissionData\u002Edescription
    {
      [Token(Token = "0x6005763"), Address(RVA = "0x3E3DE7C", Offset = "0x3E3DE7C", VA = "0x3E3DE7C", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CD0")]
    private BattleMissionTypeEnum Battle\u002EData\u002EIMissionData\u002EmissionType1
    {
      [Token(Token = "0x6005764"), Address(RVA = "0x3E3DF5C", Offset = "0x3E3DF5C", VA = "0x3E3DF5C", Slot = "10")] get
      {
        return new BattleMissionTypeEnum();
      }
    }

    [Token(Token = "0x17000CD1")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue1
    {
      [Token(Token = "0x6005765"), Address(RVA = "0x3E3DF64", Offset = "0x3E3DF64", VA = "0x3E3DF64", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CD2")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue2
    {
      [Token(Token = "0x6005766"), Address(RVA = "0x3E3DF6C", Offset = "0x3E3DF6C", VA = "0x3E3DF6C", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CD3")]
    private BattleMissionTypeEnum Battle\u002EData\u002EIMissionData\u002EmissionType2
    {
      [Token(Token = "0x6005767"), Address(RVA = "0x3E3DF74", Offset = "0x3E3DF74", VA = "0x3E3DF74", Slot = "13")] get
      {
        return new BattleMissionTypeEnum();
      }
    }

    [Token(Token = "0x17000CD4")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue3
    {
      [Token(Token = "0x6005768"), Address(RVA = "0x3E3DF7C", Offset = "0x3E3DF7C", VA = "0x3E3DF7C", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CD5")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue4
    {
      [Token(Token = "0x6005769"), Address(RVA = "0x3E3DF84", Offset = "0x3E3DF84", VA = "0x3E3DF84", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CD6")]
    private BattleMissionTypeEnum Battle\u002EData\u002EIMissionData\u002EmissionType3
    {
      [Token(Token = "0x600576A"), Address(RVA = "0x3E3DF8C", Offset = "0x3E3DF8C", VA = "0x3E3DF8C", Slot = "16")] get
      {
        return new BattleMissionTypeEnum();
      }
    }

    [Token(Token = "0x17000CD7")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue5
    {
      [Token(Token = "0x600576B"), Address(RVA = "0x3E3DF94", Offset = "0x3E3DF94", VA = "0x3E3DF94", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CD8")]
    private int Battle\u002EData\u002EIMissionData\u002Evalue6
    {
      [Token(Token = "0x600576C"), Address(RVA = "0x3E3DF9C", Offset = "0x3E3DF9C", VA = "0x3E3DF9C", Slot = "18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CD9")]
    public string Name
    {
      [Token(Token = "0x600576D"), Address(RVA = "0x3E3DFA4", Offset = "0x3E3DFA4", VA = "0x3E3DFA4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CDA")]
    public string Description
    {
      [Token(Token = "0x600576E"), Address(RVA = "0x3E3DE80", Offset = "0x3E3DE80", VA = "0x3E3DE80")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600576F")]
    [Address(RVA = "0x3E3E080", Offset = "0x3E3E080", VA = "0x3E3E080")]
    public BattleMissionData()
    {
    }
  }
}

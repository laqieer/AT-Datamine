// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaBattleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DD9")]
  [Serializable]
  public sealed class ArenaBattleData : IMasterDataEntity
  {
    [Token(Token = "0x4004243")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004244")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int clearConditionGroupID;
    [Token(Token = "0x4004245")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int failedConditionGroupID;
    [Token(Token = "0x4004246")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int turnLimit;
    [Token(Token = "0x4004247")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int placementGroup;
    [Token(Token = "0x4004248")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int facilityPlacementGroup;
    [Token(Token = "0x4004249")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string mapModel;
    [Token(Token = "0x400424A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string mapData;
    [Token(Token = "0x400424B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int mapWidth;
    [Token(Token = "0x400424C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int mapHeight;
    [Token(Token = "0x400424D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int mapOffsetX;
    [Token(Token = "0x400424E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int mapOffsetY;
    [Token(Token = "0x400424F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int mapReadyBlendStrength;
    [Token(Token = "0x4004250")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public BattleTimeTypeEnum time;
    [Token(Token = "0x4004251")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public BattleWeatherTypeEnum weather;
    [Token(Token = "0x4004252")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public string defaultFieldBgm;
    [Token(Token = "0x4004253")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int spRuleEffect1;
    [Token(Token = "0x4004254")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int spRuleEffect2;
    [Token(Token = "0x4004255")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int spRuleEffect3;

    [Token(Token = "0x17000C1E")]
    public int Key
    {
      [Token(Token = "0x6005494"), Address(RVA = "0x3AA5E60", Offset = "0x3AA5E60", VA = "0x3AA5E60", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005495")]
    [Address(RVA = "0x3AA5E68", Offset = "0x3AA5E68", VA = "0x3AA5E68", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005496")]
    [Address(RVA = "0x3AA65D4", Offset = "0x3AA65D4", VA = "0x3AA65D4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005497")]
    [Address(RVA = "0x3AA6774", Offset = "0x3AA6774", VA = "0x3AA6774")]
    public ArenaBattleData()
    {
    }
  }
}

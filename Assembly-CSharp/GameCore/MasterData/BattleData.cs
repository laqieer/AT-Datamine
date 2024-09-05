// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E29")]
  [Serializable]
  public sealed class BattleData : IMasterDataEntity
  {
    [Token(Token = "0x4004377")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004378")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int clearConditionGroupID;
    [Token(Token = "0x4004379")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int failedConditionGroupID;
    [Token(Token = "0x400437A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int memberNum;
    [Token(Token = "0x400437B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool canItemUse;
    [Token(Token = "0x400437C")]
    [FieldOffset(Offset = "0x21")]
    [SerializeField]
    public bool canRollback;
    [Token(Token = "0x400437D")]
    [FieldOffset(Offset = "0x22")]
    [SerializeField]
    public bool canAuto;
    [Token(Token = "0x400437E")]
    [FieldOffset(Offset = "0x23")]
    [SerializeField]
    public bool canSkip;
    [Token(Token = "0x400437F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public bool skipReadyProcess;
    [Token(Token = "0x4004380")]
    [FieldOffset(Offset = "0x25")]
    [SerializeField]
    public bool skipWinEffect;
    [Token(Token = "0x4004381")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int fixedRandomSeed;
    [Token(Token = "0x4004382")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool isTutoreal;
    [Token(Token = "0x4004383")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public BattleTimeTypeEnum time;
    [Token(Token = "0x4004384")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public BattleWeatherTypeEnum weather;
    [Token(Token = "0x4004385")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public BattleBgColorIdEnum bgColorType;
    [Token(Token = "0x4004386")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int enemyLevel;
    [Token(Token = "0x4004387")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int enemyElement;
    [Token(Token = "0x4004388")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public string mapModel;
    [Token(Token = "0x4004389")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string mapData;
    [Token(Token = "0x400438A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int mapWidth;
    [Token(Token = "0x400438B")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int mapHeight;
    [Token(Token = "0x400438C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int mapOffsetX;
    [Token(Token = "0x400438D")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int mapOffsetY;
    [Token(Token = "0x400438E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int mapReadyBlendStrength;
    [Token(Token = "0x400438F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public string defaultFieldBgm;
    [Token(Token = "0x4004390")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public string allyPhaseFieldBgm;
    [Token(Token = "0x4004391")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public string enemyPhaseFieldBgm;
    [Token(Token = "0x4004392")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public string anotherForcePhaseFieldBgm;
    [Token(Token = "0x4004393")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public string guestPhaseFieldBgm;
    [Token(Token = "0x4004394")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public int forcedSortieGroupId;
    [Token(Token = "0x4004395")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    public int sortieRestrictionsGroupId;
    [Token(Token = "0x4004396")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public int initialPlacement;
    [Token(Token = "0x4004397")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    public int enemyPlacement;
    [Token(Token = "0x4004398")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public int thirdarmyPlacement;
    [Token(Token = "0x4004399")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    public int guestPlacement;
    [Token(Token = "0x400439A")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public int battleFacilityPlacement;
    [Token(Token = "0x400439B")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    public int weaponExperience;
    [Token(Token = "0x400439C")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    public int recommendedCombatPower;
    [Token(Token = "0x400439D")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    public int accessoriesExperience;

    [Token(Token = "0x17000C69")]
    public int Key
    {
      [Token(Token = "0x6005647"), Address(RVA = "0x3E338B8", Offset = "0x3E338B8", VA = "0x3E338B8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005648")]
    [Address(RVA = "0x3E338C0", Offset = "0x3E338C0", VA = "0x3E338C0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005649")]
    [Address(RVA = "0x3E347C8", Offset = "0x3E347C8", VA = "0x3E347C8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C6A")]
    public string Name
    {
      [Token(Token = "0x600564A"), Address(RVA = "0x3E34AB8", Offset = "0x3E34AB8", VA = "0x3E34AB8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C6B")]
    public string LockedName
    {
      [Token(Token = "0x600564B"), Address(RVA = "0x3E34B94", Offset = "0x3E34B94", VA = "0x3E34B94")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C6C")]
    public string Guide
    {
      [Token(Token = "0x600564C"), Address(RVA = "0x3E34C70", Offset = "0x3E34C70", VA = "0x3E34C70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600564D")]
    [Address(RVA = "0x3E34D4C", Offset = "0x3E34D4C", VA = "0x3E34D4C")]
    public BattleData()
    {
    }
  }
}

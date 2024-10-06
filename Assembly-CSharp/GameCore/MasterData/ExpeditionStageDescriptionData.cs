// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FAE")]
  [Serializable]
  public sealed class ExpeditionStageDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004EEC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EED")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int stage;
    [Token(Token = "0x4004EEE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004EEF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int playerUnitExperience;
    [Token(Token = "0x4004EF0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int drop;
    [Token(Token = "0x4004EF1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x4004EF2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int enemy;
    [Token(Token = "0x4004EF3")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int mapOffsetX;
    [Token(Token = "0x4004EF4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int mapOffsetY;
    [Token(Token = "0x4004EF5")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int mapWidth;
    [Token(Token = "0x4004EF6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int mapHeight;
    [Token(Token = "0x4004EF7")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int enemyPopRectOffsetX;
    [Token(Token = "0x4004EF8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int enemyPopRectOffsetY;
    [Token(Token = "0x4004EF9")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int enemyPopRectWidth;
    [Token(Token = "0x4004EFA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int enemyPopRectHeight;

    [Token(Token = "0x17000D95")]
    public int Key
    {
      [Token(Token = "0x6005C01"), Address(RVA = "0x2787F54", Offset = "0x2787F54", VA = "0x2787F54", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C02")]
    [Address(RVA = "0x2787F5C", Offset = "0x2787F5C", VA = "0x2787F5C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C03")]
    [Address(RVA = "0x2788548", Offset = "0x2788548", VA = "0x2788548", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005C04")]
    [Address(RVA = "0x278869C", Offset = "0x278869C", VA = "0x278869C")]
    public IReadOnlyCollection<ExpeditionStageItemDropDescriptionData> GetItemDrop()
    {
      return (IReadOnlyCollection<ExpeditionStageItemDropDescriptionData>) null;
    }

    [Token(Token = "0x6005C05")]
    [Address(RVA = "0x2788798", Offset = "0x2788798", VA = "0x2788798")]
    public IReadOnlyCollection<ExpeditionStageOwnPlacementDescriptionData> GetPlacement()
    {
      return (IReadOnlyCollection<ExpeditionStageOwnPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005C06")]
    [Address(RVA = "0x2788894", Offset = "0x2788894", VA = "0x2788894")]
    public IReadOnlyCollection<ExpeditionStageEnemyDescriptionData> GetEnemy()
    {
      return (IReadOnlyCollection<ExpeditionStageEnemyDescriptionData>) null;
    }

    [Token(Token = "0x6005C07")]
    [Address(RVA = "0x2788990", Offset = "0x2788990", VA = "0x2788990")]
    public ExpeditionStageDescriptionData()
    {
    }
  }
}

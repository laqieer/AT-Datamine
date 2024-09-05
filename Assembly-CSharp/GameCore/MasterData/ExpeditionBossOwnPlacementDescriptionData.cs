// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossOwnPlacementDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F94")]
  [Serializable]
  public sealed class ExpeditionBossOwnPlacementDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004EAE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EAF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placementID;
    [Token(Token = "0x4004EB0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int x;
    [Token(Token = "0x4004EB1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int y;
    [Token(Token = "0x4004EB2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int slotID;

    [Token(Token = "0x17000D88")]
    public int Key
    {
      [Token(Token = "0x6005B8E"), Address(RVA = "0x27846B4", Offset = "0x27846B4", VA = "0x27846B4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B8F")]
    [Address(RVA = "0x27846BC", Offset = "0x27846BC", VA = "0x27846BC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B90")]
    [Address(RVA = "0x27848E8", Offset = "0x27848E8", VA = "0x27848E8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B91")]
    [Address(RVA = "0x278499C", Offset = "0x278499C", VA = "0x278499C")]
    public ExpeditionBossOwnPlacementDescriptionData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageItemDropDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FB2")]
  [Serializable]
  public sealed class ExpeditionStageItemDropDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004F00")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F01")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int drop;
    [Token(Token = "0x4004F02")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x4004F03")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4004F04")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;
    [Token(Token = "0x4004F05")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int weight;

    [Token(Token = "0x17000D97")]
    public int Key
    {
      [Token(Token = "0x6005C1B"), Address(RVA = "0x27891CC", Offset = "0x27891CC", VA = "0x27891CC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C1C")]
    [Address(RVA = "0x27891D4", Offset = "0x27891D4", VA = "0x27891D4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C1D")]
    [Address(RVA = "0x2789460", Offset = "0x2789460", VA = "0x2789460", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005C1E")]
    [Address(RVA = "0x2789524", Offset = "0x2789524", VA = "0x2789524")]
    public ExpeditionStageItemDropDescriptionData()
    {
    }
  }
}

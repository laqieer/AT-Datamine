// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossRewardGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F9A")]
  [Serializable]
  public sealed class ExpeditionBossRewardGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4004EBF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EC0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int bossDescriptionID;
    [Token(Token = "0x4004EC1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int bossRewardID;

    [Token(Token = "0x17000D8B")]
    public int Key
    {
      [Token(Token = "0x6005BAD"), Address(RVA = "0x278568C", Offset = "0x278568C", VA = "0x278568C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BAE")]
    [Address(RVA = "0x2785694", Offset = "0x2785694", VA = "0x2785694", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BAF")]
    [Address(RVA = "0x2785800", Offset = "0x2785800", VA = "0x2785800", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BB0")]
    [Address(RVA = "0x2785894", Offset = "0x2785894", VA = "0x2785894")]
    public ExpeditionBossRewardGroupData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossRareRewardSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F96")]
  [Serializable]
  public sealed class ExpeditionBossRareRewardSetData : IMasterDataEntity
  {
    [Token(Token = "0x4004EB4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EB5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int bossRewardID;
    [Token(Token = "0x4004EB6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int bossRareRewardSetDescriptionID;
    [Token(Token = "0x4004EB7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int weight;

    [Token(Token = "0x17000D89")]
    public int Key
    {
      [Token(Token = "0x6005B9A"), Address(RVA = "0x2784CE0", Offset = "0x2784CE0", VA = "0x2784CE0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B9B")]
    [Address(RVA = "0x2784CE8", Offset = "0x2784CE8", VA = "0x2784CE8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B9C")]
    [Address(RVA = "0x2784EB4", Offset = "0x2784EB4", VA = "0x2784EB4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B9D")]
    [Address(RVA = "0x2784F58", Offset = "0x2784F58", VA = "0x2784F58")]
    public ExpeditionBossRareRewardSetData()
    {
    }
  }
}

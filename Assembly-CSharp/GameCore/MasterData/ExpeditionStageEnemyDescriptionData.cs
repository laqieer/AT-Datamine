// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageEnemyDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FB0")]
  [Serializable]
  public sealed class ExpeditionStageEnemyDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004EFC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EFD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x4004EFE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int enemy;

    [Token(Token = "0x17000D96")]
    public int Key
    {
      [Token(Token = "0x6005C0F"), Address(RVA = "0x2788C5C", Offset = "0x2788C5C", VA = "0x2788C5C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C10")]
    [Address(RVA = "0x2788C64", Offset = "0x2788C64", VA = "0x2788C64", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C11")]
    [Address(RVA = "0x2788DD0", Offset = "0x2788DD0", VA = "0x2788DD0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005C12")]
    [Address(RVA = "0x2788E64", Offset = "0x2788E64", VA = "0x2788E64")]
    public NpcUnitDataData EnemyData() => (NpcUnitDataData) null;

    [Token(Token = "0x6005C13")]
    [Address(RVA = "0x2788F00", Offset = "0x2788F00", VA = "0x2788F00")]
    public ExpeditionStageEnemyDescriptionData()
    {
    }
  }
}

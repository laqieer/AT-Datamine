// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossEnemyDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F92")]
  [Serializable]
  public sealed class ExpeditionBossEnemyDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004EA5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EA6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int bossEnemy;
    [Token(Token = "0x4004EA7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int enemy;
    [Token(Token = "0x4004EA8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int barrier;
    [Token(Token = "0x4004EA9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int barrierHp;
    [Token(Token = "0x4004EAA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int barrierRecovery;
    [Token(Token = "0x4004EAB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int x;
    [Token(Token = "0x4004EAC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int y;

    [Token(Token = "0x17000D87")]
    public int Key
    {
      [Token(Token = "0x6005B82"), Address(RVA = "0x2783F14", Offset = "0x2783F14", VA = "0x2783F14", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B83")]
    [Address(RVA = "0x2783F1C", Offset = "0x2783F1C", VA = "0x2783F1C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B84")]
    [Address(RVA = "0x2784268", Offset = "0x2784268", VA = "0x2784268", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B85")]
    [Address(RVA = "0x278434C", Offset = "0x278434C", VA = "0x278434C")]
    public NpcUnitDataData EnemyData() => (NpcUnitDataData) null;

    [Token(Token = "0x6005B86")]
    [Address(RVA = "0x27843E8", Offset = "0x27843E8", VA = "0x27843E8")]
    public ExpeditionBossEnemyDescriptionData()
    {
    }
  }
}

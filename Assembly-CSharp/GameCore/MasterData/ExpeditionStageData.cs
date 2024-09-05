// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageData
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
  [Token(Token = "0x2000FB6")]
  [Serializable]
  public sealed class ExpeditionStageData : IMasterDataEntity
  {
    [Token(Token = "0x4004F0D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F0E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004F0F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string map;
    [Token(Token = "0x4004F10")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int expSpan;
    [Token(Token = "0x4004F11")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int itemSpan;
    [Token(Token = "0x4004F12")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int boss;
    [Token(Token = "0x4004F13")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int element;

    [Token(Token = "0x17000D99")]
    public int Key
    {
      [Token(Token = "0x6005C2E"), Address(RVA = "0x2789BE8", Offset = "0x2789BE8", VA = "0x2789BE8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C2F")]
    [Address(RVA = "0x2789BF0", Offset = "0x2789BF0", VA = "0x2789BF0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C30")]
    [Address(RVA = "0x2789EDC", Offset = "0x2789EDC", VA = "0x2789EDC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005C31")]
    [Address(RVA = "0x2789FB8", Offset = "0x2789FB8", VA = "0x2789FB8")]
    public IReadOnlyCollection<ExpeditionBossDescriptionData> GetBossList()
    {
      return (IReadOnlyCollection<ExpeditionBossDescriptionData>) null;
    }

    [Token(Token = "0x6005C32")]
    [Address(RVA = "0x278A03C", Offset = "0x278A03C", VA = "0x278A03C")]
    public ExpeditionBossDescriptionData GetBossFromLevel(int level)
    {
      return (ExpeditionBossDescriptionData) null;
    }

    [Token(Token = "0x17000D9A")]
    public string Name
    {
      [Token(Token = "0x6005C33"), Address(RVA = "0x278A0D0", Offset = "0x278A0D0", VA = "0x278A0D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005C34")]
    [Address(RVA = "0x278A1AC", Offset = "0x278A1AC", VA = "0x278A1AC")]
    public ExpeditionStageData()
    {
    }
  }
}

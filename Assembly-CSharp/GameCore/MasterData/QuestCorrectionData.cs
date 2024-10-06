// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.QuestCorrectionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001127")]
  [Serializable]
  public sealed class QuestCorrectionData : IMasterDataEntity
  {
    [Token(Token = "0x4005377")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005378")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int correctionType;
    [Token(Token = "0x4005379")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int correctionValue;
    [Token(Token = "0x400537A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int level;
    [Token(Token = "0x400537B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int lifeRate;
    [Token(Token = "0x400537C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int lifeFixed;
    [Token(Token = "0x400537D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int strRate;
    [Token(Token = "0x400537E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int strFixed;
    [Token(Token = "0x400537F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int intRate;
    [Token(Token = "0x4005380")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int intFixed;
    [Token(Token = "0x4005381")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int vitRate;
    [Token(Token = "0x4005382")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int vitFixed;
    [Token(Token = "0x4005383")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int minRate;
    [Token(Token = "0x4005384")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int minFixed;
    [Token(Token = "0x4005385")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int agiRate;
    [Token(Token = "0x4005386")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int agiFixed;
    [Token(Token = "0x4005387")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int dexRate;
    [Token(Token = "0x4005388")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int dexFixed;
    [Token(Token = "0x4005389")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int lucRate;
    [Token(Token = "0x400538A")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int lucFixed;
    [Token(Token = "0x400538B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int hpRate;
    [Token(Token = "0x400538C")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int hpFixed;
    [Token(Token = "0x400538D")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int hpStock;
    [Token(Token = "0x400538E")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int hpStockCnt;
    [Token(Token = "0x400538F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int skillLevelFixed;
    [Token(Token = "0x4005390")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int moveFixed;

    [Token(Token = "0x17000EC4")]
    public int Key
    {
      [Token(Token = "0x60062BC"), Address(RVA = "0x4AE1B18", Offset = "0x4AE1B18", VA = "0x4AE1B18", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062BD")]
    [Address(RVA = "0x4AE1B20", Offset = "0x4AE1B20", VA = "0x4AE1B20", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60062BE")]
    [Address(RVA = "0x4AE252C", Offset = "0x4AE252C", VA = "0x4AE252C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60062BF")]
    [Address(RVA = "0x4AE2730", Offset = "0x4AE2730", VA = "0x4AE2730")]
    public QuestCorrectionData()
    {
    }
  }
}

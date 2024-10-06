// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomAFrameData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200133C")]
  [Serializable]
  public sealed class AbilityboardCustomAFrameData : IMasterDataEntity
  {
    [Token(Token = "0x4005AA5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AA6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x4005AA7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int value;
    [Token(Token = "0x4005AA8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int lotteryWeight;
    [Token(Token = "0x4005AA9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int frameType;

    [Token(Token = "0x17001062")]
    public int Key
    {
      [Token(Token = "0x6006C81"), Address(RVA = "0x46F42F4", Offset = "0x46F42F4", VA = "0x46F42F4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C82")]
    [Address(RVA = "0x46F42FC", Offset = "0x46F42FC", VA = "0x46F42FC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C83")]
    [Address(RVA = "0x46F4528", Offset = "0x46F4528", VA = "0x46F4528", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C84")]
    [Address(RVA = "0x46F45DC", Offset = "0x46F45DC", VA = "0x46F45DC")]
    public AbilityboardCustomAFrameData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ReincarnationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013AB")]
  [Serializable]
  public sealed class ReincarnationData : IMasterDataEntity
  {
    [Token(Token = "0x4005BA3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BA4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int materialPaymentAmount;
    [Token(Token = "0x4005BA5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int unlockUnitLevel;
    [Token(Token = "0x4005BA6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int unlockSpecialRequirementRarity;
    [Token(Token = "0x4005BA7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int specialRequirementAfterLevel;
    [Token(Token = "0x4005BA8")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int unlockMemoryRequirementLevel;
    [Token(Token = "0x4005BA9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int unlockMemoryRestoreRequirementLevel;

    [Token(Token = "0x17001096")]
    public int Key
    {
      [Token(Token = "0x6006E76"), Address(RVA = "0x4705AA8", Offset = "0x4705AA8", VA = "0x4705AA8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E77")]
    [Address(RVA = "0x4705AB0", Offset = "0x4705AB0", VA = "0x4705AB0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E78")]
    [Address(RVA = "0x4705D9C", Offset = "0x4705D9C", VA = "0x4705D9C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E79")]
    [Address(RVA = "0x4705E70", Offset = "0x4705E70", VA = "0x4705E70")]
    public ReincarnationData()
    {
    }
  }
}

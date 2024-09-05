// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionRewardDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B3")]
  [Serializable]
  public sealed class TotalMissionRewardDetailData : IMasterDataEntity
  {
    [Token(Token = "0x400522B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400522C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int missionRewardID;
    [Token(Token = "0x400522D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x400522E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x400522F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000E63")]
    public int Key
    {
      [Token(Token = "0x600609A"), Address(RVA = "0x28D9050", Offset = "0x28D9050", VA = "0x28D9050", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600609B")]
    [Address(RVA = "0x28D9058", Offset = "0x28D9058", VA = "0x28D9058", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600609C")]
    [Address(RVA = "0x28D9284", Offset = "0x28D9284", VA = "0x28D9284", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600609D")]
    [Address(RVA = "0x28D9338", Offset = "0x28D9338", VA = "0x28D9338")]
    public TotalMissionRewardDetailData()
    {
    }
  }
}

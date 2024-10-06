// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestRewardPaymentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011DC")]
  [Serializable]
  public sealed class StoryAreaEventQuestRewardPaymentData : IMasterDataEntity
  {
    [Token(Token = "0x40055BD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055BE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int taskRewardPaymentLabel;
    [Token(Token = "0x40055BF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x40055C0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40055C1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardQuantity;
    [Token(Token = "0x40055C2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int paymentType;
    [Token(Token = "0x40055C3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int paymentID;
    [Token(Token = "0x40055C4")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int paymentQuantity;

    [Token(Token = "0x17000F68")]
    public int Key
    {
      [Token(Token = "0x6006620"), Address(RVA = "0x4D22768", Offset = "0x4D22768", VA = "0x4D22768", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006621")]
    [Address(RVA = "0x4D22770", Offset = "0x4D22770", VA = "0x4D22770", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006622")]
    [Address(RVA = "0x4D22ABC", Offset = "0x4D22ABC", VA = "0x4D22ABC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006623")]
    [Address(RVA = "0x4D22BA0", Offset = "0x4D22BA0", VA = "0x4D22BA0")]
    public StoryAreaEventQuestRewardPaymentData()
    {
    }
  }
}

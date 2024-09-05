// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001253")]
  [Serializable]
  public sealed class StoryFreeActionConstData : IMasterDataEntity
  {
    [Token(Token = "0x40057AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40057AC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public float walkMoveSpeed;
    [Token(Token = "0x40057AD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public float runMoveSpeed;
    [Token(Token = "0x40057AE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public float autoMoveWalkSpeed;
    [Token(Token = "0x40057AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float autoMoveRunSpeed;
    [Token(Token = "0x40057B0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float autoMoveWalkMotionRate;
    [Token(Token = "0x40057B1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float autoMoveRunMotionRate;
    [Token(Token = "0x40057B2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float rotationSpeed;
    [Token(Token = "0x40057B3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float rotationLimit;
    [Token(Token = "0x40057B4")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float changeToWalkDistance;
    [Token(Token = "0x40057B5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float passiveMsgShowDistance;
    [Token(Token = "0x40057B6")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float passiveMsgHideDistance;
    [Token(Token = "0x40057B7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public float passiveMsgDisplayTime;
    [Token(Token = "0x40057B8")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public float passiveMsgIntervalTime;
    [Token(Token = "0x40057B9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public float forwardDistance;
    [Token(Token = "0x40057BA")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public float actionIconDefLength;
    [Token(Token = "0x40057BB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public float actionIconFarLength;
    [Token(Token = "0x40057BC")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public float actionIconNearRate;
    [Token(Token = "0x40057BD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public float actionIconFarRate;
    [Token(Token = "0x40057BE")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public float actionIconCT;
    [Token(Token = "0x40057BF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public float actionIconExpandAndCollapseDistance;

    [Token(Token = "0x17000FB9")]
    public int Key
    {
      [Token(Token = "0x6006836"), Address(RVA = "0x4D36708", Offset = "0x4D36708", VA = "0x4D36708", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006837")]
    [Address(RVA = "0x4D36710", Offset = "0x4D36710", VA = "0x4D36710", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006838")]
    [Address(RVA = "0x4D36F3C", Offset = "0x4D36F3C", VA = "0x4D36F3C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006839")]
    [Address(RVA = "0x4D370F0", Offset = "0x4D370F0", VA = "0x4D370F0")]
    public StoryFreeActionConstData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleLandCorrectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E1B")]
  [Serializable]
  public sealed class BattleLandCorrectData : IMasterDataEntity
  {
    [Token(Token = "0x400432D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400432E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public LandformTypeEnum landform;
    [Token(Token = "0x400432F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public LandTagEnum landTag1;
    [Token(Token = "0x4004330")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public LandTagEnum landTag2;
    [Token(Token = "0x4004331")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public LandTagEnum landTag3;
    [Token(Token = "0x4004332")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string duelSceneName;
    [Token(Token = "0x4004333")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float groundOffset;
    [Token(Token = "0x4004334")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int infantryMoveCost;
    [Token(Token = "0x4004335")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public bool infantryStoppable;
    [Token(Token = "0x4004336")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int flyMoveCost;
    [Token(Token = "0x4004337")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public bool flyStoppable;
    [Token(Token = "0x4004338")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int equestrianMoveCost;
    [Token(Token = "0x4004339")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public bool equestrianStoppable;
    [Token(Token = "0x400433A")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int floatingMoveCost;
    [Token(Token = "0x400433B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public bool floatingStoppable;
    [Token(Token = "0x400433C")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int statusEffect;
    [Token(Token = "0x400433D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int elementEffect;
    [Token(Token = "0x400433E")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int instantEffect;
    [Token(Token = "0x400433F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public string effectName;
    [Token(Token = "0x4004340")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int score;
    [Token(Token = "0x4004341")]
    private const int MaxLandTag = 3;
    [Token(Token = "0x4004342")]
    [FieldOffset(Offset = "0x70")]
    private LandTagEnum[] landTags;

    [Token(Token = "0x17000C54")]
    public int Key
    {
      [Token(Token = "0x60055F3"), Address(RVA = "0x3E2FE6C", Offset = "0x3E2FE6C", VA = "0x3E2FE6C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60055F4")]
    [Address(RVA = "0x3E2FE74", Offset = "0x3E2FE74", VA = "0x3E2FE74", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60055F5")]
    [Address(RVA = "0x3E30650", Offset = "0x3E30650", VA = "0x3E30650", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C55")]
    public LandTagEnum[] LandTags
    {
      [Token(Token = "0x60055F6"), Address(RVA = "0x3E307FC", Offset = "0x3E307FC", VA = "0x3E307FC")] get
      {
        return (LandTagEnum[]) null;
      }
    }

    [Token(Token = "0x60055F7")]
    [Address(RVA = "0x3E30890", Offset = "0x3E30890", VA = "0x3E30890")]
    public int GetCost(MoveTypeEnum moveType) => new int();

    [Token(Token = "0x60055F8")]
    [Address(RVA = "0x3E308E0", Offset = "0x3E308E0", VA = "0x3E308E0")]
    public bool IsStoppable(MoveData moveType) => new bool();

    [Token(Token = "0x60055F9")]
    [Address(RVA = "0x3E3094C", Offset = "0x3E3094C", VA = "0x3E3094C")]
    public bool IsStoppableAny() => new bool();

    [Token(Token = "0x60055FA")]
    [Address(RVA = "0x3E3097C", Offset = "0x3E3097C", VA = "0x3E3097C")]
    public BattleLandCorrectData()
    {
    }
  }
}

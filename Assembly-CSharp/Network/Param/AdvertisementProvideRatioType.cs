// Decompiled with JetBrains decompiler
// Type: Network.Param.AdvertisementProvideRatioType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A3B")]
  [Serializable]
  public class AdvertisementProvideRatioType
  {
    [Token(Token = "0x4007025")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int reward_type_id;
    [Token(Token = "0x4007026")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int reward_id;
    [Token(Token = "0x4007027")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int reward_quantity;
    [Token(Token = "0x4007028")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float ratio;

    [Token(Token = "0x1700185B")]
    public int RewardTypeId
    {
      [Token(Token = "0x6009587"), Address(RVA = "0x48EEA58", Offset = "0x48EEA58", VA = "0x48EEA58")] get
      {
        return new int();
      }
      [Token(Token = "0x6009588"), Address(RVA = "0x48EEA60", Offset = "0x48EEA60", VA = "0x48EEA60")] set
      {
      }
    }

    [Token(Token = "0x1700185C")]
    public int RewardId
    {
      [Token(Token = "0x6009589"), Address(RVA = "0x48EEA68", Offset = "0x48EEA68", VA = "0x48EEA68")] get
      {
        return new int();
      }
      [Token(Token = "0x600958A"), Address(RVA = "0x48EEA70", Offset = "0x48EEA70", VA = "0x48EEA70")] set
      {
      }
    }

    [Token(Token = "0x1700185D")]
    public int RewardQuantity
    {
      [Token(Token = "0x600958B"), Address(RVA = "0x48EEA78", Offset = "0x48EEA78", VA = "0x48EEA78")] get
      {
        return new int();
      }
      [Token(Token = "0x600958C"), Address(RVA = "0x48EEA80", Offset = "0x48EEA80", VA = "0x48EEA80")] set
      {
      }
    }

    [Token(Token = "0x1700185E")]
    public float Ratio
    {
      [Token(Token = "0x600958D"), Address(RVA = "0x48EEA88", Offset = "0x48EEA88", VA = "0x48EEA88")] get
      {
        return new float();
      }
      [Token(Token = "0x600958E"), Address(RVA = "0x48EEA90", Offset = "0x48EEA90", VA = "0x48EEA90")] set
      {
      }
    }

    [Token(Token = "0x600958F")]
    [Address(RVA = "0x48EEA98", Offset = "0x48EEA98", VA = "0x48EEA98")]
    public AdvertisementProvideRatioType()
    {
    }
  }
}

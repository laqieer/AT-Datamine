// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RarityUpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013A7")]
  [Serializable]
  public sealed class RarityUpData : IMasterDataEntity
  {
    [Token(Token = "0x4005B99")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B9A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rarityStar;
    [Token(Token = "0x4005B9B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int initialRarityStar;
    [Token(Token = "0x4005B9C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int styleId;
    [Token(Token = "0x4005B9D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int paymentAmount;

    [Token(Token = "0x17001094")]
    public int Key
    {
      [Token(Token = "0x6006E5F"), Address(RVA = "0x4704BC8", Offset = "0x4704BC8", VA = "0x4704BC8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E60")]
    [Address(RVA = "0x4704BD0", Offset = "0x4704BD0", VA = "0x4704BD0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E61")]
    [Address(RVA = "0x4704DFC", Offset = "0x4704DFC", VA = "0x4704DFC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E62")]
    [Address(RVA = "0x4704EB0", Offset = "0x4704EB0", VA = "0x4704EB0")]
    public RarityUpData()
    {
    }
  }
}

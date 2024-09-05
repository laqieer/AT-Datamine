// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRankupHintsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001204")]
  [Serializable]
  public sealed class StoryCommunicationRankupHintsData : IMasterDataEntity
  {
    [Token(Token = "0x400564A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;

    [Token(Token = "0x17000F7D")]
    public int Key
    {
      [Token(Token = "0x60066CD"), Address(RVA = "0x4D29340", Offset = "0x4D29340", VA = "0x4D29340", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60066CE")]
    [Address(RVA = "0x4D29348", Offset = "0x4D29348", VA = "0x4D29348", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60066CF")]
    [Address(RVA = "0x4D293F4", Offset = "0x4D293F4", VA = "0x4D293F4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F7E")]
    public string SuccessText
    {
      [Token(Token = "0x60066D0"), Address(RVA = "0x4D29460", Offset = "0x4D29460", VA = "0x4D29460")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F7F")]
    public string FailureText
    {
      [Token(Token = "0x60066D1"), Address(RVA = "0x4D2953C", Offset = "0x4D2953C", VA = "0x4D2953C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60066D2")]
    [Address(RVA = "0x4D29618", Offset = "0x4D29618", VA = "0x4D29618")]
    public StoryCommunicationRankupHintsData()
    {
    }
  }
}

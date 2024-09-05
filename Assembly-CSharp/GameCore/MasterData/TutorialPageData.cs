// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TutorialPageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001321")]
  [Serializable]
  public sealed class TutorialPageData : IMasterDataEntity
  {
    [Token(Token = "0x4005A69")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A6A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int imageId;
    [Token(Token = "0x4005A6B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string movieName;

    [Token(Token = "0x17001055")]
    public int Key
    {
      [Token(Token = "0x6006C01"), Address(RVA = "0x48E7924", Offset = "0x48E7924", VA = "0x48E7924", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C02")]
    [Address(RVA = "0x48E792C", Offset = "0x48E792C", VA = "0x48E792C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C03")]
    [Address(RVA = "0x48E7A98", Offset = "0x48E7A98", VA = "0x48E7A98", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001056")]
    public string Title
    {
      [Token(Token = "0x6006C04"), Address(RVA = "0x48E7B30", Offset = "0x48E7B30", VA = "0x48E7B30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001057")]
    public string Text
    {
      [Token(Token = "0x6006C05"), Address(RVA = "0x48E7C0C", Offset = "0x48E7C0C", VA = "0x48E7C0C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006C06")]
    [Address(RVA = "0x48E7CE8", Offset = "0x48E7CE8", VA = "0x48E7CE8")]
    public TutorialPageData()
    {
    }
  }
}

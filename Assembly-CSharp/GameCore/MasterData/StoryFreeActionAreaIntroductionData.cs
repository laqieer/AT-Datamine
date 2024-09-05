// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaIntroductionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200123F")]
  [Serializable]
  public sealed class StoryFreeActionAreaIntroductionData : IMasterDataEntity
  {
    [Token(Token = "0x400575A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400575B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400575C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int productionID;
    [Token(Token = "0x400575D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int chapter;

    [Token(Token = "0x17000F9C")]
    public int Key
    {
      [Token(Token = "0x60067BE"), Address(RVA = "0x4D324A8", Offset = "0x4D324A8", VA = "0x4D324A8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60067BF")]
    [Address(RVA = "0x4D324B0", Offset = "0x4D324B0", VA = "0x4D324B0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60067C0")]
    [Address(RVA = "0x4D3267C", Offset = "0x4D3267C", VA = "0x4D3267C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60067C1")]
    [Address(RVA = "0x4D32724", Offset = "0x4D32724", VA = "0x4D32724")]
    public StoryFreeActionAreaIntroductionData()
    {
    }
  }
}

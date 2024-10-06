// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaRegionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001241")]
  [Serializable]
  public sealed class StoryFreeActionAreaRegionData : IMasterDataEntity
  {
    [Token(Token = "0x400575F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005760")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005761")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int order;

    [Token(Token = "0x17000F9D")]
    public int Key
    {
      [Token(Token = "0x60067C6"), Address(RVA = "0x4D32834", Offset = "0x4D32834", VA = "0x4D32834", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60067C7")]
    [Address(RVA = "0x4D3283C", Offset = "0x4D3283C", VA = "0x4D3283C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60067C8")]
    [Address(RVA = "0x4D329A8", Offset = "0x4D329A8", VA = "0x4D329A8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F9E")]
    public string Text
    {
      [Token(Token = "0x60067C9"), Address(RVA = "0x4D32A40", Offset = "0x4D32A40", VA = "0x4D32A40")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60067CA")]
    [Address(RVA = "0x4D32B1C", Offset = "0x4D32B1C", VA = "0x4D32B1C")]
    public StoryFreeActionAreaRegionData()
    {
    }
  }
}

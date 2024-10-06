// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAdvTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DCE")]
  [Serializable]
  public sealed class StoryAdvTypeData : IMasterDataEntity
  {
    [Token(Token = "0x400420A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400420B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public AdvTypeEnum AdvType;
    [Token(Token = "0x400420C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;

    [Token(Token = "0x17000C08")]
    public int Key
    {
      [Token(Token = "0x600544D"), Address(RVA = "0x3AA4208", Offset = "0x3AA4208", VA = "0x3AA4208", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600544E")]
    [Address(RVA = "0x3AA4210", Offset = "0x3AA4210", VA = "0x3AA4210", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600544F")]
    [Address(RVA = "0x3AA444C", Offset = "0x3AA444C", VA = "0x3AA444C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005450")]
    [Address(RVA = "0x3AA44E4", Offset = "0x3AA44E4", VA = "0x3AA44E4")]
    public StoryAdvTypeData()
    {
    }
  }
}

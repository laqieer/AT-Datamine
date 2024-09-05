// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryRouteData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012F0")]
  [Serializable]
  public sealed class StoryRouteData : IMasterDataEntity
  {
    [Token(Token = "0x40059B4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17001032")]
    public int Key
    {
      [Token(Token = "0x6006B21"), Address(RVA = "0x48DF378", Offset = "0x48DF378", VA = "0x48DF378", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B22")]
    [Address(RVA = "0x48DF380", Offset = "0x48DF380", VA = "0x48DF380", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B23")]
    [Address(RVA = "0x48DF48C", Offset = "0x48DF48C", VA = "0x48DF48C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001033")]
    public string Title
    {
      [Token(Token = "0x6006B24"), Address(RVA = "0x48DF514", Offset = "0x48DF514", VA = "0x48DF514")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006B25")]
    [Address(RVA = "0x48DF5F0", Offset = "0x48DF5F0", VA = "0x48DF5F0")]
    public StoryRouteData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AITypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DD2")]
  [Serializable]
  public sealed class AITypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004212")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004213")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004214")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string summary;
    [Token(Token = "0x4004215")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public bool isAvailableUser;
    [Token(Token = "0x4004216")]
    [FieldOffset(Offset = "0x29")]
    [SerializeField]
    public bool isAvailableParty;
    [Token(Token = "0x4004217")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int role;
    [Token(Token = "0x4004218")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string assetBundleName;
    [Token(Token = "0x4004219")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string scriptName;

    [Token(Token = "0x17000C0A")]
    public int Key
    {
      [Token(Token = "0x6005465"), Address(RVA = "0x3AA4DF4", Offset = "0x3AA4DF4", VA = "0x3AA4DF4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005466")]
    [Address(RVA = "0x3AA4DFC", Offset = "0x3AA4DFC", VA = "0x3AA4DFC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005467")]
    [Address(RVA = "0x3AA5150", Offset = "0x3AA5150", VA = "0x3AA5150", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005468")]
    [Address(RVA = "0x3AA5244", Offset = "0x3AA5244", VA = "0x3AA5244")]
    public AITypeData()
    {
    }
  }
}

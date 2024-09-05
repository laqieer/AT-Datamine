// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F73")]
  [Serializable]
  public sealed class WeaponExpData : IMasterDataEntity
  {
    [Token(Token = "0x4004DDE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004DDF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004DE0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4004DE1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;

    [Token(Token = "0x17000D76")]
    public int Key
    {
      [Token(Token = "0x6005AEC"), Address(RVA = "0x277BDDC", Offset = "0x277BDDC", VA = "0x277BDDC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005AED")]
    [Address(RVA = "0x277BDE4", Offset = "0x277BDE4", VA = "0x277BDE4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005AEE")]
    [Address(RVA = "0x277BFB0", Offset = "0x277BFB0", VA = "0x277BFB0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005AEF")]
    [Address(RVA = "0x277B904", Offset = "0x277B904", VA = "0x277B904")]
    public WeaponExpData()
    {
    }
  }
}

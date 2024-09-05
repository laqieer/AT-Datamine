// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CommonEffectListData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E88")]
  [Serializable]
  public sealed class CommonEffectListData : IMasterDataEntity
  {
    [Token(Token = "0x400461B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400461C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string EffectName;
    [Token(Token = "0x400461D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string AssetBundlePath;
    [Token(Token = "0x400461E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string EffectPrefabName;
    [Token(Token = "0x400461F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string SE;

    [Token(Token = "0x17000D25")]
    public int Key
    {
      [Token(Token = "0x6005877"), Address(RVA = "0x3E49184", Offset = "0x3E49184", VA = "0x3E49184", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005878")]
    [Address(RVA = "0x3E4918C", Offset = "0x3E4918C", VA = "0x3E4918C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005879")]
    [Address(RVA = "0x3E493B8", Offset = "0x3E493B8", VA = "0x3E493B8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600587A")]
    [Address(RVA = "0x3E4947C", Offset = "0x3E4947C", VA = "0x3E4947C")]
    public CommonEffectListData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvDemoInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DAB")]
  [Serializable]
  public sealed class AdvDemoInfoData : IMasterDataEntity
  {
    [Token(Token = "0x400417E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400417F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x4004180")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string titleText;
    [Token(Token = "0x4004181")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string summaryText;
    [Token(Token = "0x4004182")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public bool IsSceneChange;
    [Token(Token = "0x4004183")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string ScriptAssetbundle;
    [Token(Token = "0x4004184")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string ScriptFilename;
    [Token(Token = "0x4004185")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public string PreBGMBank;
    [Token(Token = "0x4004186")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string PreBGMEvent;
    [Token(Token = "0x4004187")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int OptionID;
    [Token(Token = "0x4004188")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int carenderStartID;
    [Token(Token = "0x4004189")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int carenderEndID;
    [Token(Token = "0x400418A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public string PreLoadVoiceBank;

    [Token(Token = "0x17000BF6")]
    public int Key
    {
      [Token(Token = "0x60053AE"), Address(RVA = "0x3A9C3B8", Offset = "0x3A9C3B8", VA = "0x3A9C3B8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60053AF")]
    [Address(RVA = "0x3A9C3C0", Offset = "0x3A9C3C0", VA = "0x3A9C3C0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60053B0")]
    [Address(RVA = "0x3A9C8F0", Offset = "0x3A9C8F0", VA = "0x3A9C8F0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60053B1")]
    [Address(RVA = "0x3A9CA44", Offset = "0x3A9CA44", VA = "0x3A9CA44")]
    public AdvDemoInfoData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceAdvSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200102F")]
  [Serializable]
  public sealed class IntroChapterSequenceAdvSettingData : IMasterDataEntity
  {
    [Token(Token = "0x400504F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005050")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int advID;

    [Token(Token = "0x17000DE1")]
    public int Key
    {
      [Token(Token = "0x6005E20"), Address(RVA = "0x2799F54", Offset = "0x2799F54", VA = "0x2799F54", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E21")]
    [Address(RVA = "0x2799F5C", Offset = "0x2799F5C", VA = "0x2799F5C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E22")]
    [Address(RVA = "0x279A068", Offset = "0x279A068", VA = "0x279A068", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E23")]
    [Address(RVA = "0x279A0EC", Offset = "0x279A0EC", VA = "0x279A0EC")]
    public IntroChapterSequenceAdvSettingData()
    {
    }
  }
}

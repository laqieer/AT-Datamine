// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200127C")]
  [Serializable]
  public sealed class StoryFreeActionSettingData : IMasterDataEntity
  {
    [Token(Token = "0x400584E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400584F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x4005850")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int FreeActionCount;
    [Token(Token = "0x4005851")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int PlayerLabel;
    [Token(Token = "0x4005852")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int StartArea;
    [Token(Token = "0x4005853")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string StartPointName;
    [Token(Token = "0x4005854")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int AreaGroupLabel;
    [Token(Token = "0x4005855")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int AreaSettingLabel;
    [Token(Token = "0x4005856")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int LayoutLabel;
    [Token(Token = "0x4005857")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int TalkBalloonEventLabel;
    [Token(Token = "0x4005858")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int TalkADVEventLabel;
    [Token(Token = "0x4005859")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int SystemMenuEventLabel;
    [Token(Token = "0x400585A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int soundEffectLabel;
    [Token(Token = "0x400585B")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int SubquestLabel;
    [Token(Token = "0x400585C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int CommunicationLabel;
    [Token(Token = "0x400585D")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int Facilitylabel;
    [Token(Token = "0x400585E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int telopLabel;
    [Token(Token = "0x400585F")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int RewardObjectLayoutLabel;
    [Token(Token = "0x4005860")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int FlavorObjectLabel;
    [Token(Token = "0x4005861")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int fasttravelLabel;
    [Token(Token = "0x4005862")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int MovableSound;
    [Token(Token = "0x4005863")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int shopLabel;

    [Token(Token = "0x17000FE9")]
    public int Key
    {
      [Token(Token = "0x6006916"), Address(RVA = "0x48CC2AC", Offset = "0x48CC2AC", VA = "0x48CC2AC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006917")]
    [Address(RVA = "0x48CC2B4", Offset = "0x48CC2B4", VA = "0x48CC2B4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006918")]
    [Address(RVA = "0x48CCB40", Offset = "0x48CCB40", VA = "0x48CCB40", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006919")]
    [Address(RVA = "0x48CCD0C", Offset = "0x48CCD0C", VA = "0x48CCD0C")]
    public StoryFreeActionSettingData()
    {
    }
  }
}

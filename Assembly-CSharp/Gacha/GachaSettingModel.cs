// Decompiled with JetBrains decompiler
// Type: Gacha.GachaSettingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq.SaveData;
using System;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001541")]
  internal class GachaSettingModel
  {
    [Token(Token = "0x40061A7")]
    [FieldOffset(Offset = "0x10")]
    private readonly GachaSettingSaveData gachaSettingSaveData;
    [Token(Token = "0x40061A8")]
    [FieldOffset(Offset = "0x18")]
    private bool isSkipGachaPlayback;
    [Token(Token = "0x40061A9")]
    [FieldOffset(Offset = "0x20")]
    private Action<bool> onSkipGachaPlaybackChanged;

    [Token(Token = "0x17001281")]
    public bool IsSkipGachaPlayback
    {
      [Token(Token = "0x6007861"), Address(RVA = "0x44F9F28", Offset = "0x44F9F28", VA = "0x44F9F28")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007862"), Address(RVA = "0x44F9F30", Offset = "0x44F9F30", VA = "0x44F9F30")] set
      {
      }
    }

    [Token(Token = "0x14000101")]
    public event Action<bool> OnSkipGachaPlaybackChanged
    {
      [Token(Token = "0x6007863"), Address(RVA = "0x44F9F9C", Offset = "0x44F9F9C", VA = "0x44F9F9C")] add
      {
      }
      [Token(Token = "0x6007864"), Address(RVA = "0x44FA05C", Offset = "0x44FA05C", VA = "0x44FA05C")] remove
      {
      }
    }

    [Token(Token = "0x6007865")]
    [Address(RVA = "0x44F7DF0", Offset = "0x44F7DF0", VA = "0x44F7DF0")]
    public GachaSettingModel(GachaSettingSaveData gachaSettingSaveData)
    {
    }

    [Token(Token = "0x6007866")]
    [Address(RVA = "0x44FA104", Offset = "0x44FA104", VA = "0x44FA104")]
    private void Initialize()
    {
    }
  }
}

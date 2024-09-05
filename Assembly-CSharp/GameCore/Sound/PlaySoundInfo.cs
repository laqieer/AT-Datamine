// Decompiled with JetBrains decompiler
// Type: GameCore.Sound.PlaySoundInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.Sound
{
  [Token(Token = "0x2000C3F")]
  public class PlaySoundInfo
  {
    [Token(Token = "0x4003781")]
    [FieldOffset(Offset = "0x10")]
    public string eventName;
    [Token(Token = "0x4003782")]
    [FieldOffset(Offset = "0x18")]
    public uint playingID;
    [Token(Token = "0x4003783")]
    [FieldOffset(Offset = "0x1C")]
    public bool endFlag;
    [Token(Token = "0x4003784")]
    [FieldOffset(Offset = "0x20")]
    public float endDuration;
    [Token(Token = "0x4003785")]
    [FieldOffset(Offset = "0x24")]
    public bool IsContinuePlayed;

    [Token(Token = "0x600466C")]
    [Address(RVA = "0x3516C14", Offset = "0x3516C14", VA = "0x3516C14")]
    public void Init()
    {
    }

    [Token(Token = "0x600466D")]
    [Address(RVA = "0x3516C74", Offset = "0x3516C74", VA = "0x3516C74")]
    public PlaySoundInfo()
    {
    }
  }
}

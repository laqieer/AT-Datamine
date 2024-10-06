// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000675")]
  public struct PropSettingData
  {
    [Token(Token = "0x4001F1A")]
    [FieldOffset(Offset = "0x0")]
    public int id;
    [Token(Token = "0x4001F1B")]
    [FieldOffset(Offset = "0x8")]
    public string attachObject;
    [Token(Token = "0x4001F1C")]
    [FieldOffset(Offset = "0x10")]
    public StoryIKSettingEnum ikObject;
    [Token(Token = "0x4001F1D")]
    [FieldOffset(Offset = "0x14")]
    public float ikPositionWeight;
    [Token(Token = "0x4001F1E")]
    [FieldOffset(Offset = "0x18")]
    public float ikRotationWeight;

    [Token(Token = "0x1700055F")]
    public bool IsValid
    {
      [Token(Token = "0x60024F7"), Address(RVA = "0x2F354DC", Offset = "0x2F354DC", VA = "0x2F354DC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60024F8")]
    [Address(RVA = "0x2F34E04", Offset = "0x2F34E04", VA = "0x2F34E04")]
    public StoryFreeActionPropData GetMasterData() => (StoryFreeActionPropData) null;
  }
}

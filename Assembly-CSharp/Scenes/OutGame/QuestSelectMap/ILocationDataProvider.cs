// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.ILocationDataProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033C2")]
  public interface ILocationDataProvider
  {
    [Token(Token = "0x6014589")]
    ILocationDataProvider.LocationData? GetLocationData(int locationHandleId);

    [Token(Token = "0x20033C3")]
    struct LocationData
    {
      [Token(Token = "0x400E0E1")]
      [FieldOffset(Offset = "0x0")]
      public string LocationName;
      [Token(Token = "0x400E0E2")]
      [FieldOffset(Offset = "0x8")]
      public float MapX;
      [Token(Token = "0x400E0E3")]
      [FieldOffset(Offset = "0xC")]
      public float MapY;
      [Token(Token = "0x400E0E4")]
      [FieldOffset(Offset = "0x10")]
      public int LandResourceHandleId;
    }
  }
}

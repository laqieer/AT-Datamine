// Decompiled with JetBrains decompiler
// Type: Gacha.SelectGacha.StyleSelectThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Gacha.SelectGacha
{
  [Token(Token = "0x200159F")]
  public class StyleSelectThumbResource
  {
    [Token(Token = "0x400631D")]
    [FieldOffset(Offset = "0x10")]
    public AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400631E")]
    [FieldOffset(Offset = "0x18")]
    public StyleData masterData;
    [Token(Token = "0x400631F")]
    [FieldOffset(Offset = "0x20")]
    public bool isSelected;
    [Token(Token = "0x4006320")]
    [FieldOffset(Offset = "0x28")]
    public Action<int> OnClickThumbnail;

    [Token(Token = "0x6007A87")]
    [Address(RVA = "0x229D768", Offset = "0x229D768", VA = "0x229D768")]
    public StyleSelectThumbResource()
    {
    }
  }
}

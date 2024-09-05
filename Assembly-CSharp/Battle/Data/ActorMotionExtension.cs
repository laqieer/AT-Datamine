// Decompiled with JetBrains decompiler
// Type: Battle.Data.ActorMotionExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Unit;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026F3")]
  public static class ActorMotionExtension
  {
    [Token(Token = "0x400A6A3")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<int, string> AssetGroupNameMap;

    [Token(Token = "0x600F11E")]
    [Address(RVA = "0x41AC044", Offset = "0x41AC044", VA = "0x41AC044")]
    public static string GetAssetGroupName(this Actor.AnimationType self) => (string) null;

    [Token(Token = "0x600F11F")]
    [Address(RVA = "0x41AC0DC", Offset = "0x41AC0DC", VA = "0x41AC0DC")]
    static ActorMotionExtension()
    {
    }
  }
}

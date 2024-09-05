// Decompiled with JetBrains decompiler
// Type: Battle.Data.ActorDirectionExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Unit;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026F4")]
  public static class ActorDirectionExtension
  {
    [Token(Token = "0x400A6A4")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<int, string> AssetSuffixNameMap;

    [Token(Token = "0x600F120")]
    [Address(RVA = "0x41AC204", Offset = "0x41AC204", VA = "0x41AC204")]
    public static Vector2 ToNormalizedVector(this Actor.Direction self) => new Vector2();

    [Token(Token = "0x600F121")]
    [Address(RVA = "0x41AC270", Offset = "0x41AC270", VA = "0x41AC270")]
    public static Vector2Int ToNormalizedXY(this Actor.Direction self) => new Vector2Int();

    [Token(Token = "0x600F122")]
    [Address(RVA = "0x41AC2EC", Offset = "0x41AC2EC", VA = "0x41AC2EC")]
    public static Quaternion GetSkillEffectRotOffset(this Actor.Direction self, bool isReverse = false)
    {
      return new Quaternion();
    }

    [Token(Token = "0x600F123")]
    [Address(RVA = "0x41AC3A4", Offset = "0x41AC3A4", VA = "0x41AC3A4")]
    public static string GetAssetSuffix(this Actor.Direction self) => (string) null;

    [Token(Token = "0x600F124")]
    [Address(RVA = "0x41AC43C", Offset = "0x41AC43C", VA = "0x41AC43C")]
    static ActorDirectionExtension()
    {
    }
  }
}

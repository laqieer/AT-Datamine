// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponTypeEnumExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001406")]
  public static class WeaponTypeEnumExtension
  {
    [Token(Token = "0x4005CF2")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<int, string> AssetDirNameMap;
    [Token(Token = "0x4005CF3")]
    [FieldOffset(Offset = "0x8")]
    private static readonly Dictionary<int, string> AssetGroupNameMap;

    [Token(Token = "0x60070F6")]
    [Address(RVA = "0x421D5D0", Offset = "0x421D5D0", VA = "0x421D5D0")]
    public static string GetAssetGroupDirName(this WeaponTypeEnum self) => (string) null;

    [Token(Token = "0x60070F7")]
    [Address(RVA = "0x421D668", Offset = "0x421D668", VA = "0x421D668")]
    public static string GetAssetGroupName(this WeaponTypeEnum self) => (string) null;

    [Token(Token = "0x60070F8")]
    [Address(RVA = "0x421D700", Offset = "0x421D700", VA = "0x421D700")]
    static WeaponTypeEnumExtension()
    {
    }
  }
}

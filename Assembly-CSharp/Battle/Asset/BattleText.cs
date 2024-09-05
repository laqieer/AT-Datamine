// Decompiled with JetBrains decompiler
// Type: Battle.Asset.BattleText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Battle.Asset
{
  [Token(Token = "0x20022C3")]
  public static class BattleText
  {
    [Token(Token = "0x40092F8")]
    private const string SystemAbName = "text_system";
    [Token(Token = "0x40092F9")]
    private const string BattleAbName = "text_system_battle";

    [Token(Token = "0x600D406")]
    [Address(RVA = "0x19DCE6C", Offset = "0x19DCE6C", VA = "0x19DCE6C")]
    public static IEnumerator Load() => (IEnumerator) null;

    [Token(Token = "0x600D407")]
    [Address(RVA = "0x19DCEF4", Offset = "0x19DCEF4", VA = "0x19DCEF4")]
    public static string GetText(string key) => (string) null;

    [Token(Token = "0x600D408")]
    [Address(RVA = "0x19D298C", Offset = "0x19D298C", VA = "0x19D298C")]
    public static string GetBattleText(string key) => (string) null;

    [Token(Token = "0x600D409")]
    [Address(RVA = "0x19DCF58", Offset = "0x19DCF58", VA = "0x19DCF58")]
    public static string GetCommonText(string key) => (string) null;
  }
}

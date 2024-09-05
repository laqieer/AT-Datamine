// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleDecision
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002685")]
  public abstract class BattleDecision
  {
    [Token(Token = "0x600EE78")]
    public abstract BattleResult Check(BattleCore core);

    [Token(Token = "0x600EE79")]
    [Address(RVA = "0x44477C0", Offset = "0x44477C0", VA = "0x44477C0")]
    public static string GetWinningDetailText(int id) => (string) null;

    [Token(Token = "0x600EE7A")]
    [Address(RVA = "0x4447868", Offset = "0x4447868", VA = "0x4447868")]
    public static string GetLosingDetailText(int id) => (string) null;

    [Token(Token = "0x600EE7B")]
    [Address(RVA = "0x4447910", Offset = "0x4447910", VA = "0x4447910")]
    protected BattleDecision()
    {
    }
  }
}

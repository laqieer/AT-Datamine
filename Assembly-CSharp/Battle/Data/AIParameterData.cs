// Decompiled with JetBrains decompiler
// Type: Battle.Data.AIParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002716")]
  public class AIParameterData
  {
    [Token(Token = "0x400A731")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string InteractCountOnPhase;
    [Token(Token = "0x400A732")]
    [FieldOffset(Offset = "0x10")]
    public int unitId;
    [Token(Token = "0x400A733")]
    [FieldOffset(Offset = "0x14")]
    public int currentModuleIndex;
    [Token(Token = "0x400A734")]
    [FieldOffset(Offset = "0x18")]
    public int fierceModuleIndex;
    [Token(Token = "0x400A735")]
    [FieldOffset(Offset = "0x20")]
    public Dictionary<string, int> variables;
    [Token(Token = "0x400A736")]
    [FieldOffset(Offset = "0x28")]
    public Hate hate;

    [Token(Token = "0x170033A6")]
    public bool WithoutArts
    {
      [Token(Token = "0x600F2AB"), Address(RVA = "0x41BA15C", Offset = "0x41BA15C", VA = "0x41BA15C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F2AC"), Address(RVA = "0x41BA164", Offset = "0x41BA164", VA = "0x41BA164")] private set
      {
      }
    }

    [Token(Token = "0x170033A7")]
    public bool WithoutStratagem
    {
      [Token(Token = "0x600F2AD"), Address(RVA = "0x41BA170", Offset = "0x41BA170", VA = "0x41BA170")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F2AE"), Address(RVA = "0x41BA178", Offset = "0x41BA178", VA = "0x41BA178")] private set
      {
      }
    }

    [Token(Token = "0x170033A8")]
    public int TargetChestId
    {
      [Token(Token = "0x600F2AF"), Address(RVA = "0x41BA184", Offset = "0x41BA184", VA = "0x41BA184")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2B0"), Address(RVA = "0x41BA18C", Offset = "0x41BA18C", VA = "0x41BA18C")] set
      {
      }
    }

    [Token(Token = "0x600F2B1")]
    [Address(RVA = "0x41BA194", Offset = "0x41BA194", VA = "0x41BA194")]
    public void ApplyAfterCommandParam(
      int unitId,
      int currentModuleIndex,
      int fierceModuleIndex,
      Dictionary<string, int> variables)
    {
    }

    [Token(Token = "0x600F2B2")]
    [Address(RVA = "0x41BA1A4", Offset = "0x41BA1A4", VA = "0x41BA1A4")]
    public void AffectAutoOption(bool unuseArts, bool unuseStratagem)
    {
    }

    [Token(Token = "0x600F2B3")]
    [Address(RVA = "0x41BA1B8", Offset = "0x41BA1B8", VA = "0x41BA1B8")]
    public void SetVariable(string key, int value)
    {
    }

    [Token(Token = "0x600F2B4")]
    [Address(RVA = "0x41BA220", Offset = "0x41BA220", VA = "0x41BA220")]
    public int GetVariable(string key) => new int();

    [Token(Token = "0x600F2B5")]
    [Address(RVA = "0x41BA298", Offset = "0x41BA298", VA = "0x41BA298")]
    public AIParameterData Copy() => (AIParameterData) null;

    [Token(Token = "0x600F2B6")]
    [Address(RVA = "0x41BA5E4", Offset = "0x41BA5E4", VA = "0x41BA5E4")]
    public AIParameterData()
    {
    }

    [Token(Token = "0x600F2B7")]
    [Address(RVA = "0x41BA5F4", Offset = "0x41BA5F4", VA = "0x41BA5F4")]
    static AIParameterData()
    {
    }
  }
}

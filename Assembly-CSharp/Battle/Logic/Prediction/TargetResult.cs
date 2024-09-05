// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.TargetResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x2002504")]
  public sealed class TargetResult
  {
    [Token(Token = "0x4009F14")]
    [FieldOffset(Offset = "0x10")]
    public int TargetUnitId;
    [Token(Token = "0x4009F15")]
    [FieldOffset(Offset = "0x14")]
    public (int x, int y) TargetUnitCoord;
    [Token(Token = "0x4009F16")]
    [FieldOffset(Offset = "0x20")]
    public UnitParameterChange Before;
    [Token(Token = "0x4009F17")]
    [FieldOffset(Offset = "0x28")]
    public UnitParameterChange After;

    [Token(Token = "0x600E48D")]
    [Address(RVA = "0x477ED80", Offset = "0x477ED80", VA = "0x477ED80")]
    public TargetResult(TargetPair target)
    {
    }
  }
}

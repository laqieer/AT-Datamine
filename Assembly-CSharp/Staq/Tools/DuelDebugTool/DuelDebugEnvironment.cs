// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.DuelDebugEnvironment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000980")]
  [Serializable]
  public class DuelDebugEnvironment : IDuelDebugToolEnvironmentSettings
  {
    [Token(Token = "0x4002C2F")]
    [FieldOffset(Offset = "0x10")]
    public int EnvironmentId;
    [Token(Token = "0x4002C30")]
    [FieldOffset(Offset = "0x14")]
    public bool EnableObliviae;
    [Token(Token = "0x4002C31")]
    [FieldOffset(Offset = "0x18")]
    public BattleBgColorIdEnum obliviaeBgEnum;

    [Token(Token = "0x600360A")]
    [Address(RVA = "0x35313FC", Offset = "0x35313FC", VA = "0x35313FC")]
    public static DuelDebugEnvironment CreateDefault() => (DuelDebugEnvironment) null;

    [Token(Token = "0x600360B")]
    [Address(RVA = "0x3531824", Offset = "0x3531824", VA = "0x3531824", Slot = "4")]
    public string GetSceneName() => (string) null;

    [Token(Token = "0x600360C")]
    [Address(RVA = "0x353181C", Offset = "0x353181C", VA = "0x353181C")]
    public DuelDebugEnvironment()
    {
    }
  }
}

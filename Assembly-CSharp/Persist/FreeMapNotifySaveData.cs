// Decompiled with JetBrains decompiler
// Type: Persist.FreeMapNotifySaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Persist
{
  [Token(Token = "0x20009EB")]
  public class FreeMapNotifySaveData : FlgSaveData
  {
    [Token(Token = "0x4002DEF")]
    [FieldOffset(Offset = "0x0")]
    public static readonly FreeMapNotifySaveData CommuOpened;
    [Token(Token = "0x4002DF0")]
    [FieldOffset(Offset = "0x8")]
    private static readonly FlgSaveData[] saveDatas;

    [Token(Token = "0x6003881")]
    [Address(RVA = "0x310D8F8", Offset = "0x310D8F8", VA = "0x310D8F8")]
    public static void Init()
    {
    }

    [Token(Token = "0x6003882")]
    [Address(RVA = "0x310DAA4", Offset = "0x310DAA4", VA = "0x310DAA4")]
    public static void LoadALL()
    {
    }

    [Token(Token = "0x6003883")]
    [Address(RVA = "0x310DB98", Offset = "0x310DB98", VA = "0x310DB98")]
    public FreeMapNotifySaveData(string fileName)
    {
    }

    [Token(Token = "0x6003884")]
    [Address(RVA = "0x310D9EC", Offset = "0x310D9EC", VA = "0x310D9EC")]
    private static void Foreach(Action<FlgSaveData> action)
    {
    }

    [Token(Token = "0x6003885")]
    [Address(RVA = "0x310DB9C", Offset = "0x310DB9C", VA = "0x310DB9C")]
    static FreeMapNotifySaveData()
    {
    }
  }
}

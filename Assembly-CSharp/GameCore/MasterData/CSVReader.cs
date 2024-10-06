// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CSVReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013CD")]
  public class CSVReader
  {
    [Token(Token = "0x4005CA2")]
    [FieldOffset(Offset = "0x10")]
    public byte[] Buffer;
    [Token(Token = "0x4005CA3")]
    [FieldOffset(Offset = "0x18")]
    public Stream Stream;
    [Token(Token = "0x4005CA4")]
    [FieldOffset(Offset = "0x20")]
    public bool BOMReaded;
    [Token(Token = "0x4005CA5")]
    [FieldOffset(Offset = "0x24")]
    private CSVParser Parser;

    [Token(Token = "0x6006F2F")]
    [Address(RVA = "0x4711EB8", Offset = "0x4711EB8", VA = "0x4711EB8")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern int ParseColumn(byte[] buf, ref CSVParser parser);

    [Token(Token = "0x6006F30")]
    [Address(RVA = "0x4711F44", Offset = "0x4711F44", VA = "0x4711F44")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern int ParseInt32(byte[] buf, ref CSVParser parser, out int value);

    [Token(Token = "0x6006F31")]
    [Address(RVA = "0x4711FE0", Offset = "0x4711FE0", VA = "0x4711FE0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern int ParseUInt32(byte[] buf, ref CSVParser parser, out uint value);

    [Token(Token = "0x6006F32")]
    [Address(RVA = "0x471207C", Offset = "0x471207C", VA = "0x471207C")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern int ParseSingle(byte[] buf, ref CSVParser parser, out float value);

    [Token(Token = "0x6006F33")]
    [Address(RVA = "0x4712118", Offset = "0x4712118", VA = "0x4712118")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern int ParseDouble(byte[] buf, ref CSVParser parser, out double value);

    [Token(Token = "0x6006F34")]
    [Address(RVA = "0x47121B4", Offset = "0x47121B4", VA = "0x47121B4")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern int ParseDateTime(byte[] buf, ref CSVParser parser, out CSVDateTime dt);

    [Token(Token = "0x6006F35")]
    [Address(RVA = "0x4712250", Offset = "0x4712250", VA = "0x4712250")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern int ParseBoolean(byte[] buf, ref CSVParser parser, out int value);

    [Token(Token = "0x6006F36")]
    [Address(RVA = "0x47122EC", Offset = "0x47122EC", VA = "0x47122EC")]
    public CSVReader(Stream input)
    {
    }

    [Token(Token = "0x6006F37")]
    [Address(RVA = "0x4712358", Offset = "0x4712358", VA = "0x4712358")]
    public void UpdateBuffer()
    {
    }

    [Token(Token = "0x6006F38")]
    [Address(RVA = "0x47123E4", Offset = "0x47123E4", VA = "0x47123E4")]
    public int PeekChar() => new int();

    [Token(Token = "0x6006F39")]
    [Address(RVA = "0x4712440", Offset = "0x4712440", VA = "0x4712440")]
    public void InitParser()
    {
    }

    [Token(Token = "0x6006F3A")]
    [Address(RVA = "0x4712454", Offset = "0x4712454", VA = "0x4712454")]
    public CSVColumn ReadColumn() => new CSVColumn();

    [Token(Token = "0x6006F3B")]
    [Address(RVA = "0x47124A8", Offset = "0x47124A8", VA = "0x47124A8")]
    public string ReadString() => (string) null;

    [Token(Token = "0x6006F3C")]
    [Address(RVA = "0x4712500", Offset = "0x4712500", VA = "0x4712500")]
    public int ReadInt32() => new int();

    [Token(Token = "0x6006F3D")]
    [Address(RVA = "0x4712558", Offset = "0x4712558", VA = "0x4712558")]
    public uint ReadUInt32() => new uint();

    [Token(Token = "0x6006F3E")]
    [Address(RVA = "0x47125B0", Offset = "0x47125B0", VA = "0x47125B0")]
    public float ReadSingle() => new float();

    [Token(Token = "0x6006F3F")]
    [Address(RVA = "0x4712608", Offset = "0x4712608", VA = "0x4712608")]
    public double ReadDouble() => new double();

    [Token(Token = "0x6006F40")]
    [Address(RVA = "0x4712660", Offset = "0x4712660", VA = "0x4712660")]
    public bool ReadBoolean() => new bool();

    [Token(Token = "0x6006F41")]
    [Address(RVA = "0x47126C0", Offset = "0x47126C0", VA = "0x47126C0")]
    public DateTime ReadDateTime() => new DateTime();
  }
}

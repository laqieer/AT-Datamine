// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MasterDataBinaryReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013E3")]
  public class MasterDataBinaryReader : IMasterDataReader, IDisposable
  {
    [Token(Token = "0x4005CD5")]
    [FieldOffset(Offset = "0x10")]
    private bool HeaderReaded;
    [Token(Token = "0x4005CD6")]
    [FieldOffset(Offset = "0x11")]
    private bool disposed;
    [Token(Token = "0x4005CD7")]
    [FieldOffset(Offset = "0x18")]
    private BinaryReader Reader;

    [Token(Token = "0x6006F94")]
    [Address(RVA = "0x4206428", Offset = "0x4206428", VA = "0x4206428")]
    public MasterDataBinaryReader(Stream input)
    {
    }

    [Token(Token = "0x6006F95")]
    [Address(RVA = "0x42064A4", Offset = "0x42064A4", VA = "0x42064A4", Slot = "1")]
    ~MasterDataBinaryReader()
    {
    }

    [Token(Token = "0x6006F96")]
    [Address(RVA = "0x4206548", Offset = "0x4206548", VA = "0x4206548", Slot = "13")]
    public void Dispose()
    {
    }

    [Token(Token = "0x6006F97")]
    [Address(RVA = "0x42065B8", Offset = "0x42065B8", VA = "0x42065B8", Slot = "14")]
    protected virtual void Dispose(bool disposing)
    {
    }

    [Token(Token = "0x6006F98")]
    [Address(RVA = "0x42065F0", Offset = "0x42065F0", VA = "0x42065F0", Slot = "4")]
    public int PeekChar() => new int();

    [Token(Token = "0x6006F99")]
    [Address(RVA = "0x4206610", Offset = "0x4206610", VA = "0x4206610", Slot = "6")]
    public int ReadInt32() => new int();

    [Token(Token = "0x6006F9A")]
    [Address(RVA = "0x4206634", Offset = "0x4206634", VA = "0x4206634", Slot = "5")]
    public uint ReadUInt32() => new uint();

    [Token(Token = "0x6006F9B")]
    [Address(RVA = "0x4206658", Offset = "0x4206658", VA = "0x4206658", Slot = "7")]
    public string ReadStringEx() => (string) null;

    [Token(Token = "0x6006F9C")]
    [Address(RVA = "0x4206664", Offset = "0x4206664", VA = "0x4206664", Slot = "8")]
    public DateTime ReadDateTime() => new DateTime();

    [Token(Token = "0x6006F9D")]
    [Address(RVA = "0x4206670", Offset = "0x4206670", VA = "0x4206670", Slot = "9")]
    public float ReadSingle() => new float();

    [Token(Token = "0x6006F9E")]
    [Address(RVA = "0x4206694", Offset = "0x4206694", VA = "0x4206694", Slot = "10")]
    public double ReadDouble() => new double();

    [Token(Token = "0x6006F9F")]
    [Address(RVA = "0x42066B8", Offset = "0x42066B8", VA = "0x42066B8", Slot = "11")]
    public bool ReadBoolean() => new bool();

    [Token(Token = "0x6006FA0")]
    [Address(RVA = "0x42066D8", Offset = "0x42066D8", VA = "0x42066D8", Slot = "12")]
    public void ReadIntArray(int size, ref int[] dst)
    {
    }
  }
}

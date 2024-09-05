// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MasterDataCSVReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013E4")]
  public class MasterDataCSVReader : IMasterDataReader
  {
    [Token(Token = "0x4005CD8")]
    [FieldOffset(Offset = "0x10")]
    private bool HeaderReaded;
    [Token(Token = "0x4005CD9")]
    [FieldOffset(Offset = "0x18")]
    private CSVReader Reader;

    [Token(Token = "0x6006FA1")]
    [Address(RVA = "0x42066E4", Offset = "0x42066E4", VA = "0x42066E4")]
    public MasterDataCSVReader(Stream input)
    {
    }

    [Token(Token = "0x6006FA2")]
    [Address(RVA = "0x4206760", Offset = "0x4206760", VA = "0x4206760", Slot = "4")]
    public int PeekChar() => new int();

    [Token(Token = "0x6006FA3")]
    [Address(RVA = "0x4206784", Offset = "0x4206784", VA = "0x4206784")]
    public void ReadHeader()
    {
    }

    [Token(Token = "0x6006FA4")]
    [Address(RVA = "0x42067C8", Offset = "0x42067C8", VA = "0x42067C8", Slot = "6")]
    public int ReadInt32() => new int();

    [Token(Token = "0x6006FA5")]
    [Address(RVA = "0x42067EC", Offset = "0x42067EC", VA = "0x42067EC", Slot = "5")]
    public uint ReadUInt32() => new uint();

    [Token(Token = "0x6006FA6")]
    [Address(RVA = "0x4206810", Offset = "0x4206810", VA = "0x4206810", Slot = "7")]
    public string ReadStringEx() => (string) null;

    [Token(Token = "0x6006FA7")]
    [Address(RVA = "0x4206834", Offset = "0x4206834", VA = "0x4206834", Slot = "8")]
    public DateTime ReadDateTime() => new DateTime();

    [Token(Token = "0x6006FA8")]
    [Address(RVA = "0x4206858", Offset = "0x4206858", VA = "0x4206858", Slot = "9")]
    public float ReadSingle() => new float();

    [Token(Token = "0x6006FA9")]
    [Address(RVA = "0x420687C", Offset = "0x420687C", VA = "0x420687C", Slot = "10")]
    public double ReadDouble() => new double();

    [Token(Token = "0x6006FAA")]
    [Address(RVA = "0x42068A0", Offset = "0x42068A0", VA = "0x42068A0", Slot = "11")]
    public bool ReadBoolean() => new bool();

    [Token(Token = "0x6006FAB")]
    [Address(RVA = "0x42068C4", Offset = "0x42068C4", VA = "0x42068C4", Slot = "12")]
    public void ReadIntArray(int size, ref int[] dst)
    {
    }
  }
}

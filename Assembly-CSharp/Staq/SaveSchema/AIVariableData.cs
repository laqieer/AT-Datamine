// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AIVariableData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C8C")]
  public struct AIVariableData : IFlatbufferObject
  {
    [Token(Token = "0x4010BEB")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E76")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601806F"), Address(RVA = "0x3B1C3D0", Offset = "0x3B1C3D0", VA = "0x3B1C3D0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018070")]
    [Address(RVA = "0x3B1C3D8", Offset = "0x3B1C3D8", VA = "0x3B1C3D8")]
    public static AIVariableData GetRootAsAIVariableData(ByteBuffer _bb) => new AIVariableData();

    [Token(Token = "0x6018071")]
    [Address(RVA = "0x3B1C3E4", Offset = "0x3B1C3E4", VA = "0x3B1C3E4")]
    public static AIVariableData GetRootAsAIVariableData(ByteBuffer _bb, AIVariableData obj)
    {
      return new AIVariableData();
    }

    [Token(Token = "0x6018072")]
    [Address(RVA = "0x3B1C428", Offset = "0x3B1C428", VA = "0x3B1C428", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018073")]
    [Address(RVA = "0x3B1BD40", Offset = "0x3B1BD40", VA = "0x3B1BD40")]
    public AIVariableData __assign(int _i, ByteBuffer _bb) => new AIVariableData();

    [Token(Token = "0x17004E77")]
    public string Key
    {
      [Token(Token = "0x6018074"), Address(RVA = "0x3B1C434", Offset = "0x3B1C434", VA = "0x3B1C434")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018075")]
    [Address(RVA = "0x3B1C470", Offset = "0x3B1C470", VA = "0x3B1C470")]
    public ArraySegment<byte>? GetKeyBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018076")]
    [Address(RVA = "0x3B1C4A8", Offset = "0x3B1C4A8", VA = "0x3B1C4A8")]
    public byte[] GetKeyArray() => (byte[]) null;

    [Token(Token = "0x17004E78")]
    public int Value
    {
      [Token(Token = "0x6018077"), Address(RVA = "0x3B1C4F4", Offset = "0x3B1C4F4", VA = "0x3B1C4F4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018078")]
    [Address(RVA = "0x3B1C538", Offset = "0x3B1C538", VA = "0x3B1C538")]
    public static Offset<AIVariableData> CreateAIVariableData(
      FlatBufferBuilder builder,
      StringOffset keyOffset = default (StringOffset),
      int value = 0)
    {
      return new Offset<AIVariableData>();
    }

    [Token(Token = "0x6018079")]
    [Address(RVA = "0x3B1C620", Offset = "0x3B1C620", VA = "0x3B1C620")]
    public static void StartAIVariableData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601807A")]
    [Address(RVA = "0x3B1C5B0", Offset = "0x3B1C5B0", VA = "0x3B1C5B0")]
    public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
    {
    }

    [Token(Token = "0x601807B")]
    [Address(RVA = "0x3B1C590", Offset = "0x3B1C590", VA = "0x3B1C590")]
    public static void AddValue(FlatBufferBuilder builder, int value)
    {
    }

    [Token(Token = "0x601807C")]
    [Address(RVA = "0x3B1C5D0", Offset = "0x3B1C5D0", VA = "0x3B1C5D0")]
    public static Offset<AIVariableData> EndAIVariableData(FlatBufferBuilder builder)
    {
      return new Offset<AIVariableData>();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: EasySerializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x20001E2")]
public class EasySerializer
{
  [Token(Token = "0x6000C1A")]
  [Address(RVA = "0x4C72D00", Offset = "0x4C72D00", VA = "0x4C72D00")]
  public static byte[] SerializeObjectToMemory(object serializableObject) => (byte[]) null;

  [Token(Token = "0x6000C1B")]
  [Address(RVA = "0x4C72F78", Offset = "0x4C72F78", VA = "0x4C72F78")]
  public static object DeserializeObjectFromMemory(byte[] buf) => (object) null;

  [Token(Token = "0x6000C1C")]
  [Address(RVA = "0x4C73174", Offset = "0x4C73174", VA = "0x4C73174")]
  public static void SerializeObjectToFile(object serializableObject, string filePath)
  {
  }

  [Token(Token = "0x6000C1D")]
  [Address(RVA = "0x4C7335C", Offset = "0x4C7335C", VA = "0x4C7335C")]
  public static object DeserializeObjectFromFile(string filePath) => (object) null;

  [Token(Token = "0x6000C1E")]
  [Address(RVA = "0x4C72F14", Offset = "0x4C72F14", VA = "0x4C72F14")]
  private static void SetEnvironmentVariables()
  {
  }

  [Token(Token = "0x6000C1F")]
  [Address(RVA = "0x4C735E4", Offset = "0x4C735E4", VA = "0x4C735E4")]
  public EasySerializer()
  {
  }
}

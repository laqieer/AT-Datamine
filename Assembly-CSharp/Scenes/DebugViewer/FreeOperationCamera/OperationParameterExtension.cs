// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.FreeOperationCamera.OperationParameterExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.DebugViewer.FreeOperationCamera
{
  [Token(Token = "0x2002F73")]
  public static class OperationParameterExtension
  {
    [Token(Token = "0x400CB30")]
    [FieldOffset(Offset = "0x0")]
    private static readonly float[] SpeedRate;

    [Token(Token = "0x60128D1")]
    [Address(RVA = "0x21272B8", Offset = "0x21272B8", VA = "0x21272B8")]
    public static OperationParameter Adjust(this OperationParameter self, SpeedModeType type)
    {
      return new OperationParameter();
    }

    [Token(Token = "0x60128D2")]
    [Address(RVA = "0x21273AC", Offset = "0x21273AC", VA = "0x21273AC")]
    static OperationParameterExtension()
    {
    }
  }
}

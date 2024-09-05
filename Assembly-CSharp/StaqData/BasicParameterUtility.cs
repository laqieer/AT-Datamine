// Decompiled with JetBrains decompiler
// Type: StaqData.BasicParameterUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FE7")]
  public static class BasicParameterUtility
  {
    [Token(Token = "0x400881E")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Dictionary<int, string> BasicParameterLabel;

    [Token(Token = "0x600BD88")]
    [Address(RVA = "0x1E59348", Offset = "0x1E59348", VA = "0x1E59348")]
    public static BasicParameter CreateFromSchema(staq.SaveSchema.BasicParameter schema)
    {
      return (BasicParameter) null;
    }

    [Token(Token = "0x600BD89")]
    [Address(RVA = "0x1E5945C", Offset = "0x1E5945C", VA = "0x1E5945C")]
    public static int GetParameter(this BasicParameterType parameterType, IBasicParameter parameter)
    {
      return new int();
    }

    [Token(Token = "0x600BD8A")]
    [Address(RVA = "0x1E59730", Offset = "0x1E59730", VA = "0x1E59730")]
    public static float Total(this IBasicParameter param) => new float();

    [Token(Token = "0x600BD8B")]
    [Address(RVA = "0x1E59AA8", Offset = "0x1E59AA8", VA = "0x1E59AA8")]
    static BasicParameterUtility()
    {
    }
  }
}

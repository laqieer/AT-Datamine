// Decompiled with JetBrains decompiler
// Type: ADV2.Utility.ObjectSupport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2.Utility
{
  [Token(Token = "0x2003EFF")]
  public class ObjectSupport
  {
    [Token(Token = "0x601975F")]
    [Address(RVA = "0x373F2FC", Offset = "0x373F2FC", VA = "0x373F2FC")]
    public static Object InstantiatePrefab(Object originalObject) => (Object) null;

    [Token(Token = "0x6019760")]
    [Address(RVA = "0x373F354", Offset = "0x373F354", VA = "0x373F354")]
    public static void Destroy(GameObject gameObject)
    {
    }

    [Token(Token = "0x6019761")]
    public static void RemoveComponents<T>(GameObject rootObject) where T : Object
    {
    }

    [Token(Token = "0x6019762")]
    [Address(RVA = "0x373F3CC", Offset = "0x373F3CC", VA = "0x373F3CC")]
    public ObjectSupport()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Input.RichTextTagEraser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Diagnostics;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Input
{
  [Token(Token = "0x2003537")]
  public class RichTextTagEraser
  {
    [Token(Token = "0x400E772")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string nameTextParser;

    [Token(Token = "0x17004528")]
    public TextMeshPro TextParser
    {
      [Token(Token = "0x6014DCE"), Address(RVA = "0x1B416D0", Offset = "0x1B416D0", VA = "0x1B416D0")] get
      {
        return (TextMeshPro) null;
      }
      [Token(Token = "0x6014DCF"), Address(RVA = "0x1B416D8", Offset = "0x1B416D8", VA = "0x1B416D8")] private set
      {
      }
    }

    [Token(Token = "0x6014DD0")]
    [Address(RVA = "0x1B416E0", Offset = "0x1B416E0", VA = "0x1B416E0")]
    public RichTextTagEraser(TMP_Text baseText, Transform parent)
    {
    }

    [Token(Token = "0x6014DD1")]
    [Address(RVA = "0x1B41908", Offset = "0x1B41908", VA = "0x1B41908")]
    public bool EraseTag(TMP_InputField target) => new bool();

    [Token(Token = "0x6014DD2")]
    [Address(RVA = "0x1B419DC", Offset = "0x1B419DC", VA = "0x1B419DC")]
    [Conditional("UNITY_EDITOR")]
    private void DebugLogErasedTag(string before, string after)
    {
    }

    [Token(Token = "0x6014DD3")]
    [Address(RVA = "0x1B419E0", Offset = "0x1B419E0", VA = "0x1B419E0")]
    static RichTextTagEraser()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.GUIToggleLikeButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.DebugViewer
{
  [Token(Token = "0x2002F18")]
  public class GUIToggleLikeButton
  {
    [Token(Token = "0x400CA19")]
    [FieldOffset(Offset = "0x20")]
    private string text;

    [Token(Token = "0x1400018C")]
    public event Action<bool> OnChange
    {
      [Token(Token = "0x6012666"), Address(RVA = "0x23044BC", Offset = "0x23044BC", VA = "0x23044BC")] add
      {
      }
      [Token(Token = "0x6012667"), Address(RVA = "0x230456C", Offset = "0x230456C", VA = "0x230456C")] remove
      {
      }
    }

    [Token(Token = "0x17003E64")]
    public bool Value
    {
      [Token(Token = "0x6012668"), Address(RVA = "0x230461C", Offset = "0x230461C", VA = "0x230461C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6012669"), Address(RVA = "0x2304624", Offset = "0x2304624", VA = "0x2304624")] private set
      {
      }
    }

    [Token(Token = "0x601266A")]
    [Address(RVA = "0x2304630", Offset = "0x2304630", VA = "0x2304630")]
    public GUIToggleLikeButton(string text, bool value)
    {
    }

    [Token(Token = "0x601266B")]
    [Address(RVA = "0x23046A8", Offset = "0x23046A8", VA = "0x23046A8")]
    public void Show()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: TMPro.RubyTextMeshProUGUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text.RegularExpressions;
using UnityEngine;

#nullable disable
namespace TMPro
{
  [Token(Token = "0x2000379")]
  public class RubyTextMeshProUGUI : TextMeshProUGUI
  {
    [Token(Token = "0x4001454")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Regex RubyRegex;
    [Token(Token = "0x4001455")]
    [FieldOffset(Offset = "0x7A0")]
    [Tooltip("v offset ruby. (em, px, %).")]
    [SerializeField]
    private string rubyVerticalOffset;
    [Token(Token = "0x4001456")]
    [FieldOffset(Offset = "0x7A8")]
    [SerializeField]
    [Tooltip("ruby scale. (1=100%)")]
    private float rubyScale;
    [Token(Token = "0x4001457")]
    [FieldOffset(Offset = "0x7AC")]
    [SerializeField]
    [Tooltip("ruby show type.")]
    private RubyTextMeshProUGUI.RubyShowType rubyShowType;
    [Token(Token = "0x4001458")]
    [FieldOffset(Offset = "0x7B0")]
    [SerializeField]
    [Tooltip("all v compensation ruby.")]
    private bool allVCompensationRuby;
    [Token(Token = "0x4001459")]
    [FieldOffset(Offset = "0x7B8")]
    [Tooltip("all ruby v compensation. (em, px, %).")]
    [SerializeField]
    private string allVCompensationRubyLineHeight;
    [Token(Token = "0x400145A")]
    [FieldOffset(Offset = "0x7C0")]
    [SerializeField]
    [TextArea(5, 10)]
    private string m_uneditedText;

    [Token(Token = "0x170001F0")]
    public string UnditedText
    {
      [Token(Token = "0x60013E7"), Address(RVA = "0x2521DD8", Offset = "0x2521DD8", VA = "0x2521DD8")] set
      {
      }
    }

    [Token(Token = "0x60013E8")]
    [Address(RVA = "0x2521DE0", Offset = "0x2521DE0", VA = "0x2521DE0")]
    private void SetTextCustom(string value)
    {
    }

    [Token(Token = "0x60013E9")]
    [Address(RVA = "0x2522634", Offset = "0x2522634", VA = "0x2522634", Slot = "106")]
    public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
    {
    }

    [Token(Token = "0x60013EA")]
    [Address(RVA = "0x2521E34", Offset = "0x2521E34", VA = "0x2521E34")]
    private string ReplaceRubyTags(string str) => (string) null;

    [Token(Token = "0x60013EB")]
    [Address(RVA = "0x25226AC", Offset = "0x25226AC", VA = "0x25226AC")]
    private string CreateReplaceValue(
      string baseText,
      string rubyText,
      float rubyTextOffset,
      float compensationOffset,
      bool isRightToLeftText)
    {
      return (string) null;
    }

    [Token(Token = "0x60013EC")]
    [Address(RVA = "0x2522C28", Offset = "0x2522C28", VA = "0x2522C28")]
    public RubyTextMeshProUGUI()
    {
    }

    [Token(Token = "0x60013ED")]
    [Address(RVA = "0x2522CC8", Offset = "0x2522CC8", VA = "0x2522CC8")]
    static RubyTextMeshProUGUI()
    {
    }

    [Token(Token = "0x200037A")]
    protected enum RubyShowType
    {
      [Token(Token = "0x400145C")] RUBY_ALIGNMENT,
      [Token(Token = "0x400145D")] BASE_ALIGNMENT,
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: TMPro.RubyTextMeshPro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text.RegularExpressions;
using UnityEngine;

#nullable disable
namespace TMPro
{
  [Token(Token = "0x2000377")]
  public class RubyTextMeshPro : TextMeshPro
  {
    [Token(Token = "0x400144A")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Regex RubyRegex;
    [Token(Token = "0x400144B")]
    [FieldOffset(Offset = "0x768")]
    [SerializeField]
    [Tooltip("v offset ruby. (em, px, %).")]
    private string rubyVerticalOffset;
    [Token(Token = "0x400144C")]
    [FieldOffset(Offset = "0x770")]
    [SerializeField]
    [Tooltip("ruby scale. (1=100%)")]
    private float rubyScale;
    [Token(Token = "0x400144D")]
    [FieldOffset(Offset = "0x774")]
    [Tooltip("ruby show type.")]
    [SerializeField]
    private RubyTextMeshPro.RubyShowType rubyShowType;
    [Token(Token = "0x400144E")]
    [FieldOffset(Offset = "0x778")]
    [Tooltip("all v compensation ruby.")]
    [SerializeField]
    private bool allVCompensationRuby;
    [Token(Token = "0x400144F")]
    [FieldOffset(Offset = "0x780")]
    [Tooltip("all ruby v compensation. (em, px, %).")]
    [SerializeField]
    private string allVCompensationRubyLineHeight;
    [Token(Token = "0x4001450")]
    [FieldOffset(Offset = "0x788")]
    [SerializeField]
    [TextArea(5, 10)]
    private string m_uneditedText;

    [Token(Token = "0x170001EF")]
    public string UnditedText
    {
      [Token(Token = "0x60013DF"), Address(RVA = "0x2520EDC", Offset = "0x2520EDC", VA = "0x2520EDC")] set
      {
      }
    }

    [Token(Token = "0x60013E0")]
    [Address(RVA = "0x2520EE4", Offset = "0x2520EE4", VA = "0x2520EE4")]
    private void SetTextCustom(string value)
    {
    }

    [Token(Token = "0x60013E1")]
    [Address(RVA = "0x2521738", Offset = "0x2521738", VA = "0x2521738", Slot = "106")]
    public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
    {
    }

    [Token(Token = "0x60013E2")]
    [Address(RVA = "0x2520F38", Offset = "0x2520F38", VA = "0x2520F38")]
    private string ReplaceRubyTags(string str) => (string) null;

    [Token(Token = "0x60013E3")]
    [Address(RVA = "0x25217B0", Offset = "0x25217B0", VA = "0x25217B0")]
    private string CreateReplaceValue(
      string baseText,
      string rubyText,
      float rubyTextOffset,
      float compensationOffset,
      bool isRightToLeftText)
    {
      return (string) null;
    }

    [Token(Token = "0x60013E4")]
    [Address(RVA = "0x2521B78", Offset = "0x2521B78", VA = "0x2521B78")]
    protected float ConvertToFloatOrigin(char[] chars, int startIndex, int lastIndex)
    {
      return new float();
    }

    [Token(Token = "0x60013E5")]
    [Address(RVA = "0x2521CA8", Offset = "0x2521CA8", VA = "0x2521CA8")]
    public RubyTextMeshPro()
    {
    }

    [Token(Token = "0x60013E6")]
    [Address(RVA = "0x2521D48", Offset = "0x2521D48", VA = "0x2521D48")]
    static RubyTextMeshPro()
    {
    }

    [Token(Token = "0x2000378")]
    protected enum RubyShowType
    {
      [Token(Token = "0x4001452")] RUBY_ALIGNMENT,
      [Token(Token = "0x4001453")] BASE_ALIGNMENT,
    }
  }
}

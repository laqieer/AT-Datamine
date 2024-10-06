// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2UiLinker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E42")]
  public class Adv2UiLinker : MonoBehaviour
  {
    [Token(Token = "0x4011173")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected List<Adv2UiLinker.LinkMessageParam> linkMessages;
    [Token(Token = "0x4011174")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected List<Adv2UiLinker.LinkObjectParam> linkObjects;
    [Token(Token = "0x4011175")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected List<Adv2UiLinker.LinkButtonParam> linkButtons;
    [Token(Token = "0x4011176")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected List<Adv2UiLinker.LinkTextParam> linkTexts;

    [Token(Token = "0x601915B")]
    [Address(RVA = "0x297383C", Offset = "0x297383C", VA = "0x297383C")]
    protected Adv2UiLinker.LinkMessageParam GetLinkMessage(string key)
    {
      return (Adv2UiLinker.LinkMessageParam) null;
    }

    [Token(Token = "0x601915C")]
    [Address(RVA = "0x2968E9C", Offset = "0x2968E9C", VA = "0x2968E9C")]
    public Adv2UiLinker.LinkMessageParam SetMessage(string key, string text)
    {
      return (Adv2UiLinker.LinkMessageParam) null;
    }

    [Token(Token = "0x601915D")]
    [Address(RVA = "0x296FEC0", Offset = "0x296FEC0", VA = "0x296FEC0")]
    public bool IsOneCharacterProcess(string key) => new bool();

    [Token(Token = "0x601915E")]
    [Address(RVA = "0x2970078", Offset = "0x2970078", VA = "0x2970078")]
    public void DrawMessageAll(string key)
    {
    }

    [Token(Token = "0x601915F")]
    [Address(RVA = "0x2969C44", Offset = "0x2969C44", VA = "0x2969C44")]
    public GameObject GetLinkObject(string key) => (GameObject) null;

    [Token(Token = "0x6019160")]
    [Address(RVA = "0x296891C", Offset = "0x296891C", VA = "0x296891C")]
    public Button GetLinkButtonUI(string key) => (Button) null;

    [Token(Token = "0x6019161")]
    [Address(RVA = "0x2971A70", Offset = "0x2971A70", VA = "0x2971A70")]
    public IEnumerable<Button> GetAllLinkButton() => (IEnumerable<Button>) null;

    [Token(Token = "0x6019162")]
    [Address(RVA = "0x296FDC0", Offset = "0x296FDC0", VA = "0x296FDC0")]
    public bool IsValidTextTag(string key) => new bool();

    [Token(Token = "0x6019163")]
    [Address(RVA = "0x296A104", Offset = "0x296A104", VA = "0x296A104")]
    public void SetText(string key, string text)
    {
    }

    [Token(Token = "0x6019164")]
    [Address(RVA = "0x296C9E8", Offset = "0x296C9E8", VA = "0x296C9E8")]
    public void SetTextColor(string key, Color clr)
    {
    }

    [Token(Token = "0x6019165")]
    [Address(RVA = "0x2973A08", Offset = "0x2973A08", VA = "0x2973A08")]
    public Adv2UiLinker()
    {
    }

    [Token(Token = "0x2003E43")]
    [Serializable]
    public class LinkMessageParam
    {
      [Token(Token = "0x4011177")]
      [FieldOffset(Offset = "0x10")]
      public string Key;
      [Token(Token = "0x4011178")]
      [FieldOffset(Offset = "0x18")]
      public TextMeshProUGUI MainText;
      [Token(Token = "0x4011179")]
      [FieldOffset(Offset = "0x20")]
      public TextMeshProUGUI RubyText;
      [Token(Token = "0x401117A")]
      [FieldOffset(Offset = "0x28")]
      protected string tmpText;
      [Token(Token = "0x401117B")]
      [FieldOffset(Offset = "0x30")]
      private string nowText;
      [Token(Token = "0x401117C")]
      [FieldOffset(Offset = "0x38")]
      protected int characterIndex;
      [Token(Token = "0x401117D")]
      [FieldOffset(Offset = "0x3C")]
      protected float rubyTextSize;
      [Token(Token = "0x401117E")]
      [FieldOffset(Offset = "0x40")]
      private bool isRuby;
      [Token(Token = "0x401117F")]
      [FieldOffset(Offset = "0x48")]
      private RubyTextMeshProUGUI textMesh;
      [Token(Token = "0x4011180")]
      [FieldOffset(Offset = "0x50")]
      public bool isOneCharacterProcess;

      [Token(Token = "0x6019166")]
      [Address(RVA = "0x2972700", Offset = "0x2972700", VA = "0x2972700")]
      public void SetMessageText(string text)
      {
      }

      [Token(Token = "0x6019167")]
      [Address(RVA = "0x2973B50", Offset = "0x2973B50", VA = "0x2973B50")]
      public void ClearMessage()
      {
      }

      [Token(Token = "0x1700517C")]
      private RubyTextMeshProUGUI TextMesh
      {
        [Token(Token = "0x6019168"), Address(RVA = "0x2973C14", Offset = "0x2973C14", VA = "0x2973C14")] get
        {
          return (RubyTextMeshProUGUI) null;
        }
      }

      [Token(Token = "0x6019169")]
      [Address(RVA = "0x2973CE4", Offset = "0x2973CE4", VA = "0x2973CE4")]
      private void SetUnditedText(string str)
      {
      }

      [Token(Token = "0x601916A")]
      [Address(RVA = "0x2973D8C", Offset = "0x2973D8C", VA = "0x2973D8C")]
      private void SetNowText(string str)
      {
      }

      [Token(Token = "0x601916B")]
      [Address(RVA = "0x2973D94", Offset = "0x2973D94", VA = "0x2973D94")]
      public bool ProceedOneCharacter() => new bool();

      [Token(Token = "0x601916C")]
      [Address(RVA = "0x296FD40", Offset = "0x296FD40", VA = "0x296FD40")]
      public IEnumerator ProceedOneCharacterProcess() => (IEnumerator) null;

      [Token(Token = "0x601916D")]
      [Address(RVA = "0x2969030", Offset = "0x2969030", VA = "0x2969030")]
      public void ProceedAll()
      {
      }

      [Token(Token = "0x601916E")]
      [Address(RVA = "0x29742A4", Offset = "0x29742A4", VA = "0x29742A4")]
      public LinkMessageParam()
      {
      }
    }

    [Token(Token = "0x2003E45")]
    [Serializable]
    public class LinkObjectParam
    {
      [Token(Token = "0x4011186")]
      [FieldOffset(Offset = "0x10")]
      public string Key;
      [Token(Token = "0x4011187")]
      [FieldOffset(Offset = "0x18")]
      public GameObject Data;

      [Token(Token = "0x6019176")]
      [Address(RVA = "0x297455C", Offset = "0x297455C", VA = "0x297455C")]
      public LinkObjectParam()
      {
      }
    }

    [Token(Token = "0x2003E46")]
    [Serializable]
    public class LinkButtonParam
    {
      [Token(Token = "0x4011188")]
      [FieldOffset(Offset = "0x10")]
      public string Key;
      [Token(Token = "0x4011189")]
      [FieldOffset(Offset = "0x18")]
      public Button Data;

      [Token(Token = "0x6019177")]
      [Address(RVA = "0x29745B4", Offset = "0x29745B4", VA = "0x29745B4")]
      public LinkButtonParam()
      {
      }
    }

    [Token(Token = "0x2003E47")]
    [Serializable]
    public class LinkTextParam
    {
      [Token(Token = "0x401118A")]
      [FieldOffset(Offset = "0x10")]
      public string Key;
      [Token(Token = "0x401118B")]
      [FieldOffset(Offset = "0x18")]
      public Text Data;

      [Token(Token = "0x6019178")]
      [Address(RVA = "0x297460C", Offset = "0x297460C", VA = "0x297460C")]
      public LinkTextParam()
      {
      }
    }
  }
}

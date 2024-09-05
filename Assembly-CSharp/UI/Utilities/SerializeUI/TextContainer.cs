// Decompiled with JetBrains decompiler
// Type: UI.Utilities.SerializeUI.TextContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.Utilities.SerializeUI
{
  [Token(Token = "0x20008AA")]
  [Serializable]
  public class TextContainer : ContainerBase
  {
    [Token(Token = "0x40028AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextContainer.TextComponentType textType;
    [Token(Token = "0x40028B0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text text;
    [Token(Token = "0x40028B1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI textMeshProUGUI;

    [Token(Token = "0x17000722")]
    public bool IsEmpty
    {
      [Token(Token = "0x600314B"), Address(RVA = "0x3C164C4", Offset = "0x3C164C4", VA = "0x3C164C4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600314C")]
    [Address(RVA = "0x3C16524", Offset = "0x3C16524", VA = "0x3C16524", Slot = "4")]
    public override void SetActive(bool active)
    {
    }

    [Token(Token = "0x600314D")]
    [Address(RVA = "0x3C165AC", Offset = "0x3C165AC", VA = "0x3C165AC")]
    public void Set(string value, bool autoActive = true)
    {
    }

    [Token(Token = "0x600314E")]
    public void Set<T>(T value, T inactiveValue = default (T)) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
    }

    [Token(Token = "0x600314F")]
    public void Set<T>(
      T value,
      bool activeJudge,
      T defaultValue = default (T),
      string defaultWord = "",
      string beforeAddWord = "",
      string afterAddWord = "",
      string format = "")
      where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
    }

    [Token(Token = "0x6003150")]
    public static string ConvertParameterToViewStatus<T>(
      T value,
      T defaultValue = default (T),
      string defaultWord = "",
      string beforeAddWord = "",
      string afterAddWord = "",
      string format = "")
      where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
      return (string) null;
    }

    [Token(Token = "0x6003151")]
    [Address(RVA = "0x3C1665C", Offset = "0x3C1665C", VA = "0x3C1665C")]
    public void SetDateTime(DateTime? value, string format, DateTime? startAt = null, DateTime? endAt = null)
    {
    }

    [Token(Token = "0x6003152")]
    [Address(RVA = "0x3C16848", Offset = "0x3C16848", VA = "0x3C16848")]
    public void AppendToEndString(string value)
    {
    }

    [Token(Token = "0x6003153")]
    [Address(RVA = "0x3C16910", Offset = "0x3C16910", VA = "0x3C16910")]
    public TextContainer()
    {
    }

    [Token(Token = "0x20008AB")]
    public enum TextComponentType
    {
      [Token(Token = "0x40028B3")] Text,
      [Token(Token = "0x40028B4")] TextMeshProUGUI,
    }
  }
}

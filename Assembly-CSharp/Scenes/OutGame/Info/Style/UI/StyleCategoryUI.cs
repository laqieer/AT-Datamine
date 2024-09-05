// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.UI.StyleCategoryUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Style.UI
{
  [Token(Token = "0x2003565")]
  [Serializable]
  public class StyleCategoryUI
  {
    [Token(Token = "0x400E82D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Tooltip("スタイル名")]
    private Text title;
    [Token(Token = "0x400E82E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Tooltip("クラス")]
    private StyleCategoryUI.InfoItem classInfo;
    [Token(Token = "0x400E82F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Tooltip("兵種")]
    private StyleCategoryUI.InfoItem[] typeInfos;
    [Token(Token = "0x400E830")]
    [FieldOffset(Offset = "0x28")]
    [Tooltip("種族")]
    [SerializeField]
    private StyleCategoryUI.InfoItem[] familyInfos;
    [Token(Token = "0x400E831")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Tooltip("FACTOR")]
    private StyleCategoryUI.InfoItem factor;
    [Token(Token = "0x400E832")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Tooltip("GROUP")]
    private Text groups;
    [Token(Token = "0x400E833")]
    [FieldOffset(Offset = "0x40")]
    private readonly string noneValue;
    [Token(Token = "0x400E834")]
    [FieldOffset(Offset = "0x48")]
    private readonly Func<string> noneFactor;
    [Token(Token = "0x400E835")]
    [FieldOffset(Offset = "0x50")]
    private Color? noneColor;
    [Token(Token = "0x400E836")]
    [FieldOffset(Offset = "0x64")]
    private Color? defaultColor;

    [Token(Token = "0x1700458D")]
    private Color NoneColor
    {
      [Token(Token = "0x6014F5B"), Address(RVA = "0x4A9F10C", Offset = "0x4A9F10C", VA = "0x4A9F10C")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x1700458E")]
    private Color DefaultColor
    {
      [Token(Token = "0x6014F5C"), Address(RVA = "0x4A9F1DC", Offset = "0x4A9F1DC", VA = "0x4A9F1DC")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x6014F5D")]
    [Address(RVA = "0x4A9F224", Offset = "0x4A9F224", VA = "0x4A9F224")]
    public void SetEmpty()
    {
    }

    [Token(Token = "0x6014F5E")]
    [Address(RVA = "0x4A9F3A4", Offset = "0x4A9F3A4", VA = "0x4A9F3A4")]
    public void SetStyleName(string name)
    {
    }

    [Token(Token = "0x6014F5F")]
    [Address(RVA = "0x4A9F3C8", Offset = "0x4A9F3C8", VA = "0x4A9F3C8")]
    public void SetClassIcon(Sprite sprite = null)
    {
    }

    [Token(Token = "0x6014F60")]
    [Address(RVA = "0x4A9F3D8", Offset = "0x4A9F3D8", VA = "0x4A9F3D8")]
    public void SetClassName(string name = null)
    {
    }

    [Token(Token = "0x6014F61")]
    [Address(RVA = "0x4A9F3EC", Offset = "0x4A9F3EC", VA = "0x4A9F3EC")]
    public void SetMoveTypeIcon(Sprite sprite = null)
    {
    }

    [Token(Token = "0x6014F62")]
    [Address(RVA = "0x4A9F418", Offset = "0x4A9F418", VA = "0x4A9F418")]
    public void SetMoveTypeName(string name = null)
    {
    }

    [Token(Token = "0x6014F63")]
    [Address(RVA = "0x4A9F448", Offset = "0x4A9F448", VA = "0x4A9F448")]
    public void SetArmorTypeIcon(Sprite sprite = null)
    {
    }

    [Token(Token = "0x6014F64")]
    [Address(RVA = "0x4A9F478", Offset = "0x4A9F478", VA = "0x4A9F478")]
    public void SetArmorTypeName(string name = null)
    {
    }

    [Token(Token = "0x6014F65")]
    [Address(RVA = "0x4A9F4AC", Offset = "0x4A9F4AC", VA = "0x4A9F4AC")]
    public void SetRideTypeIcon(Sprite sprite = null, bool isShiftUp = false)
    {
    }

    [Token(Token = "0x6014F66")]
    [Address(RVA = "0x4A9F4F0", Offset = "0x4A9F4F0", VA = "0x4A9F4F0")]
    public void SetRideTypeName(string name = null, bool isShiftUp = false)
    {
    }

    [Token(Token = "0x6014F67")]
    [Address(RVA = "0x4A9F538", Offset = "0x4A9F538", VA = "0x4A9F538")]
    public void SetFamilyInfos((Sprite sprite, string name)[] values = null)
    {
    }

    [Token(Token = "0x6014F68")]
    [Address(RVA = "0x4A9F5EC", Offset = "0x4A9F5EC", VA = "0x4A9F5EC")]
    public void SetFactorIcon(Sprite sprite = null)
    {
    }

    [Token(Token = "0x6014F69")]
    [Address(RVA = "0x4A9F5FC", Offset = "0x4A9F5FC", VA = "0x4A9F5FC")]
    public void SetFactorName(string name = null)
    {
    }

    [Token(Token = "0x6014F6A")]
    [Address(RVA = "0x4A9F750", Offset = "0x4A9F750", VA = "0x4A9F750")]
    private void SetIcon(StyleCategoryUI.InfoItem infoItem, Sprite sprite)
    {
    }

    [Token(Token = "0x6014F6B")]
    [Address(RVA = "0x4A9F844", Offset = "0x4A9F844", VA = "0x4A9F844")]
    private void SetName(StyleCategoryUI.InfoItem infoItem, string name, bool isFactor = false)
    {
    }

    [Token(Token = "0x6014F6C")]
    [Address(RVA = "0x4A9F610", Offset = "0x4A9F610", VA = "0x4A9F610")]
    public void SetGroups(string[] groupArray = null)
    {
    }

    [Token(Token = "0x6014F6D")]
    [Address(RVA = "0x4A9F924", Offset = "0x4A9F924", VA = "0x4A9F924")]
    public StyleCategoryUI()
    {
    }

    [Token(Token = "0x2003566")]
    [Serializable]
    private class InfoItem
    {
      [Token(Token = "0x400E837")]
      [FieldOffset(Offset = "0x10")]
      public TypeIcon icon;
      [Token(Token = "0x400E838")]
      [FieldOffset(Offset = "0x18")]
      public Text text;
      [Token(Token = "0x400E839")]
      [FieldOffset(Offset = "0x20")]
      public GameObject nullObject;

      [Token(Token = "0x6014F6E")]
      [Address(RVA = "0x4A9FA24", Offset = "0x4A9FA24", VA = "0x4A9FA24")]
      public InfoItem()
      {
      }
    }

    [Token(Token = "0x2003567")]
    private enum TypeIndex
    {
      [Token(Token = "0x400E83B")] Move,
      [Token(Token = "0x400E83C")] Armor,
      [Token(Token = "0x400E83D")] Ride,
    }
  }
}

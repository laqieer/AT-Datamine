// Decompiled with JetBrains decompiler
// Type: StaqDebug.TextKeyLogger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F67")]
  public class TextKeyLogger : SingletonMonoBehaviour<TextKeyLogger>
  {
    [Token(Token = "0x400867C")]
    [FieldOffset(Offset = "0x19")]
    public bool IsEnable;
    [Token(Token = "0x400867D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float scalingPoint;
    [Token(Token = "0x400867E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float textHeight;
    [Token(Token = "0x400867F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Rect fillRect;
    [Token(Token = "0x4008680")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Rect textRect;
    [Token(Token = "0x4008681")]
    [FieldOffset(Offset = "0x48")]
    private Texture texture;
    [Token(Token = "0x4008682")]
    [FieldOffset(Offset = "0x50")]
    private List<string> keyLogList;
    [Token(Token = "0x4008683")]
    [FieldOffset(Offset = "0x58")]
    private bool isNextNoEntry;

    [Token(Token = "0x600BA69")]
    [Address(RVA = "0x1E45394", Offset = "0x1E45394", VA = "0x1E45394")]
    private void Start()
    {
    }

    [Token(Token = "0x600BA6A")]
    [Address(RVA = "0x1E4542C", Offset = "0x1E4542C", VA = "0x1E4542C")]
    public void SetNextNoEntry()
    {
    }

    [Token(Token = "0x600BA6B")]
    [Address(RVA = "0x1E45438", Offset = "0x1E45438", VA = "0x1E45438")]
    public void AddLog(string key, string text)
    {
    }

    [Token(Token = "0x600BA6C")]
    [Address(RVA = "0x1E45538", Offset = "0x1E45538", VA = "0x1E45538")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x600BA6D")]
    [Address(RVA = "0x1E458AC", Offset = "0x1E458AC", VA = "0x1E458AC")]
    public TextKeyLogger()
    {
    }
  }
}

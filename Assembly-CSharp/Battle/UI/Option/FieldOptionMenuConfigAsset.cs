// Decompiled with JetBrains decompiler
// Type: Battle.UI.Option.FieldOptionMenuConfigAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI.Option
{
  [Token(Token = "0x2002446")]
  [CreateAssetMenu(menuName = "staq/Battle/UI/Option Config Asset")]
  public class FieldOptionMenuConfigAsset : ScriptableObject
  {
    [Token(Token = "0x4009B93")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("ユニット一覧画面の設定")]
    [Header("・ユニット一覧画面")]
    [SerializeField]
    public UnitListConfig unitListPanel;

    [Token(Token = "0x600DE59")]
    [Address(RVA = "0x1E32064", Offset = "0x1E32064", VA = "0x1E32064")]
    public FieldOptionMenuConfigAsset()
    {
    }
  }
}

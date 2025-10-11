# 🎨 FUnity UI Toolkit Design

FUnity は Unity の **UI Toolkit** により構築されています。

## 🧱 設計方針

| 要素 | 説明 |
|------|------|
| **UI Document** | FUnity のメインUIを表示する基礎 |
| **BlockElement** | Scratch風ブロック（UXML＋USS） |
| **WorkspaceHUD** | ステージ・アクターを配置する領域 |
| **PanelSettings** | すべてのUIの共通設定 |

---

## 🧭 動作の流れ

1. ヒエラルキーに `FUnityUIInitializer` が配置される  
2. 起動時に `block.uxml` を読み込み  
3. `PanelSettings` を適用して表示  
4. `WorkspaceHUD` 上でブロックを動かす  

---

## 🧩 関連ファイル

| ファイル | 説明 |
|-----------|------|
| `Runtime/UI/BlockElement.cs` | ブロックUI定義 |
| `UXML/block.uxml` | UXMLレイアウト |
| `USS/block.uss` | ブロックデザイン |

---

📘 詳細は `FUnity/UI/` フォルダを参照してください。

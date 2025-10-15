# 🎨 FUnity Project  

[![Unity](https://img.shields.io/badge/Unity-6000.0.58f2-black?logo=unity)]()
[![License](https://img.shields.io/badge/license-MIT-blue.svg)]()
[![Platform](https://img.shields.io/badge/platform-Windows%20%7C%20Mac-lightgrey.svg)]()

---

## 🧭 概要  

**FUnity Project** は、教育向けビジュアルプログラミング環境「FUnity」パッケージを利用するための  
デモ・検証用 Unity プロジェクトです。  

FUnity は Scratch のようにブロックを組み合わせて動かす学習ツールであり、  
このリポジトリでは FUnity パッケージを Unity Editor で再生・確認できるようになっています。  

---

## 🧩 リポジトリ構成

```
Assets/
 ├── FUnity/               # FUnityリソース（PanelSettingsなど）
 │    └── Resources/
 │         └── FUnityPanelSettings.asset
 ├── Scripts/              # 実行用スクリプト
 │    └── FUnityUIInitializer.cs
 ├── README.md             # このファイル
Packages/
 ├── manifest.json         # FUnityパッケージ参照設定
 └── packages-lock.json
ProjectSettings/
 └── 各種Unity設定ファイル
```

---

## ⚙️ 利用方法

1. Unity 6000.0.58f2 以降でこのプロジェクトを開く
2. `Assets/FUnity/Scenes/FUnitySample.unity`（または同等のサンプルシーン）を開く
3. 再生すると、シーン内の **FUnityManager** が自動で `FUnity UI` オブジェクトと `UIDocument` を生成し、`FUnityPanelSettings` と UI が適用されます

💡 パッケージを別フォルダに配置している場合は、  
`Packages/manifest.json` の以下の設定を確認してください。

```json
{
  "dependencies": {
    "com.papacoder.funity": "https://github.com/oco777/FUnity.git"
  }
}
```

---

## 🧠 主なスクリプト

| ファイル | 概要 |
|-----------|------|
| `Assets/Scripts/FUnityUIInitializer.cs` | UIDocumentにUXML・PanelSettingsを適用 |
| `Packages/com.papacoder.funity/Runtime/FUnityManager.cs` | シーン起動時に FUnity UI を生成し、UIDocument に設定を適用 |

---

## 🧰 開発の流れ

FUnityプロジェクトは、AI協働型ワークフローで開発しています。

| フェーズ | 使用AI | 主なタスク |
|-----------|---------|-------------|
| 設計 | ChatGPT | プロンプト設計、構成整理 |
| 実装 | Codex | C#/UXML/USS生成 |
| 検証 | ChatGPT | コードレビュー・ドキュメント更新 |

詳しくは [`Docs/DevelopmentGuide_AI.md`](../FUnity/Docs/DevelopmentGuide_AI.md) を参照。

---

## 📜 ライセンス
このプロジェクトは **MIT License** のもとで公開されています。  
詳しくは [LICENSE.md](LICENSE.md) をご覧ください。

---

© 2025 パパコーダー  
FUnity Project – Scratch inspired visual programming for Unity  

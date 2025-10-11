# 🧠 FUnity AI Development Guide

FUnity は ChatGPT × Codex による「AI協働開発」を採用しています。

## 🚀 開発フロー

1. ChatGPT に「開発目的・要件」を説明する  
2. ChatGPT が Codex 用プロンプトを作成  
3. Codex が Unity プロジェクトにコードを生成  
4. ChatGPT がレビューし、再指示で改善  

![AI Dev Flow](images/funity-ai-devflow.png)

---

## 🧩 推奨ツール連携

| ツール | 目的 |
|--------|------|
| **uithub.com** | GitHubリポジトリの参照・要約 |
| **Codex Connector** | Unityコード生成AI（C#/UXML/USS） |
| **ChatGPT (GPT‑5)** | 設計・レビュー・ドキュメント化 |

---

## 🔧 プロンプト作成のコツ

- Codexには**最小限かつ具体的な指示**を与える  
- ChatGPTには**背景・目的を詳しく伝える**  
- どちらのAIにも**ファイル構成やUnityバージョン**を明示する  

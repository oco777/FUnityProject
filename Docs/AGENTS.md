# 🤖 FUnity Agents

Codexに指示を出す際の「エージェント定義」をまとめています。

| エージェント名 | 役割 | 対応範囲 |
|----------------|------|-----------|
| **UIAgent** | UI Toolkit と USS の設計 | UXML/USS の生成、UIDocument関連 |
| **LogicAgent** | ゲームロジック・C#スクリプト | Visual Scripting 対応コード生成 |
| **DocAgent** | ドキュメントとREADME生成 | マニュアル、README、ブログ記事 |
| **ArtAgent** | キャラクターとUI素材提案 | 画像生成、配色・レイアウト支援 |

---

### 💡 指示テンプレート例

```plaintext
[UIAgent]
FUnityのUI Toolkitを改善したいです。
サンプルシーンに「ブロックを配置できるエリア」を追加してください。
```

---

🧭 Codex実行前に、必ずChatGPTにプロンプトを設計させてから実行するのが基本です。

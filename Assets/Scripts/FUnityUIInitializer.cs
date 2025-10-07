using UnityEngine;
using UnityEngine.UIElements;

namespace FUnity
{
    /// <summary>
    /// Ensures that the FUnity UI document has all of the required assets at runtime.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(UIDocument))]
    public sealed class FUnityUIInitializer : MonoBehaviour
    {
        private const string PanelSettingsResourcePath = "FUnityPanelSettings";

        [SerializeField]
        [Tooltip("Optional fallback VisualTreeAsset that will be applied when the UIDocument has no asset assigned.")]
        private VisualTreeAsset fallbackVisualTreeAsset;

#if UNITY_EDITOR
        private const string PackageVisualTreeAssetPath = "Packages/com.papacoder.funity/UXML/block.uxml";
#endif

        private void Awake()
        {
            var uiDocument = GetComponent<UIDocument>();
            EnsurePanelSettings(uiDocument);
            EnsureVisualTreeAsset(uiDocument);
        }

        private void EnsurePanelSettings(UIDocument uiDocument)
        {
            if (uiDocument.panelSettings != null)
            {
                return;
            }

            var panelSettings = Resources.Load<PanelSettings>(PanelSettingsResourcePath);
            if (panelSettings != null)
            {
                uiDocument.panelSettings = panelSettings;
                return;
            }

            Debug.LogError(
                $"FUnityUIInitializer: Resources/{PanelSettingsResourcePath}.asset を読み込めませんでした。" +
                " FUnity/Repair Sample Scene メニューを実行してアセットを再生成してください。");
        }

        private void EnsureVisualTreeAsset(UIDocument uiDocument)
        {
            if (uiDocument.visualTreeAsset != null)
            {
                return;
            }

            if (fallbackVisualTreeAsset != null)
            {
                uiDocument.visualTreeAsset = fallbackVisualTreeAsset;
                return;
            }

#if UNITY_EDITOR
            var asset = UnityEditor.AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(PackageVisualTreeAssetPath);
            if (asset != null)
            {
                uiDocument.visualTreeAsset = asset;
                return;
            }
#endif

            Debug.LogError(
                "FUnityUIInitializer: UIDocument に VisualTreeAsset が設定されていません。" +
                " block.uxml をシーンに割り当てるか、フォールバックを指定してください。");
        }
    }
}

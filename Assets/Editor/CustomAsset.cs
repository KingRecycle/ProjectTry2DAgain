using UnityEditor;

public class CustomAsset
{
    [MenuItem("Assets/Create/Character")]
    public static void CreateAsset()
    {
        CustomAssetUtility.CreateAsset<Character>();
    }

    [MenuItem("Assets/Create/Item")]
    public static void CreateItemAsset()
    {
        CustomAssetUtility.CreateAsset<ItemData>();
    }
}
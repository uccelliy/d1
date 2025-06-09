using UnityEngine;
using UnityEditor;
using System.IO;

using UnityEngine.Assertions;
using UnityEditor.U2D.Sprites;
using System.Collections.Generic;

public class SpriteBatchImporter
{
    [MenuItem("Tools/Sprite批量设置/设置为Sprite类型 PPU=32")]
    static void ConvertTexturesToSprites()
    {
        // 可选：指定你想批量处理的路径
        // 如只处理 Assets/Sprites/ 目录下的图像，改为："Assets/Sprites"
        string searchPath = "Assets/Arts/DawnLike/Commissions";
        //想要处理的格式
        SpriteImportMode SpriteIM = SpriteImportMode.Multiple;

        // 获取所有 png 图片路径
        string[] pngFiles = Directory.GetFiles(searchPath, "*.png", SearchOption.AllDirectories);

        int modifiedCount = 0;

        foreach (string filePath in pngFiles)
        {
            string assetPath = filePath.Replace(Application.dataPath, "Assets").Replace('\\', '/');
            TextureImporter importer = AssetImporter.GetAtPath(assetPath) as TextureImporter;
            if (importer == null)
            {
                Debug.LogWarning($"无法获取 TextureImporter: {assetPath}");
                continue;
            }

            if ( importer.textureType != TextureImporterType.Sprite || importer.spriteImportMode != SpriteIM)
            {
                importer.textureType = TextureImporterType.Sprite;
                importer.spriteImportMode = SpriteIM;
                importer.spritePixelsPerUnit = 32;
                if (importer.spriteImportMode == SpriteImportMode.Multiple)
                {
                    //Texture2D texture = new Texture2D(2, 2);
                    //byte[] fileData = File.ReadAllBytes(filePath);
                    //texture.LoadImage(fileData); // 加载原图以获取宽高
                    Texture2D texture = AssetDatabase.LoadAssetAtPath<Texture2D>(assetPath);
                    Assert.IsNotNull(texture, $"Texture2D is null for {assetPath}. Please check the file path and format.");
                    int texWidth = texture.width;
                    int texHeight = texture.height;

                    int cellSize = 16;
                    List<SpriteMetaData> metas = new List<SpriteMetaData>();

                    for (int y = texHeight; y > 0; y -= cellSize)
                    {
                        for (int x = 0; x < texWidth; x += cellSize)
                        {
                            SpriteMetaData meta = new SpriteMetaData();
                            meta.rect = new Rect(x, Mathf.Max(0, y - cellSize), cellSize, cellSize);
                            meta.name = $"tile_{x}_{texHeight - y + cellSize}";
                            meta.alignment = 0; // Center
                            metas.Add(meta);
                        }
                    }
                    // 使用 TextureImporter 设置 sprite meta data
                    importer.spritesheet = metas.ToArray();
                }
                
                importer.mipmapEnabled = false;
                importer.alphaIsTransparency = true;

                AssetDatabase.ImportAsset(assetPath, ImportAssetOptions.ForceUpdate);
                modifiedCount++;
            }
        }

        Debug.Log($"已成功修改 {modifiedCount} 张图片为 Sprite 类型，PPU 设置为 32。");
    }
}


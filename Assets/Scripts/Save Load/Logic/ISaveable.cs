namespace Y.Save
{
    public interface ISaveable
    {
        string GUID { get; }

        // C#8.0之后，接口中的函数可以写内容
        void RegisterSaveable()
        {
            SaveLoadManager.Instance.RegisterSaveable(this);
        }

        /// 存储数据
        GameSaveData GenerateSaveData();

        /// 读取数据，把所有的信息赋值到物体上
        void RestoreData(GameSaveData saveData);
    }
}
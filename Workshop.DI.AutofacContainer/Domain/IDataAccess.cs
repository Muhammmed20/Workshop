namespace Workshop.DI.AutofacContainer.Domain
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string name);
    }
}
﻿namespace Test.Storage
{
    public interface IDataStorage
    {
        void StoreObject(object obj, string key);

        T RestoreObject<T>(string key);
    }
}
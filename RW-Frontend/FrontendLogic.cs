﻿using System.Collections.ObjectModel;

namespace RW_Frontend
{
    /// <summary>
    /// Logika odpowiedzialna za interakcje z użytkownikiem i obsługę widoku
    /// </summary>
    class FrontendLogic
    {
        public void SetDataContext(MainWindow mainWindow)
        {
            mainWindow.DataContext = VM.Create();
        }

        //TODO obsługiwanie modyfikacji vm - dodawanie/usuwanie elementów
        //coś na kształt poniższych, ale należy też sprawdzać poprawność - usuwanie używanych fluentów/poprawność formuł w zdaniach; docelowo dla każdego rodzaju wpisów pewnie będzie inaczej
        public void AddItem<T>(ObservableCollection<T> collection) where T : new()
        {
            collection.Add(new T());
        }

        public void RemoveItem<T>(ObservableCollection<T> collection, T item)
        {
            collection.Remove(item);
        }

        //TODO zapamiętywanie wyznaczonej reprezentacji świata
        //TODO wywoływanie obliczeń kwerend z BackendLogic
    }
}
﻿using Flow.Launcher.Infrastructure.Storage;
using Flow.Launcher.Plugin.Explorer.Search.FolderLinks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flow.Launcher.Plugin.Explorer.ViewModels
{
    public class SettingsViewModel
    {
        private readonly PluginJsonStorage<Settings> storage;

        internal Settings Settings { get; set; }

        internal PluginInitContext Context { get; set; }

        public SettingsViewModel(PluginInitContext context)
        {
            Context = context;
            storage = new PluginJsonStorage<Settings>();
            Settings = storage.Load();
        }

        public void Save()
        {
            storage.Save();
        }

        internal void RemoveFolderLinkFromQuickFolders(FolderLink selectedRow) => Settings.QuickFolderAccessLinks.Remove(selectedRow);

        internal void RemoveFolderLinkFromExcludedIndexPaths(FolderLink selectedRow) => Settings.IndexSearchExcludedSubdirectoryPaths.Remove(selectedRow);
    }
}

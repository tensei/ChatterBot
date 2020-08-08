﻿using ChatterBot.Core;
using ChatterBot.Core.State;
using MahApps.Metro.IconPacks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ChatterBot.ViewModels
{
    public class CommandsViewModel : MenuItemViewModel
    {
        private readonly CommandsSet _commandsSet;

        public BindingList<CustomCommand> CustomCommands => _commandsSet.CustomCommands;

        public CommandsViewModel(CommandsSet commandsSet)
        {
            _commandsSet = commandsSet;
            Icon = new PackIconFontAwesome { Kind = PackIconFontAwesomeKind.ExclamationSolid };
            Label = "Commands";
            ToolTip = "Custom Commands";
        }
    }
}
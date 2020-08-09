﻿using ChatterBot.Core;
using ChatterBot.Core.SimpleCommands;
using MahApps.Metro.IconPacks;
using System.ComponentModel;

namespace ChatterBot.ViewModels
{
    public class CommandsViewModel : MenuItemViewModel
    {
        private readonly ICommandsSet _commandsSet;

        public BindingList<CustomCommand> CustomCommands => _commandsSet.CustomCommands;

        public CommandsViewModel(ICommandsSet commandsSet)
        {
            _commandsSet = commandsSet;
            Icon = new PackIconFontAwesome { Kind = PackIconFontAwesomeKind.ExclamationSolid };
            Label = "Commands";
            ToolTip = "Custom Commands";
        }
    }
}
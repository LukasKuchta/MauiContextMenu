using MauiContextMenu.ViewModels.ContextMenu;

namespace MauiContextMenu.DataTemplates
{
    public class ContextMenuItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate HeaderDataTemplate { get; set; }
        public DataTemplate ItemDataTemplate { get; set; }
        public DataTemplate ExpandableItemDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is HeaderContextMenuViewModel)
            {
                return HeaderDataTemplate;
            }

            if ((item is ItemContextMenuViewModel x) && x.HasSubMenu)
            {
                return ExpandableItemDataTemplate;
            }

            return ItemDataTemplate;
        }
    }
}
